namespace _19520600_19521219_LAB4
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
            this.rtb_Input = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.rtb_SHA256 = new System.Windows.Forms.RichTextBox();
            this.rtb_SHA1 = new System.Windows.Forms.RichTextBox();
            this.rtb_MD5 = new System.Windows.Forms.RichTextBox();
            this.cb_SHA256 = new System.Windows.Forms.CheckBox();
            this.cb_SHA1 = new System.Windows.Forms.CheckBox();
            this.cb_MD5 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ReadFile = new System.Windows.Forms.Button();
            this.cb_DataFormat = new System.Windows.Forms.ComboBox();
            this.cb_SHA512 = new System.Windows.Forms.CheckBox();
            this.rtb_SHA512 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_Input
            // 
            this.rtb_Input.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Input.Location = new System.Drawing.Point(299, 70);
            this.rtb_Input.Name = "rtb_Input";
            this.rtb_Input.Size = new System.Drawing.Size(607, 67);
            this.rtb_Input.TabIndex = 16;
            this.rtb_Input.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(547, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Input Data";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Calculate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(12, 236);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(133, 63);
            this.btn_Calculate.TabIndex = 26;
            this.btn_Calculate.Text = "Caculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // rtb_SHA256
            // 
            this.rtb_SHA256.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_SHA256.Location = new System.Drawing.Point(299, 272);
            this.rtb_SHA256.Name = "rtb_SHA256";
            this.rtb_SHA256.Size = new System.Drawing.Size(607, 27);
            this.rtb_SHA256.TabIndex = 25;
            this.rtb_SHA256.Text = "";
            // 
            // rtb_SHA1
            // 
            this.rtb_SHA1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_SHA1.Location = new System.Drawing.Point(299, 236);
            this.rtb_SHA1.Name = "rtb_SHA1";
            this.rtb_SHA1.Size = new System.Drawing.Size(607, 30);
            this.rtb_SHA1.TabIndex = 24;
            this.rtb_SHA1.Text = "";
            // 
            // rtb_MD5
            // 
            this.rtb_MD5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_MD5.Location = new System.Drawing.Point(299, 204);
            this.rtb_MD5.Name = "rtb_MD5";
            this.rtb_MD5.Size = new System.Drawing.Size(607, 26);
            this.rtb_MD5.TabIndex = 23;
            this.rtb_MD5.Text = "";
            // 
            // cb_SHA256
            // 
            this.cb_SHA256.AutoSize = true;
            this.cb_SHA256.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SHA256.Location = new System.Drawing.Point(190, 273);
            this.cb_SHA256.Name = "cb_SHA256";
            this.cb_SHA256.Size = new System.Drawing.Size(89, 23);
            this.cb_SHA256.TabIndex = 22;
            this.cb_SHA256.Text = "SHA-256";
            this.cb_SHA256.UseVisualStyleBackColor = true;
            // 
            // cb_SHA1
            // 
            this.cb_SHA1.AutoSize = true;
            this.cb_SHA1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SHA1.Location = new System.Drawing.Point(190, 240);
            this.cb_SHA1.Name = "cb_SHA1";
            this.cb_SHA1.Size = new System.Drawing.Size(73, 23);
            this.cb_SHA1.TabIndex = 21;
            this.cb_SHA1.Text = "SHA-1";
            this.cb_SHA1.UseVisualStyleBackColor = true;
            // 
            // cb_MD5
            // 
            this.cb_MD5.AutoSize = true;
            this.cb_MD5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MD5.Location = new System.Drawing.Point(190, 204);
            this.cb_MD5.Name = "cb_MD5";
            this.cb_MD5.Size = new System.Drawing.Size(64, 23);
            this.cb_MD5.TabIndex = 20;
            this.cb_MD5.Text = "MD5";
            this.cb_MD5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(547, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 22);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "Output Data";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(789, 349);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 31);
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ReadFile
            // 
            this.btn_ReadFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ReadFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadFile.Location = new System.Drawing.Point(12, 105);
            this.btn_ReadFile.Name = "btn_ReadFile";
            this.btn_ReadFile.Size = new System.Drawing.Size(251, 31);
            this.btn_ReadFile.TabIndex = 29;
            this.btn_ReadFile.Text = "Read File";
            this.btn_ReadFile.UseVisualStyleBackColor = false;
            this.btn_ReadFile.Click += new System.EventHandler(this.btn_ReadBinaryFile_Click);
            // 
            // cb_DataFormat
            // 
            this.cb_DataFormat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DataFormat.FormattingEnabled = true;
            this.cb_DataFormat.Items.AddRange(new object[] {
            "Text string",
            "Hex string",
            "Binary"});
            this.cb_DataFormat.Location = new System.Drawing.Point(12, 69);
            this.cb_DataFormat.Name = "cb_DataFormat";
            this.cb_DataFormat.Size = new System.Drawing.Size(251, 30);
            this.cb_DataFormat.TabIndex = 0;
            // 
            // cb_SHA512
            // 
            this.cb_SHA512.AutoSize = true;
            this.cb_SHA512.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SHA512.Location = new System.Drawing.Point(190, 306);
            this.cb_SHA512.Name = "cb_SHA512";
            this.cb_SHA512.Size = new System.Drawing.Size(89, 23);
            this.cb_SHA512.TabIndex = 30;
            this.cb_SHA512.Text = "SHA-512";
            this.cb_SHA512.UseVisualStyleBackColor = true;
            // 
            // rtb_SHA512
            // 
            this.rtb_SHA512.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_SHA512.Location = new System.Drawing.Point(299, 305);
            this.rtb_SHA512.Name = "rtb_SHA512";
            this.rtb_SHA512.Size = new System.Drawing.Size(607, 27);
            this.rtb_SHA512.TabIndex = 31;
            this.rtb_SHA512.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 402);
            this.Controls.Add(this.rtb_SHA512);
            this.Controls.Add(this.cb_SHA512);
            this.Controls.Add(this.btn_ReadFile);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.rtb_Input);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.rtb_SHA256);
            this.Controls.Add(this.rtb_SHA1);
            this.Controls.Add(this.rtb_MD5);
            this.Controls.Add(this.cb_SHA256);
            this.Controls.Add(this.cb_SHA1);
            this.Controls.Add(this.cb_MD5);
            this.Controls.Add(this.cb_DataFormat);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Input;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.RichTextBox rtb_SHA256;
        private System.Windows.Forms.RichTextBox rtb_SHA1;
        private System.Windows.Forms.RichTextBox rtb_MD5;
        private System.Windows.Forms.CheckBox cb_SHA256;
        private System.Windows.Forms.CheckBox cb_SHA1;
        private System.Windows.Forms.CheckBox cb_MD5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ReadFile;
        private System.Windows.Forms.ComboBox cb_DataFormat;
        private System.Windows.Forms.CheckBox cb_SHA512;
        private System.Windows.Forms.RichTextBox rtb_SHA512;
    }
}

