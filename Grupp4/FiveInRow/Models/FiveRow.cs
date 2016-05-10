using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web.Helpers;
using System.Web.UI.WebControls;

namespace FiveInRow.Models
{
    public class FiveRow
    {
        public int[,] Board { get; set; } = new int[6, 7];
        public string[,] Strings { get; set; } = new string[6, 7];
        public string PlayerColor { get; set; } = "blue";
        public string ComputerColor { get; set; } = "red";





        public void Test1(int tal)
        {

            for (int i = 5; i >= 0 ; i--)
            {
                if (Strings[i, tal] != PlayerColor || Strings[i, tal] != ComputerColor)
                {
                    if (Strings[i, tal] == null)
                    {
                        Strings[i, tal] = PlayerColor;
                        break;
                    }
                    
                    
                                       
                }
            }
            ComputerMove();

        }

        private void ComputerMove()
        {
            Random random = new Random();
            var rnd = random.Next(0, 6);

            for (int i = 5; i >= 0; i--)
            {
                if (Strings[i, rnd] != PlayerColor || Strings[i, rnd] != ComputerColor)
                {
                    if (Strings[i, rnd] == null)
                    {
                        Strings[i, rnd] = ComputerColor;
                        break;
                    }

                }
            }

        }
    }
}