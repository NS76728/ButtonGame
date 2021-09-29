using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButtonGame.Models
{
    public class UpdateButton : IUpdateButton
    {
        public UpdateButton()
        {

        }

        public void Choice(int guess)
        {
            if(guess ==Button.BadButton)
            {
                ScoreReset();
            }
            else
            {
                ScoreIncrease();
            }
        }

        public void GenerateBadButton()
        {
            var rando = new Random();
            Button.BadButton = rando.Next(1, 4);
        }

        public void ScoreIncrease()
        {
            Button.Score++;
        }

        public void ScoreReset()
        {
            if (Button.Score > Button.HighScore)
                Button.HighScore = Button.Score;
            Button.Score = 0;

        }
    }
}
