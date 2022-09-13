
namespace ProgettoCad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UndoBtn = new System.Windows.Forms.ToolStripButton();
            this.ReverseBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveLbl = new System.Windows.Forms.ToolStripLabel();
            this.LoadBtn = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.WidthTxt = new System.Windows.Forms.ToolStripTextBox();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.LessBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.colorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.defaultZoomBtn = new System.Windows.Forms.ToolStripButton();
            this.HelpBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.FrecciaBtn = new System.Windows.Forms.ToolStripButton();
            this.LineaBtn = new System.Windows.Forms.ToolStripButton();
            this.CurvaBtn = new System.Windows.Forms.ToolStripButton();
            this.RettangoloBtn = new System.Windows.Forms.ToolStripButton();
            this.CerchioBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(6, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1827, 707);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoBtn,
            this.ReverseBtn,
            this.SaveLbl,
            this.LoadBtn,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.WidthTxt,
            this.AddBtn,
            this.LessBtn,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.colorBtn,
            this.toolStripSeparator3,
            this.defaultZoomBtn,
            this.HelpBtn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1381, 41);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UndoBtn
            // 
            this.UndoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoBtn.Image = ((System.Drawing.Image)(resources.GetObject("UndoBtn.Image")));
            this.UndoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(36, 38);
            this.UndoBtn.Text = "UndoBtn";
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // ReverseBtn
            // 
            this.ReverseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReverseBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReverseBtn.Image")));
            this.ReverseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReverseBtn.Name = "ReverseBtn";
            this.ReverseBtn.Size = new System.Drawing.Size(36, 38);
            this.ReverseBtn.Text = "ReverseBtn";
            this.ReverseBtn.Click += new System.EventHandler(this.ReverseBtn_Click);
            // 
            // SaveLbl
            // 
            this.SaveLbl.Name = "SaveLbl";
            this.SaveLbl.Size = new System.Drawing.Size(31, 38);
            this.SaveLbl.Text = "Save";
            this.SaveLbl.Click += new System.EventHandler(this.SaveLbl_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(33, 38);
            this.LoadBtn.Text = "Load";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 38);
            this.toolStripLabel2.Text = "Width";
            // 
            // WidthTxt
            // 
            this.WidthTxt.Name = "WidthTxt";
            this.WidthTxt.Size = new System.Drawing.Size(56, 41);
            this.WidthTxt.Text = "5";
            this.WidthTxt.TextChanged += new System.EventHandler(this.WidthTxt_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(36, 38);
            this.AddBtn.Text = "AddBtn";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // LessBtn
            // 
            this.LessBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LessBtn.Image = ((System.Drawing.Image)(resources.GetObject("LessBtn.Image")));
            this.LessBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LessBtn.Name = "LessBtn";
            this.LessBtn.Size = new System.Drawing.Size(36, 38);
            this.LessBtn.Text = "toolStripButton2";
            this.LessBtn.Click += new System.EventHandler(this.LessBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 38);
            this.toolStripLabel1.Text = "Color";
            // 
            // colorBtn
            // 
            this.colorBtn.AutoSize = false;
            this.colorBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.colorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorBtn.Margin = new System.Windows.Forms.Padding(7, 1, 0, 10);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(30, 30);
            this.colorBtn.Text = "colorBtn";
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // defaultZoomBtn
            // 
            this.defaultZoomBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.defaultZoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("defaultZoomBtn.Image")));
            this.defaultZoomBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.defaultZoomBtn.Name = "defaultZoomBtn";
            this.defaultZoomBtn.Size = new System.Drawing.Size(36, 38);
            this.defaultZoomBtn.Text = "defaultZoomBtn";
            this.defaultZoomBtn.Click += new System.EventHandler(this.defaultZoomBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.HelpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpBtn.Size = new System.Drawing.Size(23, 38);
            this.HelpBtn.Text = "?";
            this.HelpBtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.HelpBtn.ToolTipText = "Help";
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrecciaBtn,
            this.LineaBtn,
            this.CurvaBtn,
            this.RettangoloBtn,
            this.CerchioBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 41);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1381, 39);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // FrecciaBtn
            // 
            this.FrecciaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FrecciaBtn.Image = ((System.Drawing.Image)(resources.GetObject("FrecciaBtn.Image")));
            this.FrecciaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrecciaBtn.Name = "FrecciaBtn";
            this.FrecciaBtn.Size = new System.Drawing.Size(36, 36);
            this.FrecciaBtn.Text = "FrecciaBtn";
            this.FrecciaBtn.Click += new System.EventHandler(this.FrecciaBtn_Click);
            // 
            // LineaBtn
            // 
            this.LineaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineaBtn.Image = ((System.Drawing.Image)(resources.GetObject("LineaBtn.Image")));
            this.LineaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineaBtn.Name = "LineaBtn";
            this.LineaBtn.Size = new System.Drawing.Size(36, 36);
            this.LineaBtn.Text = "LineaBtn";
            this.LineaBtn.Click += new System.EventHandler(this.LineaBtn_Click);
            // 
            // CurvaBtn
            // 
            this.CurvaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurvaBtn.Image = ((System.Drawing.Image)(resources.GetObject("CurvaBtn.Image")));
            this.CurvaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurvaBtn.Name = "CurvaBtn";
            this.CurvaBtn.Size = new System.Drawing.Size(36, 36);
            this.CurvaBtn.Text = "CurvaBtn";
            this.CurvaBtn.Click += new System.EventHandler(this.CurvaBtn_Click);
            // 
            // RettangoloBtn
            // 
            this.RettangoloBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RettangoloBtn.Image = ((System.Drawing.Image)(resources.GetObject("RettangoloBtn.Image")));
            this.RettangoloBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RettangoloBtn.Name = "RettangoloBtn";
            this.RettangoloBtn.Size = new System.Drawing.Size(36, 36);
            this.RettangoloBtn.Text = "RettangoloBtn";
            this.RettangoloBtn.Click += new System.EventHandler(this.RettangoloBtn_Click);
            // 
            // CerchioBtn
            // 
            this.CerchioBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CerchioBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerchioBtn.Image")));
            this.CerchioBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CerchioBtn.Name = "CerchioBtn";
            this.CerchioBtn.Size = new System.Drawing.Size(36, 36);
            this.CerchioBtn.Text = "CerchioBtn";
            this.CerchioBtn.Click += new System.EventHandler(this.CerchioBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 38);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1381, 666);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Draw1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton FrecciaBtn;
        private System.Windows.Forms.ToolStripButton LineaBtn;
        private System.Windows.Forms.ToolStripButton LessBtn;
        private System.Windows.Forms.ToolStripButton CurvaBtn;
        private System.Windows.Forms.ToolStripButton UndoBtn;
        private System.Windows.Forms.ToolStripButton ReverseBtn;
        private System.Windows.Forms.ToolStripLabel SaveLbl;
        private System.Windows.Forms.ToolStripLabel LoadBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox WidthTxt;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton RettangoloBtn;
        private System.Windows.Forms.ToolStripButton CerchioBtn;
        private System.Windows.Forms.ToolStripButton colorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton defaultZoomBtn;
        private System.Windows.Forms.ToolStripButton HelpBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

