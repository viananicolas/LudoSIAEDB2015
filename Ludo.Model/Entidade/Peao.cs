using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Model.Entidade
{

    /*Devo inicializar os valores para cada peão de cada base. Ex: Peao Azul 1: Posição -1 [Na base], Restam 54 [Porque ele ainda não está nos quadrados
     * nem na linha de chegada]. A classe deverá ser abstrada, com um construtor inicializando os valores quando um novo jogo for iniciado. 
    */
    public abstract class Peao
    {
        private bool bNovoJogo;
        private string strCor;
        private int inumBase;
        private int[][] inumChegada;
        private int[][] iblocosRestantes;

       // public string Cor { get { return strCor;} set; }

        /*private static void InicializaValores(bool newGame)
        {
            if(newGame)
            {
               
            }
        }*/
    }
}
