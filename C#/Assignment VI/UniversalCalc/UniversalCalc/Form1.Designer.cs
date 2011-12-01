namespace UniversalCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grp3D = new System.Windows.Forms.GroupBox();
            this.lblMantelArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblTotSurfaceArea = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp2D = new System.Windows.Forms.GroupBox();
            this.lblBaseCircum = new System.Windows.Forms.Label();
            this.lblBaseArea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.lblLenght = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblShape = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.imgShapeList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grp3D.SuspendLayout();
            this.grp2D.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picImage);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.grpOutput);
            this.tabPage1.Controls.Add(this.grpInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shapes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(593, 328);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(93, 33);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.grp3D);
            this.grpOutput.Controls.Add(this.grp2D);
            this.grpOutput.Location = new System.Drawing.Point(6, 184);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(430, 212);
            this.grpOutput.TabIndex = 0;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // grp3D
            // 
            this.grp3D.Controls.Add(this.lblMantelArea);
            this.grp3D.Controls.Add(this.lblVolume);
            this.grp3D.Controls.Add(this.lblTotSurfaceArea);
            this.grp3D.Controls.Add(this.label5);
            this.grp3D.Controls.Add(this.label4);
            this.grp3D.Controls.Add(this.label3);
            this.grp3D.Location = new System.Drawing.Point(7, 103);
            this.grp3D.Name = "grp3D";
            this.grp3D.Size = new System.Drawing.Size(407, 103);
            this.grp3D.TabIndex = 1;
            this.grp3D.TabStop = false;
            this.grp3D.Text = "Results 3D";
            // 
            // lblMantelArea
            // 
            this.lblMantelArea.BackColor = System.Drawing.Color.LightGray;
            this.lblMantelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMantelArea.Location = new System.Drawing.Point(237, 15);
            this.lblMantelArea.Name = "lblMantelArea";
            this.lblMantelArea.Size = new System.Drawing.Size(164, 23);
            this.lblMantelArea.TabIndex = 6;
            this.lblMantelArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.LightGray;
            this.lblVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVolume.Location = new System.Drawing.Point(237, 71);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(164, 23);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotSurfaceArea
            // 
            this.lblTotSurfaceArea.BackColor = System.Drawing.Color.LightGray;
            this.lblTotSurfaceArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotSurfaceArea.Location = new System.Drawing.Point(237, 46);
            this.lblTotSurfaceArea.Name = "lblTotSurfaceArea";
            this.lblTotSurfaceArea.Size = new System.Drawing.Size(164, 23);
            this.lblTotSurfaceArea.TabIndex = 4;
            this.lblTotSurfaceArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Surface Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mantel Area";
            // 
            // grp2D
            // 
            this.grp2D.Controls.Add(this.lblBaseCircum);
            this.grp2D.Controls.Add(this.lblBaseArea);
            this.grp2D.Controls.Add(this.label2);
            this.grp2D.Controls.Add(this.label1);
            this.grp2D.Location = new System.Drawing.Point(7, 29);
            this.grp2D.Name = "grp2D";
            this.grp2D.Size = new System.Drawing.Size(407, 68);
            this.grp2D.TabIndex = 0;
            this.grp2D.TabStop = false;
            this.grp2D.Text = "Results 2D";
            // 
            // lblBaseCircum
            // 
            this.lblBaseCircum.BackColor = System.Drawing.Color.LightGray;
            this.lblBaseCircum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaseCircum.Location = new System.Drawing.Point(237, 39);
            this.lblBaseCircum.Name = "lblBaseCircum";
            this.lblBaseCircum.Size = new System.Drawing.Size(164, 23);
            this.lblBaseCircum.TabIndex = 3;
            this.lblBaseCircum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaseArea
            // 
            this.lblBaseArea.BackColor = System.Drawing.Color.LightGray;
            this.lblBaseArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaseArea.Location = new System.Drawing.Point(237, 11);
            this.lblBaseArea.Name = "lblBaseArea";
            this.lblBaseArea.Size = new System.Drawing.Size(164, 23);
            this.lblBaseArea.TabIndex = 2;
            this.lblBaseArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base Circumference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Area";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtLenght);
            this.grpInput.Controls.Add(this.txtDepth);
            this.grpInput.Controls.Add(this.txtWidth);
            this.grpInput.Controls.Add(this.cmbShape);
            this.grpInput.Controls.Add(this.lblLenght);
            this.grpInput.Controls.Add(this.lblDepth);
            this.grpInput.Controls.Add(this.lblWidth);
            this.grpInput.Controls.Add(this.lblShape);
            this.grpInput.Location = new System.Drawing.Point(6, 15);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(430, 163);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(265, 112);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(100, 20);
            this.txtLenght.TabIndex = 8;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(265, 79);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 20);
            this.txtDepth.TabIndex = 7;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(265, 47);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // cmbShape
            // 
            this.cmbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(244, 20);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(121, 21);
            this.cmbShape.TabIndex = 5;
            this.cmbShape.SelectedIndexChanged += new System.EventHandler(this.cmbShape_SelectedIndexChanged);
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Location = new System.Drawing.Point(17, 112);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(46, 13);
            this.lblLenght.TabIndex = 4;
            this.lblLenght.Text = "Lenght";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(17, 82);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(41, 13);
            this.lblDepth.TabIndex = 3;
            this.lblDepth.Text = "Depth";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(17, 49);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(40, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(17, 20);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(43, 13);
            this.lblShape.TabIndex = 1;
            this.lblShape.Text = "Shape";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Units";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(805, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trigonometry";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(805, 433);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Currency Exchanger";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(805, 433);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fuel Consumption";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(486, 15);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(295, 222);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // imgShapeList
            // 
            this.imgShapeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgShapeList.ImageStream")));
            this.imgShapeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgShapeList.Images.SetKeyName(0, "rectangle.jpg");
            this.imgShapeList.Images.SetKeyName(1, "circle.jpg");
            this.imgShapeList.Images.SetKeyName(2, "elipse.jpg");
            this.imgShapeList.Images.SetKeyName(3, "prism.jpg");
            this.imgShapeList.Images.SetKeyName(4, "cylinder.jpg");
            this.imgShapeList.Images.SetKeyName(5, "sphere.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 484);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Universal Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grp3D.ResumeLayout(false);
            this.grp3D.PerformLayout();
            this.grp2D.ResumeLayout(false);
            this.grp2D.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.GroupBox grp3D;
        private System.Windows.Forms.Label lblMantelArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblTotSurfaceArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp2D;
        private System.Windows.Forms.Label lblBaseCircum;
        private System.Windows.Forms.Label lblBaseArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ImageList imgShapeList;
    }
}

