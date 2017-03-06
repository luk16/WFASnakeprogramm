using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WFASnakeprogramm
{
    class Spieler
    {

        private Hashtable keytable = new Hashtable();


        public bool KeyPressed(Keys key)
        {

            if (keytable[key] == null)
            {
                return false;


            }

            return (bool)keytable[key];


        }

        public void Wechseln(Keys key, bool strate)
            {

            keytable[key] = strate;
            }








    }
}
