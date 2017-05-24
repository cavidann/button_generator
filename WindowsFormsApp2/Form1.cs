using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            int col = 3;
            int enter = 100;
            int j = 0;
            int copy = 0;
            List<Button> buttons = new List<Button>();
            for (int i = 1; i < 100; i++)
            {
                Button newButton = new Button();
                newButton.Name = "a" + i;
                buttons.Add(newButton);
                this.Controls.Add(newButton);
                newButton.Location = new System.Drawing.Point(j, enter);
                if (i%col == 0)
                {                 
                    j = 0;
                    enter += 100;
                }
                else
                {
                    j += 100;
                }
               
            }
        }
    }
}
