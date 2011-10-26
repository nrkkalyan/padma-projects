namespace Assignment4CBS
{
    partial class MainForm2a
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
            this.btnOK = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnCancel = new System.Windows.Forms.RadioButton();
            this.rbtnReserved = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumOfVacant = new System.Windows.Forms.Label();
            this.lblNumOfReserved = new System.Windows.Forms.Label();
            this.lblNumOfSeats = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.grpReservations = new System.Windows.Forms.GroupBox();
            this.cmboxChoice = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Navy;
            this.btnOK.Location = new System.Drawing.Point(29, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(163, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Reserve";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.rbtnCancel);
            this.grpInput.Controls.Add(this.rbtnReserved);
            this.grpInput.Controls.Add(this.btnOK);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpInput.Location = new System.Drawing.Point(25, 36);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(236, 171);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Booking Input";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.AutoSize = true;
            this.rbtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnCancel.Location = new System.Drawing.Point(103, 23);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(118, 17);
            this.rbtnCancel.TabIndex = 4;
            this.rbtnCancel.TabStop = true;
            this.rbtnCancel.Text = "Cancel Reservation";
            this.rbtnCancel.UseVisualStyleBackColor = true;
            this.rbtnCancel.CheckedChanged += new System.EventHandler(this.rbtnCancel_CheckedChanged);
            // 
            // rbtnReserved
            // 
            this.rbtnReserved.AutoSize = true;
            this.rbtnReserved.Checked = true;
            this.rbtnReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnReserved.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnReserved.Location = new System.Drawing.Point(11, 23);
            this.rbtnReserved.Name = "rbtnReserved";
            this.rbtnReserved.Size = new System.Drawing.Size(65, 17);
            this.rbtnReserved.TabIndex = 3;
            this.rbtnReserved.TabStop = true;
            this.rbtnReserved.Text = "Reserve";
            this.rbtnReserved.UseVisualStyleBackColor = true;
            this.rbtnReserved.CheckedChanged += new System.EventHandler(this.rbtnReserved_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumOfVacant);
            this.groupBox1.Controls.Add(this.lblNumOfReserved);
            this.groupBox1.Controls.Add(this.lblNumOfSeats);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Data";
            // 
            // lblNumOfVacant
            // 
            this.lblNumOfVacant.BackColor = System.Drawing.Color.White;
            this.lblNumOfVacant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumOfVacant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfVacant.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfVacant.Location = new System.Drawing.Point(175, 88);
            this.lblNumOfVacant.Name = "lblNumOfVacant";
            this.lblNumOfVacant.Size = new System.Drawing.Size(46, 17);
            this.lblNumOfVacant.TabIndex = 7;
            this.lblNumOfVacant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumOfReserved
            // 
            this.lblNumOfReserved.BackColor = System.Drawing.Color.White;
            this.lblNumOfReserved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumOfReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfReserved.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfReserved.Location = new System.Drawing.Point(175, 60);
            this.lblNumOfReserved.Name = "lblNumOfReserved";
            this.lblNumOfReserved.Size = new System.Drawing.Size(46, 17);
            this.lblNumOfReserved.TabIndex = 6;
            this.lblNumOfReserved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumOfSeats
            // 
            this.lblNumOfSeats.BackColor = System.Drawing.Color.White;
            this.lblNumOfSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfSeats.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfSeats.Location = new System.Drawing.Point(175, 35);
            this.lblNumOfSeats.Name = "lblNumOfSeats";
            this.lblNumOfSeats.Size = new System.Drawing.Size(46, 17);
            this.lblNumOfSeats.TabIndex = 5;
            this.lblNumOfSeats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(6, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Number of Vacant:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Location = new System.Drawing.Point(6, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(108, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Number of Reserved:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(6, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Number of Seats:";
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.Location = new System.Drawing.Point(24, 54);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(423, 264);
            this.lstReservations.TabIndex = 3;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstReservations_SelectedIndexChanged);
            // 
            // grpReservations
            // 
            this.grpReservations.Controls.Add(this.cmboxChoice);
            this.grpReservations.Controls.Add(this.label7);
            this.grpReservations.Controls.Add(this.label8);
            this.grpReservations.Controls.Add(this.label9);
            this.grpReservations.Controls.Add(this.label10);
            this.grpReservations.Controls.Add(this.lstReservations);
            this.grpReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpReservations.Location = new System.Drawing.Point(303, 36);
            this.grpReservations.Name = "grpReservations";
            this.grpReservations.Size = new System.Drawing.Size(453, 337);
            this.grpReservations.TabIndex = 4;
            this.grpReservations.TabStop = false;
            this.grpReservations.Text = "Reservations (100 kr per ticket)";
            // 
            // cmboxChoice
            // 
            this.cmboxChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxChoice.FormattingEnabled = true;
            this.cmboxChoice.Location = new System.Drawing.Point(317, 10);
            this.cmboxChoice.Name = "cmboxChoice";
            this.cmboxChoice.Size = new System.Drawing.Size(121, 21);
            this.cmboxChoice.TabIndex = 13;
            this.cmboxChoice.SelectedIndexChanged += new System.EventHandler(this.cmboxChoice_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(21, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Row";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(87, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Column";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(233, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(158, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Status";
            // 
            // MainForm2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 417);
            this.Controls.Add(this.grpReservations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInput);
            this.Name = "MainForm2a";
            this.Text = "CBS Cinema Booking System Version 2a";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpReservations.ResumeLayout(false);
            this.grpReservations.PerformLayout();
            this.ResumeLayout(true);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblNumOfSeats;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnCancel;
        private System.Windows.Forms.RadioButton rbtnReserved;
        private System.Windows.Forms.Label lblNumOfVacant;
        private System.Windows.Forms.Label lblNumOfReserved;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.GroupBox grpReservations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmboxChoice;
    }
}

