using System.Drawing;
using System.Web.UI.WebControls;

namespace FiveInRow.Models
{
    public class FiveRow
    {
        public int[,] Board { get; set; } = new int[7,6];
        //Alternativ
        //public Button[,] Buttons { get; set; } = new Button[7,6];
        public string Color { get; set; } = "";
        public string PlayerColor { get; set; } = "blue";
        public string ComputerColor { get; set; } = "red";

        public string ChangeColor(int i, int j)
        {
            if (i == 1 && j == 1)
            {
                Color = PlayerColor;
                return Color;
            }


            return "";
        }

    }
}