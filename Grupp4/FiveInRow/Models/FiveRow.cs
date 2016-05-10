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



            for (int i = 0; i < 6; i++)
            {
                if (Strings[i, tal] != PlayerColor || Strings[i, tal] == ComputerColor)
                {
                    Strings[i, tal] = PlayerColor;


                }

            }


        }

    }
}