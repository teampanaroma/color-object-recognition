namespace RenkYakalama
{
    partial class AnaForm
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
            this.kameraPictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TanimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RenkHassasiyetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TuvalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseColorBox = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kameraPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kameraPictureBox
            // 
            this.kameraPictureBox.BackColor = System.Drawing.Color.Black;
            this.kameraPictureBox.Location = new System.Drawing.Point(0, 24);
            this.kameraPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.kameraPictureBox.Name = "kameraPictureBox";
            this.kameraPictureBox.Size = new System.Drawing.Size(576, 432);
            this.kameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kameraPictureBox.TabIndex = 0;
            this.kameraPictureBox.TabStop = false;
            this.kameraPictureBox.DoubleClick += new System.EventHandler(this.kameraPictureBox_DoubleClick);
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanimaToolStripMenuItem,
            this.TuvalToolStripMenuItem,
            this.BrushToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TanimaToolStripMenuItem
            // 
            this.TanimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedToolStripMenuItem,
            this.GreenToolStripMenuItem,
            this.BlueToolStripMenuItem,
            this.toolStripSeparator1,
            this.RenkHassasiyetiToolStripMenuItem});
            this.TanimaToolStripMenuItem.Name = "TanimaToolStripMenuItem";
            this.TanimaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.TanimaToolStripMenuItem.Text = "Tanıma";
            // 
            // RedToolStripMenuItem
            // 
            this.RedToolStripMenuItem.Name = "RedToolStripMenuItem";
            this.RedToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.RedToolStripMenuItem.Text = "Kırmızı";
            this.RedToolStripMenuItem.Click += new System.EventHandler(this.RedToolStripMenuItem_Click);
            // 
            // GreenToolStripMenuItem
            // 
            this.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem";
            this.GreenToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.GreenToolStripMenuItem.Text = "Yeşil";
            this.GreenToolStripMenuItem.Click += new System.EventHandler(this.GreenToolStripMenuItem_Click);
            // 
            // BlueToolStripMenuItem
            // 
            this.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem";
            this.BlueToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.BlueToolStripMenuItem.Text = "Mavi";
            this.BlueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // RenkHassasiyetiToolStripMenuItem
            // 
            this.RenkHassasiyetiToolStripMenuItem.Name = "RenkHassasiyetiToolStripMenuItem";
            this.RenkHassasiyetiToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.RenkHassasiyetiToolStripMenuItem.Text = "Hassasiyet";
            this.RenkHassasiyetiToolStripMenuItem.Click += new System.EventHandler(this.RenkHassasiyetiToolStripMenuItem_Click);
            // 
            // TuvalToolStripMenuItem
            // 
            this.TuvalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CleanToolStripMenuItem});
            this.TuvalToolStripMenuItem.Name = "TuvalToolStripMenuItem";
            this.TuvalToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.TuvalToolStripMenuItem.Text = "Tuval";
            // 
            // CleanToolStripMenuItem
            // 
            this.CleanToolStripMenuItem.Name = "CleanToolStripMenuItem";
            this.CleanToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.CleanToolStripMenuItem.Text = "Tuvali Temizle";
            this.CleanToolStripMenuItem.Click += new System.EventHandler(this.CleanToolStripMenuItem_Click);
            // 
            // BrushToolStripMenuItem
            // 
            this.BrushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeColorToolStripMenuItem});
            this.BrushToolStripMenuItem.Name = "BrushToolStripMenuItem";
            this.BrushToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.BrushToolStripMenuItem.Text = "Fırça";
            // 
            // ChangeColorToolStripMenuItem
            // 
            this.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem";
            this.ChangeColorToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ChangeColorToolStripMenuItem.Text = "Renk Değiştir";
            this.ChangeColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorToolStripMenuItem_Click);
            // 
            // ChooseColorBox
            // 
            this.ChooseColorBox.Color = System.Drawing.Color.Red;
            this.ChooseColorBox.FullOpen = true;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(623, 479);
            this.Controls.Add(this.kameraPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Nesne Yakala";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaForm_FormClosed);
            this.DoubleClick += new System.EventHandler(this.AnaForm_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.kameraPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        /// <summary>
        /// Hlavní komponenta pro vykreslení obrazu webkamery
        /// </summary>
        public System.Windows.Forms.PictureBox kameraPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TanimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TuvalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CleanToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ChooseColorBox;
        private System.Windows.Forms.ToolStripMenuItem BrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RenkHassasiyetiToolStripMenuItem;
    }
}

