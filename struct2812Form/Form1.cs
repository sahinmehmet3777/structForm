using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struct2812Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (User u = new User(nametxt.Text, locationtxt.Text, int.Parse(agetxt.Text)))
            {
                listBox1.Items.Add(u.name + "-" + u.location + "-" + u.age);
            }
            User u1;
            u1.name = nametxt.Text;
            u1.location = locationtxt.Text;
            u1.age = int.Parse(agetxt.Text);
            listBox1.Items.Add("-----------------------------------------");
            listBox1.Items.Add(u1.name + "-" + u1.location + "-" + u1.age);
        }
    }
    struct User: IDisposable
    {
        public string name;
        public string location;
        public int age;
        public User(string n, string a,  int b)
        {
            name = n;
            location = a;
            age = b;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

}
