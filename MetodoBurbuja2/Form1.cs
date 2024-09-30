using MetodoBurbuja2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoBurbuja2
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(tbNumber.Text);
                numbers[i++] = number;
                ShowNiggas();
                Clear();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        public void ShowNiggas() 
        {
            if (lbNumbers.Items.Count > 0) 
            {
                lbNumbers.Items.Clear();
            }

            foreach (int number in numbers) 
            {
                lbNumbers.Items.Add(number);
            }
        }

        private void Clear() 
        {
            tbNumber.Clear();
            tbNumber.Focus();
        }
        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Bubble bubble = new Bubble();
            bubble.Sort(numbers);
            ShowNiggas();
        }
    }
}
