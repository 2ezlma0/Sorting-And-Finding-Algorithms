using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithm___Serial_Search
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> aList = new List<int> { 3, 31, 12, 45, 55, 12, 44, 90, 12, 17, 73, 41, 9, 50, 77 };   
            int itemSought = Convert.ToInt32(nudItem.Value);

            int index = LinearSearch(aList, itemSought);

            if (index != -1)
            {
                MessageBox.Show("Item was found at position: " + index);
            }
            else
            {
                MessageBox.Show("Item was not found");
            }
        }

        private int LinearSearch(List<int> aList, int itemSought)
        {
            int index = -1;
            int i = 0;
            bool found = false;

            while (i < aList.Count && found == false)
            {
                if(aList[i] == itemSought)
                {
                    index = i;
                    found = true;
                }
                else
                {
                    i = i + 1;
                }
            }
            return index;
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            List<int> aList = new List<int> { 3, 31, 12, 45, 55, 12, 44, 90, 12, 17, 73, 41, 9, 50, 77 };

            int itemSought = Convert.ToInt32(nudItem.Value);
            
            int index = BinarySearch(aList, itemSought, 0, aList.Count - 1);
            MessageBox.Show("Your item index number is: " + index);
        }

        private int BinarySearch(List<int> aList, int itemSought, int first, int last)
        {
            if(last<first)
            {
                return -1;
            }
            else
            {
                int midpoint = (first+last) / 2;
                if (aList[midpoint] > itemSought)
                {
                    return BinarySearch(aList, itemSought, first, midpoint - 1);
                }
                else
                {
                    if(aList[midpoint] < itemSought)
                    {
                        return BinarySearch(aList, itemSought, midpoint + 1, last);
                    }
                    else
                    {
                        return midpoint;
                    }
                }
            }
        }

        private void bubbleButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[] { 3, 31, 12, 45, 55, 12, 44, 90, 12, 17, 73, 41, 9, 50, 77 };
            int numItems = numbers.Length;

            for(int i=0; i<= numItems -2; i++)
            {
                for(int j=0; j <= numItems -i -2; j++)
                {
                    if (numbers[j] > numbers[j + i])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + i];
                        numbers[j + i] = temp;
                    }
                }
                //Print out the sorted list
                string val = "";
                foreach (int num in numbers)
                {
                    val = val + num + ", ";
                }
                MessageBox.Show(val, "Sorted list");
            }
        }

        private void bubble2Button_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[] { 3, 31, 12, 45, 55, 12, 44, 90, 12, 17, 73, 41, 9, 50, 77 };
            int numItems = numbers.Length;
            bool flag = true;
            int i = 0;
            while( i < numItems-1 && flag == true)
            {
                flag = false;
                for (int j = 0; j <= numItems - i - 2; j++)
                {
                    if (numbers[j] > numbers[j + i])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + i];
                        numbers[j + i] = temp;
                        flag = true;
                    }
                }
                i = i + 1;
            }
            //Print out the sorted list
            string val = "";
            foreach (int num in numbers)
            {
                val = val + num + ", ";
            }
            MessageBox.Show(val, "Sorted list");
        }

        private void insertionButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { 3, 31, 12, 45, 55, 12, 44, 90, 12, 17, 73, 41, 9, 50, 77 };
            insertionsort(ref numbers);
            //Print the sorted list
            string val = "";
            foreach (int num in numbers)
            {
                val = val + num + ", ";
            }
            MessageBox.Show(val, "Sorted list!");
        }

        private void insertionsort(ref List<int> numbers)
        {
            int n = numbers.Count;
            int x = 0;
            for (int index = 1; index <= n-1; index++)
            {
                int currentValue = numbers[index];
                int position = index;
                while(position>0 && numbers[position-1] > currentValue)
                {
                    numbers[position] = numbers[position - 1];
                    position = position - 1;
                    string b = "";
                    if (x == 0)
                    {
                        foreach (int num in numbers)
                        {
                            b = b + num + ", ";
                        }
                        MessageBox.Show(b, "Sorting list");
                        x++;
                    }
                    else
                    {
                        if (x == 1)
                        {
                            string a = ".";
                            foreach (int num in numbers)
                            {
                                b = b + num + ", ";
                            }
                            MessageBox.Show(b, "Sorting list" + a);
                            x++;
                        }
                        else
                        {
                            if (x == 2)
                            {
                                string a = "..";
                                foreach (int num in numbers)
                                {
                                    b = b + num + ", ";
                                }
                                MessageBox.Show(b, "Sorting list" + a);
                                x++;
                            }
                            else
                            {
                                if (x == 3)
                                {
                                    string a = "...";
                                    foreach (int num in numbers)
                                    {
                                        b = b + num + ", ";
                                    }
                                    MessageBox.Show(b, "Sorting list" + a);
                                    x = 0;
                                }
                                else
                                {

                                }
                            }
                        }
                    }

                }
                numbers[position] = currentValue;
            }
        }
    }
}
