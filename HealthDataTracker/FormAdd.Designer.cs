namespace HealthDataTracker
{
    partial class FormAdd
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
            this.buttonImportExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSystolicBloodPressure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBloodSugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiastolicBloodPressure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Health Data";
            // 
            // buttonImportExcel
            // 
            this.buttonImportExcel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonImportExcel.Location = new System.Drawing.Point(46, 69);
            this.buttonImportExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonImportExcel.Name = "buttonImportExcel";
            this.buttonImportExcel.Size = new System.Drawing.Size(358, 48);
            this.buttonImportExcel.TabIndex = 3;
            this.buttonImportExcel.Text = "Import Health Data From Excel (.csv)";
            this.buttonImportExcel.UseVisualStyleBackColor = false;
            this.buttonImportExcel.Click += new System.EventHandler(this.buttonImportExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Record Today\'s Systolic Blood Pressure";
            // 
            // textBoxSystolicBloodPressure
            // 
            this.textBoxSystolicBloodPressure.Location = new System.Drawing.Point(46, 171);
            this.textBoxSystolicBloodPressure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSystolicBloodPressure.Name = "textBoxSystolicBloodPressure";
            this.textBoxSystolicBloodPressure.Size = new System.Drawing.Size(320, 20);
            this.textBoxSystolicBloodPressure.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "mmHg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "mg/dL";
            // 
            // textBoxBloodSugar
            // 
            this.textBoxBloodSugar.Location = new System.Drawing.Point(46, 285);
            this.textBoxBloodSugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBloodSugar.Name = "textBoxBloodSugar";
            this.textBoxBloodSugar.Size = new System.Drawing.Size(320, 20);
            this.textBoxBloodSugar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Record Today\'s Blood Sugar";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(349, 323);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(56, 28);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(46, 323);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(56, 28);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "mmHg";
            // 
            // textBoxDiastolicBloodPressure
            // 
            this.textBoxDiastolicBloodPressure.Location = new System.Drawing.Point(46, 227);
            this.textBoxDiastolicBloodPressure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDiastolicBloodPressure.Name = "textBoxDiastolicBloodPressure";
            this.textBoxDiastolicBloodPressure.Size = new System.Drawing.Size(320, 20);
            this.textBoxDiastolicBloodPressure.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Record Today\'s Diastolic Blood Pressure";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 374);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDiastolicBloodPressure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBloodSugar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSystolicBloodPressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonImportExcel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImportExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSystolicBloodPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBloodSugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDiastolicBloodPressure;
        private System.Windows.Forms.Label label7;
    }
}