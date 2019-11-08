using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Media
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep();
            Console.Beep(100, 2000);
        }
        private SpeechSynthesizer synth = new SpeechSynthesizer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = new Uri(@"C:\Users\Michael\Desktop\video.mkv");
            mediaElement.LoadedBehavior = MediaState.Manual;
            // mediaElement.Play();

            foreach (var voice in synth.GetInstalledVoices())
            {
                comboBoxVoices.Items.Add(voice.VoiceInfo.Name);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            synth.SelectVoice(comboBoxVoices.Text);
            synth.Speak(textBoxInhalt.Text);
        }
    }
}
