using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grupp4.Models  
{
    public class Game1Model
    {
        private int currentValue;
        public int CurrentValue
        {
            get { return currentValue; }
            set
            {
                if (currentValue > 21)
                {
                    currentValue = 0;
                }
                else
                    currentValue = value;
            }
        }
        public int ChoosenNumber { get; set; }
        public int Computer { get; set; }
        public bool PlayerIsWinner()
        {
            if (CurrentValue >= 21)
            {
                return true;
            }

            
            return false;
        }
        public bool ComputerIsWinner()
        {
            if (CurrentValue >= 21)
            {
                return true;
            }
           
            return false;
        }
        public int ComputerLogic()
        {
            if (CurrentValue % 3 == 0)
            {
               Computer += 1;
            }
            else if (CurrentValue % 3 == 1)
            {
                Computer += 2;
            }
            else if (CurrentValue % 3 == 2)
            {
                Computer += 1;
            }
            return Computer;
        }
        public void Start()
        {
            CurrentValue = 0;
        }
        public int PlayerAddCurrentValue()
        {
            CurrentValue += ChoosenNumber;
            return CurrentValue;
        }

        public int ComputerAddCurrentValue()
        {
            ComputerLogic();
            CurrentValue += Computer;
            return CurrentValue;
        }
    }
}