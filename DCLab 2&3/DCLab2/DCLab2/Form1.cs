using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new DCLab2.DataFunctions();
            string SQL_Slect = "SELECT * FROM Student; ";
            dataGridView1.DataSource = dataObj.getData(SQL_Slect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new DCLab2.DataFunctions();
            string SQL_Slect = "SELECT Student.[StudentRollNo], Student.Name, Student.Batch, Student.[FatherName], Student.Year, City.CityName FROM Student, City WHERE Student.CityID = City.CityID;";
            dataGridView1.DataSource = dataObj.getData(SQL_Slect);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new DCLab2.DataFunctions();
            string SQL_Insert = "INSERT INTO Student (StudentRollNo, Name, FatherName, Batch, Year, CityID) VALUES (" + int.Parse(textBox1.Text) + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + int.Parse(textBox4.Text) + "," + int.Parse(textBox5.Text) + "," + (comboBox1.SelectedIndex + 1) + "); ";
            dataGridView1.DataSource = dataObj.Manipulation(SQL_Insert);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new DCLab2.DataFunctions();
            string SQL_Update = "UPDATE Student SET Name= ' " + textBox2.Text + " ' , FatherName= ' " + textBox3.Text + " ' , Batch= " + int.Parse(textBox4.Text) + " , Year= " + int.Parse(textBox5.Text) + " , CityID= " + (comboBox1.SelectedIndex + 1) + " WHERE StudentRollNo= " + int.Parse(textBox1.Text) + "; ";
            dataGridView1.DataSource = dataObj.Manipulation(SQL_Update);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new DCLab2.DataFunctions();
            string SQL_Delete = "DELETE FROM Student WHERE StudentRollNo= " + int.Parse(textBox1.Text) + ";";
            dataGridView1.DataSource = dataObj.Manipulation(SQL_Delete);
        }
    }
}