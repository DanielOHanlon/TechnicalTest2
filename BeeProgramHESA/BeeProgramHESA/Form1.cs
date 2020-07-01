using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeProgramHESA
{
    public partial class Form1 : Form
    {

        public Random random;

        public Form1()
        {
            InitializeComponent();

            Bee Worker = new Bee("Worker");            
            Bee Queen = new Bee("Queen");           
            Bee Drone = new Bee("Drone");

            listBox1.Items.Add(Worker);
            listBox1.Items.Add(Queen);
            listBox1.Items.Add(Drone);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int amount = 15;

            Bee bee = (Bee)listBox1.SelectedItem;

            if(bee != null)
            {
                Bee damagedBee = bee.damage(bee, amount);

                if(damagedBee.health == 0)
                {
                    listBox2.Items.Add(damagedBee.name + " is dead");
                }
                else
                {
                    String currentBeeHealth = damagedBee.name + damagedBee.health.ToString();
                    listBox2.Items.Add(currentBeeHealth);
                }    
            }
        } 
    }
}
