using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyscigi
{
    public class Greyhound
    {
        int StartingPossition;
        int RacetrackLength;//dlugosc trasy
        PictureBox MyPictureBox;
        int Location = 0;
        Random MyRandom;

        public bool Run()
        {
            Location += MyRandom.Next(1, 4);
            //aktualizujemy połozenie pictureBox na formularzu

            if (Location >= RacetrackLength)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            //zerujemyy połozenie pictureBox na formularzu

        }
    }
}
