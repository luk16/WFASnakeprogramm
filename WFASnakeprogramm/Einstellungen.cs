using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFASnakeprogramm
{

    public enum Direction

    {


        UP,
        Down,
        Left,
        Right,


    }


     public class Einstellungen
    {
        public static int Breite { get; set; }
        public static int Hoehe { get; set; }
        public static int  speed { get; set; }
        public static int Spielstand { get; set; }
        public static  int Punkte { get; set; }
        public static bool Spielende { get; set; }
        public static Direction direction {get;set;}





        public Einstellungen()
        {



            Breite = 18;
            Hoehe = 18;
            speed = 10;
            Spielstand = 0;
            Punkte = 50;
            Spielende = false;
            direction = Direction.Down;






        }




    }
}
