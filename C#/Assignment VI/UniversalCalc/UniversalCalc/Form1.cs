//File Name: Form1.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversalCalc
{
    public partial class Form1 : Form
    {
        // values to store dimensions
        double width = 0.0D;
        double lenght = 0.0D;
        double depth = 0.0D;

        public Form1()
        {
            InitializeComponent();
            //my initalization
            InitializeGUI();
        }

        /// <summary>
        /// Initalizes the textboxes values to empty and loads the combobox and selects default value for the 
        /// image to display
        /// </summary>
        private void InitializeGUI()
        {
            txtDepth.Text = string.Empty;
            txtLenght.Text = string.Empty;
            txtWidth.Text = string.Empty;
            // clear and updated the combobox with shapes Enum and select default value as rectangle.
            cmbShape.Items.Clear();
            cmbShape.Items.AddRange(Enum.GetNames(typeof(Shapes)));
            cmbShape.SelectedIndex = (int)Shapes.Rectangle;

            //select default image for the image display
            picImage.Image = this.imgShapeList.Images[cmbShape.SelectedIndex];
            
            //Update the lables of the Output Groupbox
            UpdateLables();
        }

        /// <summary>
        /// This method returns the type of the shape that is selected in the combo box
        /// </summary>
        /// <returns>The shape selected by the user</returns>
        private Shapes GetFigure()
        {
            return (Shapes)Enum.Parse(typeof(Shapes), cmbShape.Text, true);
        }

        /// <summary>
        /// According to user selected values select and perform the operations
        /// according to the cases
        /// </summary>
        private void UpdateLables()
        {
            Shapes figure = GetFigure();
            Shape shape = null;

            switch (figure)
            {
                case Shapes.Rectangle:
                    {
                        //create instance of the Rectangle class and call necessary methods
                        //to perform operations
                        shape = new Rectangle(width,depth);
                        lblBaseArea.Text = ((Rectangle)shape).Area.ToString("0.00");
                        lblBaseCircum.Text = ((Rectangle)shape).Circum.ToString("0.00");

                        break;
                    }
                case Shapes.Circle:
                    {
                        //create instance of the Ellipse class and call necessary methods
                        //to perform operations 
                        shape = new Ellipse(width);
                        lblBaseArea.Text = ((Ellipse)shape).Area.ToString("0.00");
                        lblBaseCircum.Text = ((Ellipse)shape).Circum.ToString("0.00");

                        break;
                    }
                case Shapes.Cylinder:
                    {

                        //create instance of the Cylinder class and call necessary methods
                        //to perform operations
                        shape = new Cylinder(width,depth,lenght);
                        lblBaseArea.Text = ((Cylinder)shape).BaseArea.ToString("0.00");
                        lblBaseCircum.Text = ((Cylinder)shape).BaseCircum.ToString("0.00");

                        lblVolume.Text = ((Cylinder)shape).Volume.ToString("0.00");
                        lblMantelArea.Text = ((Cylinder)shape).MantelArea.ToString("0.00");
                        lblTotSurfaceArea.Text = ((Cylinder)shape).TotalArea.ToString("0.00");

                        break;
                    }
                case Shapes.Ellipse:
                    {
                        //create instance of the Ellipse class and call necessary methods
                        //to perform operations
                        shape = new Ellipse(width,depth);
                        lblBaseArea.Text = ((Ellipse)shape).Area.ToString("0.00");
                        lblBaseCircum.Text = ((Ellipse)shape).Circum.ToString("0.00");

                        break;
                    }

                case Shapes.Prism:
                    {
                        //create instance of the Prism class and call necessary methods
                        //to perform operations
                        shape = new Prism(width, depth, lenght);
                        lblBaseArea.Text = ((Prism)shape).BaseArea.ToString("0.00");
                        lblBaseCircum.Text = ((Prism)shape).BaseCircum.ToString("0.00");

                        lblVolume.Text = ((Prism)shape).Volume.ToString("0.00");
                        lblMantelArea.Text = ((Prism)shape).MantelArea.ToString("0.00");
                        lblTotSurfaceArea.Text = ((Prism)shape).TotalArea.ToString("0.00");

                        break;
                    }

                case Shapes.Sphere:
                    {
                        //create instance of the Sphere class and call necessary methods
                        //to perform operations
                        shape = new Sphere(width);
                        lblBaseArea.Text = ((Sphere)shape).BaseArea.ToString("0.00");
                        lblBaseCircum.Text = ((Sphere)shape).BaseCircum.ToString("0.00");

                        lblVolume.Text = ((Sphere)shape).Volume.ToString("0.00");
                        lblMantelArea.Text = ((Sphere)shape).MantelArea.ToString("0.00");
                        lblTotSurfaceArea.Text = ((Sphere)shape).TotalArea.ToString("0.00");

                        break;
                    }

            }
        }
        
        /// <summary>
        /// Event handler for click event of btnCalcuate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //validate the inputs
            bool inputOK = ReadAndValidateInput(out width, out depth, out lenght);
            //update lables if input is validated
            if (inputOK)
            {
                //update the output lables
                UpdateLables();
            }

        }

        /// <summary>
        /// This method validates the user inputs and convert them into
        /// doulbe values if they are valid.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <param name="lenght"></param>
        /// <returns></returns>
        private bool ReadAndValidateInput(out double width, out double depth, out double lenght)
        {
            //boolean variables
            bool validWidth = InputUtility.GetDouble(txtWidth.Text,out width);
            bool validHeight = InputUtility.GetDouble(txtDepth.Text, out depth);
            bool validLenght = InputUtility.GetDouble(txtLenght.Text, out lenght);
            //if any of the inputs are not valid alert the user
            if (!validHeight || !validWidth || !validLenght)
            {
                MessageBox.Show("Input is invalid!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Event handler for the selected changes event of cmbShape
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDepth.Text = string.Empty;
            txtLenght.Text = string.Empty;
            txtWidth.Text = string.Empty;
            //change image in the image control according to the selection
            picImage.Image = this.imgShapeList.Images[cmbShape.SelectedIndex];
            //enable necessary text boxes
            EnableDisableTextBoxes();
            //change the values of grpInput back to empty
            DefaultValues();
        }

        /// <summary>
        /// Depending on the choice of the cmbShapesd
        /// enable or disable some of the text boxes.
        /// </summary>
        private void EnableDisableTextBoxes()
        {
            bool depthEnabled = true;
            bool lenghtEnabled = true;
            //If shape is Circle or Sphere disable depth and lenght textboxes
            if (GetFigure() == Shapes.Circle || GetFigure() == Shapes.Sphere)
            {
                lblWidth.Text = "Radius";
                depthEnabled = false;
                lenghtEnabled = false;
            }
            else if (GetFigure() == Shapes.Cylinder || GetFigure() == Shapes.Ellipse) //if shape is ellipse disable lengh text box
            {
                lblWidth.Text = "Hor. Radius";
                lblDepth.Text = "Ver. Radius";
                if (GetFigure() == Shapes.Ellipse)
                {
                    lenghtEnabled = false;
                }
            }
            else if (GetFigure() == Shapes.Rectangle || GetFigure() == Shapes.Prism)
            {
                //disable lenght text box
                lblWidth.Text = "Width";
                lblDepth.Text = "Depth";
                if (GetFigure() == Shapes.Rectangle)
                {
                    lenghtEnabled = false;
                }
            }
            txtDepth.Enabled = depthEnabled;
            txtLenght.Enabled = lenghtEnabled;
        }

        /// <summary>
        /// put the default values to the grpOutPut
        /// </summary>
        private void DefaultValues()
        {

            lblBaseArea.Text = "0.00";
            lblBaseCircum.Text = "0.00";
            lblMantelArea.Text = "0.00";
            lblTotSurfaceArea.Text = "0.00";
            lblVolume.Text = "0.00";
        }

    }
}
