namespace WindowsFormsApp3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkrevnumber = new System.Windows.Forms.CheckBox();
            this.chkdisplaystatusbar = new System.Windows.Forms.CheckBox();
            this.chklang = new System.Windows.Forms.CheckBox();
            this.btnsldworks = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chkinsertnote = new System.Windows.Forms.CheckBox();
            this.chkinsertable = new System.Windows.Forms.CheckBox();
            this.chkinsertksetch = new System.Windows.Forms.CheckBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnnewpart = new System.Windows.Forms.Button();
            this.chkeditrollback = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkaddcomp = new System.Windows.Forms.CheckBox();
            this.btnnewassembly = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkeditofrmat = new System.Windows.Forms.CheckBox();
            this.btnnewdrawing = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsldworks);
            this.groupBox1.Controls.Add(this.chklang);
            this.groupBox1.Controls.Add(this.chkdisplaystatusbar);
            this.groupBox1.Controls.Add(this.chkrevnumber);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SldWorks";
            // 
            // chkrevnumber
            // 
            this.chkrevnumber.AutoSize = true;
            this.chkrevnumber.Location = new System.Drawing.Point(31, 36);
            this.chkrevnumber.Name = "chkrevnumber";
            this.chkrevnumber.Size = new System.Drawing.Size(133, 20);
            this.chkrevnumber.TabIndex = 0;
            this.chkrevnumber.Text = "Revision Number";
            this.chkrevnumber.UseVisualStyleBackColor = true;
            // 
            // chkdisplaystatusbar
            // 
            this.chkdisplaystatusbar.AutoSize = true;
            this.chkdisplaystatusbar.Location = new System.Drawing.Point(31, 74);
            this.chkdisplaystatusbar.Name = "chkdisplaystatusbar";
            this.chkdisplaystatusbar.Size = new System.Drawing.Size(139, 20);
            this.chkdisplaystatusbar.TabIndex = 1;
            this.chkdisplaystatusbar.Text = "Display Status Bar";
            this.chkdisplaystatusbar.UseVisualStyleBackColor = true;
            this.chkdisplaystatusbar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chklang
            // 
            this.chklang.AutoSize = true;
            this.chklang.Location = new System.Drawing.Point(31, 114);
            this.chklang.Name = "chklang";
            this.chklang.Size = new System.Drawing.Size(114, 20);
            this.chklang.TabIndex = 2;
            this.chklang.Text = "Get Language";
            this.chklang.UseVisualStyleBackColor = true;
            // 
            // btnsldworks
            // 
            this.btnsldworks.Location = new System.Drawing.Point(315, 36);
            this.btnsldworks.Name = "btnsldworks";
            this.btnsldworks.Size = new System.Drawing.Size(143, 23);
            this.btnsldworks.TabIndex = 3;
            this.btnsldworks.Text = "Connect to SldWorks";
            this.btnsldworks.UseVisualStyleBackColor = true;
            this.btnsldworks.Click += new System.EventHandler(this.btnsldworks_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModel);
            this.groupBox2.Controls.Add(this.chkinsertnote);
            this.groupBox2.Controls.Add(this.chkinsertable);
            this.groupBox2.Controls.Add(this.chkinsertksetch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(27, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ModelDoc2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Part";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(165, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Assembly";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(300, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Drawing";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "We will use method NewDocument";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkinsertnote
            // 
            this.chkinsertnote.AutoSize = true;
            this.chkinsertnote.Location = new System.Drawing.Point(34, 190);
            this.chkinsertnote.Name = "chkinsertnote";
            this.chkinsertnote.Size = new System.Drawing.Size(93, 20);
            this.chkinsertnote.TabIndex = 9;
            this.chkinsertnote.Text = "Insert Note";
            this.chkinsertnote.UseVisualStyleBackColor = true;
            // 
            // chkinsertable
            // 
            this.chkinsertable.AutoSize = true;
            this.chkinsertable.Location = new System.Drawing.Point(34, 150);
            this.chkinsertable.Name = "chkinsertable";
            this.chkinsertable.Size = new System.Drawing.Size(100, 20);
            this.chkinsertable.TabIndex = 8;
            this.chkinsertable.Text = "Insert Table";
            this.chkinsertable.UseVisualStyleBackColor = true;
            // 
            // chkinsertksetch
            // 
            this.chkinsertksetch.AutoSize = true;
            this.chkinsertksetch.Location = new System.Drawing.Point(34, 112);
            this.chkinsertksetch.Name = "chkinsertksetch";
            this.chkinsertksetch.Size = new System.Drawing.Size(105, 20);
            this.chkinsertksetch.TabIndex = 7;
            this.chkinsertksetch.Text = "Insert Sketch";
            this.chkinsertksetch.UseVisualStyleBackColor = true;
            this.chkinsertksetch.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(315, 131);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(143, 23);
            this.btnModel.TabIndex = 4;
            this.btnModel.Text = "Connect to Model";
            this.btnModel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkeditrollback);
            this.groupBox3.Controls.Add(this.btnnewpart);
            this.groupBox3.Location = new System.Drawing.Point(27, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 84);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PartDoc";
            // 
            // btnnewpart
            // 
            this.btnnewpart.Location = new System.Drawing.Point(34, 34);
            this.btnnewpart.Name = "btnnewpart";
            this.btnnewpart.Size = new System.Drawing.Size(143, 23);
            this.btnnewpart.TabIndex = 11;
            this.btnnewpart.Text = "New Part";
            this.btnnewpart.UseVisualStyleBackColor = true;
            // 
            // chkeditrollback
            // 
            this.chkeditrollback.AutoSize = true;
            this.chkeditrollback.Location = new System.Drawing.Point(238, 37);
            this.chkeditrollback.Name = "chkeditrollback";
            this.chkeditrollback.Size = new System.Drawing.Size(113, 20);
            this.chkeditrollback.TabIndex = 12;
            this.chkeditrollback.Text = "Edit Roll Back";
            this.chkeditrollback.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkaddcomp);
            this.groupBox4.Controls.Add(this.btnnewassembly);
            this.groupBox4.Location = new System.Drawing.Point(27, 557);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 84);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AssemblyDoc";
            // 
            // chkaddcomp
            // 
            this.chkaddcomp.AutoSize = true;
            this.chkaddcomp.Location = new System.Drawing.Point(238, 37);
            this.chkaddcomp.Name = "chkaddcomp";
            this.chkaddcomp.Size = new System.Drawing.Size(126, 20);
            this.chkaddcomp.TabIndex = 12;
            this.chkaddcomp.Text = "Add Component";
            this.chkaddcomp.UseVisualStyleBackColor = true;
            // 
            // btnnewassembly
            // 
            this.btnnewassembly.Location = new System.Drawing.Point(34, 34);
            this.btnnewassembly.Name = "btnnewassembly";
            this.btnnewassembly.Size = new System.Drawing.Size(143, 23);
            this.btnnewassembly.TabIndex = 11;
            this.btnnewassembly.Text = "New Assembly";
            this.btnnewassembly.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkeditofrmat);
            this.groupBox5.Controls.Add(this.btnnewdrawing);
            this.groupBox5.Location = new System.Drawing.Point(27, 647);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(487, 84);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DrawingDoc";
            // 
            // chkeditofrmat
            // 
            this.chkeditofrmat.AutoSize = true;
            this.chkeditofrmat.Location = new System.Drawing.Point(238, 37);
            this.chkeditofrmat.Name = "chkeditofrmat";
            this.chkeditofrmat.Size = new System.Drawing.Size(97, 20);
            this.chkeditofrmat.TabIndex = 12;
            this.chkeditofrmat.Text = "Edit Format";
            this.chkeditofrmat.UseVisualStyleBackColor = true;
            // 
            // btnnewdrawing
            // 
            this.btnnewdrawing.Location = new System.Drawing.Point(34, 34);
            this.btnnewdrawing.Name = "btnnewdrawing";
            this.btnnewdrawing.Size = new System.Drawing.Size(143, 23);
            this.btnnewdrawing.TabIndex = 11;
            this.btnnewdrawing.Text = "New Drawing";
            this.btnnewdrawing.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 787);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chklang;
        private System.Windows.Forms.CheckBox chkdisplaystatusbar;
        private System.Windows.Forms.CheckBox chkrevnumber;
        private System.Windows.Forms.Button btnsldworks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.CheckBox chkinsertnote;
        private System.Windows.Forms.CheckBox chkinsertable;
        private System.Windows.Forms.CheckBox chkinsertksetch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkeditrollback;
        private System.Windows.Forms.Button btnnewpart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkaddcomp;
        private System.Windows.Forms.Button btnnewassembly;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkeditofrmat;
        private System.Windows.Forms.Button btnnewdrawing;
    }
}

