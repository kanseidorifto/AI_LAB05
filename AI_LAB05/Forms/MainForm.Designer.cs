namespace AI_LAB05.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.paintControl1 = new AI_LAB05.PaintControl();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нейроннаМережаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.навчатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиМережуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиМережуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вибіркиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.навчальнаВибіркаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестоваВибіркаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SaveToBatch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.навчальнаВибіркаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тестоваВибіркаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_ClearPaintBox = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paintControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintControl1
            // 
            this.paintControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintControl1.Location = new System.Drawing.Point(26, 45);
            this.paintControl1.Name = "paintControl1";
            this.paintControl1.Size = new System.Drawing.Size(256, 256);
            this.paintControl1.TabIndex = 0;
            this.paintControl1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Виконати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.нейроннаМережаToolStripMenuItem,
            this.вибіркиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // нейроннаМережаToolStripMenuItem
            // 
            this.нейроннаМережаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.навчатиToolStripMenuItem,
            this.налаштуванняToolStripMenuItem,
            this.завантажитиМережуToolStripMenuItem,
            this.зберегтиМережуToolStripMenuItem});
            this.нейроннаМережаToolStripMenuItem.Name = "нейроннаМережаToolStripMenuItem";
            this.нейроннаМережаToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.нейроннаМережаToolStripMenuItem.Text = "Нейронна мережа";
            // 
            // навчатиToolStripMenuItem
            // 
            this.навчатиToolStripMenuItem.Name = "навчатиToolStripMenuItem";
            this.навчатиToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.навчатиToolStripMenuItem.Text = "Навчати";
            this.навчатиToolStripMenuItem.Click += new System.EventHandler(this.навчатиToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // завантажитиМережуToolStripMenuItem
            // 
            this.завантажитиМережуToolStripMenuItem.Name = "завантажитиМережуToolStripMenuItem";
            this.завантажитиМережуToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.завантажитиМережуToolStripMenuItem.Text = "Завантажити";
            this.завантажитиМережуToolStripMenuItem.Click += new System.EventHandler(this.завантажитиМережуToolStripMenuItem_Click);
            // 
            // зберегтиМережуToolStripMenuItem
            // 
            this.зберегтиМережуToolStripMenuItem.Name = "зберегтиМережуToolStripMenuItem";
            this.зберегтиМережуToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.зберегтиМережуToolStripMenuItem.Text = "Зберегти";
            this.зберегтиМережуToolStripMenuItem.Click += new System.EventHandler(this.зберегтиМережуToolStripMenuItem_Click);
            // 
            // вибіркиToolStripMenuItem
            // 
            this.вибіркиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.навчальнаВибіркаToolStripMenuItem,
            this.тестоваВибіркаToolStripMenuItem});
            this.вибіркиToolStripMenuItem.Name = "вибіркиToolStripMenuItem";
            this.вибіркиToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.вибіркиToolStripMenuItem.Text = "Вибірки";
            // 
            // навчальнаВибіркаToolStripMenuItem
            // 
            this.навчальнаВибіркаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглянутиToolStripMenuItem,
            this.завантажитиToolStripMenuItem,
            this.зберегтиToolStripMenuItem});
            this.навчальнаВибіркаToolStripMenuItem.Name = "навчальнаВибіркаToolStripMenuItem";
            this.навчальнаВибіркаToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.навчальнаВибіркаToolStripMenuItem.Text = "Навчальна вибірка";
            // 
            // переглянутиToolStripMenuItem
            // 
            this.переглянутиToolStripMenuItem.Name = "переглянутиToolStripMenuItem";
            this.переглянутиToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.переглянутиToolStripMenuItem.Text = "Переглянути";
            this.переглянутиToolStripMenuItem.Click += new System.EventHandler(this.переглянутиToolStripMenuItem_Click);
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.завантажитиToolStripMenuItem.Text = "Завантажити";
            this.завантажитиToolStripMenuItem.Click += new System.EventHandler(this.завантажитиToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // тестоваВибіркаToolStripMenuItem
            // 
            this.тестоваВибіркаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглянутиToolStripMenuItem1,
            this.завантажитиToolStripMenuItem1,
            this.зберегтиToolStripMenuItem1});
            this.тестоваВибіркаToolStripMenuItem.Name = "тестоваВибіркаToolStripMenuItem";
            this.тестоваВибіркаToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.тестоваВибіркаToolStripMenuItem.Text = "Тестова вибірка";
            // 
            // переглянутиToolStripMenuItem1
            // 
            this.переглянутиToolStripMenuItem1.Name = "переглянутиToolStripMenuItem1";
            this.переглянутиToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.переглянутиToolStripMenuItem1.Text = "Переглянути";
            this.переглянутиToolStripMenuItem1.Click += new System.EventHandler(this.переглянутиToolStripMenuItem1_Click);
            // 
            // завантажитиToolStripMenuItem1
            // 
            this.завантажитиToolStripMenuItem1.Name = "завантажитиToolStripMenuItem1";
            this.завантажитиToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.завантажитиToolStripMenuItem1.Text = "Завантажити";
            this.завантажитиToolStripMenuItem1.Click += new System.EventHandler(this.завантажитиToolStripMenuItem1_Click);
            // 
            // зберегтиToolStripMenuItem1
            // 
            this.зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            this.зберегтиToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.зберегтиToolStripMenuItem1.Text = "Зберегти";
            this.зберегтиToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиToolStripMenuItem1_Click);
            // 
            // btn_SaveToBatch
            // 
            this.btn_SaveToBatch.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_SaveToBatch.Location = new System.Drawing.Point(26, 311);
            this.btn_SaveToBatch.Name = "btn_SaveToBatch";
            this.btn_SaveToBatch.Size = new System.Drawing.Size(126, 63);
            this.btn_SaveToBatch.TabIndex = 6;
            this.btn_SaveToBatch.Text = "Зберегти у навч. вибірку";
            this.toolTip1.SetToolTip(this.btn_SaveToBatch, "Клацніть правою кнопкою, щоб змінити вибірку");
            this.btn_SaveToBatch.UseVisualStyleBackColor = true;
            this.btn_SaveToBatch.Click += new System.EventHandler(this.btn_SaveToBatch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.навчальнаВибіркаToolStripMenuItem1,
            this.тестоваВибіркаToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 56);
            // 
            // навчальнаВибіркаToolStripMenuItem1
            // 
            this.навчальнаВибіркаToolStripMenuItem1.Checked = true;
            this.навчальнаВибіркаToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.навчальнаВибіркаToolStripMenuItem1.Name = "навчальнаВибіркаToolStripMenuItem1";
            this.навчальнаВибіркаToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.навчальнаВибіркаToolStripMenuItem1.Text = "Навчальна вибірка";
            this.навчальнаВибіркаToolStripMenuItem1.Click += new System.EventHandler(this.навчальнаВибіркаToolStripMenuItem1_Click);
            // 
            // тестоваВибіркаToolStripMenuItem1
            // 
            this.тестоваВибіркаToolStripMenuItem1.Name = "тестоваВибіркаToolStripMenuItem1";
            this.тестоваВибіркаToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.тестоваВибіркаToolStripMenuItem1.Text = "Тестова вибірка";
            this.тестоваВибіркаToolStripMenuItem1.Click += new System.EventHandler(this.тестоваВибіркаToolStripMenuItem1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(288, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 384);
            this.listBox1.TabIndex = 7;
            // 
            // btn_ClearPaintBox
            // 
            this.btn_ClearPaintBox.Location = new System.Drawing.Point(156, 311);
            this.btn_ClearPaintBox.Name = "btn_ClearPaintBox";
            this.btn_ClearPaintBox.Size = new System.Drawing.Size(126, 63);
            this.btn_ClearPaintBox.TabIndex = 9;
            this.btn_ClearPaintBox.Text = "Очистити";
            this.btn_ClearPaintBox.UseVisualStyleBackColor = true;
            this.btn_ClearPaintBox.Click += new System.EventHandler(this.btn_ClearPaintBox_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "NeuronNetwork trained";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 468);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_ClearPaintBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_SaveToBatch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paintControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeuronNetwork";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.paintControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaintControl paintControl1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private Button btn_SaveToBatch;
        private ListBox listBox1;
        private SaveFileDialog saveFileDialog1;
        private Button btn_ClearPaintBox;
        private ToolStripMenuItem нейроннаМережаToolStripMenuItem;
        private ToolStripMenuItem зберегтиМережуToolStripMenuItem;
        private ToolStripMenuItem завантажитиМережуToolStripMenuItem;
        private ToolStripMenuItem налаштуванняToolStripMenuItem;
        private ToolStripMenuItem вибіркиToolStripMenuItem;
        private ToolStripMenuItem навчальнаВибіркаToolStripMenuItem;
        private ToolStripMenuItem завантажитиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem переглянутиToolStripMenuItem;
        private ToolStripMenuItem тестоваВибіркаToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem навчатиToolStripMenuItem;
        private ToolStripMenuItem переглянутиToolStripMenuItem1;
        private ToolStripMenuItem завантажитиToolStripMenuItem1;
        private ToolStripMenuItem зберегтиToolStripMenuItem1;
        private OpenFileDialog openFileDialog2;
        private SaveFileDialog saveFileDialog2;
        private OpenFileDialog openFileDialog3;
        private SaveFileDialog saveFileDialog3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem навчальнаВибіркаToolStripMenuItem1;
        private ToolStripMenuItem тестоваВибіркаToolStripMenuItem1;
        private ToolTip toolTip1;
    }
}