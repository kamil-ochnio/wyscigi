using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace wyscigi
{
    public class Guy
    {
        public string Name;
        public Bet myBet;
        public int Cash;

        RadioButton myRadioButton;
        Label myLabel;
        public void UpdateLabel()
        {
            //myBet = 0;
        }

        public bool PlaceBet(int Amount,int DogToWin)
        {
            //ustal nowy zakład
            return true;//jeli ma wystarczjaca ilosc pieniedzy
        }

        public void Collect(int Winner)
        {
            //popros o wyplate i zaktualizuj etykiety
        }
    }

}
