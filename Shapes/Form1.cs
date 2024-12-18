using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Shapes
{
    public partial class Form1 : Form
    {
        private IShape currentShape;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Draw_Click(object sender, EventArgs e)
        {
            try
            {
                // Determine the selected shape
                string selectedShape = CB_ShapeChoice.SelectedItem.ToString();

                if (selectedShape == "Circle")
                {
                    currentShape = new Circle(double.Parse(Txt_Dim1.Text));
                }
                else if (selectedShape == "Rectangle")
                {
                    currentShape = new Rectangle(double.Parse(Txt_Dim1.Text), double.Parse(Txt_Dim2.Text));
                }
                else if (selectedShape == "Triangle")
                {
                    currentShape = new Triangle(double.Parse(Txt_Dim1.Text), double.Parse(Txt_Dim2.Text));
                }
                else
                {
                    throw new NotSupportedException("Shape not supported.");
                }

                // Redraw the panel with the new shape
                PL_Canvas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PL_Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (currentShape != null)
            {
                // Draw the current shape at the center of the canvas
                int centerX = PL_Canvas.Width / 2;
                int centerY = PL_Canvas.Height / 2;

                currentShape.Draw(e.Graphics, new Point(centerX, centerY));
            }
        }
    }
}
