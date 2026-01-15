namespace WindowsFormsApp9
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbtnBrass = new System.Windows.Forms.RadioButton();
            this.rbtnAL = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkContour2 = new System.Windows.Forms.CheckBox();
            this.chkContour1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.rbtnRevolve = new System.Windows.Forms.RadioButton();
            this.rbtnExtrude = new System.Windows.Forms.RadioButton();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(55, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 278);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbtnBrass);
            this.tabPage1.Controls.Add(this.rbtnAL);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(528, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Material";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbtnBrass
            // 
            this.rbtnBrass.AutoSize = true;
            this.rbtnBrass.Location = new System.Drawing.Point(62, 91);
            this.rbtnBrass.Name = "rbtnBrass";
            this.rbtnBrass.Size = new System.Drawing.Size(63, 20);
            this.rbtnBrass.TabIndex = 1;
            this.rbtnBrass.Text = "Brass";
            this.rbtnBrass.UseVisualStyleBackColor = true;
            // 
            // rbtnAL
            // 
            this.rbtnAL.AutoSize = true;
            this.rbtnAL.Checked = true;
            this.rbtnAL.Location = new System.Drawing.Point(62, 45);
            this.rbtnAL.Name = "rbtnAL";
            this.rbtnAL.Size = new System.Drawing.Size(142, 20);
            this.rbtnAL.TabIndex = 0;
            this.rbtnAL.TabStop = true;
            this.rbtnAL.Text = "1060-H12 Rod (SS)";
            this.rbtnAL.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtRadius);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtWidth);
            this.tabPage2.Controls.Add(this.txtHeight);
            this.tabPage2.Controls.Add(this.rbtnCircle);
            this.tabPage2.Controls.Add(this.rbtnRectangle);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(528, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(332, 151);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(332, 82);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(332, 47);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 2;
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Location = new System.Drawing.Point(48, 151);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(62, 20);
            this.rbtnCircle.TabIndex = 1;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "Circle";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Location = new System.Drawing.Point(48, 50);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(90, 20);
            this.rbtnRectangle.TabIndex = 0;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "Rectangle";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkContour2);
            this.tabPage3.Controls.Add(this.chkContour1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtAngle);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtDepth);
            this.tabPage3.Controls.Add(this.rbtnRevolve);
            this.tabPage3.Controls.Add(this.rbtnExtrude);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(528, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Operation";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // chkContour2
            // 
            this.chkContour2.AutoSize = true;
            this.chkContour2.Location = new System.Drawing.Point(405, 198);
            this.chkContour2.Name = "chkContour2";
            this.chkContour2.Size = new System.Drawing.Size(85, 20);
            this.chkContour2.TabIndex = 11;
            this.chkContour2.Text = "Contour 2";
            this.chkContour2.UseVisualStyleBackColor = true;
            // 
            // chkContour1
            // 
            this.chkContour1.AutoSize = true;
            this.chkContour1.Location = new System.Drawing.Point(405, 172);
            this.chkContour1.Name = "chkContour1";
            this.chkContour1.Size = new System.Drawing.Size(85, 20);
            this.chkContour1.TabIndex = 10;
            this.chkContour1.Text = "Contour 1";
            this.chkContour1.UseVisualStyleBackColor = true;
            this.chkContour1.CheckedChanged += new System.EventHandler(this.chkContour1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Angle";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(215, 122);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 22);
            this.txtAngle.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Depth";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(215, 41);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 22);
            this.txtDepth.TabIndex = 6;
            this.txtDepth.TextChanged += new System.EventHandler(this.txtDepth_TextChanged);
            // 
            // rbtnRevolve
            // 
            this.rbtnRevolve.AutoSize = true;
            this.rbtnRevolve.Location = new System.Drawing.Point(53, 124);
            this.rbtnRevolve.Name = "rbtnRevolve";
            this.rbtnRevolve.Size = new System.Drawing.Size(79, 20);
            this.rbtnRevolve.TabIndex = 3;
            this.rbtnRevolve.TabStop = true;
            this.rbtnRevolve.Text = "Revolve";
            this.rbtnRevolve.UseVisualStyleBackColor = true;
            this.rbtnRevolve.CheckedChanged += new System.EventHandler(this.rbtnRevolve_CheckedChanged);
            // 
            // rbtnExtrude
            // 
            this.rbtnExtrude.AutoSize = true;
            this.rbtnExtrude.Location = new System.Drawing.Point(53, 40);
            this.rbtnExtrude.Name = "rbtnExtrude";
            this.rbtnExtrude.Size = new System.Drawing.Size(73, 20);
            this.rbtnExtrude.TabIndex = 2;
            this.rbtnExtrude.TabStop = true;
            this.rbtnExtrude.Text = "Extrude";
            this.rbtnExtrude.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(512, 334);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "Build Part";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(512, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 406);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Part Automation Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbtnBrass;
        private System.Windows.Forms.RadioButton rbtnAL;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.RadioButton rbtnRevolve;
        private System.Windows.Forms.RadioButton rbtnExtrude;
        private System.Windows.Forms.CheckBox chkContour2;
        private System.Windows.Forms.CheckBox chkContour1;
    }
}

