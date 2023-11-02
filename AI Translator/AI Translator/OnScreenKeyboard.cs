using System;
using System.Drawing;
using System.Windows.Forms;

namespace AI_Translator
{
    public partial class OnScreenKeyboard : Form
    {
        private mainForm parent;
        bool caps = false;
        bool alt = false;



        // ============================================================== Setup ============================================================================ //

        public OnScreenKeyboard(mainForm mainForm)
        {
            InitializeComponent();
            keyAssigment();
            parent = mainForm;
        }
        private void OnScreenKeyboard_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        // ============================================================== End of Setup ============================================================================ //





        private void keyAssigment()
        {
            //  =============================================================================== Buttons Mapping ========================================================================================================================================//
            if ( comboBox1.SelectedIndex==0)        //Buttons mapping for selected Russian
            {
                if (caps == false && alt == false) { buttonQ.Text = "й"; }else if(caps==true && alt==false) { buttonQ.Text = "Й"; } else if (caps==false&&alt==true) { buttonQ.Text = "й"; } else if (caps == true && alt == true) { buttonQ.Text = "Й"; }
                if (caps == false && alt == false) { buttonW.Text = "ц"; } else if (caps == true && alt == false) { buttonW.Text = "Ц"; } else if (caps == false && alt == true) { buttonW.Text = "ц"; } else if (caps == true && alt == true) { buttonW.Text = "Ц"; }
                if (caps == false && alt == false) { buttonE.Text = "у"; } else if (caps == true && alt == false) { buttonE.Text = "У"; } else if (caps == false && alt == true) { buttonE.Text = "у"; } else if (caps == true && alt == true) { buttonE.Text = "У"; }
                if (caps == false && alt == false) { buttonR.Text = "к"; } else if (caps == true && alt == false) { buttonR.Text = "К"; } else if (caps == false && alt == true) { buttonR.Text = "к"; } else if (caps == true && alt == true) { buttonR.Text = "К"; }
                if (caps == false && alt == false) { buttonT.Text = "е"; } else if (caps == true && alt == false) { buttonT.Text = "Е"; } else if (caps == false && alt == true) { buttonT.Text = "е"; } else if (caps == true && alt == true) { buttonT.Text = "Е"; }
                if (caps == false && alt == false) { buttonY.Text = "н"; } else if (caps == true && alt == false) { buttonY.Text = "Н"; } else if (caps == false && alt == true) { buttonY.Text = "н"; } else if (caps == true && alt == true) { buttonY.Text = "Н"; }
                if (caps == false && alt == false) { buttonU.Text = "г"; } else if (caps == true && alt == false) { buttonU.Text = "Г"; } else if (caps == false && alt == true) { buttonU.Text = "г"; } else if (caps == true && alt == true) { buttonU.Text = "Г"; }
                if (caps == false && alt == false) { buttonI.Text = "ш"; } else if (caps == true && alt == false) { buttonI.Text = "Ш"; } else if (caps == false && alt == true) { buttonI.Text = "ш"; } else if (caps == true && alt == true) { buttonI.Text = "Ш"; }
                if (caps == false && alt == false) { buttonO.Text = "щ"; } else if (caps == true && alt == false) { buttonO.Text = "Щ"; } else if (caps == false && alt == true) { buttonO.Text = "щ"; } else if (caps == true && alt == true) { buttonO.Text = "Щ"; }
                if (caps == false && alt == false) { buttonP.Text = "з"; } else if (caps == true && alt == false) { buttonP.Text = "З"; } else if (caps == false && alt == true) { buttonP.Text = "з"; } else if (caps == true && alt == true) { buttonP.Text = "З"; }
                if (caps == false && alt == false) { buttonA.Text = "ф"; } else if (caps == true && alt == false) { buttonA.Text = "Ф"; } else if (caps == false && alt == true) { buttonA.Text = "ф"; } else if (caps == true && alt == true) { buttonA.Text = "Ф"; }
                if (caps == false && alt == false) { buttonS.Text = "ы"; } else if (caps == true && alt == false) { buttonS.Text = "Ы"; } else if (caps == false && alt == true) { buttonS.Text = "ы"; } else if (caps == true && alt == true) { buttonS.Text = "Ы"; }
                if (caps == false && alt == false) { buttonD.Text = "в"; } else if (caps == true && alt == false) { buttonD.Text = "В"; } else if (caps == false && alt == true) { buttonD.Text = "в"; } else if (caps == true && alt == true) { buttonD.Text = "В"; }
                if (caps == false && alt == false) { buttonF.Text = "а"; } else if (caps == true && alt == false) { buttonF.Text = "А"; } else if (caps == false && alt == true) { buttonF.Text = "а"; } else if (caps == true && alt == true) { buttonF.Text = "А"; }
                if (caps == false && alt == false) { buttonG.Text = "п"; } else if (caps == true && alt == false) { buttonG.Text = "П"; } else if (caps == false && alt == true) { buttonG.Text = "п"; } else if (caps == true && alt == true) { buttonG.Text = "П"; }
                if (caps == false && alt == false) { buttonH.Text = "р"; } else if (caps == true && alt == false) { buttonH.Text = "Р"; } else if (caps == false && alt == true) { buttonH.Text = "р"; } else if (caps == true && alt == true) { buttonH.Text = "Р"; }
                if (caps == false && alt == false) { buttonJ.Text = "о"; } else if (caps == true && alt == false) { buttonJ.Text = "О"; } else if (caps == false && alt == true) { buttonJ.Text = "о"; } else if (caps == true && alt == true) { buttonJ.Text = "О"; }
                if (caps == false && alt == false) { buttonK.Text = "л"; } else if (caps == true && alt == false) { buttonK.Text = "Л"; } else if (caps == false && alt == true) { buttonK.Text = "л"; } else if (caps == true && alt == true) { buttonK.Text = "Л"; }
                if (caps == false && alt == false) { buttonL.Text = "д"; } else if (caps == true && alt == false) { buttonL.Text = "Д"; } else if (caps == false && alt == true) { buttonL.Text = "д"; } else if (caps == true && alt == true) { buttonL.Text = "Д"; }
                if (caps == false && alt == false) { buttonZ.Text = "я"; } else if (caps == true && alt == false) { buttonZ.Text = "Я"; } else if (caps == false && alt == true) { buttonZ.Text = "я"; } else if (caps == true && alt == true) { buttonZ.Text = "Я"; }
                if (caps == false && alt == false) { buttonX.Text = "ч"; } else if (caps == true && alt == false) { buttonX.Text = "Ч"; } else if (caps == false && alt == true) { buttonX.Text = "ч"; } else if (caps == true && alt == true) { buttonX.Text = "Ч"; }
                if (caps == false && alt == false) { buttonC.Text = "с"; } else if (caps == true && alt == false) { buttonC.Text = "С"; } else if (caps == false && alt == true) { buttonC.Text = "с"; } else if (caps == true && alt == true) { buttonC.Text = "С"; }
                if (caps == false && alt == false) { buttonV.Text = "м"; } else if (caps == true && alt == false) { buttonV.Text = "М"; } else if (caps == false && alt == true) { buttonV.Text = "м"; } else if (caps == true && alt == true) { buttonV.Text = "М"; }
                if (caps == false && alt == false) { buttonB.Text = "и"; } else if (caps == true && alt == false) { buttonB.Text = "И"; } else if (caps == false && alt == true) { buttonB.Text = "и"; } else if (caps == true && alt == true) { buttonB.Text = "И"; }
                if (caps == false && alt == false) { buttonN.Text = "т"; } else if (caps == true && alt == false) { buttonN.Text = "Т"; } else if (caps == false && alt == true) { buttonN.Text = "т"; } else if (caps == true && alt == true) { buttonN.Text = "Т"; }
                if (caps == false && alt == false) { buttonM.Text = "ь"; } else if (caps == true && alt == false) { buttonM.Text = "Ь"; } else if (caps == false && alt == true) { buttonM.Text = "ь"; } else if (caps == true && alt == true) { buttonM.Text = "Ь"; }
                //special buttons
                if (caps == false && alt == false) { button36.Text = "х"; } else if (caps == true && alt == false) { button36.Text = "Х"; } else if (caps == false && alt == true) { button36.Text = "х"; } else if (caps == true && alt == true) { button36.Text = "Х"; }
                if (caps == false && alt == false) { button37.Text = "ъ"; } else if (caps == true && alt == false) { button37.Text = "Ъ"; } else if (caps == false && alt == true) { button37.Text = "ъ"; } else if (caps == true && alt == true) { button37.Text = "Ъ"; }
                if (caps == false && alt == false) { button38.Text = "\\"; } else if (caps == true && alt == false) { button38.Text = "/"; } else if (caps == false && alt == true) { button38.Text = "\\"; } else if (caps == true && alt == true) { button38.Text = "/"; }
                if (caps == false && alt == false) { button21.Text = "ж"; } else if (caps == true && alt == false) { button21.Text = "Ж"; } else if (caps == false && alt == true) { button21.Text = "ж"; } else if (caps == true && alt == true) { button21.Text = "Ж"; }
                if (caps == false && alt == false) { button24.Text = "э"; } else if (caps == true && alt == false) { button24.Text = "Э"; } else if (caps == false && alt == true) { button24.Text = "э"; } else if (caps == true && alt == true) { button24.Text = "Э"; }
                if (caps == false && alt == false) { button12.Text = "б"; } else if (caps == true && alt == false) { button12.Text = "Б"; } else if (caps == false && alt == true) { button12.Text = "б"; } else if (caps == true && alt == true) { button12.Text = "Б"; }
                if (caps == false && alt == false) { button13.Text = "ю"; } else if (caps == true && alt == false) { button13.Text = "Ю"; } else if (caps == false && alt == true) { button13.Text = "ю"; } else if (caps == true && alt == true) { button13.Text = "Ю"; }
                if (caps == false && alt == false) { button14.Text = "."; } else if (caps == true && alt == false) { button14.Text = ","; } else if (caps == false && alt == true) { button14.Text = "."; } else if (caps == true && alt == true) { button14.Text = ","; }
                if (caps == false && alt == false) { button40.Text = "ё"; } else if (caps == true && alt == false) { button40.Text = "Ё"; } else if (caps == false && alt == true) { button40.Text = "ё"; } else if (caps == true && alt == true) { button40.Text = "Ё"; }
                //Numeric
                if (caps == false && alt == false) { button1.Text = "1"; } else if (caps == true && alt == false) { button1.Text = "!"; } else if (caps == false && alt == true) { button1.Text = "1"; } else if (caps == true && alt == true) { button1.Text = "!"; }
                if (caps == false && alt == false) { button2.Text = "2"; } else if (caps == true && alt == false) { button2.Text = "\""; } else if (caps == false && alt == true) { button2.Text = "2"; } else if (caps == true && alt == true) { button2.Text = "\""; }
                if (caps == false && alt == false) { button3.Text = "3"; } else if (caps == true && alt == false) { button3.Text = "№"; } else if (caps == false && alt == true) { button3.Text = "3"; } else if (caps == true && alt == true) { button3.Text = "№"; }
                if (caps == false && alt == false) { button4.Text = "4"; } else if (caps == true && alt == false) { button4.Text = ";"; } else if (caps == false && alt == true) { button4.Text = "4"; } else if (caps == true && alt == true) { button4.Text = ";"; }
                if (caps == false && alt == false) { button5.Text = "5"; } else if (caps == true && alt == false) { button5.Text = "%"; } else if (caps == false && alt == true) { button5.Text = "5"; } else if (caps == true && alt == true) { button5.Text = "%"; }
                if (caps == false && alt == false) { button6.Text = "6"; } else if (caps == true && alt == false) { button6.Text = ":"; } else if (caps == false && alt == true) { button6.Text = "6"; } else if (caps == true && alt == true) { button6.Text = ":"; }
                if (caps == false && alt == false) { button7.Text = "7"; } else if (caps == true && alt == false) { button7.Text = "?"; } else if (caps == false && alt == true) { button7.Text = "7"; } else if (caps == true && alt == true) { button7.Text = "?"; }
                if (caps == false && alt == false) { button8.Text = "8"; } else if (caps == true && alt == false) { button8.Text = "*"; } else if (caps == false && alt == true) { button8.Text = "8"; } else if (caps == true && alt == true) { button8.Text = "*"; }
                if (caps == false && alt == false) { button9.Text = "9"; } else if (caps == true && alt == false) { button9.Text = "("; } else if (caps == false && alt == true) { button9.Text = "9"; } else if (caps == true && alt == true) { button9.Text = "("; }
                if (caps == false && alt == false) { button0.Text = "0"; } else if (caps == true && alt == false) { button0.Text = ")"; } else if (caps == false && alt == true) { button0.Text = "0"; } else if (caps == true && alt == true) { button0.Text = ")"; }
                //numeric special
                if (caps == false && alt == false) { button50.Text = "-"; } else if (caps == true && alt == false) { button50.Text = "_"; } else if (caps == false && alt == true) { button50.Text = "-"; } else if (caps == true && alt == true) { button50.Text = "_"; }
                if (caps == false && alt == false) { button51.Text = "="; } else if (caps == true && alt == false) { button51.Text = "+"; } else if (caps == false && alt == true) { button51.Text = "="; } else if (caps == true && alt == true) { button51.Text = "+"; }
            }
            else if ( comboBox1.SelectedIndex==1)               //Buttons mapping for English
            {
                if (caps == false && alt == false) { buttonQ.Text = "q"; } else if (caps == true && alt == false) { buttonQ.Text = "Q"; } else if (caps == false && alt == true) { buttonQ.Text = "q"; } else if (caps == true && alt == true) { buttonQ.Text = "Q"; }
                if (caps == false && alt == false) { buttonW.Text = "w"; } else if (caps == true && alt == false) { buttonW.Text = "W"; } else if (caps == false && alt == true) { buttonW.Text = "w"; } else if (caps == true && alt == true) { buttonW.Text = "W"; }
                if (caps == false && alt == false) { buttonE.Text = "e"; } else if (caps == true && alt == false) { buttonE.Text = "E"; } else if (caps == false && alt == true) { buttonE.Text = "e"; } else if (caps == true && alt == true) { buttonE.Text = "E"; }
                if (caps == false && alt == false) { buttonR.Text = "r"; } else if (caps == true && alt == false) { buttonR.Text = "R"; } else if (caps == false && alt == true) { buttonR.Text = "r"; } else if (caps == true && alt == true) { buttonR.Text = "R"; }
                if (caps == false && alt == false) { buttonT.Text = "t"; } else if (caps == true && alt == false) { buttonT.Text = "T"; } else if (caps == false && alt == true) { buttonT.Text = "t"; } else if (caps == true && alt == true) { buttonT.Text = "T"; }
                if (caps == false && alt == false) { buttonY.Text = "y"; } else if (caps == true && alt == false) { buttonY.Text = "Y"; } else if (caps == false && alt == true) { buttonY.Text = "y"; } else if (caps == true && alt == true) { buttonY.Text = "Y"; }
                if (caps == false && alt == false) { buttonU.Text = "u"; } else if (caps == true && alt == false) { buttonU.Text = "U"; } else if (caps == false && alt == true) { buttonU.Text = "u"; } else if (caps == true && alt == true) { buttonU.Text = "U"; }
                if (caps == false && alt == false) { buttonI.Text = "i"; } else if (caps == true && alt == false) { buttonI.Text = "I"; } else if (caps == false && alt == true) { buttonI.Text = "i"; } else if (caps == true && alt == true) { buttonI.Text = "I"; }
                if (caps == false && alt == false) { buttonO.Text = "o"; } else if (caps == true && alt == false) { buttonO.Text = "O"; } else if (caps == false && alt == true) { buttonO.Text = "o"; } else if (caps == true && alt == true) { buttonO.Text = "O"; }
                if (caps == false && alt == false) { buttonP.Text = "p"; } else if (caps == true && alt == false) { buttonP.Text = "P"; } else if (caps == false && alt == true) { buttonP.Text = "p"; } else if (caps == true && alt == true) { buttonP.Text = "P"; }
                if (caps == false && alt == false) { buttonA.Text = "a"; } else if (caps == true && alt == false) { buttonA.Text = "A"; } else if (caps == false && alt == true) { buttonA.Text = "a"; } else if (caps == true && alt == true) { buttonA.Text = "A"; }
                if (caps == false && alt == false) { buttonS.Text = "s"; } else if (caps == true && alt == false) { buttonS.Text = "S"; } else if (caps == false && alt == true) { buttonS.Text = "s"; } else if (caps == true && alt == true) { buttonS.Text = "S"; }
                if (caps == false && alt == false) { buttonD.Text = "d"; } else if (caps == true && alt == false) { buttonD.Text = "D"; } else if (caps == false && alt == true) { buttonD.Text = "d"; } else if (caps == true && alt == true) { buttonD.Text = "D"; }
                if (caps == false && alt == false) { buttonF.Text = "f"; } else if (caps == true && alt == false) { buttonF.Text = "F"; } else if (caps == false && alt == true) { buttonF.Text = "f"; } else if (caps == true && alt == true) { buttonF.Text = "F"; }
                if (caps == false && alt == false) { buttonG.Text = "g"; } else if (caps == true && alt == false) { buttonG.Text = "G"; } else if (caps == false && alt == true) { buttonG.Text = "g"; } else if (caps == true && alt == true) { buttonG.Text = "G"; }
                if (caps == false && alt == false) { buttonH.Text = "h"; } else if (caps == true && alt == false) { buttonH.Text = "H"; } else if (caps == false && alt == true) { buttonH.Text = "h"; } else if (caps == true && alt == true) { buttonH.Text = "H"; }
                if (caps == false && alt == false) { buttonJ.Text = "j"; } else if (caps == true && alt == false) { buttonJ.Text = "J"; } else if (caps == false && alt == true) { buttonJ.Text = "j"; } else if (caps == true && alt == true) { buttonJ.Text = "J"; }
                if (caps == false && alt == false) { buttonK.Text = "k"; } else if (caps == true && alt == false) { buttonK.Text = "K"; } else if (caps == false && alt == true) { buttonK.Text = "k"; } else if (caps == true && alt == true) { buttonK.Text = "K"; }
                if (caps == false && alt == false) { buttonL.Text = "l"; } else if (caps == true && alt == false) { buttonL.Text = "L"; } else if (caps == false && alt == true) { buttonL.Text = "l"; } else if (caps == true && alt == true) { buttonL.Text = "L"; }
                if (caps == false && alt == false) { buttonZ.Text = "z"; } else if (caps == true && alt == false) { buttonZ.Text = "Z"; } else if (caps == false && alt == true) { buttonZ.Text = "z"; } else if (caps == true && alt == true) { buttonZ.Text = "Z"; }
                if (caps == false && alt == false) { buttonX.Text = "x"; } else if (caps == true && alt == false) { buttonX.Text = "X"; } else if (caps == false && alt == true) { buttonX.Text = "c"; } else if (caps == true && alt == true) { buttonX.Text = "C"; }
                if (caps == false && alt == false) { buttonC.Text = "c"; } else if (caps == true && alt == false) { buttonC.Text = "С"; } else if (caps == false && alt == true) { buttonC.Text = "с"; } else if (caps == true && alt == true) { buttonC.Text = "С"; }
                if (caps == false && alt == false) { buttonV.Text = "v"; } else if (caps == true && alt == false) { buttonV.Text = "V"; } else if (caps == false && alt == true) { buttonV.Text = "v"; } else if (caps == true && alt == true) { buttonV.Text = "V"; }
                if (caps == false && alt == false) { buttonB.Text = "b"; } else if (caps == true && alt == false) { buttonB.Text = "B"; } else if (caps == false && alt == true) { buttonB.Text = "n"; } else if (caps == true && alt == true) { buttonB.Text = "N"; }
                if (caps == false && alt == false) { buttonN.Text = "n"; } else if (caps == true && alt == false) { buttonN.Text = "N"; } else if (caps == false && alt == true) { buttonN.Text = "n"; } else if (caps == true && alt == true) { buttonN.Text = "N"; }
                if (caps == false && alt == false) { buttonM.Text = "m"; } else if (caps == true && alt == false) { buttonM.Text = "M"; } else if (caps == false && alt == true) { buttonM.Text = "m"; } else if (caps == true && alt == true) { buttonM.Text = "M"; }
                //special buttons
                if (caps == false && alt == false) { button36.Text = "["; } else if (caps == true && alt == false) { button36.Text = "{"; } else if (caps == false && alt == true) { button36.Text = "["; } else if (caps == true && alt == true) { button36.Text = "{"; }
                if (caps == false && alt == false) { button37.Text = "]"; } else if (caps == true && alt == false) { button37.Text = "}"; } else if (caps == false && alt == true) { button37.Text = "]"; } else if (caps == true && alt == true) { button37.Text = "}"; }
                if (caps == false && alt == false) { button38.Text = "\\"; } else if (caps == true && alt == false) { button38.Text = "|"; } else if (caps == false && alt == true) { button38.Text = "\\"; } else if (caps == true && alt == true) { button38.Text = "|"; }
                if (caps == false && alt == false) { button21.Text = ";"; } else if (caps == true && alt == false) { button21.Text = ":"; } else if (caps == false && alt == true) { button21.Text = ";"; } else if (caps == true && alt == true) { button21.Text = ":"; }
                if (caps == false && alt == false) { button24.Text = "'"; } else if (caps == true && alt == false) { button24.Text = "\""; } else if (caps == false && alt == true) { button24.Text = "'"; } else if (caps == true && alt == true) { button24.Text = "\""; }
                if (caps == false && alt == false) { button12.Text = ","; } else if (caps == true && alt == false) { button12.Text = "<"; } else if (caps == false && alt == true) { button12.Text = ","; } else if (caps == true && alt == true) { button12.Text = "<"; }
                if (caps == false && alt == false) { button13.Text = "."; } else if (caps == true && alt == false) { button13.Text = ">"; } else if (caps == false && alt == true) { button13.Text = "."; } else if (caps == true && alt == true) { button13.Text = ">"; }
                if (caps == false && alt == false) { button14.Text = "/"; } else if (caps == true && alt == false) { button14.Text = "?"; } else if (caps == false && alt == true) { button14.Text = "/"; } else if (caps == true && alt == true) { button14.Text = "?"; }
                if (caps == false && alt == false) { button40.Text = "`"; } else if (caps == true && alt == false) { button40.Text = "~"; } else if (caps == false && alt == true) { button40.Text = "`"; } else if (caps == true && alt == true) { button40.Text = "~"; }
                //Numeric
                if (caps == false && alt == false) { button1.Text = "1"; } else if (caps == true && alt == false) { button1.Text = "!"; } else if (caps == false && alt == true) { button1.Text = "1"; } else if (caps == true && alt == true) { button1.Text = "!"; }
                if (caps == false && alt == false) { button2.Text = "2"; } else if (caps == true && alt == false) { button2.Text = "@"; } else if (caps == false && alt == true) { button2.Text = "2"; } else if (caps == true && alt == true) { button2.Text = "@"; }
                if (caps == false && alt == false) { button3.Text = "3"; } else if (caps == true && alt == false) { button3.Text = "#"; } else if (caps == false && alt == true) { button3.Text = "3"; } else if (caps == true && alt == true) { button3.Text = "#"; }
                if (caps == false && alt == false) { button4.Text = "4"; } else if (caps == true && alt == false) { button4.Text = "$"; } else if (caps == false && alt == true) { button4.Text = "4"; } else if (caps == true && alt == true) { button4.Text = "$"; }
                if (caps == false && alt == false) { button5.Text = "5"; } else if (caps == true && alt == false) { button5.Text = "%"; } else if (caps == false && alt == true) { button5.Text = "5"; } else if (caps == true && alt == true) { button5.Text = "%"; }
                if (caps == false && alt == false) { button6.Text = "6"; } else if (caps == true && alt == false) { button6.Text = "^"; } else if (caps == false && alt == true) { button6.Text = "6"; } else if (caps == true && alt == true) { button6.Text = "^"; }
                if (caps == false && alt == false) { button7.Text = "7"; } else if (caps == true && alt == false) { button7.Text = "&"; } else if (caps == false && alt == true) { button7.Text = "7"; } else if (caps == true && alt == true) { button7.Text = "&"; }
                if (caps == false && alt == false) { button8.Text = "8"; } else if (caps == true && alt == false) { button8.Text = "*"; } else if (caps == false && alt == true) { button8.Text = "8"; } else if (caps == true && alt == true) { button8.Text = "*"; }
                if (caps == false && alt == false) { button9.Text = "9"; } else if (caps == true && alt == false) { button9.Text = "("; } else if (caps == false && alt == true) { button9.Text = "9"; } else if (caps == true && alt == true) { button9.Text = "("; }
                if (caps == false && alt == false) { button0.Text = "0"; } else if (caps == true && alt == false) { button0.Text = ")"; } else if (caps == false && alt == true) { button0.Text = "0"; } else if (caps == true && alt == true) { button0.Text = ")"; }
                //numeric special
                if (caps == false && alt == false) { button50.Text = "-"; } else if (caps == true && alt == false) { button50.Text = "_"; } else if (caps == false && alt == true) { button50.Text = "-"; } else if (caps == true && alt == true) { button50.Text = "_"; }
                if (caps == false && alt == false) { button51.Text = "="; } else if (caps == true && alt == false) { button51.Text = "+"; } else if (caps == false && alt == true) { button51.Text = "="; } else if (caps == true && alt == true) { button51.Text = "+"; }
            }
            //  =============================================================================== End of Buttons Mapping ========================================================================================================================================//
        }




