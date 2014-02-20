using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Shuffle
    {
        public void shuffleAll(ref int[] data, int size)
        {
            data = new int[size];
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(i + 1);
            }
            for (int j = 0; j < data.Length - 1; j++)
            {
                int i = r.Next(0, list.Count - 1);
                data[j] = list[i];
                list.RemoveAt(i);
            }
        }

        public void Reverse(ref int[] data, int size)
        {
            data = new int[size];
            int j = 0;
            for (int i = size; i > 0; i--)
            {
                data[j] = i;
                j++;
            }
        }

        public void First(ref int[] data, int size)
        {
            Random r = new Random();
            data = new int[size];
            List<int> list = new List<int>();
            for (int i = size / 2; i < size; i++)
            {
                list.Add(i + 1);
            }

            for (int i = 0; i < size / 2; i++)
            {
                data[i] = i + 1;
            }

            for (int i = size / 2; i < size; i++)
            {
                int rand = r.Next(0, list.Count - 1);
                data[i] = list[rand];
                list.RemoveAt(rand);
            }
        }

        public void Last(ref int[] data, int size)
        {
            Random r = new Random();
            data = new int[size];
            List<int> list = new List<int>();
            for (int i = 0; i < size/2; i++)
            {
                list.Add(i + 1);
            }

            for (int i = 0; i < size/2; i++)
            {
                int rand = r.Next(0, list.Count - 1);
                data[i] = list[rand];
                list.RemoveAt(rand);
            }

            for (int i = size / 2; i < size; i++)
            {
                data[i] = i + 1;
            }
        }
    }
}
