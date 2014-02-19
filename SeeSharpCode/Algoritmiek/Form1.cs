using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static int[] data;
        public Form1()
        {

            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            data = new int[100];
            Random r = new Random();
            for (int j = 0; j < data.Length - 1; j++)
            {
                int i = r.Next(0, list.Count - 1);
                data[j] = list[i];
                list.RemoveAt(i);
            }

            InitializeComponent();
            chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            SortArray(ref data);
            chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });
        }

        public void SortArray(ref int[] array)
        {//THANKS INTERWEBS
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                    chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });
                    this.chart1.Update();
                }
            }
        }
    }
}
