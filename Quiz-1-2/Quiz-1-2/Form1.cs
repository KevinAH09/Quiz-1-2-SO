using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Proceso proceso = new Proceso();
            InitializeComponent();

            string[] row0 = { "1", "29", "2,9,4,5,4,5",
                            "2,4,5,6,3,5,", " 6" };
            string[] row1 = {
                "2", "29","2,9,4,5,4,5",
                            "2,4,5,6,3,3", " 6" };
            string[] row2 = {
                "3", "29", "2,9,4,5,4,5",
                            "2,4,5,6,3,3", " 6" };
            string[] row3 = {
                "4", "29", "2,9,4,5,4,5",
                            "2,4,5,6,3,2", " 6" };
            string[] row4 = {
                "5", "29", "2,9,4,5,4,5",
                            "2,4,5,6,3,4", " 6" };
            string[] row5 ={
                "6", "29","2,9,4,5,4,5",
                            "2,4,5,6,3,2", " 6" };
            string[] row6 ={
                "7", "29","2,9,4,5,4,5",
                            "2,4,5,6,3,4", " 6" };

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);
            dataGridView1.Rows.Add(row5);
            dataGridView1.Rows.Add(row6);

          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
