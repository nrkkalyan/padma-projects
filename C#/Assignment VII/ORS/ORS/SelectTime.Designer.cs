namespace ORS
{
    partial class SelectTime
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
            this.lstSelectedTime = new System.Windows.Forms.ListBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the time which is suitable for your travel requirements:";
            // 
            // lstSelectedTime
            // 
            this.lstSelectedTime.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectedTime.FormattingEnabled = true;
            this.lstSelectedTime.ItemHeight = 14;
            this.lstSelectedTime.Location = new System.Drawing.Point(53, 77);
            this.lstSelectedTime.Name = "lstSelectedTime";
            this.lstSelectedTime.Size = new System.Drawing.Size(658, 256);
            this.lstSelectedTime.TabIndex = 1;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(344, 357);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // SelectTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 418);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lstSelectedTime);
            this.Controls.Add(this.label1);
            this.Name = "SelectTime";
            this.Text = "SelectTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSelectedTime;
        private System.Windows.Forms.Button btnContinue;
    }
}