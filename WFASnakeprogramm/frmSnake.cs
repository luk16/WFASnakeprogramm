using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASnakeprogramm
{
    public partial class frmSnake : Form
    {


        List<Snake> Schlange = new List<Snake>();
         Snake Fressen = new Snake();


      


    
        


        public frmSnake()
        {
            InitializeComponent();
            new Einstellungen();

            tmschlange.Interval = 1000 / Einstellungen.speed;
            tmschlange.Tick += Bildupdate;
            tmschlange.Start();


            Start_Spiel();

        }

        
        private void Start_Spiel()
        {

            new Einstellungen();

            Schlange.Clear();
            Snake Kopf = new Snake { intx= 10, inty = 5 };
            Schlange.Add(Kopf);





        }
        












        /*
        private void cmdstarten_Click(object sender, EventArgs e)
        {

            int intXkre = rnd.Next(1, 300);
            int intYkre = rnd.Next(1, 300);

            Fressen.Snakekreise(pbsnake, intXkre, intYkre);
       


        }

        private void cmdende_Click(object sender, EventArgs e)
        {

            pbsnake.Image = null;

            MessageBox.Show(" Sie haben so viele Punkte erreicht");



        }

        private void frmSnake_KeyPress(object sender, KeyPressEventArgs e)
        {

            int intxschlange = rnd.Next(1, 300);
            int intyschlange = rnd.Next(1, 300);

           



            if (e.KeyChar == 'w')
            {

                Fressen.Snakeschlange(pbsnake, intxschl ,intyschl - 5);
                Fressen.Snakeloeschen(pbsnake, intxschl ,intyschl - 5);

                intyschl = intyschl + 5;
                
            }

           if (e.KeyChar == 's')
            {
                Fressen.Snakeschlange(pbsnake, intxschl ,intyschl + 5);
                Fressen.Snakeloeschen(pbsnake, intxschl ,intyschl + 5);
                intyschl = intyschl - 5;

            }

            if (e.KeyChar == 'd')
            {
                Fressen.Snakeschlange(pbsnake, intxschl + 5, intyschl);
                Fressen.Snakeloeschen(pbsnake, intxschl + 5, intyschl);
                intxschl = intxschl + 5;


            }

            if (e.KeyChar == 'a')
            {
                Fressen.Snakeschlange(pbsnake, intxschl - 5, intyschl);
                Fressen.Snakeloeschen(pbsnake, intxschl - 5, intyschl);
                intxschl = intxschl - 5;


            }

        }

 
    */
    }
    }

