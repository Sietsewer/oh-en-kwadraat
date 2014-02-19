using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int selected;
        public static int[] data;
        public int amount = 50;
        public Form1()

        {

            InitializeComponent();
            init();

        }

        private void init()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                list.Add(i+1);
            }

            data = new int[amount];
            Random r = new Random();
            for (int j = 0; j < data.Length - 1; j++)
            {
                int i = r.Next(0, list.Count - 1);
                data[j] = list[i];
                list.RemoveAt(i);
            }
            chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });
            this.txt_Elements.Text = this.amount + "";
            this.drp_Sort.SelectedIndex = this.selected;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case Elements.bogo_Sort:
                    bogoSnort(ref data);
                    break;
                case Elements.bubble_Sort:
                    SortArray(ref data);
                    break;
                case Elements.heap_Sort:
                    HeapSort.Sort(data, this.chart1);
                    break;
                case Elements.quick_Sort:
                    QuickSort.Sort(data, this.chart1);
                    break;
            }
            chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });
        }

        private Boolean isSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++) if (data[i] < data[i - 1]) return false;
            return true;
        }

        public void bogoSnort(ref int[] data)
        {
            while(!isSort(data)) 
            {
                Shuffle(ref data);
                chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });
                this.chart1.Update();
            }
        }

        public void Shuffle(ref int[] data){
            Random r = new Random();
            int a = r.Next(data.Length);
            int b = r.Next(data.Length);
            int c = data[a];
            data[a] = data[b];
            data[b] = c;
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            int i = this.amount;
            try
            {
                i = Convert.ToInt32(txt_Elements.Text);
            }
            catch (Exception ey)
            {
                Console.WriteLine(ey.ToString());
                txt_Elements.Clear();
            }
            finally
            {
                this.amount = i;
            }
            init();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = this.drp_Sort.SelectedIndex;
        }
    }
}
