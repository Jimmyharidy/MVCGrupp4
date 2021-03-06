﻿using System;

namespace Game21V2.Models
{
    public class GameOf21
    {
        public int Total { get; set; } = 0;
        public string Announcement { get; set; }

        public void AddNr(int tal)
        {
            if (Total <= 21)
            {
                Total += tal;
                if (Total == 21)
                {
                    Announcement = "You Win!!";
                }
            }

            Computer();
        }

        private void Computer()
        {
            if (Total >= 12)
            {
                Total += (Total + 1)%3 == 0 ? 1 : 2;
                if (Total == 21)
                {
                    Announcement = "Computer Won!!";
                }
            }

            if (Total < 12)
            {
                var random = new Random();
                Total += random.Next(1, 3);
            }
        }
    }
}