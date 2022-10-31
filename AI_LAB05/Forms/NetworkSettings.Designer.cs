namespace AI_LAB05.Forms
{
    partial class NetworkSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown_dataX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_dataY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_layers_characteristic = new System.Windows.Forms.TrackBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_outputclasses = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_max_iter = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textBox_precision = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_pen_width = new System.Windows.Forms.TextBox();
            this.textBox_learning_rate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dataX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dataY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_layers_characteristic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outputclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_iter)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_dataX
            // 
            this.numericUpDown_dataX.Location = new System.Drawing.Point(209, 12);
            this.numericUpDown_dataX.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown_dataX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_dataX.Name = "numericUpDown_dataX";
            this.numericUpDown_dataX.Size = new System.Drawing.Size(70, 27);
            this.numericUpDown_dataX.TabIndex = 0;
            this.numericUpDown_dataX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_dataY
            // 
            this.numericUpDown_dataY.Location = new System.Drawing.Point(285, 12);
            this.numericUpDown_dataY.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown_dataY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_dataY.Name = "numericUpDown_dataY";
            this.numericUpDown_dataY.Size = new System.Drawing.Size(70, 27);
            this.numericUpDown_dataY.TabIndex = 1;
            this.numericUpDown_dataY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Розміри вхідної матриці";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Характеристики прихованих шарів";
            // 
            // trackBar_layers_characteristic
            // 
            this.trackBar_layers_characteristic.Location = new System.Drawing.Point(13, 71);
            this.trackBar_layers_characteristic.Name = "trackBar_layers_characteristic";
            this.trackBar_layers_characteristic.Size = new System.Drawing.Size(340, 56);
            this.trackBar_layers_characteristic.TabIndex = 4;
            this.trackBar_layers_characteristic.Scroll += new System.EventHandler(this.trackBar_layers_characteristic_Scroll);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(340, 65);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість класів (вихідних нейронів)";
            // 
            // numericUpDown_outputclasses
            // 
            this.numericUpDown_outputclasses.Location = new System.Drawing.Point(286, 199);
            this.numericUpDown_outputclasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_outputclasses.Name = "numericUpDown_outputclasses";
            this.numericUpDown_outputclasses.Size = new System.Drawing.Size(70, 27);
            this.numericUpDown_outputclasses.TabIndex = 7;
            this.numericUpDown_outputclasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Максимальна кількість ітерацій";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Точність";
            // 
            // numericUpDown_max_iter
            // 
            this.numericUpDown_max_iter.Location = new System.Drawing.Point(247, 232);
            this.numericUpDown_max_iter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_max_iter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_max_iter.Name = "numericUpDown_max_iter";
            this.numericUpDown_max_iter.Size = new System.Drawing.Size(109, 27);
            this.numericUpDown_max_iter.TabIndex = 10;
            this.numericUpDown_max_iter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(152, 377);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Зберегти";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textBox_precision
            // 
            this.textBox_precision.Location = new System.Drawing.Point(206, 267);
            this.textBox_precision.Name = "textBox_precision";
            this.textBox_precision.Size = new System.Drawing.Size(150, 27);
            this.textBox_precision.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 152);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ширина пезлика";
            // 
            // textBox_pen_width
            // 
            this.textBox_pen_width.Location = new System.Drawing.Point(206, 333);
            this.textBox_pen_width.Name = "textBox_pen_width";
            this.textBox_pen_width.Size = new System.Drawing.Size(150, 27);
            this.textBox_pen_width.TabIndex = 17;
            // 
            // textBox_learning_rate
            // 
            this.textBox_learning_rate.Location = new System.Drawing.Point(206, 300);
            this.textBox_learning_rate.Name = "textBox_learning_rate";
            this.textBox_learning_rate.Size = new System.Drawing.Size(150, 27);
            this.textBox_learning_rate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Швидкість навчання";
            // 
            // NetworkSettings
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(371, 418);
            this.Controls.Add(this.textBox_learning_rate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_pen_width);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_precision);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numericUpDown_max_iter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_outputclasses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trackBar_layers_characteristic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_dataY);
            this.Controls.Add(this.numericUpDown_dataX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NetworkSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NetworkSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dataX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dataY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_layers_characteristic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outputclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_iter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public NumericUpDown numericUpDown_dataX;
        public NumericUpDown numericUpDown_dataY;
        private Label label1;
        private Label label2;
        public TrackBar trackBar_layers_characteristic;
        private Label label3;
        public DataGridView dataGridView1;
        public NumericUpDown numericUpDown_outputclasses;
        private Label label4;
        private Label label5;
        public NumericUpDown numericUpDown_max_iter;
        private Button btnCancel;
        private Button btnOk;
        public TextBox textBox_precision;
        private Panel panel1;
        private Label label6;
        public TextBox textBox_pen_width;
        public TextBox textBox_learning_rate;
        private Label label7;
    }
}