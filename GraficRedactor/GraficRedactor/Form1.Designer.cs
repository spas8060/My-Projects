namespace GraficRedactor
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
            Panel panel1;
            trackBar1 = new TrackBar();
            panelBackColor = new Panel();
            panelConturColor = new Panel();
            Eraserbtn = new Button();
            TextFontbtn = new Button();
            Freehandbtn = new Button();
            Textbn = new Button();
            CustomBtn = new Button();
            LineBtn = new Button();
            RectangleBtn = new Button();
            Elipsebtn = new Button();
            statusStrip1 = new StatusStrip();
            Tool1 = new ToolStripStatusLabel();
            Label2 = new ToolStripStatusLabel();
            Label3 = new ToolStripStatusLabel();
            statusStrip2 = new StatusStrip();
            frmPicture = new PictureBox();
            colorDialog2 = new ColorDialog();
            fontDialog1 = new FontDialog();
            panel1 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frmPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(panelBackColor);
            panel1.Controls.Add(panelConturColor);
            panel1.Controls.Add(Eraserbtn);
            panel1.Controls.Add(TextFontbtn);
            panel1.Controls.Add(Freehandbtn);
            panel1.Controls.Add(Textbn);
            panel1.Controls.Add(CustomBtn);
            panel1.Controls.Add(LineBtn);
            panel1.Controls.Add(RectangleBtn);
            panel1.Controls.Add(Elipsebtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 623);
            panel1.TabIndex = 3;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(42, 495);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.TabIndex = 10;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // panelBackColor
            // 
            panelBackColor.BackColor = Color.White;
            panelBackColor.Location = new Point(42, 372);
            panelBackColor.Name = "panelBackColor";
            panelBackColor.Size = new Size(109, 88);
            panelBackColor.TabIndex = 8;
            panelBackColor.DoubleClick += panelBackColor_DoubleClick;
            // 
            // panelConturColor
            // 
            panelConturColor.BackColor = SystemColors.ActiveCaptionText;
            panelConturColor.Location = new Point(59, 390);
            panelConturColor.Name = "panelConturColor";
            panelConturColor.Size = new Size(113, 87);
            panelConturColor.TabIndex = 9;
            panelConturColor.DoubleClick += panelConturColor_DoubleClick;
            // 
            // Eraserbtn
            // 
            Eraserbtn.BackColor = SystemColors.ActiveCaption;
            Eraserbtn.Location = new Point(109, 557);
            Eraserbtn.Name = "Eraserbtn";
            Eraserbtn.Size = new Size(94, 50);
            Eraserbtn.TabIndex = 7;
            Eraserbtn.Text = "Eraser";
            Eraserbtn.UseVisualStyleBackColor = false;
            Eraserbtn.Click += Eraserbtn_Click;
            // 
            // TextFontbtn
            // 
            TextFontbtn.BackColor = SystemColors.ActiveCaption;
            TextFontbtn.Location = new Point(9, 557);
            TextFontbtn.Name = "TextFontbtn";
            TextFontbtn.Size = new Size(94, 50);
            TextFontbtn.TabIndex = 6;
            TextFontbtn.Text = "Text Font";
            TextFontbtn.UseVisualStyleBackColor = false;
            TextFontbtn.Click += TextFontbtn_Click;
            // 
            // Freehandbtn
            // 
            Freehandbtn.Location = new Point(109, 160);
            Freehandbtn.Name = "Freehandbtn";
            Freehandbtn.Size = new Size(94, 69);
            Freehandbtn.TabIndex = 5;
            Freehandbtn.Text = "Freehand Tool";
            Freehandbtn.UseVisualStyleBackColor = false;
            Freehandbtn.Click += Freehand_Click;
            // 
            // Textbn
            // 
            Textbn.Location = new Point(9, 160);
            Textbn.Name = "Textbn";
            Textbn.Size = new Size(94, 69);
            Textbn.TabIndex = 4;
            Textbn.Text = "Text";
            Textbn.UseVisualStyleBackColor = false;
            Textbn.KeyPress += Textbn_KeyPress;
            // 
            // CustomBtn
            // 
            CustomBtn.Location = new Point(109, 85);
            CustomBtn.Name = "CustomBtn";
            CustomBtn.Size = new Size(94, 69);
            CustomBtn.TabIndex = 3;
            CustomBtn.Text = "Custom";
            CustomBtn.UseVisualStyleBackColor = false;
            CustomBtn.Click += CustomBtn_Click;
            // 
            // LineBtn
            // 
            LineBtn.Location = new Point(9, 85);
            LineBtn.Name = "LineBtn";
            LineBtn.Size = new Size(94, 69);
            LineBtn.TabIndex = 2;
            LineBtn.Text = "Line";
            LineBtn.UseVisualStyleBackColor = false;
            LineBtn.Click += LineBtn_Click;
            // 
            // RectangleBtn
            // 
            RectangleBtn.Location = new Point(109, 11);
            RectangleBtn.Name = "RectangleBtn";
            RectangleBtn.Size = new Size(94, 69);
            RectangleBtn.TabIndex = 1;
            RectangleBtn.Text = "Recrangle";
            RectangleBtn.UseVisualStyleBackColor = false;
            RectangleBtn.Click += RectangleBtn_Click;
            // 
            // Elipsebtn
            // 
            Elipsebtn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            Elipsebtn.FlatAppearance.BorderSize = 5;
            Elipsebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            Elipsebtn.Location = new Point(9, 11);
            Elipsebtn.Name = "Elipsebtn";
            Elipsebtn.Size = new Size(94, 69);
            Elipsebtn.TabIndex = 0;
            Elipsebtn.Text = "Elipse";
            Elipsebtn.UseVisualStyleBackColor = false;
            Elipsebtn.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { Tool1, Label2, Label3 });
            statusStrip1.Location = new Point(0, 635);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1080, 30);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Tool1
            // 
            Tool1.AutoSize = false;
            Tool1.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            Tool1.BorderStyle = Border3DStyle.Raised;
            Tool1.Name = "Tool1";
            Tool1.Size = new Size(151, 24);
            // 
            // Label2
            // 
            Label2.AutoSize = false;
            Label2.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            Label2.BorderStyle = Border3DStyle.Raised;
            Label2.MergeAction = MergeAction.Replace;
            Label2.Name = "Label2";
            Label2.Size = new Size(155, 24);
            // 
            // Label3
            // 
            Label3.AutoSize = false;
            Label3.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            Label3.BorderStyle = Border3DStyle.Raised;
            Label3.Name = "Label3";
            Label3.Size = new Size(151, 24);
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Location = new Point(0, 613);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(1080, 22);
            statusStrip2.TabIndex = 2;
            statusStrip2.Text = "statusStrip2";
            // 
            // frmPicture
            // 
            frmPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmPicture.BackColor = SystemColors.ButtonHighlight;
            frmPicture.Location = new Point(226, 3);
            frmPicture.Name = "frmPicture";
            frmPicture.Size = new Size(853, 623);
            frmPicture.TabIndex = 4;
            frmPicture.TabStop = false;
            frmPicture.MouseDown += frmPicture_MouseDown;
            frmPicture.MouseMove += frmPicture_MouseMove;
            frmPicture.MouseUp += frmPicture_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 665);
            Controls.Add(frmPicture);
            Controls.Add(panel1);
            Controls.Add(statusStrip2);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Графичен Редактор";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frmPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Elipsebtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Tool1;
        private ToolStripStatusLabel Label2;
        private ToolStripStatusLabel Label3;
        private StatusStrip statusStrip2;
        private PictureBox frmPicture;
        private Button CustomBtn;
        private Button LineBtn;
        private Button RectangleBtn;
        private Button Freehandbtn;
        private Button Textbn;
        private Button TextFontbtn;
        private Button Eraserbtn;
        private Panel panelConturColor;
        private Panel panelBackColor;
        private TrackBar trackBar1;
        private ColorDialog colorDialog2;
        private FontDialog fontDialog1;
    }
}