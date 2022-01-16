namespace GPACalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.textBoxGPAX = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(775, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 153);
            this.button2.TabIndex = 1;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "GPAX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "MAX GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "MIN GPA";
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGPA_input.Location = new System.Drawing.Point(597, 41);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(172, 45);
            this.textBoxGPA_input.TabIndex = 6;
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName_input.Location = new System.Drawing.Point(274, 41);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(317, 45);
            this.textBoxName_input.TabIndex = 7;
            // 
            // textBoxGPAX
            // 
            this.textBoxGPAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGPAX.Location = new System.Drawing.Point(533, 38);
            this.textBoxGPAX.Name = "textBoxGPAX";
            this.textBoxGPAX.Size = new System.Drawing.Size(172, 45);
            this.textBoxGPAX.TabIndex = 8;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxName.Location = new System.Drawing.Point(210, 92);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(317, 45);
            this.textBoxMaxName.TabIndex = 9;
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinName.Location = new System.Drawing.Point(210, 146);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.Size = new System.Drawing.Size(317, 45);
            this.textBoxMinName.TabIndex = 10;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxGPA.Location = new System.Drawing.Point(533, 92);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.Size = new System.Drawing.Size(172, 45);
            this.textBoxMaxGPA.TabIndex = 11;
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinGPA.Location = new System.Drawing.Point(533, 146);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.Size = new System.Drawing.Size(172, 45);
            this.textBoxMinGPA.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.textBoxGPAX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.AcceptsReturn = true;
            this.textBoxAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAllData.Location = new System.Drawing.Point(64, 335);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.Size = new System.Drawing.Size(908, 283);
            this.textBoxAllData.TabIndex = 14;
            this.textBoxAllData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 630);
            this.Controls.Add(this.textBoxAllData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGPA_input;
        private System.Windows.Forms.TextBox textBoxName_input;
        private System.Windows.Forms.TextBox textBoxGPAX;
        private System.Windows.Forms.TextBox textBoxMaxName;
        private System.Windows.Forms.TextBox textBoxMinName;
        private System.Windows.Forms.TextBox textBoxMaxGPA;
        private System.Windows.Forms.TextBox textBoxMinGPA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAllData;
    }
}

