namespace مثال_منو2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.تغییررنگToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ابیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سبزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قرمزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییرعنوانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ساعتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عبارتدلخواهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خالیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تغییررنگToolStripMenuItem,
            this.تغییرعنوانToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // تغییررنگToolStripMenuItem
            // 
            this.تغییررنگToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ابیToolStripMenuItem,
            this.سبزToolStripMenuItem,
            this.قرمزToolStripMenuItem});
            this.تغییررنگToolStripMenuItem.Name = "تغییررنگToolStripMenuItem";
            this.تغییررنگToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.تغییررنگToolStripMenuItem.Text = "تغییر رنگ";
            // 
            // ابیToolStripMenuItem
            // 
            this.ابیToolStripMenuItem.Name = "ابیToolStripMenuItem";
            this.ابیToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.ابیToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ابیToolStripMenuItem.Text = "ابی";
            this.ابیToolStripMenuItem.Click += new System.EventHandler(this.ابیToolStripMenuItem_Click);
            // 
            // سبزToolStripMenuItem
            // 
            this.سبزToolStripMenuItem.Name = "سبزToolStripMenuItem";
            this.سبزToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.سبزToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.سبزToolStripMenuItem.Text = "سبز";
            this.سبزToolStripMenuItem.Click += new System.EventHandler(this.سبزToolStripMenuItem_Click);
            // 
            // قرمزToolStripMenuItem
            // 
            this.قرمزToolStripMenuItem.Name = "قرمزToolStripMenuItem";
            this.قرمزToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.قرمزToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.قرمزToolStripMenuItem.Text = "قرمز";
            this.قرمزToolStripMenuItem.Click += new System.EventHandler(this.قرمزToolStripMenuItem_Click);
            // 
            // تغییرعنوانToolStripMenuItem
            // 
            this.تغییرعنوانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ساعتToolStripMenuItem,
            this.عبارتدلخواهToolStripMenuItem,
            this.خالیToolStripMenuItem});
            this.تغییرعنوانToolStripMenuItem.Name = "تغییرعنوانToolStripMenuItem";
            this.تغییرعنوانToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.تغییرعنوانToolStripMenuItem.Text = "تغییر عنوان";
            this.تغییرعنوانToolStripMenuItem.Click += new System.EventHandler(this.تغییرعنوانToolStripMenuItem_Click);
            // 
            // ساعتToolStripMenuItem
            // 
            this.ساعتToolStripMenuItem.Checked = true;
            this.ساعتToolStripMenuItem.CheckOnClick = true;
            this.ساعتToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ساعتToolStripMenuItem.Name = "ساعتToolStripMenuItem";
            this.ساعتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ساعتToolStripMenuItem.Text = "ساعت";
            this.ساعتToolStripMenuItem.Click += new System.EventHandler(this.ساعتToolStripMenuItem_Click);
            // 
            // عبارتدلخواهToolStripMenuItem
            // 
            this.عبارتدلخواهToolStripMenuItem.Checked = true;
            this.عبارتدلخواهToolStripMenuItem.CheckOnClick = true;
            this.عبارتدلخواهToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.عبارتدلخواهToolStripMenuItem.Name = "عبارتدلخواهToolStripMenuItem";
            this.عبارتدلخواهToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.عبارتدلخواهToolStripMenuItem.Text = "عبارت دلخواه";
            this.عبارتدلخواهToolStripMenuItem.Click += new System.EventHandler(this.عبارتدلخواهToolStripMenuItem_Click);
            // 
            // خالیToolStripMenuItem
            // 
            this.خالیToolStripMenuItem.Checked = true;
            this.خالیToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.خالیToolStripMenuItem.Name = "خالیToolStripMenuItem";
            this.خالیToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.خالیToolStripMenuItem.Text = "خالی";
            this.خالیToolStripMenuItem.Click += new System.EventHandler(this.خالیToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Checked = true;
            this.خروجToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(232, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(246, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "قبول";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تغییررنگToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ابیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سبزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قرمزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییرعنوانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ساعتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عبارتدلخواهToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem خالیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}

