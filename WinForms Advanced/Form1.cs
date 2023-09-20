using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Test.Entities;

namespace Test
{
    public partial class Form1 : Form
    {
        //string connectionString = @"Data Source=localhost\pops1;Initial Catalog=Ordering;User ID=test;Password=123456";
        OrderingContext _dbContext = new OrderingContext();
        public Form1()
        {
            // OrderingContext _dbContext = new OrderingContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listCateogries.DataSource = _dbContext.Categories.Select(c => new { c.Id, c.Name }).ToList();
            listView1.DataSource = _dbContext.Orders.Select(o => new {o.Id,o.TotalPrice,o.TaxPrice}).ToList();
        }
        private void listCateogries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = listCateogries.Rows[e.RowIndex].Cells[0].Value;
            if (id != null)
            {
                listItems.DataSource = _dbContext.Items.Where(w => (int)w.CategoryId == (int)id).Select(s => new { s.Id, s.Name }).ToList();
            }
        }
        private void ButtonSaveCategory_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Name = textBox1.Text;
            _dbContext.Add(categories);
            _dbContext.SaveChanges();

            listCateogries.DataSource = _dbContext.Categories.Select(c => new { c.Id, c.Name }).ToList();
        }
        private void ButtonSaveItem_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Name = textBox2.Text;
            items.Price = decimal.Parse(textBox3.Text);
            _dbContext.Add(items);
            _dbContext.SaveChanges();
        }


        private void listItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = listItems.Rows[e.RowIndex].Cells[0].Value;
            if (id != null)
            {
                dataGridView1.DataSource = _dbContext.Items.Where(h => (int)h.Id == (int)id).Select(q => new { q.Name, q.Price }).ToList();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var cell = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                double value = System.Convert.ToDouble(cell);
                var tax = value * 5 / 100;
                var total = value - tax;
                ValueTax.Text = tax.ToString();
                ValueTotal.Text = total.ToString();
            }
            else if (radioButton2.Checked)
            {
                ValueTax.Text = "0.00";
                ValueTotal.Text = (string)dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            Orders orders= new Orders();
            orders.TaxPrice=decimal.Parse(ValueTax.Text);
            orders.TotalPrice=decimal.Parse(ValueTotal.Text);
            _dbContext.Add(orders);
            _dbContext.SaveChanges();
            listView1.DataSource = _dbContext.Orders.Select(o => new { o.Id, o.TotalPrice, o.TaxPrice }).ToList();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            User user=new User();
            user.UserName=tbUsername.Text; 
            user.Password=tbPassword.Text;
            user.Email=tbEmail.Text;
            user.ImageName=tbImage.Text;
            user.Notes=tbTextNotes.Text;
            _dbContext.Add(user);
            _dbContext.SaveChanges();
            listViewNotes.DataSource = _dbContext.User.Select(s => new { s.Notes, s.UserName }).ToList();
        }
    }
}
