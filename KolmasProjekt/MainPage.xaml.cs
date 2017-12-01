using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KolmasProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static int attempt = 3;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string username = textbox1.Text;
            string password = passwordbox1.Password;

            if ((this.textbox1.Text == "Kasutaja") && (this.passwordbox1.Password == "Passw0rd" && attempt <=0))
            {
                
                textblock2.Text = "Sisselogimene õnnestus";
            }
            else if(attempt <= 3)
            {
                textblock2.Text = ("Sul on jäänud " + Convert.ToString(attempt) + " katset veel");
                attempt = attempt - 1;
                
            }

            else if (attempt >= 3 )
            {
                textblock2.Text = "Sisselogimine on keelatud";
            }
        }
    }
}
