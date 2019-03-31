/*
 * Conner Warboys
 * Converts Ottawa time to time in different time zones
 * March 28th, 2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace _185338GoodTimes
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

        private void btnTimeFinder_Click(object sender, RoutedEventArgs e)
        {
            string TextEntered = txtTime.Text;
            int Ottawa = 0;
            int.TryParse(txtTime.Text, out Ottawa);
            /* Telling the program how to get the time values of each city
               based off of Ottawa time
            */

            int Victoria = Ottawa - 300;
            int Edmonton = Ottawa - 200;
            int Winnipeg = Ottawa - 100;
            int Toronto = Ottawa;
            int Halifax = Ottawa + 100;
            int StJohns = Ottawa + 130 ;
            if (Victoria % 100 > 59) Victoria = Victoria - 60 + 100;
            if (Victoria <= 0)
            {
                Victoria += 2400;
            }
            if (Edmonton % 100 > 59) Edmonton = Edmonton - 60 + 100;
            if (Edmonton <= 0)
            {
                Edmonton += 2400;
            }
            if (Winnipeg % 100 > 59) Winnipeg = Winnipeg - 60 + 100;
            if (Winnipeg <= 0)
            {
                Winnipeg += 2400;
            }
            if (Toronto % 100 > 59) Toronto = Toronto - 60 + 100;
            if (Toronto <= 0)
            {
                Toronto += 2400;
            }
            if (Halifax % 100 > 59) Halifax = Halifax - 60 + 100;
            if (Halifax >= 2400)
            {
                Halifax -= 2400;
            }
            if (StJohns % 100 > 59) StJohns = StJohns - 60 + 100;
            if (StJohns >= 2400)
            {
                StJohns -= 2400;
            }
            if (Ottawa % 100 > 59) Ottawa = Ottawa - 60 + 100;
            /* Had to do the oposite of the others when stateing the max time 
               because Halifax and St'Johns are ahead and not behind so you 
               have to worry about it going above 2400 and not below 0
            */


            lblOuput.Content += Ottawa + " In Ottawa" + "\r" + "\n";
            lblOuput.Content += Victoria + " In Victoria" + "\r" + "\n";
            lblOuput.Content += Edmonton + " In Edmonton" + "\r" + "\n";
            lblOuput.Content += Winnipeg + " In Winnipeg" + "\r" + "\n";
            lblOuput.Content += Toronto + " In Toronto" + "\r" + "\n";
            lblOuput.Content += Halifax + " In Halifax" + "\r" + "\n";
            lblOuput.Content += StJohns + " In St. John's" + "\r" + "\n";
            /* Tells program to show the time value in the specific city for
               the input that the user added and then adds an new line
            */
        }
    }
}
