using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Message
    {

        private DateTime now = DateTime.Now;
        private int morning, afternoon, night;
        

         public Message()
        {

        }
        // constructeur de paramètre mes jours de la semaine
        public Message(DateTime now)
        {

            this.now = now;

        }
        //constructeur des paramètre de la date et des tranches horaire
        public Message(DateTime now ,  int morning = 9, int afternoon = 13, int night = 18 )
        {

            this.morning = morning;
            this.afternoon = afternoon;
            this.night = night;
            this.now = now;

        }


        public string GetHelloMessage()
    {

         

        if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)

        {

            return "Bon week-end ";
           
        }

        else

        {

            if (now.DayOfWeek == DayOfWeek.Monday && now.Hour <morning)

            {

                return "Bon week-end ";
               

            }

            else

            {

                if (now.Hour >=morning && now.Hour < afternoon)

                {

                    return "Bonjour ";
                   

                }
                else if (now.Hour >= afternoon && now.Hour < night)
                {
                    return "Bonne après-midi ";
                    
                }


                else

                {
                    if (now.DayOfWeek == DayOfWeek.Friday && now.Hour >= night)

                    {

                        return "Bon week-end " ;
                        

                    }

                    else

                    {

                        return "Bonsoir " ;
                        

                    }

                }

            }

        }

    }
}

}
