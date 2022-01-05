namespace HealthDataTracker
{
    partial class FormView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEnterDate = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBloodSugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSystolicBloodPressure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDiastolicBloodPressure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Health Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Date (MM/DD/YYYY):";
            // 
            // textBoxEnterDate
            // 
            this.textBoxEnterDate.Location = new System.Drawing.Point(48, 117);
            this.textBoxEnterDate.Name = "textBoxEnterDate";
            this.textBoxEnterDate.Size = new System.Drawing.Size(165, 22);
            this.textBoxEnterDate.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(246, 112);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(70, 32);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxDiastolicBloodPressure);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxBloodSugar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSystolicBloodPressure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(46, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Health Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "mg/dL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "mmHg";
            // 
            // textBoxBloodSugar
            // 
            this.textBoxBloodSugar.Location = new System.Drawing.Point(196, 164);
            this.textBoxBloodSugar.Name = "textBoxBloodSugar";
            this.textBoxBloodSugar.ReadOnly = true;
            this.textBoxBloodSugar.Size = new System.Drawing.Size(150, 22);
            this.textBoxBloodSugar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Blood Sugar";
            // 
            // textBoxSystolicBloodPressure
            // 
            this.textBoxSystolicBloodPressure.Location = new System.Drawing.Point(195, 82);
            this.textBoxSystolicBloodPressure.Name = "textBoxSystolicBloodPressure";
            this.textBoxSystolicBloodPressure.ReadOnly = true;
            this.textBoxSystolicBloodPressure.Size = new System.Drawing.Size(150, 22);
            this.textBoxSystolicBloodPressure.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Systolic Blood Pressure";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(195, 41);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(150, 22);
            this.textBoxDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(46, 412);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 35);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "mmHg";
            // 
            // textBoxDiastolicBloodPressure
            // 
            this.textBoxDiastolicBloodPressure.Location = new System.Drawing.Point(195, 122);
            this.textBoxDiastolicBloodPressure.Name = "textBoxDiastolicBloodPressure";
            this.textBoxDiastolicBloodPressure.ReadOnly = true;
            this.textBoxDiastolicBloodPressure.Size = new System.Drawing.Size(150, 22);
            this.textBoxDiastolicBloodPressure.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Diastolic Blood Pressure";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 470);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxEnterDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormView";
            this.Text = "View Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEnterDate;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBloodSugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSystolicBloodPressure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDiastolicBloodPressure;
        private System.Windows.Forms.Label label9;
    }
}