using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace AI_Translator
{
    internal class TextToSpeech
    {
        public TextToSpeech(string whatShouldIRead, int selectedOutputLanguage)
        {
            //checkVoices();                              //Function to check what voices are installed in ur system
            if (whatShouldIRead != null)
            {
                try
                {
                    SpeechSynthesizer speak = new SpeechSynthesizer();

                    switch (selectedOutputLanguage)
                    {
                        case 0:
                            speak.SelectVoice("Microsoft Paulina Desktop");
                            break;
                        case 1:
                            speak.SelectVoice("Microsoft Zira Desktop");
                            break;
                        case 2:
                            speak.SelectVoice("Microsoft Hortense Desktop");
                            break;
                        case 3:
                            speak.SelectVoice("Microsoft Irina Desktop");
                            break;
                        case 4:
                            speak.SelectVoice("Microsoft Hedda Desktop");
                            break;
                    }

                    speak.SetOutputToDefaultAudioDevice();
                    speak.SpeakAsync(whatShouldIRead);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        public void checkVoices()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                MessageBox.Show(" Name:          " + info.Name);
                MessageBox.Show(" Culture:       " + info.Culture);
            }
        }
    }
}
