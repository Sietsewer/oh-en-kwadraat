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
        public int selectedSort = 0;
        public int selectedShuffle = 0;
        public static int[] data;
        public int amount = 50;
        public Form1()

        {

            InitializeComponent();
            init();

        }
        Shuffle s = new Shuffle();
        private void init()
        {
            this.drp_Shuffle.SelectedIndex = this.selectedShuffle;
            switch (this.selectedShuffle)
            {
                case Constants.random:
                    s.shuffleAll(ref data, amount);
                    break;
                case Constants.reverse:
                    s.Reverse(ref data, amount);
                    break;
                case Constants.first:
                    s.First(ref data, amount);
                    break;
                case Constants.last:
                    s.Last(ref data, amount);
                    break;
            }
            
            chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });
            this.txt_Elements.Text = this.amount + "";
            this.drp_Sort.SelectedIndex = this.selectedSort;
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
                        chart1.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { data });
                        this.chart1.Update();
                    }
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (selectedSort)
            {
                case Constants.bogo_Sort:
                    bogoSnort(ref data);
                    break;
                case Constants.bubble_Sort:
                    SortArray(ref data);
                    break;
                case Constants.heap_Sort:
                    HeapSort.Sort(data, this.chart1);
                    break;
                case Constants.quick_Sort:
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
            selectedSort = this.drp_Sort.SelectedIndex;
        }

        private void drp_Shuffle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedShuffle = this.drp_Shuffle.SelectedIndex;
        }
    }
}
