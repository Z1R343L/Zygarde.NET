using System;
using System.Collections.Generic;
using System.Text;
using Discord;

namespace SysBot.Pokemon.Discord.Helpers
{
    public class Colors
    {
         public static Color Catch()
        {
            Random catch_slot_rnd = new Random();
            int color_slot = catch_slot_rnd.Next(1, 14);
            int r = 255;
            int g = 0;
            int b = 0;
            if (color_slot == 1)
            {
                r = 250;
                g = 214;
                b = 175;
            }
            if (color_slot == 2)
            {
                r = 169;
                g = 225;
                b = 249;
            }
            if (color_slot == 3)
            {
                r = 169;
                g = 249;
                b = 222;
            }
            if (color_slot == 4)
            {
                r = 221;
                g = 159;
                b = 181;
            }
            if (color_slot == 5)
            {
                r = 159;
                g = 181;
                b = 221;
            }
            if (color_slot == 6)
            {
                r = 232;
                g = 240;
                b = 203;
            }
            if (color_slot == 7)
            {
                r = 230;
                g = 203;
                b = 240;
            }
            if (color_slot == 8)
            {
                r = 159;
                g = 89;
                b = 110;
            }
            if (color_slot == 9)
            {
                r = 159;
                g = 103;
                b = 89;
            }
            if (color_slot == 10)
            {
                r = 225;
                g = 207;
                b = 193;
            }
            if (color_slot == 11)
            {
                r = 225;
                g = 223;
                b = 193;
            }
            if (color_slot == 12)
            {
                r = 211;
                g = 225;
                b = 193;
            }
            if (color_slot == 13)
            {
                r = 195;
                g = 225;
                b = 193;
            }
            Color Catch = new Color(r, g, b);
            return Catch;
        }

        public static Color Fail()
        {
            Color Fail = new Color(126, 58, 154);
            return Fail;
        }

        public static Color Main()
        {
            Random main_slot_rnd = new Random();
            int main_slot = main_slot_rnd.Next(1, 5);
            int main_r = 255;
            int main_g = 0;
            int main_b = 0;
            if(main_slot == 1)
            {
                main_r = 217;
                main_g = 219;
                main_b = 224;
            }
            if(main_slot==2)
            {
                main_r = 14;
                main_g = 129;
                main_b = 117;
            }
            if(main_slot==3)
            {
                main_r = 189;
                main_g = 58;
                main_b = 83;
            }
            if(main_slot==4)
            {
                main_r = 100;
                main_g = 132;
                main_b = 132;
            }
            Color Main = new Color(main_r, main_g, main_b);
            return Main;
        }

        public static Color Gift()
        {
            Color Gift = new Color(255, 89, 178);
            return Gift;
        }
    }
}
