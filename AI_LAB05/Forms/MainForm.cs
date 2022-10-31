using AI_LAB05.Classes;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace AI_LAB05.Forms
{
    public partial class MainForm : Form
    {
        private NeuronNetwork _neuronNetwork;
        //private ArrayToStates<float> const_inputs;
        private List<InputArray> input_signals_arr;
        private List<InputArray> test_signals_arr;
        private Settings _settings = new Settings();
        private List<Category> _classes = new List<Category>();
        private List<Category> _test_classes = new List<Category>();
        private bool _test_batch_flag = false;
        public MainForm()
        {
            InitializeComponent();
            paintControl1.SetSize();
            var s = LoadSettings("configNN.json");
            if (s != null)
            {
                _settings = s;
                paintControl1.SetPenWidth(_settings._pen_width);
            }
            _neuronNetwork = new NeuronNetwork(_settings._dataX * _settings._dataY, _settings._layers_characteristic, _settings._outputclasses_count);

            input_signals_arr = new List<InputArray>();
            test_signals_arr = new List<InputArray>();
            //input_signals_image_arr = new List<InputImage>();
            //_dataBatch = new DataBatch(settings._dataX * settings._dataY);

        }
        #region settings
        private Settings? LoadSettings(string path) // Завантажити налаштування з файлу
        {
            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                return JsonSerializer.Deserialize<Settings>(data);
            }
            return null;
        }
        private void SaveSettings(string path) // Записати налаштування у файл
        {
            string inputJson = JsonSerializer.Serialize(_settings, new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText(path, inputJson);
        }
        #endregion
        private void btn_SaveToBatch_Click(object sender, EventArgs e) // Збереження до вибірки
        {
            if (!_test_batch_flag)
            {
                for (int i = 0; i < input_signals_arr.Count; i++)
                    if (!_classes.Exists(x => x._category_num == input_signals_arr[i]._category_num))
                        _classes.Add(new Category(input_signals_arr[i]._category_num, input_signals_arr[i]._category_name));

                Category promptValue = UserControl.Prompt.ShowDialog(_classes);
                if (promptValue == null)
                    return;
                //_dataBatch.AddSet(new InputImage(Program.ResizeImage(paintControl1.GetBitmap(), settings._dataX, settings._dataY), promptValue._category_num));
                //
                //Program.ResizeImage(paintControl1.GetBitmap(), settings._dataX, settings._dataY).Save("_img" + input_signals_arr.Count.ToString() + ".png");
                //paintControl1.GetBitmap().Save("_img" + input_signals_arr.Count.ToString() + "_origin.png");
                input_signals_arr.Add(new InputArray(new InputImage(Program.ResizeImage(paintControl1.GetBitmap(), _settings._dataX, _settings._dataY), promptValue._category_num).GetArray(), promptValue._category_num, promptValue._category_name));
            }
            else
            {
                for (int i = 0; i <test_signals_arr.Count; i++)
                    if (!_test_classes.Exists(x => x._category_num == test_signals_arr[i]._category_num))
                        _test_classes.Add(new Category(test_signals_arr[i]._category_num, test_signals_arr[i]._category_name));

                Category promptValue = UserControl.Prompt.ShowDialog(_test_classes);
                if (promptValue == null)
                    return;
                test_signals_arr.Add(new InputArray(new InputImage(Program.ResizeImage(paintControl1.GetBitmap(), _settings._dataX, _settings._dataY), promptValue._category_num).GetArray(), promptValue._category_num, promptValue._category_name));
            }
        }

        private void btn_ClearPaintBox_Click(object sender, EventArgs e) // Очищення поля вводу
        {
            paintControl1.Reset();
        }

        private void button1_Click(object sender, EventArgs e) // Отримати результати
        {
            InputArray input_signals = new InputArray(new InputImage(Program.ResizeImage(paintControl1.GetBitmap(), _settings._dataX, _settings._dataY), 1).GetArray(), 0, "");
            OutputSignals result = _neuronNetwork.GetAnswer(input_signals);
            listBox1.Items.Clear();
            if (_classes == null || _classes.Count == 0)
                for (int i = 0; i < result.GetArray().Count; i++)
                {
                    listBox1.Items.Add(i + " - " + ": " + String.Format("{0:P}", result.GetSignal(i)));
                }
            else
                foreach (var item in _classes)
                {
                    listBox1.Items.Add(item._category_num + " - " + item._category_name + ": " + String.Format("{0:P}", result.GetSignal(item._category_num)));
                }

        }

        private void навчатиToolStripMenuItem_Click(object sender, EventArgs e) // Навчання мережі
        {
            var starttime = System.DateTime.Now;
            int iter_count = 0;
            if (test_signals_arr.Count > 0)
                iter_count = _neuronNetwork.Learning(input_signals_arr.ToArray(), test_signals_arr.ToArray(), _settings._max_iter, _settings._precision);
            else
                iter_count = _neuronNetwork.Learning(input_signals_arr.ToArray(), input_signals_arr.ToArray(), _settings._max_iter, _settings._precision);
            notifyIcon1.Icon = SystemIcons.Information;
            var deltatime = System.DateTime.Now - starttime;
            toolStripStatusLabel1.Text = "Кількість ітерацій = " + iter_count.ToString() + " | Час = " + deltatime;
            notifyIcon1.BalloonTipTitle = "NeuronNetwork";
            notifyIcon1.BalloonTipText = "Network has been trained!";
            notifyIcon1.ShowBalloonTip(1000);
        }

        #region data load/save
        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "input_states";
            openFileDialog1.Filter = " |*.json";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                if (!File.Exists(openFileDialog1.FileName))
                {
                    MessageBox.Show("Файл не відкрито!", "Помилка");
                    return;
                }
                else
                {
                    string data = File.ReadAllText(openFileDialog1.FileName);
                    input_signals_arr = JsonSerializer.Deserialize<List<InputArray>>(data);
                    /*
                    input_signals_arr = new List<InputArray>();
                    for (int i = 0; i < const_inputs.count; i++)
                    {
                        input_signals_arr.Add(new InputArray(const_inputs.Convert(i), i));
                    }*/
                    MessageBox.Show("Файл успішно відкрито!", "Успіх");
                    return;
                }
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "input_states";
            saveFileDialog1.Filter = " |*.json";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string inputJson = JsonSerializer.Serialize(input_signals_arr, new JsonSerializerOptions()
                {
                    //WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                if (inputJson == null)
                {
                    MessageBox.Show("Файл не збережено!", "Помилка");
                    return;
                }
                else
                {
                    File.WriteAllText(saveFileDialog1.FileName, inputJson);
                    MessageBox.Show("Файл успішно збережено!", "Успіх");
                    return;
                }
            }
        }

        private void завантажитиМережуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "neuron_network";
            openFileDialog2.Filter = " |*.json";
            if (DialogResult.OK == openFileDialog2.ShowDialog())
            {
                if (!File.Exists(openFileDialog2.FileName))
                {
                    MessageBox.Show("Файл не відкрито!", "Помилка");
                    return;
                }
                else
                {
                    string data = File.ReadAllText(openFileDialog2.FileName);
                    _neuronNetwork = JsonSerializer.Deserialize<NeuronNetwork>(data);
                    MessageBox.Show("Файл успішно відкрито!", "Успіх");
                    return;
                }
            }
        }

        private void зберегтиМережуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog2.FileName = "neuron_network";
            saveFileDialog2.Filter = " |*.json";
            if (DialogResult.OK == saveFileDialog2.ShowDialog())
            {
                if (!true)
                {
                    MessageBox.Show("Файл не збережено!", "Помилка");
                    return;
                }
                else
                {
                    string inputJson = JsonSerializer.Serialize(_neuronNetwork, new JsonSerializerOptions()
                    {
                        //WriteIndented = true,
                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    });
                    File.WriteAllText(saveFileDialog2.FileName, inputJson);
                    MessageBox.Show("Файл успішно збережено!", "Успіх");
                    return;
                }
            }
        }

        private void завантажитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog3.FileName = "test_states";
            openFileDialog3.Filter = " |*.json";
            if (DialogResult.OK == openFileDialog3.ShowDialog())
            {
                if (!File.Exists(openFileDialog3.FileName))
                {
                    MessageBox.Show("Файл не відкрито!", "Помилка");
                    return;
                }
                else
                {
                    string data = File.ReadAllText(openFileDialog3.FileName);
                    test_signals_arr = JsonSerializer.Deserialize<List<InputArray>>(data);
                    /*
                    input_signals_arr = new List<InputArray>();
                    for (int i = 0; i < const_inputs.count; i++)
                    {
                        input_signals_arr.Add(new InputArray(const_inputs.Convert(i), i));
                    }*/
                    MessageBox.Show("Файл успішно відкрито!", "Успіх");
                    return;
                }
            }
        }

        private void зберегтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog3.FileName = "test_states";
            saveFileDialog3.Filter = " |*.json";
            if (DialogResult.OK == saveFileDialog3.ShowDialog())
            {
                string inputJson = JsonSerializer.Serialize(test_signals_arr, new JsonSerializerOptions()
                {
                    //WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                if (inputJson == null)
                {
                    MessageBox.Show("Файл не збережено!", "Помилка");
                    return;
                }
                else
                {
                    File.WriteAllText(saveFileDialog3.FileName, inputJson);
                    MessageBox.Show("Файл успішно збережено!", "Успіх");
                    return;
                }
            }
        }
        #endregion

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e) // Форма налаштуваннь
        {
            NetworkSettings networkSettings = new NetworkSettings();
            networkSettings.numericUpDown_dataX.Value = _settings._dataX;
            networkSettings.numericUpDown_dataY.Value = _settings._dataY;

            networkSettings.trackBar_layers_characteristic.Value = _settings._layers_characteristic.Length;
            networkSettings.dataGridView1.RowCount = 1;
            networkSettings.dataGridView1.ColumnCount = _settings._layers_characteristic.Length;
            for (int i = 0; i < _settings._layers_characteristic.Length; i++)
            {
                networkSettings.dataGridView1.Rows[0].Cells[i].Value = _settings._layers_characteristic[i];
            }

            networkSettings.numericUpDown_outputclasses.Value = _settings._outputclasses_count;
            networkSettings.numericUpDown_max_iter.Value = _settings._max_iter;
            networkSettings.textBox_precision.Text = _settings._precision.ToString();
            networkSettings.textBox_pen_width.Text = _settings._pen_width.ToString();

            if (networkSettings.ShowDialog() == DialogResult.OK)
            {
                int[] _layers_characteristic = new int[networkSettings.trackBar_layers_characteristic.Value];
                for (int i = 0; i < _layers_characteristic.Length; i++)
                {
                    _layers_characteristic[i] = Int32.Parse(networkSettings.dataGridView1.Rows[0].Cells[i].Value.ToString());
                }
                _settings = new Settings((int)networkSettings.numericUpDown_dataX.Value,
                 (int)networkSettings.numericUpDown_dataY.Value,
                 _layers_characteristic,
                 (int)networkSettings.numericUpDown_outputclasses.Value,
                 (int)networkSettings.numericUpDown_max_iter.Value,
                 float.Parse(networkSettings.textBox_precision.Text),float.Parse(networkSettings.textBox_pen_width.Text));
                paintControl1.SetPenWidth(_settings._pen_width);
                SaveSettings("configNN.json");
                _neuronNetwork = new NeuronNetwork(_settings._dataX * _settings._dataY, _settings._layers_characteristic, _settings._outputclasses_count);
                MessageBox.Show("Нейронна мережа була заново створена!\nБажано оновити вхідні (та тестові) вибірки.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void переглянутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBatch viewBatch = new ViewBatch();
            viewBatch.LoadBatch(input_signals_arr.ToArray(), _settings._dataX, _settings._dataY);
            viewBatch.Show();
        }

        private void переглянутиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBatch viewBatch = new ViewBatch();
            viewBatch.LoadBatch(test_signals_arr.ToArray(), _settings._dataX, _settings._dataY);
            viewBatch.Show();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NeuronNetwork\n\nVersion 0.87\n\n© Kozak 2022\n", "Про програму NeuronNetwork");
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Незбережені дані будуть втрачені!", "Вихід", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (MessageBox.Show("Незбережені дані будуть втрачені!", "Вихід", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    Application.Exit();
                else e.Cancel = true;
        }

        private void навчальнаВибіркаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            навчальнаВибіркаToolStripMenuItem1.Checked = true;
            тестоваВибіркаToolStripMenuItem1.Checked = false;
            _test_batch_flag = false;
            btn_SaveToBatch.Text = "Зберегти у навч. вибірку";
        }

        private void тестоваВибіркаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            навчальнаВибіркаToolStripMenuItem1.Checked = false;
            тестоваВибіркаToolStripMenuItem1.Checked = true;
            _test_batch_flag = true;
            btn_SaveToBatch.Text = "Зберегти у тест. вибірку";
        }
    }
}
