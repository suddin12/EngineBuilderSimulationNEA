using System.Windows.Forms;

namespace Graph_Sketching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point[] pts = new Point[1000];

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            pts[count++] = new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);

            for (int i = 0; i < count; i++)
            {
                if (i != 0)
                {
                    this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 4), pts[i - 1], pts[i]);
                }

                else
                {
                    this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 4), pts[i], pts[i]);
                }
            }
        }
    }
}
