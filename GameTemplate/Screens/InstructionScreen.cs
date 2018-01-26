using System;
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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
            label1.Text = "Space - Next \nEscape -Back to menu\n B, N, M - Decisions(when prompted)";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }

       
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGray;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.AliceBlue;
        }
    }
}
