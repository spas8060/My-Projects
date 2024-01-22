using System.Drawing;
using System.Windows.Forms;

namespace GraficRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics myGraph;
        Point startPoint, endPoint;
        Pen blackPen = new Pen(Color.Black, 3);
        int width = 0;
        int height = 0;
        string currentOper = "";
       
        string printText = "";
        char KeyChar;
        SolidBrush brush = new SolidBrush(Color.White);
        bool click ;
        Font textFont = new Font("Arial", 16);

        private void button1_Click(object sender, EventArgs e)
        {
            currentOper = "Elipse";
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            currentOper = "Rectangle";
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            currentOper = "Line";
        }

        private void CustomBtn_Click(object sender, EventArgs e)
        {
            currentOper = "Custom";
        }
        private void Freehand_Click(object sender, EventArgs e)
        {
            currentOper = "Freehand Tool";
        }
        private void frmPicture_MouseMove(object sender, MouseEventArgs e)
        {
            Label3.Text = e.X + " x " + e.Y;
            if (click)
            {
                if (currentOper == "Freehand Tool")
                {

                    endPoint = e.Location;
                    myGraph = frmPicture.CreateGraphics();
                    myGraph.DrawLine(blackPen, startPoint, endPoint);
                    startPoint = endPoint;
                }


                else if (currentOper == "Eraser")
                {
                    endPoint = e.Location;
                    myGraph = frmPicture.CreateGraphics();
                    Pen eraserPen = new Pen(Color.White, 10);
                    myGraph.DrawLine(eraserPen, startPoint, endPoint);
                    startPoint = endPoint;

                }
            }

        }



        private void frmPicture_MouseDown(object sender, MouseEventArgs e)
        {
            Tool1.Text = e.X + " x " + e.Y;
            startPoint.X = e.X;
            startPoint.Y = e.Y;

            printText = "";
            click = true;
        }

        private void frmPicture_MouseUp(object sender, MouseEventArgs e)
        {
            Label2.Text = e.X + " x " + e.Y;
            endPoint.X = e.X;
            endPoint.Y = e.Y;

            click = false;
            width = endPoint.X - startPoint.X;
            height = endPoint.Y - startPoint.Y;

            myGraph = frmPicture.CreateGraphics();

            if (currentOper == "Elipse")
            {
                myGraph.FillEllipse(brush, startPoint.X, startPoint.Y, width, height);
                myGraph.DrawEllipse(blackPen, startPoint.X, startPoint.Y, width, height);
            }
            else if (currentOper == "Rectangle")
            {

                myGraph.FillRectangle(brush, startPoint.X, startPoint.Y, width, height);
                myGraph.DrawRectangle(blackPen, startPoint.X, startPoint.Y, width, height);
            }
            else if (currentOper == "Line")
            {

                myGraph.DrawLine(blackPen, startPoint, endPoint);
            }
            else if (currentOper == "Custom")
            {

                int headHeight = (int)Math.Round(1.0 / 4.0 * height);
                int headWidth = (int)Math.Round(1.0 / 3.0 * width);

                //head
                myGraph.FillEllipse(brush, startPoint.X +
                    (int)Math.Round((1.0 / 3.0) * width),
                    startPoint.Y,
                    headWidth, headHeight);
                myGraph.DrawEllipse(blackPen, startPoint.X + (int)Math.Round((1.0 / 3.0) * width),
                    startPoint.Y, headWidth, headHeight);


                //body
                myGraph.DrawLine(blackPen,
                    startPoint.X + (int)Math.Round((1.0 / 2.0) * width),
                    startPoint.Y + (int)Math.Round((1.0 / 4.0) * height),
                    startPoint.X + (int)Math.Round((1.0 / 2.0) * width),
                    startPoint.Y + (int)Math.Round((5.0 / 8.0) * height));

                // legs

                myGraph.DrawLine(blackPen,
                    startPoint.X + (int)Math.Round((1.0 / 2.0) * width),
                    startPoint.Y + (int)Math.Round((5.0 / 8.0) * height),
                    startPoint.X + (int)Math.Round((1.0 / 5.0) * width),
                    endPoint.Y);
                myGraph.DrawLine(blackPen,
                   startPoint.X + (int)Math.Round((1.0 / 2.0) * width),
                   startPoint.Y + (int)Math.Round((5.0 / 8.0) * height),
                   startPoint.X + (int)Math.Round((4.0 / 5.0) * width),
                   endPoint.Y);


                //arms
                myGraph.DrawLine(blackPen,
                   startPoint.X,
                   startPoint.Y + (int)Math.Round((1.0 / 3.0) * height),
                   endPoint.X,
                   startPoint.Y + (int)Math.Round((1.0 / 3.0) * height));

            }


        }




        private void panelConturColor_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                blackPen.Color = colorDialog2.Color;
                panelConturColor.BackColor = colorDialog2.Color;

            }
        }

        private void panelBackColor_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                brush.Color = colorDialog2.Color;
                panelBackColor.BackColor = colorDialog2.Color;
            }
        }



        private void TextFontbtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textFont = fontDialog.Font;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            blackPen.Width = trackBar1.Value;

        }

        private void Textbn_KeyPress(object sender, KeyPressEventArgs e)
        {

            Point startP = new Point(startPoint.X, startPoint.Y);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            printText += e.KeyChar;
            myGraph = frmPicture.CreateGraphics();
            myGraph.DrawString(printText, textFont, drawBrush, startP);

        }

        private void Eraserbtn_Click(object sender, EventArgs e)
        {
            currentOper = "Eraser";
        }
    }
}