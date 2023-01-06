using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsd
{
    public partial class bsd : Form
    {
        public Form form = new Form();
        public bsd()
        {
            InitializeComponent();
            this.Size=new Size(0,0);
            this.ControlBox = false;

            // Set the start position to manual
            form.StartPosition = FormStartPosition.Manual;

// Get the screen dimensions
int screenWidth = Screen.PrimaryScreen.Bounds.Width;
int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = 0;

            // Set the form location to the top right corner of the screen
            form.Location = new Point(screenWidth -120, 0);
            Button button1 = new Button();

            // Set the button's text
            button1.Text = "בס\"ד";
            button1.FlatStyle = FlatStyle.Flat;

            // Set the button's font
            button1.Font = new Font("Arial", 28);

            // Set the button's size
            button1.Size = new Size(120, 120);
            form.Size = new Size(80, 120);
            form.ControlBox = false;
            // Add the button to the form
            form.Controls.Add(button1);
            form.TopMost = true;

            // Show the form
            button1.Click += button1_Click;
            
            // Define the event handler method

            form.Show();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form.Hide();
            this.Close();
        }

    }
}
