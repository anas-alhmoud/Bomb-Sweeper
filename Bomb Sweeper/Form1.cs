using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomb_Sweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<bool> trueFalseList = new List<bool>{ false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isBomb()
        {
            Random random = new Random();
            int randomIndex = random.Next(trueFalseList.Count);

            bool result = trueFalseList[randomIndex];

            trueFalseList.RemoveAt(randomIndex);

            return result;

        }
        private void button_click(object sender, EventArgs e)
        {
            var button = (Button) sender;
            Console.WriteLine(button.Text);
            
            if (isBomb())
            {
                button.BackColor = Color.Blue;
            }
            else
            {
                button.BackColor = Color.Red;
                string text = "lost";
                MessageBox.Show(text);
            }
            
        }
    }
}
