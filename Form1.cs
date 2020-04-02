using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsPractice3_GUI
{
    public partial class CsLab3 : Form
    {
        Rectangles_GUI arrayOfRectangles;
        Parallelepipeds_GUI arrayOfParallelepipeds;

        public CsLab3()
        {
            InitializeComponent();
        }

        //Rectangles

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Byte.Parse(SizeBox.Text) == 0)
                {
                    MessageBox.Show("Size of array must be positive and less than 256");
                }
                else
                {
                    arrayOfRectangles = new Rectangles_GUI(Byte.Parse(SizeBox.Text));

                    Side1ValueBox.Enabled = true;
                    Side2ValueBox.Enabled = true;
                    SetValueButton.Enabled = true;
                    GenerateButton.Enabled = true;

                    CounterBox.Text = arrayOfRectangles.Counter();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SaveValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(Side1ValueBox.Text) <= 0 || Double.Parse(Side2ValueBox.Text) <= 0)
                    MessageBox.Show("Values of sides must be positive");
                else if (arrayOfRectangles.SetElement(Double.Parse(Side1ValueBox.Text), Double.Parse(Side2ValueBox.Text)))
                {
                    ShowValuesButton.Enabled = true;
                    CounterBox.Text = arrayOfRectangles.Counter();
                }
                else MessageBox.Show("Out of array length");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (arrayOfRectangles.GenerateElement())
            {
                CounterBox.Text = arrayOfRectangles.Counter();

                if (!ShowValuesButton.Enabled)
                    ShowValuesButton.Enabled = true;
            }
            else MessageBox.Show("Out of array length");
        }

        private void DispInfo_Click(object sender, EventArgs e)
        {
            RectanglesInfTextBox.Text = arrayOfRectangles.ToString();
        }

        //Parallelepipeds 

        private void CreateButtonPar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Byte.Parse(SizeBoxPar.Text) == 0)
                    MessageBox.Show("Size of array must be positive and less than 256");
                else
                {
                    arrayOfParallelepipeds = new Parallelepipeds_GUI(Byte.Parse(SizeBoxPar.Text));

                    Side1ValueBoxPar.Enabled = true;
                    Side2ValueBoxPar.Enabled = true;
                    HeightBox.Enabled = true;
                    SetValuesPar.Enabled = true;
                    GenerateValuesPar.Enabled = true;

                    ParCounterBox.Text = arrayOfParallelepipeds.Counter();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SetValuesPar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(Side1ValueBoxPar.Text) <= 0 ||
                    Double.Parse(Side2ValueBoxPar.Text) <= 0 ||
                    Double.Parse(HeightBox.Text) <= 0)
                    MessageBox.Show("Values of sides must be positive");
                else if (arrayOfParallelepipeds.SetElement(Double.Parse(Side1ValueBoxPar.Text),
                         Double.Parse(Side2ValueBoxPar.Text), Double.Parse(HeightBox.Text))) 
                {
                    ShowValuesPar.Enabled = true;
                    ParCounterBox.Text = arrayOfParallelepipeds.Counter();
                }
                else MessageBox.Show("Out of array length");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void GenerateValuesPar_Click(object sender, EventArgs e)
        {
            if (arrayOfParallelepipeds.GenerateElement())
            { 
                ShowValuesPar.Enabled = true;
                ParCounterBox.Text = arrayOfParallelepipeds.Counter();
            }
            else MessageBox.Show("Out of array length");
        }

        private void ShowValuesPar_Click(object sender, EventArgs e)
        {
            ParInfTextBox.Text = arrayOfParallelepipeds.ToString();
        }
    }
}