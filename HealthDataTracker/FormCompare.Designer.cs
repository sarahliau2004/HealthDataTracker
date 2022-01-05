namespace HealthDataTracker
{
    partial class FormCompare
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
            this.textBoxEnterDate1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEnterDate2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSystolicBloodPressureChange = new System.Windows.Forms.TextBox();
            this.textBoxSugarChange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDiastolicBloodPressureChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Compare Health Data";
            // 
            // textBoxEnterDate1
            // 
            this.textBoxEnterDate1.Location = new System.Drawing.Point(36, 104);
            this.textBoxEnterDate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnterDate1.Name = "textBoxEnterDate1";
            this.textBoxEnterDate1.Size = new System.Drawing.Size(125, 20);
            this.textBoxEnterDate1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date 1 (MM/DD/YYYY):";
            // 
            // textBoxEnterDate2
            // 
            this.textBoxEnterDate2.Location = new System.Drawing.Point(202, 104);
            this.textBoxEnterDate2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnterDate2.Name = "textBoxEnterDate2";
            this.textBoxEnterDate2.Size = new System.Drawing.Size(125, 20);
            this.textBoxEnterDate2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date 2 (MM/DD/YYYY):";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(348, 96);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(68, 34);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Change in Systolic Blood Pressure";
            // 
            // textBoxSystolicBloodPressureChange
            // 
            this.textBoxSystolicBloodPressureChange.Location = new System.Drawing.Point(202, 144);
            this.textBoxSystolicBloodPressureChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSystolicBloodPressureChange.Name = "textBoxSystolicBloodPressureChange";
            this.textBoxSystolicBloodPressureChange.ReadOnly = true;
            this.textBoxSystolicBloodPressureChange.Size = new System.Drawing.Size(126, 20);
            this.textBoxSystolicBloodPressureChange.TabIndex = 12;
            // 
            // textBoxSugarChange
            // 
            this.textBoxSugarChange.Location = new System.Drawing.Point(202, 219);
            this.textBoxSugarChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSugarChange.Name = "textBoxSugarChange";
            this.textBoxSugarChange.ReadOnly = true;
            this.textBoxSugarChange.Size = new System.Drawing.Size(126, 20);
            this.textBoxSugarChange.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Change in Blood Sugar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "mg/dL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "mmHg";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(36, 266);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(56, 32);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "mmHg";
            // 
            // textBoxDiastolicBloodPressureChange
            // 
            this.textBoxDiastolicBloodPressureChange.Location = new System.Drawing.Point(202, 180);
            this.textBoxDiastolicBloodPressureChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDiastolicBloodPressureChange.Name = "textBoxDiastolicBloodPressureChange";
            this.textBoxDiastolicBloodPressureChange.ReadOnly = true;
            this.textBoxDiastolicBloodPressureChange.Size = new System.Drawing.Size(126, 20);
            this.textBoxDiastolicBloodPressureChange.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Change in Diastolic Blood Pressure";
            // 
            // FormCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 314);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDiastolicBloodPressureChange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSugarChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSystolicBloodPressureChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxEnterDate2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEnterDate1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormCompare";
            this.Text = "Compare Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnterDate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEnterDate2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSystolicBloodPressureChange;
        private System.Windows.Forms.TextBox textBoxSugarChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDiastolicBloodPressureChange;
        private System.Windows.Forms.Label label9;
    }
}