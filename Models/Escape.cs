using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaEscape.Models
{
    static public class Escape
    {
        static List <string> IncognitasSalas=  new List <string>{} ;
        //lo pusimos en el controller
        private static int _estadoJuego=1;
       
       public static int EstadoJuego
        {
            get
            {
                return _estadoJuego;
            }
        }

        public static void IniciarJuego()
        {
            _estadoJuego = 1;
        }

        static void InicializarLista()
        {
            IncognitasSalas.Add("");
            string incognita1 = "1997-06-26";
            IncognitasSalas.Add(incognita1);
            string incognita2 = "6";
            IncognitasSalas.Add(incognita2);
            string incognita3 = "Gryffindor";
            IncognitasSalas.Add(incognita3);
            string incognita4 = "humano";
            IncognitasSalas.Add(incognita4);
        }

        public static bool ResolverSala(int Sala, string Incognita)
        {
            InicializarLista();
            if (IncognitasSalas[Sala] == Incognita)
            {
                _estadoJuego = Sala+1;
                return true;
            }
            else
            {
                _estadoJuego = Sala;
                return false;              
            }

        }
         
    }
}