using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameTemplate.Screens
{
    public partial class UserControl1 : UserControl
    {
     

        public UserControl1()
        {
            InitializeComponent();
        }

        int scene = 0;
        Boolean nextEnabled = true;
        Boolean typeSkip = false;

        private void Form1_Click(object sender, EventArgs e)
        {
            typeSkip = true;

            if (nextEnabled == true)
            {
                scene++;
                nextEnabled = false;




                switch (scene)
                {
                    case 1:
                        // get name 
                        
                        

                        break;
                    case 2:
                        textLabel.Text = "Austria-Hungary:";
                        type(" Kyaaaaaaaaaa!");
                        break;
                    case 3:
                        textLabel.Text = "Austria-Hungary:";
                        type(" Help me Senpai!");
                        break;
                    case 4:
                        textLabel.Text = "";
                        type("(Broke)");
                        break;
                    case 5:
                        textLabel.Text = "";
                        type(" testestestestestestestestestestestestestestestestestestestest");
                        break;
                    case 6:
                        textLabel.Text = "";
                        type(" aaaaaaaaaaaaaaaaaaaaaaaaaaa");
                        break;


                }
            }
        }

        public void type(string text)
        {

            typeSkip = false;
            if (typeSkip == false)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    textLabel.Text += text.ElementAt(i);
                    textLabel.Refresh();
                    Thread.Sleep(100);


                }
            }
            else if (typeSkip == true)
            {
                textLabel.Text = text;
                typeSkip = true;
            }
            nextEnabled = true;
        }


    }


}