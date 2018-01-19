using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTemplate.Dialogs;
using System.Threading;

namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        int scene = 0;
        int day = 2;
        List<string> dialog = new List<string>();
        List<string> dialog2 = new List<string>();
        List<string> dialog2a = new List<string>();
        List<string> dialog2b = new List<string>();
        List<string> dialog2c = new List<string>();
        List<string> dialog2d = new List<string>();
        List<string> dialog2e = new List<string>();
        List<string> dialog2f = new List<string>();
        List<string> dialog3 = new List<string>();
        bool nextEnabled = true;
        bool decisionEnabled = false;
        string charName;
        string day2;

        public GameScreen()
        {
            InitializeComponent();
            //Day 1 List
            dialog.Add("Alarm: Ring! Ring!");
            dialog.Add(charName + ": Ughhhh...");
            dialog.Add("Alarm: Ring! Ring!");
            dialog.Add(charName + ": Alright, alright! I'm up.");
            dialog.Add("(Why did I set my alarm so early…)"); //5
            dialog.Add("(Oh shoot! It's the first day of school!)");
            dialog.Add(""); //BG Change
            dialog.Add("(As I walk to school, I suddenly hear a familiar voice behind me)");
            dialog.Add("???: Hey! " + charName + "! Wait up!");
            dialog.Add(charName+ ": Oh, hey Hideki."); //10
            dialog.Add("(Hideki had been my only friend since I moved to this town a couple of months ago.)");
            dialog.Add("(The two of us resume our walks to school.)");
            dialog.Add("Hideki: So this is your first day, huh?");
            dialog.Add(charName + ": Yep. I’m kind of nervous, to be honest.");
            dialog.Add("Hideki: You’ll be fine, man. They’ve got a wicked history club we could join!"); //15
            dialog.Add(charName + ": That does sound like fun...");
            dialog.Add("Hideki: Trust me, you'll have a great time here.");
            dialog.Add(""); //BG Change
            dialog.Add("(We talk some more before arriving at school)");
            dialog.Add("Hideki: History club meets at lunch! I’ll see you there!"); //20
            dialog.Add(""); //BG Change
            dialog.Add("(Well that was quite the first day)");
            dialog.Add("(It kind of sucks that I already have an essay to write though)");
            dialog.Add("(For History Club, no less)");
            dialog.Add("(I thought clubs were supposed to be fun)"); //25
            dialog.Add("(As I think about what to write, I hear some beautiful music coming from down the hall)");
            dialog.Add("(Some music could help me concentrate on my writing. I’ll go check it out)");
            dialog.Add("");//BG Change
            dialog.Add("(I follow the music to its source " +
                "and discover a classroom filled with strangely-dressed girls.)");
            dialog.Add(charName + ": Hello?"); //30
            dialog.Add("United Kingdom: Hello there!");
            dialog.Add("Russia: Oh...");
            dialog.Add("Russia: Hi!");
            dialog.Add("France: Salut!");
            dialog.Add(charName + ": "); //35
            dialog.Add("");
            dialog.Add("");
            dialog.Add("");
            //You know that it's spelled "dialogue," right?

            //Day 2 List
            dialog2.Add("[DecisionTest]");
            dialog2.Add("Didn't work");
            dialog2a.Add("Germany");
            dialog2b.Add("Austria-Hungary");
            dialog2c.Add("Ottoman Empire");

            //Day 3 List
            dialog3.Add("HI");
        }
        


        
       
        

        private void GameScreen_Click(object sender, EventArgs e)
        {
            scene++;           
        }

        public void type(string text)
        {
            textLabel.Text = " ";

            for (int i = 0; i < text.Length; i++)
            {
                textLabel.Text += text.ElementAt(i);
                textLabel.Refresh();
                Thread.Sleep(10);
            }
        }

        //Choices
        private void GameScreen_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (decisionEnabled == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        day2 = "GER";
                        scene = 0;
                        decisionEnabled = false; ;
                        break;
                    case Keys.N:
                        day2 = "AUS";
                        scene = 0;
                        decisionEnabled = false;
                        break;
                    case Keys.M:
                        day2 = "OTT";
                        scene = 0;
                        decisionEnabled = false; ;
                        break;
                }

  
            }
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            // player 1 button presses 
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();

                    break;


                case Keys.Space:
                    //charName = nameBox.Text;

                    

                    switch (day )
                    {
                        case 1: //Day 1
                            if (nextEnabled == true)
                            {
                                try
                                {
                                    nextEnabled = false;                                   
                                    type(dialog[scene]);
                                    scene++;
                                    
                                }
                                catch
                                {
                                    day++;
                                    scene = 0;
                                }
                                //Scene Changes
                                if (scene == 7)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.street;
                                }
                                if (scene == 18)
                                {
                                    this.BackgroundImage = null;
                                }
                                if (scene == 21)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.hall;
                                }
                                if (scene == 28)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.Class;
                                }
                            }
                            nextEnabled = true;
                            break;
                            
                        case 2: //Day 2
                            if (day2 == "GER")
                            {
                                
                                type(dialog2a[scene]);
                                scene++;
                            }
                            else if (day2 == "AUS")
                            {                               
                                type(dialog2b[scene]);
                                scene++;
                            }
                            else if (day2 == "OTT")
                            {
                                type(dialog2c[scene]);
                                scene++;
                            }
                            else
                            {
                                try
                                {
                                    type(dialog2[scene]);
                                    scene++;
                                }
                                catch
                                {
                                    day++;
                                    scene = 0;
                                }
                            }
                            if(scene == 1)
                            {
                                decisionEnabled = true;
                            }
                            if (scene == 2)
                            {

                            }
                            break;

                        case 3:
                            try
                            {
                                type(dialog3[scene]);
                                scene++;
                            }
                            catch
                            {
                                day++;
                                scene = 0;
                            }
                            break;
                    }
                  

                    


                    //dialog.Add("HI");
                    //textLabel.Text = " ";
                    //type(dialog[scene]);
                    //scene++;
                    break;


                case Keys.Right:

                    break;


            }
            // private void PauseGame()
            //    {

            //  }
        }
    }
}