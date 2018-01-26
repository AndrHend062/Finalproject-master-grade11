﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameTemplate.Screens
{
    public partial class OptionScreen : UserControl
    {
        int var1 = 0;
        public OptionScreen()
        {
            InitializeComponent();

            ScreenControl.setComponentValues(this);
            defaultOverride();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }

        /// <summary>
        /// Change any control default values here
        /// </summary>
        public void defaultOverride()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var1= var1 + 1;
            button1.Text = var1 + " ";

        }
    }
}
