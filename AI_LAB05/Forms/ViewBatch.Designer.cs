namespace AI_LAB05.Forms
{
    partial class ViewBatch
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сортуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заПорядкомДоданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заЗростаннямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listView1, "Клацніть правою кнопкою, щоб змінити порядок сортування");
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортуватиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 28);
            // 
            // сортуватиToolStripMenuItem
            // 
            this.сортуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заПорядкомДоданняToolStripMenuItem,
            this.заЗростаннямToolStripMenuItem});
            this.сортуватиToolStripMenuItem.Name = "сортуватиToolStripMenuItem";
            this.сортуватиToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.сортуватиToolStripMenuItem.Text = "Сортувати";
            // 
            // заПорядкомДоданняToolStripMenuItem
            // 
            this.заПорядкомДоданняToolStripMenuItem.Checked = true;
            this.заПорядкомДоданняToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.заПорядкомДоданняToolStripMenuItem.Name = "заПорядкомДоданняToolStripMenuItem";
            this.заПорядкомДоданняToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.заПорядкомДоданняToolStripMenuItem.Text = "За порядком додання";
            this.заПорядкомДоданняToolStripMenuItem.Click += new System.EventHandler(this.заПорядкомДоданняToolStripMenuItem_Click);
            // 
            // заЗростаннямToolStripMenuItem
            // 
            this.заЗростаннямToolStripMenuItem.Name = "заЗростаннямToolStripMenuItem";
            this.заЗростаннямToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.заЗростаннямToolStripMenuItem.Text = "За зростанням";
            this.заЗростаннямToolStripMenuItem.Click += new System.EventHandler(this.заЗростаннямToolStripMenuItem_Click);
            // 
            // ViewBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "ViewBatch";
            this.Text = "ViewBatch";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem сортуватиToolStripMenuItem;
        private ToolStripMenuItem заПорядкомДоданняToolStripMenuItem;
        private ToolStripMenuItem заЗростаннямToolStripMenuItem;
        private ToolTip toolTip1;
    }
}