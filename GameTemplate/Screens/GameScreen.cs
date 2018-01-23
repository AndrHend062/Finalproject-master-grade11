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
using System.IO;

namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        int scene = 0;
        int day = 2;
        int textSpeed = 20;
        List<string> dialog = new List<string>();
        List<string> dialog2 = new List<string>();
        List<string> dialog2EN = new List<string>();
        List<string> dialog2ENGBR = new List<string>();
        List<string> dialog2ENFRA = new List<string>();
        List<string> dialog2ENRUS = new List<string>();
        List<string> dialog2CP = new List<string>();
        List<string> dialog2CPGER = new List<string>();
        List<string> dialog2CPAUS = new List<string>();
        List<string> dialog2CPOTT = new List<string>();
        List<string> dialog3 = new List<string>();
        bool nextEnabled = true;
        bool decision2Enabled = false;
        bool decision3Enabled = false;
        string charName;
        string charChoice;
        string clubChoice;

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
            dialog.Add(charName + ": I heard you guys playing music and decided to check it out so..."); //35
            dialog.Add("France: We’re the Entente Music Club! You can stay here and watch us practice if you want.");
            dialog.Add("United Kingdom: Of course, it would be rude to invite you " +
                "in without offering you some tea first.");
            dialog.Add("United Kingdom: What do you prefer? Darjeeling? Orange Pekoe?");
            dialog.Add(charName + ": Ahhhh, I don’t really drink tea."); 
            dialog.Add("United Kingdom: I’ll just pick for you then. Oolong tea, coming right up!"); //40
            dialog.Add("(Man, these people sure are coming on quite strong.)");
            dialog.Add("(At least that one in the furry hat doesn’t seem so bad.)");
            dialog.Add("(Maybe I’ll sit next to her.)");
            dialog.Add(charName + ": Hi there!"); 
            dialog.Add("Russia: Uhh…"); //45
            dialog.Add("Russia: I…");
            dialog.Add("Russia: Uuuu…");
            dialog.Add("(She buries her face in her hands)");
            dialog.Add(charName + ": Well then."); 
            dialog.Add("(The one in blue takes a seat next to me)"); //50
            dialog.Add("France: Hiya! I don’t think I introduced myself yet. I’m France!");
            dialog.Add(charName + ": You’re whatnow!?");
            dialog.Add("France: France. La France…");
            dialog.Add("France:  F-R-A-N-C-E."); 
            dialog.Add(charName + ": You’re named after a country?"); //55
            dialog.Add("France: No, silly! I am a country!");
            dialog.Add(charName + ": Ummmm…");
            dialog.Add("(This is seriously weird. It’s like something from one of my visual novels.)");
            dialog.Add("United Kingdom: That tea you wanted is ready."); 
            dialog.Add(charName + ": I didn’t want any tea!!!"); //60
            dialog.Add("United Kingdom: I’m sorry. I was under the impression you wanted tea.");
            dialog.Add("United Kingdom: I guess I should have introduced myself first.");
            dialog.Add("United Kingdom: I am the United Kingdom under His Majesty King George V.");
            dialog.Add(charName + ": Nope. That’s it. I’m out.");
            dialog.Add(""); //BG change //65
            dialog.Add("(I hurriedly leave the clubroom)");
            dialog.Add("(As I walk off down the hall, the club members call out after me)");
            dialog.Add("Russia: Um, Bye...");
            dialog.Add("France: Awwwwww… please stay!");
            dialog.Add("United Kingdom: You’re welcome back any time!"); //70
            dialog.Add("(Further down the hall I hear yet more music coming from a different classroom.)");
            dialog.Add("(Is there a second music club?)");
            dialog.Add("(It really doesn’t sound all that great, but at least the people here might be normal.)");
            dialog.Add("(I enter the clubroom.)");
            dialog.Add(""); //75 //BGChange
            dialog.Add(charName + ": Hello?");
            dialog.Add("Ottoman Empire: Aha! A tributary comes to bow before my awesome might!");
            dialog.Add(charName + ": Is this the drama club?");
            dialog.Add("Austria-Hungary: Nope! This is the…");
            dialog.Add("(...)"); //80
            dialog.Add(charName + ": The…");
            dialog.Add("Austria-Hungary: I forget!");
            dialog.Add("Germany: We are the Central Powers Music Club!");
            dialog.Add("Austria-Hungary: Oh, right. I always forget things…");
            dialog.Add("Germany: That’s ok. We all make mistakes. As long as you try your best, right?"); //85
            dialog.Add("Ottoman Empire: How are we ever going to beat those losers in " +
                "the Entente Club with you two acting like this all the time?");
            dialog.Add("(Wait a minute.)");
            dialog.Add("(Entente…)");
            dialog.Add("(Central Powers…)");
            dialog.Add("(I don’t like where this is going.)"); //90
            dialog.Add("Austria-Hungary: You really need to work on channeling your positive energy, Ottoman-Chan.");
            dialog.Add("Ottoman Empire: D-don’t call me that!!!! ");
            dialog.Add("Ottoman Empire: I am one of the oldest and most powerful empires in the world!");
            dialog.Add(charName + ": Well, oldest at least.");
            dialog.Add("Ottoman Empire: Rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr!"); //95
            dialog.Add("Germany: Tee-hee.");
            dialog.Add("Germany: We should probably introduce ourselves.");
            dialog.Add("Germany: I’m The German Empire, the leader of this club!");
            dialog.Add("Austria-Hungary: I’m Austria-Hungary. Germany’s cousin.");
            dialog.Add("Ottoman Empire: And I’m the Ottoman Empire, as I’m sure you already know."); //100
            dialog.Add("(Great. More crazy country people.)");
            dialog.Add("(I guess I’m not as shocked this time around.)");
            dialog.Add(charName + ": Um… Nice to meet you all. My name is ." + charName + ".");
            dialog.Add(charName + ": I was looking for a place I could stay after school to write my History essay.");
            dialog.Add("Germany: Well you could always stay here with us, as long as you don’t mind" +
                " helping out from time to time."); //105
            dialog.Add(charName + ": I guess I’d be fine with that. I’ll see you around. Bye for now!");
            dialog.Add("Austria-Hungary: Bye-bye!");
            dialog.Add("Germany: Tchüß!");
            dialog.Add("Ottoman Empire: Whatever. Bye."); 
            dialog.Add(""); //BG Change //110
            dialog.Add("(Well that was an interesting day.)");
            dialog.Add("(I guess I’m excited to spend some time with the Central Powers after school.)");
            dialog.Add("(Then again, the Entente did say I was welcome back whenever.)");
            dialog.Add("(And I feel kind of bad. I was really rude to them.)");
            dialog.Add("(But I can only choose one of the two clubs to stay with after school.)"); //115
            dialog.Add("(I’ll have to make up my mind tomorrow.)");
            dialog.Add("");
            dialog.Add("");
            dialog.Add("");
            dialog.Add("");
            //You know that it's spelled "dialogue," right?

            //Day 2 List
            dialog2.Add("[DecisionTest]");
            dialog2.Add("Didn't work");
            dialog2CP.Add("central powers");
            dialog2CP.Add("bbbbbbbbbbbbbbbb");
            dialog2CP.Add("bbbbbbbbbbbbbbbb");
            dialog2CP.Add("bbbbbbbbbbbbbbbb");
            dialog2EN.Add("britan-Hungary");
            dialog2CPGER.Add("German Empire");
            dialog2CPAUS.Add("Austria - Hungary");




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
                Thread.Sleep(textSpeed);
            }
        }

        //Choices
        private void GameScreen_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (decision2Enabled == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        clubChoice = "a";
                        scene = 0;
                        decision2Enabled = false; ;
                        break;
                    case Keys.N:
                        clubChoice = "b";
                        scene = 0;
                        decision2Enabled = false;
                        break;
                  
                }


            }

            if (decision3Enabled == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        charChoice = "a";
                        scene = 0;
                        decision3Enabled = false; ;
                        break;
                    case Keys.N:
                        charChoice = "b";
                        scene = 0;
                        decision3Enabled = false;
                        break;
                    case Keys.M:
                        charChoice = "c";
                        scene = 0;
                        decision3Enabled = false; ;
                        break;
                }


            }
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
                                if (scene == 53)
                                {
                                    textSpeed = 60;
                                }
                                if (scene == 54)
                                {
                                    textSpeed = 20;
                                }
                                if (scene == 65)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.hall;
                                }
                                if (scene == 75)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.class2;
                                }
                                if (scene == 110)
                                {
                                    this.BackgroundImage = null;
                                }
                            }
                            nextEnabled = true;
                            break;
                            
                        case 2: //Day 2
                            if (clubChoice == "a") // centeral powers  
                            {
                                if (charChoice == "a")
                                {

                                    type(dialog2CPGER[scene]);
                                    scene++;
                                }
                                else if (charChoice == "b")
                                {
                                    type(dialog2CPAUS[scene]);
                                    scene++;
                                }
                                else if (charChoice == "c")
                                {
                                    type(dialog2CPOTT[scene]);
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

                            }   
                            else if (clubChoice == "b")  // entente
                            {
                                if (charChoice == "a")
                                {

                                    type(dialog2ENGBR[scene]);
                                    scene++;
                                }
                                else if (charChoice == "b")
                                {
                                    type(dialog2ENFRA[scene]);
                                    scene++;
                                }
                                else if (charChoice == "c")
                                {
                                    type(dialog2ENRUS[scene]);
                                    scene++;
                                }
                               
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
                                textLabel.Text = "b - Central Powers \n n - Entente";
                                decision2Enabled = true;
                            }
                            if (scene == 2 && clubChoice == "b") 
                            {
                                textLabel.Text = "b - The Somme \n n - Verdun \n m - Brusilov Offensive";
                                decision3Enabled = true;
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