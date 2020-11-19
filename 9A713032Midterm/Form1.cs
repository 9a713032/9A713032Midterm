using _9A713032Midterm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9A713032Midterm
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources.pizza);
            list.Add(Resources.dumpling);
            list.Add(Resources.fastfood);
            list.Add(Resources.ramen);
            list.Add(Resources.roastduck);
            list.Add(Resources.sushi);
            list.Add(Resources.steak);
            list.Add(Resources.mud);
            list.Add(Resources.shit);
            list.Add(Resources.ass);
        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int a = ran.Next(1, 10);
            int index = a;
            picResult.Image = list[index];
        }
    }
}
