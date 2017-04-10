using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Seat_Reservation
{
    class seatLocation
    {

        public string addSeatAlphabet(int locationY)
        {
            if (locationY == 0)
            {
                return "A ";
            }
            else if (locationY == 30)
            {
                return "B ";
            }
            else if (locationY == 60)
            {
                return "C ";
            }
            else if (locationY == 120)
            {
                return "D ";
            }
            else if (locationY == 150)
            {
                return "E ";
            }
            else if (locationY == 180)
            {
                return "F ";
            }
            else if (locationY == 210)
            {
                return "G ";
            }
            else if (locationY == 240)
            {
                return "H ";
            }
            else if (locationY == 270)
            {
                return "I ";
            }

            else
                return " ";
        }

        public int setJ(string item)
        {
            if (item.Contains("1"))
            {
                if (item.Contains("10"))
                {
                    return 9;
                }
                else if (item.Contains("11"))
                {
                    return 10;
                }
                else if (item.Contains("12"))
                {
                    return 11;
                }
                else if (item.Contains("13"))
                {
                    return 12;
                }
                else if (item.Contains("14"))
                {
                    return 13;
                }
                else if (item.Contains("15"))
                {
                    return 14;
                }
                else if (item.Contains("16"))
                {
                    return 15;
                }
                else
                {
                    return 0;
                }
            }
            else if (item.Contains("2"))
            {
                return 1;
            }
            else if (item.Contains("3"))
            {
                return 2;
            }
            else if (item.Contains("4"))
            {
                return 3;
            }
            else if (item.Contains("5"))
            {
                return 4;
            }
            else if (item.Contains("6"))
            {
                return 5;
            }
            else if (item.Contains("7"))
            {
                return 6;
            }
            else if (item.Contains("8"))
            {
                return 7;
            }
            else if (item.Contains("9"))
            {
                return 8;
            }
            return -1;
        }

        public int setI(string item)
        {
            if (item.Contains('A'))
            {
                return 0;
            }
            else if (item.Contains('B'))
            {
                return 1;
            }
            else if (item.Contains('C'))
            {
                return 2;
            }
            else if (item.Contains('D'))
            {
                return 4;
            }
            else if (item.Contains('E'))
            {
                return 5;
            }
            else if (item.Contains('F'))
            {
                return 6;
            }
            else if (item.Contains('G'))
            {
                return 7;
            }
            else if (item.Contains('H'))
            {
                return 8;
            }
            else if (item.Contains('I'))
            {
                return 9;
            }
            else
            {
                return -1;
            }
        }

    }
}
