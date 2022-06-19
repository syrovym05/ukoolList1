using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukolList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Vypis(List<char> seznam, ListBox listBox)
        {
            foreach(char c in seznam)
            {
                listBox.Items.Add(c);
            }
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<char> seznam = new List<char>();
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {                 
                    seznam.Add(char.Parse(textBox1.Lines[i]));
                }
                seznam.RemoveAll(x => (x >= 'a' && x <= 'z') || (x >= '0' && x <= '9'));
                Vypis(seznam, listBox1);
            }
            catch(Exception)
            {
                MessageBox.Show("Zadal jsi chybně znaky");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ve víceřádkové komponentě TextBox jsou zapsány znaky, v každém řádku jeden " +
                "znak.Vytvořte seznam znaků z TextBox pomocí třídy List.Znaky z List vypište do " +
                "komponenty ListBox. Ze seznamu List vypusťte všechna malá písmena anglické " +
                "abecedy a všechny číslice.Opravený seznam zobrazte.","Zadání",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }
    }
}
