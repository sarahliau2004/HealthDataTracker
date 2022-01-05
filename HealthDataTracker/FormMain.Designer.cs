namespace HealthDataTracker
{
    partial class FormMain
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Salmon;
            this.buttonAdd.Location = new System.Drawing.Point(63, 102);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(491, 66);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Health Data";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health Data Tracker";
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.LightCoral;
            this.buttonView.Location = new System.Drawing.Point(58, 204);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(491, 66);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "View Past Data";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCompare.Location = new System.Drawing.Point(58, 306);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(491, 66);
            this.buttonCompare.TabIndex = 3;
            this.buttonCompare.Text = "Compare Data";
            this.buttonCompare.UseVisualStyleBackColor = false;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Health Data Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonCompare;
    }
}

