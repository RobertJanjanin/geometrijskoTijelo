using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrijskoTijeloKlase
{
    class GeometrijskoTijelo
    {
     
        static int brojacTijela;
         double volumen;
        double oplosje;
        public static int BrojacTijela { get => brojacTijela; set => brojacTijela = value; }


        public double Volumen { get => volumen; set => volumen = value; }

        public double Oplosje { get => oplosje; set => oplosje = value; }

       
        
        public GeometrijskoTijelo()
        {

          BrojacTijela++;
            
        }
       
    }
}