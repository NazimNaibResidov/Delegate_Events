using Events_and_Delegate.Core;
using Events_and_Delegate.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_and_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Pepole pepole = new Pepole();
            pepole.Name = name.Text;
            pepole.Surname = surname.Text;
            pepole.Kecdi += Pepole_Kecdi;
            pepole.Qaldi += Pepole_Qaldi;
            pepole.Vize =Convert.ToDouble(vize.Text);
            pepole.Final = Convert.ToDouble(final.Text);
            listBox1.Items.Add(pepole);
            Tools.Clean(name);
            Tools.Clean(surname);
            Tools.Clean(vize);
            Tools.Clean(final);
           
           
        }

        private void Pepole_Qaldi(object sender, EnteryArgs e)
        {
            listBox3.Items.Remove(e.NameSurname);
            listBox2.Items.Remove(e.NameSurname);
            listBox3.Items.Add(e.NameSurname);
        }

        private void Pepole_Kecdi(object sender, EnteryArgs e)
        {
            listBox2.Items.Remove(e.NameSurname);
            listBox3.Items.Remove(e.NameSurname);
            listBox2.Items.Add(e.NameSurname);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Pepole pepole = (Pepole)listBox1.SelectedItem;
            name.Text = pepole.Name;
            surname.Text = pepole.Surname;
            vize.Text = pepole.Vize.ToString();
            final.Text = pepole.Final.ToString();
            name.Tag = pepole;
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Pepole pepole = (Pepole)name.Tag;
            pepole.Name = name.Text;
            pepole.Surname = surname.Text;
            pepole.Vize =Convert.ToDouble(vize.Text);
            pepole.Final = Convert.ToDouble(final.Text);
            listBox1.Items.Remove(pepole);
            listBox1.Items.Add(pepole);
        }
    }
}
