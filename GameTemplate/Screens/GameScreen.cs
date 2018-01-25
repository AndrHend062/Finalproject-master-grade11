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
        int textSpeed = 0; //20 
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
        List<string> dialog2CPEND = new List<string>();
         List<string> dialog2ENEND = new List<string>();
        List<string> dialog3 = new List<string>();
        bool nextEnabled = true;
        bool decision2Enabled = false;
        bool decision3Enabled = false;
        string charName;
        string charChoice;
        string clubChoice;
        bool end = false;

        System.Windows.Media.MediaPlayer enPlayer;
        System.Windows.Media.MediaPlayer cpPlayer;
        System.Windows.Media.MediaPlayer walkPlayer;
        System.Windows.Media.MediaPlayer markPlayer;
        public GameScreen()
        {
            InitializeComponent();
            //Day 1 List
            #region 
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
            dialog.Add(""); // 120
            #endregion
            //You know that it's spelled "dialogue," right?

            //Day 2 List
            dialog2.Add(""); //BG change //1
            dialog2.Add("Alarm: Ring! Ring!");
            dialog2.Add("(Time for my second day, I guess)");
            dialog2.Add("");//BG change
            dialog2.Add("Hideki: Hey "+charName+"!"); //5
            dialog2.Add("Hideki: Have you decided on a topic for your essay yet?"); 
            dialog2.Add(charName+": Nothing yet. I’m planning to start writing it today after school.");
            dialog2.Add("Hideki: Right on, man.");
            dialog2.Add("Hideki: I’m writing mine about the Holy Roman Empire.");
            dialog2.Add("(I bet that Austria-Hungary would really enjoy that topic)"); //10
            dialog2.Add("(In fact, whatever topic I choose to write about will probably affect my "+
                 "relations with those countries I met yesterday.)"); 
            dialog2.Add("(I should pick my topic carefully, some of those countries were pretty cute.)");
            dialog2.Add("(Wow that sounds weird out loud.)");
            dialog2.Add("");// BG change
            dialog2.Add("(It's the end of the day now.)"); //15
            dialog2.Add("(Time to decide what club to spend my afterschools with.)"); 
            dialog2.Add("(So what’ll it be - Entente or Central Powers?)");
            dialog2.Add(""); //18
            //cp words 
            dialog2CP.Add("(I think I really hit it off with the central Powers club members yesterday.)");
            dialog2CP.Add("(That’s where I’ll write my essay.)");
            dialog2CP.Add(" "); //BG change 
            dialog2CP.Add("(By the time I enter the clubroom the girls have already started practicing.)");
            dialog2CP.Add("(I take my seat at the back of the class.)"); //5
            dialog2CP.Add("(Man, this club really isn’t so good at playing.)");
            dialog2CP.Add("(It’s actually really hard to concentrate on the essay.)");
            dialog2CP.Add("(I can barely even hear the Ottoman Empire’s part.)");
            dialog2CP.Add("(Austria-Hungary is playing more than loud enough, but hitting all the wrong notes.)");
            dialog2CP.Add("(At least Germany’s playing is fine, I guess.)"); //10
            dialog2CP.Add("(Man, this club really isn’t so good at playing.)");
            dialog2CP.Add("(Anyways, I should really get writing this essay.)");
            dialog2CP.Add("(But what to write it on?)");
            dialog2CP.Add(" "); //14
          
            dialog2EN.Add("(I think it would be best to make amends with the Entente club.)");
            dialog2EN.Add("(I was really rude to them yesterday.)");
            dialog2EN.Add(""); // BG change 
            dialog2EN.Add("(By the time I enter the clubroom the girls have already started practicing.)");
            dialog2EN.Add("(As I hoped, the club’s music really helps me to relax.)"); //5
            dialog2EN.Add("(Russia’s playing is maybe not quite as good as the others, but it isn’t"+
                 "particularly bad either.)");
            dialog2EN.Add("(Anyways, I should really get writing this essay.)");
            dialog2EN.Add("(But what to write it on?)");
            dialog2EN.Add(""); //9
   
            dialog2EN.Add("Britan-Hungary?");
            //great britan day 2
            #region
            dialog2ENGBR.Add("(After a while, the United Kingdom stands up and stops the practice.)");
            dialog2ENGBR.Add("United Kingdom: Alright! Great job everyone!");
            dialog2ENGBR.Add("United Kingdom: France, make sure you’re hitting all those high notes.");
            dialog2ENGBR.Add("United Kingdom: Russia, you may have to work on your embouchure a bit.");
            dialog2ENGBR.Add("United Kingdom: You two keep practicing on your own for a bit. I should probably check in on our guest.");
            dialog2ENGBR.Add("(The UK sits down beside me. The other girls resume practicing.)");
            dialog2ENGBR.Add("United Kingdom: We might need a bit more practice, but I’d say we’re more than prepared for the competition.");
            dialog2ENGBR.Add(charName+": Competition? What competition?");
            dialog2ENGBR.Add("United Kingdom: I guess I haven’t told you about that.");
            dialog2ENGBR.Add("United Kingdom: We’ve got this really big play-off coming up against the Central Powers club.");
            dialog2ENGBR.Add("United Kingdom: They’re not exactly ready for it though.");
            dialog2ENGBR.Add(charName+": Why would they even enter then?");
            dialog2ENGBR.Add("United Kingdom: Well, Austria-Hungary and Russia kind of started this whole thing.");
            dialog2ENGBR.Add("United Kingdom: Something about Serbia-Chan, I don’t really know. ");
            dialog2ENGBR.Add("United Kingdom: I almost didn’t join this club, but my friend Belgium convinced me.");
            dialog2ENGBR.Add("United Kingdom: France and I don’t really get along, see?");
            dialog2ENGBR.Add("United Kingdom: Russia I’ve never had any problems with. She mostly just keeps to herself.");
            dialog2ENGBR.Add(charName +": Well I think you guys sound great.");
            dialog2ENGBR.Add("United Kingdom: Why thank you!");
            dialog2ENGBR.Add("United Kingdom: Anyways, let’s see that essay you’re writing.");
            dialog2ENGBR.Add(charName+": Oh, sure thing.");
            dialog2ENGBR.Add("(I hand the United Kingdom my essay.)");
            dialog2ENGBR.Add("(She studies it intensely.)");
            dialog2ENGBR.Add("United Kingdom: Oh my my…");
            dialog2ENGBR.Add("United Kingdom: This is quite good.");
            dialog2ENGBR.Add("United Kingdom: I really appreciate the subject matter. That truly was a glorious offensive.");
            dialog2ENGBR.Add(charName +": Oh, thanks.");
            dialog2ENGBR.Add("United Kingdom: You’re very welcome.");
            dialog2ENGBR.Add("United Kingdom: I should probably get back to the others.");
            dialog2ENGBR.Add("(Oh right. I kind of forgot about the other members for a second.)");
            dialog2ENGBR.Add("(The United Kingdom heads up to the front of the clubroom.)");
            dialog2ENGBR.Add("");
            dialog2ENGBR.Add("(After a while, the United Kingdom stands up and stops the practice.)");
            dialog2ENGBR.Add("United Kingdom: Alright! Great job everyone!");
            dialog2ENGBR.Add("United Kingdom: France, make sure you’re hitting all those high notes.");
            dialog2ENGBR.Add("United Kingdom: Russia, you may have to work on your embouchure a bit.");
            dialog2ENGBR.Add("United Kingdom: Actually, I think I’d like to work one-on-one with you for a bit. ");
            dialog2ENGBR.Add("United Kingdom: France, you can go talk to our guest.");
            dialog2ENGBR.Add("France: Yes!");
            dialog2ENGBR.Add("(France skips over and sits beside me. The other girls resume practicing.)");
            dialog2ENGBR.Add("France: Soooo… How are you?"); 
            dialog2ENGBR.Add(charName +": I’m pretty good, how about you?");
            dialog2ENGBR.Add("France: I feel just glorious!");
            dialog2ENGBR.Add("France: We’re so going to beat those Central Powers losers in the music competition. ");
            dialog2ENGBR.Add(charName +": Competition?");
            dialog2ENGBR.Add("France: Yeah, that idiot Austria started something with Russia over Serbia.");
            dialog2ENGBR.Add("France: It all led to this big upcoming play-off.");
            dialog2ENGBR.Add("France: This is my chance to finally get back Alsace-Lorraine!");
            dialog2ENGBR.Add("France: You don’t know how happy that makes me!");
            dialog2ENGBR.Add("France: Anywho… Let me see that essay you’re writing!");
            dialog2ENGBR.Add(charName +": Yeah, sure.");
            dialog2ENGBR.Add("(France quickly glances at the essay.)");
            dialog2ENGBR.Add("(I’m not really sure if she even read a word of it.)");
            dialog2ENGBR.Add("France: Sacré bleu!");
            dialog2ENGBR.Add("France: This is fantastique!");
            dialog2ENGBR.Add(charName + ": Did you actually read it?");
            dialog2ENGBR.Add("France: Of course.");
            dialog2ENGBR.Add(charName + ": If you say so.");
            dialog2ENGBR.Add("(Meanwhile, the other girls have finished their practicing.)");
            dialog2ENGBR.Add("France: I guess I gotta go now.");
            dialog2ENGBR.Add("France: Au revoir ma cherie!");
            dialog2ENGBR.Add("(France skips back up to the front of the class.)");
            dialog2ENGBR.Add("(What a strange girl.)");
            dialog2ENGBR.Add("");
            #endregion
            //rus day 2
            #region
            dialog2ENRUS.Add("(After a while, the United Kingdom stands up and stops the practice.)");
            dialog2ENRUS.Add("United Kingdom: Alright! Great job everyone!");
            dialog2ENRUS.Add("United Kingdom: Russia, you may have to work on your embouchure a bit.");
            dialog2ENRUS.Add("United Kingdom: France, make sure you’re hitting all those high notes.");
            dialog2ENRUS.Add("United Kingdom: Actually, I think I’d like to work one-on-one with you for a bit. ");
            dialog2ENRUS.Add("United Kingdom: Russia, you can go talk to our guest.");
            dialog2ENRUS.Add("Russia: Oh…");
            dialog2ENRUS.Add("Russia: I…");
            dialog2ENRUS.Add("Russia: I guess I’m ok with that.");
            dialog2ENRUS.Add("(Russia awkwardly shuffles over and sits beside me. The other girls resume practicing.)");
            dialog2ENRUS.Add("(We sit in silence for a while.)");
            dialog2ENRUS.Add(charName + ": So… what’s new with you?");
            dialog2ENRUS.Add("Russia: Well… ");
            dialog2ENRUS.Add("Russia: There’s that competition  coming up.");
            dialog2ENRUS.Add(charName + ": Competition?");
            dialog2ENRUS.Add("Russia: Yeah. Me and Austria kind of started a bit of a feud.");
            dialog2ENRUS.Add("Russia: I think our club’s pretty set though.");
            dialog2ENRUS.Add("Russia: Those Central Powers members aren’t so good.");
            dialog2ENRUS.Add("Russia: They’re probably better than me though.");
            dialog2ENRUS.Add(charName + ": Don’t say that.");
            dialog2ENRUS.Add(charName + ": Your playing is fine.");
            dialog2ENRUS.Add(charName + ": You’re too hard on yourself.");
            dialog2ENRUS.Add("Russia: Yeah… Maybe...");
            dialog2ENRUS.Add("Russia: I think I’m going to go now.");
            dialog2ENRUS.Add("Russia: The others look like they’re done practicing.");
            dialog2ENRUS.Add("MC: Hey! Wait, don’t-");
            dialog2ENRUS.Add("(She’s already walking back to the front of the class.)");
            dialog2ENRUS.Add("");
            #endregion

            //germany day 2
            #region
            dialog2CPGER.Add("(After a while Germany stand up and stops the practice.)");
            dialog2CPGER.Add("Germany: Alright! Great job everyone!");   
            dialog2CPGER.Add("Germany: Ottoman Empire, you’re still a little quiet.");
            dialog2CPGER.Add("Germany: Austria-Hungary, you might need to practice a bit more. Make" +
                "sure you’re hitting the right notes."); 
            dialog2CPGER.Add("Germany: You two keep practicing on your own for a bit." + 
                "I should probably check in on our guest."); //5
            dialog2CPGER.Add("(Germany sits down beside me. The other girls resume practicing.)");
            dialog2CPGER.Add("Germany: Yeah… We’re not exactly prepared for the competition, are we?");
            dialog2CPGER.Add( charName+": Competition? What competition?"); 
            dialog2CPGER.Add("Germany: I guess I haven’t told you about that.");
            dialog2CPGER.Add("Germany: We’ve got this really big play-off coming up against the Entente club."); //10 
            dialog2CPGER.Add("Germany: The stakes are pretty high so it’d really be a shame if we lost.");
            dialog2CPGER.Add(charName +": Why even enter then?");
            dialog2CPGER.Add("Germany: Well, Austria-Hungary and Russia kind of started this whole thing.");
            dialog2CPGER.Add("Germany: Something about Serbia-Chan, I don’t really know. ");
            dialog2CPGER.Add("Germany: I kind of put this club together to help her out."); //15 
            dialog2CPGER.Add("Germany: I really thought that our friend Italy would join. She promised she would, you know.");
            dialog2CPGER.Add("Germany: Instead we got the Ottoman Empire. She really is quite sweet, "+
                "even if she doesn’t seem that way at first.");
            dialog2CPGER.Add("Germany: I believe you would call her a “tsundere”. ");
            dialog2CPGER.Add(charName +": You guys sound like you’re really in trouble."); //20 
            dialog2CPGER.Add("Germany: You can say that again.");
            dialog2CPGER.Add("Germany: Anyways, let’s see that essay you’re writing.");
            dialog2CPGER.Add(charName +": Oh, sure thing.");
            dialog2CPGER.Add("(I hand Germany my essay.)");
            dialog2CPGER.Add("(She studies it intensely.)"); //25
            dialog2CPGER.Add("Germany: Oh.");
            dialog2CPGER.Add("Germany: Oh my…");
            dialog2CPGER.Add("Germany: This is really good.");
            dialog2CPGER.Add("Germany: I really appreciate the subject matter and the writing is very strong and direct.");
            dialog2CPGER.Add(charName+": Oh, thanks."); //30
            dialog2CPGER.Add("Germany: Don’t mention it.");
            dialog2CPGER.Add("Germany: I should probably get back to the others.");
            dialog2CPGER.Add("(Oh right. I kind of forgot about the other members for a second.)");
            dialog2CPGER.Add("(Germany heads up to the front of the clubroom.)");
            dialog2CPGER.Add("");
            #endregion
            //austria day 2
            #region
            dialog2CPAUS.Add("(After a while Germany stand up and stops the practice.)");
            dialog2CPAUS.Add("Germany: Alright! Great job everyone!");
            dialog2CPAUS.Add("Germany: Ottoman Empire, you’re still a little quiet...");
            dialog2CPAUS.Add("Germany: I think I’d like to work with you one on one for a bit.");
            dialog2CPAUS.Add("Germany: Austria-Hungary, you might need to practice a bit more. Make sure you’re hitting the right notes.");//5
            dialog2CPAUS.Add("Germany: Austria-Hungary, you can go talk to our guest if you want.");
            dialog2CPAUS.Add("Austria-Hungary: Yay!");
            dialog2CPAUS.Add("(Austria-Hungary waddles over and takes a seat beside me.)");
            dialog2CPAUS.Add("(The other club members resume their practicing.)");
            dialog2CPAUS.Add("Austria-Hungary: Germany sure is doing her best to get us ready for the competition.");//10
            dialog2CPAUS.Add(charName +": Competition? What competition?");
            dialog2CPAUS.Add("Austria-Hungary: Oh yeah, no one’s told you yet!");
            dialog2CPAUS.Add("Austria-Hungary: I kind of accidentally started this feud between our club and the Entente club.");
            dialog2CPAUS.Add("Austria-Hungary: We’re really not ready for it. Especially me.");
            dialog2CPAUS.Add("Austria-Hungary: I really hope I’m not letting the rest of the club down.");//15
            dialog2CPAUS.Add(charName+": Really? I thought you guys sounded fine.");
            dialog2CPAUS.Add("Austria-Hungary: You did?");
            dialog2CPAUS.Add(charName+": Yeah. I mean, everyone has to start somewhere.");
            dialog2CPAUS.Add(charName+": For beginners, you guys are pretty good.");
            dialog2CPAUS.Add("Austria-Hungary: You really think so?");//20
            dialog2CPAUS.Add(charName +":Yeah, I mean you’re… ");
            dialog2CPAUS.Add("Austria-Hungary: Oooooo! I forgot to ask to see your essay!");
            dialog2CPAUS.Add("Austria-Hungary: Can I? Pleeaase?");
            dialog2CPAUS.Add(charName +": Yeah, sure. Here you go.");
            dialog2CPAUS.Add("(I hand Austria-Hungary my essay.)");//25
            dialog2CPAUS.Add("Her eyes light up as she glances over it.)");
            dialog2CPAUS.Add("Austria-Hungary: Wow! This is sooooo good!!!");
            dialog2CPAUS.Add("Austria-Hungary: I really, really like the subject matter too.");
            dialog2CPAUS.Add("Austria-Hungary: You should really join the History Club.");
            dialog2CPAUS.Add(charName +": That’s kind of what I’m writing this essay for.");//30
            dialog2CPAUS.Add("Austria-Hungary: Oh! Cool!");
            dialog2CPAUS.Add("(Meanwhile, Germany and the Ottoman Empire have stopped their practice.)");
            dialog2CPAUS.Add("Austria-Hungary: Oh, I should probably get going…");
            dialog2CPAUS.Add("Austria-Hungary: Bye!");
            dialog2CPAUS.Add("(She waddles back to the front of the class.)");//35
            dialog2CPAUS.Add("");//
            #endregion

            dialog2CPAUS.Add("");
            dialog2CPAUS.Add("");
            dialog2CPAUS.Add("Austria - Hungary");
            //ottomans day 2 
            #region 
            dialog2CPOTT.Add("(After a while Germany stand up and stops the practice.)");
            dialog2CPOTT.Add("Germany: Alright! Great job everyone!");
            dialog2CPOTT.Add("Germany: Austria-Hungary, you might need to practice a bit more. Make sure you’re hitting the right notes.");
            dialog2CPOTT.Add("Germany: I think I’d like to work with you one on one for a bit.");
            dialog2CPOTT.Add("Ottoman Empire: Alright. I guess I’ll go talk to that loser guest of ours.");
            dialog2CPOTT.Add("(Wow. Thanks.)");
            dialog2CPOTT.Add("(The Ottoman Empire struts over and takes a seat next to me.)");
            dialog2CPOTT.Add("(The other club members resume their practicing.)");
            dialog2CPOTT.Add("Ottoman Empire: Man, those two really aren’t good at this, huh?");
            dialog2CPOTT.Add("(She’s one to talk.)");
            dialog2CPOTT.Add("Ottoman Empire: I don’t know how I’m going to win the competition with only these losers to back me up.");
            dialog2CPOTT.Add("(Competition? What competition?)");
            dialog2CPOTT.Add("Ottoman Empire: You probably don’t even know what I’m talking about.");
            dialog2CPOTT.Add("Ottoman Empire: Austria and Russia kind of started this dumb feud.");
            dialog2CPOTT.Add("Ottoman Empire: So now engaged in a music competition with the Entente club.");
            dialog2CPOTT.Add("Ottoman Empire: It kind of sucks, to be honest.");
            dialog2CPOTT.Add("Ottoman Empire: Anyways, let me see that essay of yours.");
            dialog2CPOTT.Add(charName +": Yeah, sure.");
            dialog2CPOTT.Add("(I hand the Ottoman Empire my essay.)");
            dialog2CPOTT.Add("(Her eyes light up as she reads it.)");
            dialog2CPOTT.Add("(Wait… is she blushing?)");
            dialog2CPOTT.Add("Ottoman Empire: I…");
            dialog2CPOTT.Add("Ottoman Empire: This is…");
            dialog2CPOTT.Add("Ottoman Empire: The other club members are probably finishing up practice now.");
            dialog2CPOTT.Add("Ottoman Empire: I should really get going.");
            dialog2CPOTT.Add("(She nervously returns to the front of the class.)");
            #endregion 
            dialog2CPEND.Add("Germany: Alright, listen up everyone! ");
            dialog2CPEND.Add("Germany: So tomorrow I thought we would be doing a bit of a group activity ");
            dialog2CPEND.Add("Austria-Hungary: Yay! I like teamwork!");
            dialog2CPEND.Add("Ottoman Empire: Ugh, I guess that’s fine.");
            dialog2CPEND.Add("Germany: We can choose our partners tomorrow. Since there’s only three of us, I guess one will partner up with "+charName + ".");
            dialog2CPEND.Add("Germany: It’s getting late, so I guess that means practice is over for today.");
            dialog2CPEND.Add("Germany: Good job today everyone!");
            dialog2CPEND.Add("");
            dialog2CPEND.Add("And with that, we all leave the clubroom and head back home.)    ");
            dialog2CPEND.Add("(I’m sure the group activity will be lots of fun.)");
            dialog2CPEND.Add("(Though it will be tough to choose a partner.)");
            dialog2CPEND.Add("(That’s a decision I’ll have to make tomorrow though.)");

            dialog2CPEND.Add("end list start ");

            //Day 3 List
            dialog3.Add("HI day 3");

            //music 

            enPlayer = new System.Windows.Media.MediaPlayer();
            cpPlayer = new System.Windows.Media.MediaPlayer();
            walkPlayer = new System.Windows.Media.MediaPlayer();
            markPlayer = new System.Windows.Media.MediaPlayer();
            enPlayer.Open(new Uri(Application.StartupPath + "/Resources/Yuki_no_Shingun.mp3"));
            cpPlayer.Open(new Uri(Application.StartupPath + "/Resources/Fredericus_Rex.mp3"));
            walkPlayer.Open(new Uri(Application.StartupPath + "/Resources/Wenn_die_Soldaten.mp3"));
            markPlayer.Open(new Uri(Application.StartupPath + "/Resources/Markische_Heide.mp3"));

        }




        private void GameScreen_Click(object sender, EventArgs e)
        {
         //   scene++;           
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
                switch (e.KeyCode) // club
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

            if (decision3Enabled == true) //char 
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
                case Keys.Tab:
                    day++;

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
                                   // walkplayer.play();
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

                                // char changes day 1 
                                if (scene == 31 )
                                {
                                    charBox1.BackgroundImage = GameTemplate.Properties.Resources.GBR;
                                }
                                if (scene == 32 )
                                {
                                    charBox2.BackgroundImage = GameTemplate.Properties.Resources.RUS;
                                }
                                if (scene == 34)
                                {
                                    charBox3.BackgroundImage = GameTemplate.Properties.Resources.FRA;
                                }
                                if (scene == 42) // gbr and fra leave 
                                {
                                    charBox1.BackgroundImage = null;
                                    charBox3.BackgroundImage = null;
                                }

                                if (scene == 49) //rus leave 
                                {
                                    charBox2.BackgroundImage = null;
                                  
                                }
                                if (scene == 50) //france 
                                {
                                    charBox3.BackgroundImage = GameTemplate.Properties.Resources.FRA;

                                }
                                if (scene == 59) // tea britan 
                                {
                                    charBox1.BackgroundImage = GameTemplate.Properties.Resources.GBR;

                                }
                                if (scene == 66) // leave room 
                                {
                                    charBox1.BackgroundImage = null;
                                    charBox2.BackgroundImage = null;
                                    charBox3.BackgroundImage = null;
                                }

                                if (scene == 68) // leave room hi rus 
                                {
                                    charBox2.BackgroundImage = GameTemplate.Properties.Resources.RUS;
                                }
                                if (scene == 69) // leave room hi fra
                                {
                                    charBox3.BackgroundImage = GameTemplate.Properties.Resources.FRA;
                                }
                                if (scene == 70) // leave room hi  gbr
                                {
                                    charBox1.BackgroundImage = GameTemplate.Properties.Resources.GBR;
                                }
                                if (scene == 71) // leave  all 
                                {
                                    charBox1.BackgroundImage = null;
                                    charBox2.BackgroundImage = null;
                                    charBox3.BackgroundImage = null;
                                }

                                if (scene == 77) // enter  room aus 
                                {
                                    charBox3.BackgroundImage = GameTemplate.Properties.Resources.OTT;
                                }
                                if (scene == 79) // enter  room aus 
                                {
                                    charBox2.BackgroundImage = GameTemplate.Properties.Resources.AUS;
                                }
                                if (scene == 83) // club great  room ger 
                                {
                                    charBox1.BackgroundImage = GameTemplate.Properties.Resources.GER;
                                }
                                if (scene == 110) // cp leave room 
                                {
                                    charBox1.BackgroundImage = null;
                                    charBox2.BackgroundImage = null;
                                    charBox3.BackgroundImage = null;
                                }

                            }

                            nextEnabled = true;
                            break;
                            
                        case 2: //Day 2

                           

                           if (clubChoice == "a") // centeral     
                            {



                                if (charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true)
                                {
                                    scene++;

                                    type(dialog2CP[scene]);
                                }
                                if (charChoice == "a" && end != true)
                                {
                                    try
                                    {

                                        type(dialog2CPGER[scene]);
                                        scene++;
                                    }
                                    catch
                                    {
                                        try
                                        {

                                            type(dialog2CPOTT[scene]);
                                            scene++;
                                        }
                                        catch
                                        {
                                            end = true;

                                            type(dialog2CPEND[scene]);

                                        }
                                    }
                                }
                                else if (charChoice == "b" && end != true)
                                {
                                    try
                                    {


                                        type(dialog2CPAUS[scene]);
                                        scene++;
                                    }
                                    catch
                                    {
                                        try
                                        {


                                            type(dialog2CPOTT[scene]);
                                            scene++;
                                        }
                                        catch
                                        {
                                            end = true;

                                            type(dialog2CPEND[scene]);

                                        }
                                    }
                                }
                                else if (charChoice == "c" && end != true)
                                {
                                    try
                                    {


                                        type(dialog2CPOTT[scene]);
                                        scene++;
                                    }
                                    catch
                                    {
                                        end = true;

                                        type(dialog2CPEND[scene]);

                                    }
                                }
                                else if ( end == true)
                                {
                                    try
                                    {
                                        scene++;
                                        type(dialog2CPEND[scene]);
                                    }
                                    catch
                                    {
                                        scene = 0;
                                        end = false;
                                        day++;
                                        charChoice = "f";
                                    }
                                }
                            }

                            else if (clubChoice == "b")  // entetetenen
                            {

                                if (charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true)
                                {
                                    scene++;

                                    type(dialog2CP[scene]);
                                }
                                if (charChoice == "a" && end != true)
                                {
                                    try
                                    {

                                        type(dialog2ENGBR[scene]);
                                        scene++;
                                    }
                                    catch
                                    {
                                        try
                                        {

                                            type(dialog2ENGBR[scene]);
                                            scene++;
                                        }
                                        catch
                                        {
                                            end = true;

                                            type(dialog2ENEND[scene]);

                                        }
                                    }
                                }
                                else if (charChoice == "b" && end != true)
                                {
                                    try
                                    {


                                        type(dialog2ENRUS[scene]);
                                        scene++;
                                    }
                                    catch
                                    {
                                        try
                                        {


                                            type(dialog2ENRUS[scene]);
                                            scene++;
                                        }
                                        catch
                                        {
                                            end = true;

                                            type(dialog2ENEND[scene]);

                                        }
                                    }
                                }
                                else if (charChoice == "c" && end != true)
                                {
                                    try
                                    {


                                        type(dialog2ENFRA[scene]);
                                        scene++;
                                    }
                                    catch
                                    {
                                        end = true;

                                        type(dialog2ENEND[scene]);

                                    }
                                }
                                else if (end == true)
                                {
                                    try
                                    {
                                        scene++;
                                        type(dialog2CPEND[scene]);
                                    }
                                    catch
                                    {
                                        scene = 0;
                                        end = false;
                                        day++;
                                        charChoice = "f";
                                    }
                                }
                            }

                            //scene changes 
                            if (scene == 1 && clubChoice != "a" && clubChoice != "b" && end != true)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.bedroom;
                                }
                             if (scene == 4 && clubChoice != "a" && clubChoice != "b" && end != true)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.street;
                                }
                              if (scene == 14 && clubChoice != "a" && clubChoice != "b" && end != true)
                                {
                                    this.BackgroundImage = null;
                                }


                               // cp scene changes 
                           if (scene == 3 && clubChoice == "a" && end != true)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.class2;
                                }
                             

                                // EN scene changes 
                           if (scene == 3 && clubChoice == "b" && end != true)
                                {
                                    this.BackgroundImage = GameTemplate.Properties.Resources.Class;
                                }



                           //char changes 

                            //char cp 
                            if (scene == 4 && clubChoice == "a" && clubChoice != "b" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true)
                            {
                                charBox1.BackgroundImage = GameTemplate.Properties.Resources.GER;
                            }
                            if (scene == 4 && clubChoice == "a" && clubChoice != "b" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true)
                            {
                                charBox2.BackgroundImage = GameTemplate.Properties.Resources.AUS;
                            }
                            if (scene == 4 && clubChoice == "a" && clubChoice != "b" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true)
                            {
                                charBox3.BackgroundImage = GameTemplate.Properties.Resources.OTT;
                            }
                            //ger 
                            if (scene == 6 && clubChoice == "a" && clubChoice != "b" && charChoice == "a" && charChoice != "b" && charChoice != "c" && end != true)
                            {
                                charBox1.BackgroundImage = null;
                                charBox3.BackgroundImage = null;
                                charBox2.BackgroundImage = GameTemplate.Properties.Resources.GER;
                            }
                            //aus
                            if (scene == 4 && clubChoice == "a" && clubChoice != "b" && charChoice != "a" && charChoice == "b" && charChoice != "c" && end != true)
                            {
                                charBox1.BackgroundImage = null;
                                charBox3.BackgroundImage = null;
                                charBox2.BackgroundImage = GameTemplate.Properties.Resources.AUS;
                            }
                            //ott
                            if (scene == 4 && clubChoice == "a" && clubChoice != "b" && charChoice != "a" && charChoice != "b" && charChoice == "c" && end != true)
                            {
                                charBox1.BackgroundImage = null;
                                charBox3.BackgroundImage = null;
                                charBox2.BackgroundImage = GameTemplate.Properties.Resources.OTT;
                            }






                            if (scene == 17  && clubChoice != "a" && clubChoice != "b"&& charChoice != "a" && charChoice != "b" && charChoice != "c"&& end !=true)  // activate desision 
                            {
                                textLabel.Text = "b - Central Powers \n n - Entente";
                                decision2Enabled = true;
                            }
                            if (scene == 17 && clubChoice != "a" && clubChoice != "b" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true) // stop progression 
                            { scene = scene - 1; }

                            if (scene == 9 && clubChoice == "b" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true) // activate desision 
                            {
                                textLabel.Text = "b - The Somme \n n - Verdun \n m - Brusilov Offensive";
                                decision3Enabled = true;
                            }
                            if (scene == 9 && clubChoice == "b" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true)// stop progression 
                            { scene = scene - 1; }

                            if (scene == 13 && clubChoice == "a" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true) // activate desision 
                            {
                                textLabel.Text = "b - Tannenberg \n n - The Isonzo \n m - Gallipoli";
                                decision3Enabled = true;
                            }
                            if (scene == 13 && clubChoice == "a" && charChoice != "a" && charChoice != "b" && charChoice != "c" && end != true)// stop progression 
                            {scene = scene - 1; }

                            break;

                        case 3: // day 3 
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