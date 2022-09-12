
namespace andruinoCtr
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWriteLCD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLed1 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed2 = new System.Windows.Forms.CheckBox();
            this.checkBoxLed3 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 51);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWriteLCD);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LCD";
            // 
            // buttonWriteLCD
            // 
            this.buttonWriteLCD.Location = new System.Drawing.Point(119, 76);
            this.buttonWriteLCD.Name = "buttonWriteLCD";
            this.buttonWriteLCD.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteLCD.TabIndex = 1;
            this.buttonWriteLCD.Text = "Ghi";
            this.buttonWriteLCD.UseVisualStyleBackColor = true;
            this.buttonWriteLCD.Click += new System.EventHandler(this.buttonWriteLCD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxLed3);
            this.groupBox2.Controls.Add(this.checkBoxLed2);
            this.groupBox2.Controls.Add(this.checkBoxLed1);
            this.groupBox2.Location = new System.Drawing.Point(237, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Control";
            // 
            // checkBoxLed1
            // 
            this.checkBoxLed1.AutoSize = true;
            this.checkBoxLed1.Location = new System.Drawing.Point(45, 52);
            this.checkBoxLed1.Name = "checkBoxLed1";
            this.checkBoxLed1.Size = new System.Drawing.Size(50, 17);
            this.checkBoxLed1.TabIndex = 0;
            this.checkBoxLed1.Text = "Led1";
            this.checkBoxLed1.UseVisualStyleBackColor = true;
            this.checkBoxLed1.CheckedChanged += new System.EventHandler(this.checkBoxLed1_CheckedChanged);
            // 
            // checkBoxLed2
            // 
            this.checkBoxLed2.AutoSize = true;
            this.checkBoxLed2.Location = new System.Drawing.Point(134, 52);
            this.checkBoxLed2.Name = "checkBoxLed2";
            this.checkBoxLed2.Size = new System.Drawing.Size(50, 17);
            this.checkBoxLed2.TabIndex = 0;
            this.checkBoxLed2.Text = "Led2";
            this.checkBoxLed2.UseVisualStyleBackColor = true;
            this.checkBoxLed2.CheckedChanged += new System.EventHandler(this.checkBoxLed2_CheckedChanged);
            // 
            // checkBoxLed3
            // 
            this.checkBoxLed3.AutoSize = true;
            this.checkBoxLed3.Location = new System.Drawing.Point(209, 52);
            this.checkBoxLed3.Name = "checkBoxLed3";
            this.checkBoxLed3.Size = new System.Drawing.Size(50, 17);
            this.checkBoxLed3.TabIndex = 0;
            this.checkBoxLed3.Text = "Led3";
            this.checkBoxLed3.UseVisualStyleBackColor = true;
            this.checkBoxLed3.CheckedChanged += new System.EventHandler(this.checkBoxLed3_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.buttonConnect);
            this.groupBox3.Location = new System.Drawing.Point(237, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 122);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect Serial";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(155, 41);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM3",
            "COM6"});
            this.comboBox1.Location = new System.Drawing.Point(18, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 303);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Computer Control Andruino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWriteLCD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxLed3;
        private System.Windows.Forms.CheckBox checkBoxLed2;
        private System.Windows.Forms.CheckBox checkBoxLed1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonConnect;
    }
}

