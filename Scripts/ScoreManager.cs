using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Static
{
    public static class ScoreManager
    {
        public static float score;
        public static void ResetScore()
        {
            score = 0;
        }
    }
}
