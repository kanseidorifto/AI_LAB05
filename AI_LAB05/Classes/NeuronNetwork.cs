using AI_LAB05.Interfaces;
using System.Text.Json.Serialization;

namespace AI_LAB05.Classes
{
    internal class NeuronNetwork
    {
        [JsonInclude]
        public List<NeuronLayer> _neuronLayerList;
        [JsonInclude]
        public readonly float learning_rate = 0.1f;
        [JsonInclude]
        public int _outputclasses_count;
        public NeuronNetwork()
        {
            _neuronLayerList = new List<NeuronLayer>();
            learning_rate = 1;
            _outputclasses_count = 0;
        }
        //Example new NeuronNetwork(128, new int[]{64,32}, 10); 16x16 image to classify numbers 0..9; 2 hidden layers with 64 and 32 neurons
        public NeuronNetwork(int inputsignals_count, int[] layers_characteristic, int outputclasses_count)
        {
            if (inputsignals_count > 0 && outputclasses_count > 0)
            {
                _neuronLayerList = new List<NeuronLayer>();
                _outputclasses_count = outputclasses_count;

                _neuronLayerList.Add(new NeuronLayer(inputsignals_count, inputsignals_count)); // Вхідний шар

                if (layers_characteristic.Length == 0) // Якщо немає прихованих шарів
                {
                    _neuronLayerList.Add(new NeuronLayer(_outputclasses_count, inputsignals_count)); // Додаємо тільки один(вихідний) шар
                }
                else
                {
                    if (layers_characteristic[0] <= 0) throw new ArgumentException("layer_characteristic[] has 0 or negative value");

                    int i = 0;
                    _neuronLayerList.Add(new NeuronLayer(layers_characteristic[i], inputsignals_count)); // Додаємо перший прихований шар
                    for (i = 1; i < layers_characteristic.Length; i++)
                    {
                        if (layers_characteristic[i] <= 0) throw new ArgumentException("layer_characteristic[] has 0 or negative value");
                        _neuronLayerList.Add(new NeuronLayer(layers_characteristic[i], layers_characteristic[i - 1])); // Додаємо приховані шари
                    }
                    _neuronLayerList.Add(new NeuronLayer(_outputclasses_count, layers_characteristic[i - 1])); // Додаємо вихідний шар
                }
            }
            else
            {
                throw new ArgumentException("inputsignals_count <= 0 or layers_characteristic.Length <= 0 or outputclasses_count <= 0");
            }
        }
        public OutputSignals GetAnswer(IInputSignals inputSignals)
        {
            /*OutputSignals results = _neuronLayerList[0].GetAnswer(inputSignals);
            for (int i = 1; i < _neuronLayerList.Count; i++)
            {
                results = _neuronLayerList[i].GetAnswer(results);
            }*/
            List<ISignals> l_layers_results = new List<ISignals>();

            // Прямий прохід
            l_layers_results.Add(inputSignals);
            for (int k = 1; k < _neuronLayerList.Count; k++)
            {
                l_layers_results.Add(_neuronLayerList[k].GetAnswer(l_layers_results[k - 1]));
            }
            return (OutputSignals)l_layers_results[_neuronLayerList.Count - 1];
        }
        public int Learning(IInputSignals[] inputSignals_batch, IInputSignals[] testSignals_batch, int max_iter, float precision)
        {

            /*float[,] l_right_result_arr = new float[inputSignals_batch.Length, _neuronLayerList[_neuronLayerList.Count - 1].GetNeyronsCount()];
            for (int j = 0; j < inputSignals_batch.Length; j++)
            {
                for (int i = 0; i < _neuronLayerList[_neuronLayerList.Count - 1].GetNeyronsCount(); i++) //Розрахування вектора правильних відповідей персептрона на даний набір даних
                {
                    if ((j == i))
                        l_right_result_arr[j, i] = 1f;
                    else
                        l_right_result_arr[j, i] = 0f;
                }
            }*/
            //
                float[] desire_result_vector = new float[_neuronLayerList[_neuronLayerList.Count - 1].GetNeyronsCount()];
            /*
            float[] GetDesireVectorId(int index)
            {
                float[] desire_result_vector = new float[_neuronLayerList[_neuronLayerList.Count - 1].GetNeyronsCount()];
                desire_result_vector[index] = 1f;
                return desire_result_vector;
            }
            */
            //
            float avg_err = 1;
            int epoch = 0;
            while (avg_err > precision && epoch < max_iter)
            {
                epoch++;
                for (int q = 0; q < inputSignals_batch.Length; q++)
                {
                    //inputSignals[q].GetArray(); //Вектор вхідних сигналів
                    //l_right_result_arr[q,]; //Вектор бажаних відповідей
                    List<ISignals> l_layers_results = new List<ISignals>();
                    var inputSignals_d = inputSignals_batch[q].GetCorrectAnswer();

                    /*if(inputSignals_d == 1) //Для виключного або
                    desire_result_vector[0] = 1;*/

                    
                    desire_result_vector[inputSignals_d] = 1;
                    

                    // Прямий прохід
                    l_layers_results.Add(inputSignals_batch[q]);
                    for (int k = 1; k < _neuronLayerList.Count; k++)
                    {
                        l_layers_results.Add(_neuronLayerList[k].GetAnswer(l_layers_results[k - 1]));
                    }

                    // Зворотній прохід
                    float[] nablaoflayer = new float[_neuronLayerList[_neuronLayerList.Count - 1].GetNeyronsCount()];
                    for (int k = _neuronLayerList.Count - 1; k > 0; k--)
                    {
                        if (k == (_neuronLayerList.Count - 1)) // Для вихідного шару
                        {
                            for (int i = 0; i < _neuronLayerList[k].GetNeyronsCount(); i++) //Цикл по кожному нейрону k-того(в даному випадку вихідного) шару
                            {
                                float neuron_result = l_layers_results[k].GetSignal(i);
                                float right_result = desire_result_vector[i];
                                nablaoflayer[i] = neuron_result * (1f - neuron_result) * (right_result - neuron_result);
                            }
                        }
                        else // Для прихованих шарів
                        {
                            float[] nablaofnextlayer = nablaoflayer;
                            nablaoflayer = new float[_neuronLayerList[k].GetNeyronsCount()];
                            for (int i = 0; i < _neuronLayerList[k].GetNeyronsCount(); i++) //Цикл по кожному нейрону k-того шару
                            {
                                float neuron_result = l_layers_results[k].GetSignal(i);
                                float sum = 0;
                                for (int l = 0; l < _neuronLayerList[k + 1].GetNeyronsCount(); l++)
                                {
                                    sum += nablaofnextlayer[l] * _neuronLayerList[k + 1].GetWeightAt(l, i + 1);
                                }
                                nablaoflayer[i] = neuron_result * (1f - neuron_result) * sum;
                            }
                        }
                        //
                        _neuronLayerList[k].CorrectNeurons(learning_rate, nablaoflayer, l_layers_results[k - 1]);

                    }
                    /*if (inputSignals_d == 1)
                    {
                        desire_result_vector[0] = 0;
                    }*/

                    
                    desire_result_vector[inputSignals_d] = 0;
                    
                }
                float eps_sum = 0;
                float max_err = 0;
                for (int q = 0; q < testSignals_batch.Length - 1; q++) // Середньоквадратична помилка
                {
                    ISignals answer = this.GetAnswer(inputSignals_batch[q]);
                    var testSignals_d = testSignals_batch[q].GetCorrectAnswer();
                    /*if (inputSignals_d == 1)
                    {
                        desire_result_vector[0] = 0;
                    }*/
                    desire_result_vector[testSignals_d] = 1;
                    for (int i = 0; i < _outputclasses_count; i++)
                    {
                        float delta = desire_result_vector[i] - answer.GetSignal(i);
                        eps_sum += (float)Math.Pow(delta, 2);
                        if (Math.Abs(delta) > max_err) // Максимальна різниця між бажаним та отриманим результатом
                            max_err = Math.Abs(delta);
                    }
                    /*if (inputSignals_d == 1)
                    {
                        desire_result_vector[0] = 0;
                    }*/
                    desire_result_vector[testSignals_d] = 0;
                    
                }
                avg_err = eps_sum / (testSignals_batch.Length * _outputclasses_count);
            }
            return epoch;
        }
    }
}
