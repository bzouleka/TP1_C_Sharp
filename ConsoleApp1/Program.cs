using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Date { get; private set; }

        static void Main(string[] args)
        {
            Message message = new Message();

            var now = new DateTime(2018, 6, 17, 18, 12,32);

            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)

            {
                
                message.AfficherBonWeekEnd();

            }

            else

            {
                
                if (now.DayOfWeek == DayOfWeek.Monday && now.Hour < 9)

                {
                    
                    message.AfficherBonWeekEnd();

                }

                else

                {

                    if (now.Hour >= 9 && now.Hour < 13)

                    {
                        
                        message.AfficherBonjour();

                    } else if (now.Hour >= 13 && now.Hour < 18)
                    {
                        message.AfficherBonneApresMidi();
                    }

                    else

                    {
                        if (now.DayOfWeek == DayOfWeek.Friday && now.Hour >= 18)

                        {

                            message.AfficherBonWeekEnd();

                        }

                        else

                        {

                            message.AfficherBonsoir();

                        }

                    }

                }

            }

        }


        


    }
}