        // ============================== Physical Keyboard Keys Press Events ===================================== //
        private void OnScreenKeyboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) parent.translateButton_Click(sender, e);

        }
        // ============================== END OF Physical Keyboard Keys Press Events ===================================== //









        // ================================= KEY EVENTS ASSIGMENT ================================= //
        // Make sure all keys are changed properly
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyAssigment();
        }



        //Alpha keys
        private void buttonQ_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonQ.Text;
        }
        private void buttonW_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonW.Text;
        }
        private void buttonE_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonE.Text;
        }
        private void buttonR_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonR.Text;
        }
        private void buttonT_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonT.Text;
        }
        private void buttonY_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonY.Text;
        }
        private void buttonU_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonU.Text;
        }
        private void buttonI_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonI.Text;
        }
        private void buttonO_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonO.Text;
        }
        private void buttonP_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonP.Text;
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonA.Text;
        }
        private void buttonS_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonS.Text;
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonD.Text;
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonF.Text;
        }
        private void buttonG_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonG.Text;
        }
        private void buttonH_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonH.Text;
        }
        private void buttonJ_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonJ.Text;
        }
        private void buttonK_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonK.Text;
        }
        private void buttonL_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonL.Text;
        }
        private void buttonZ_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonZ.Text;
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonX.Text;
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonC.Text;
        }
        private void buttonV_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonV.Text;
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonB.Text;
        }
        private void buttonN_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonN.Text;
        }
        private void buttonM_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonM.Text;
        }



        //Special sign keys
        private void buttonSpacebar_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += buttonSpacebar.Text;
        }
        private void button40_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button40.Text;
        }
        private void button36_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button36.Text;
        }
        private void button37_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button37.Text;
        }
        private void button38_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button38.Text;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button21.Text;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button12.Text;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button13.Text;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button14.Text;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button24.Text;
        }




        //Numeric Keys
        private void button1_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button9.Text;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button0.Text;
        }



        //Numeric Keys Special
        private void button50_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button50.Text;
        }
        private void button51_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button51.Text;
        }



        //Functional KEYS
        private void buttonShift_Click(object sender, EventArgs e)
        {
            switch(caps)
            {
                case true:
                    caps = false;
                    buttonShift.BackColor = default;
                break;
                case false:
                    caps = true;
                    buttonShift.BackColor = Color.White;
                break;
            }
            keyAssigment();
        }
        private void buttonAlt_Click(object sender, EventArgs e)
        {
            switch (alt)
            {
                case true:
                    alt = false;
                    buttonAlt.BackColor = default;
                break;
                case false:
                    alt = true;
                    buttonAlt.BackColor = Color.White;
                break;
            }
            keyAssigment();
        }
        private void translateButton_Click_1(object sender, EventArgs e)
        {
            parent.translateButton_Click(sender, e);

        }
        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (parent.inputBox.Text != "") { parent.inputBox.Text = parent.inputBox.Text.Remove(parent.inputBox.Text.Length - 1); }
        }
        // ============================================= END OF KEY Events Assigment ============================================================== //
    }
}
