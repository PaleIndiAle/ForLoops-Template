using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            q1Output.Text = "";
            q2Output.Text = "";
            q3Output.Text = "";

            int sum = 0;
            string stars = "*";

            q6Output.Text = stars;

            ///1.  Create a loop that displays all values inclusive between 1-5.

            for (int i = 1; i <= 5; i++)
            {
                q1Output.Text += i + ",";
            }


            ///2.  Create a loop that displays all values inclusive between 10-6.

            for (int j = 10; j >= 6; j--)
            {
                q2Output.Text += j + ",";
            }

            ///3.  Create a loop that displays even numbers inclusive between 2 and 10

            for (int h = 2; h <= 10; h++)
            {
                if(h % 2 == 0)
                {
                    q3Output.Text += h + ",";
                }
            }

            ///4.  Create a loop that displays the sum of all numbers inclusive 
            ///between 1 and 10. The answers should be 55.

            for (int g = 1; g <= 10; g++)
            {
                sum += g;
                q4Output.Text = $"{sum}";
            }

            ///5. Create a loop that displays all leap years inclusive between 
            ///1990 and 2010. The output should be: 1992 1996 2000 2004 2008

            for (int w = 1992; w <= 2008; w++)
            {
                if(w % 4 == 0)
                {
                    q5Output.Text += w + ",";
                }
            }

            ///6. Print the following patterns using a loop:
            ///
            /// *
            /// **
            /// ***
            /// ****
            /// *****
            /// 
            /// Hint: Start off with a string that has 1 "*" in it, then 
            /// in the loop you will add another "*" using +=

            for (int z = 1; z <= 4; z++)
            {
                stars += "*";
                q6Output.Text += "\n" + stars;
            }
        }
    }
}
