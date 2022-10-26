using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Target_Teste
{
    internal class Info
    {
        private int fibonacci; // Campo

        public int _Fibonacci   // Propriedade
        {
            get { return fibonacci; }   // get metodo
            set { fibonacci = value; }  // set metodo
        }

        private string reversesort; // Campo

        public string _Reversesort   // Propriedade
        {
            get { return reversesort; }   // get metodo
            set { reversesort = value; }  // set metodo
        }

        private ArrayList arrayinteiro; // Campo

        public ArrayList _Arrayinteiro   // Propriedade
        {
            get { return arrayinteiro; }   // get metodo
            set { arrayinteiro = value; }  // set metodo
        }


     
        public void Reverse()
        {


          
            char[] arraycaracter = _Reversesort.ToCharArray(); // Criação 1 array
            char[] arraycaracter2 = _Reversesort.ToCharArray();  //cópia do 1 array para inversão de valores

            int contadorauxiliar = arraycaracter.Length - 1; // Contando o número máximo do array (ex 3) porém do 0 até o 2 não existe o 3 então -1.

            for (int i = 0; i < arraycaracter.Length; i++) // For da quantidade de caracteres no array
            {
                arraycaracter2[i] = arraycaracter[contadorauxiliar]; // Inversão do maior para o menor (ex casa 3 do array 1 vai apra a casa 1 do array2)

                contadorauxiliar--; //decremento da inversão
            }

            reversesort = "";
            foreach (char c in arraycaracter2) // para cada char no array 2 
            {
                reversesort += c;
              
            }

            
            
           



        }

     

        public ArrayList fibo()
        {
            int numanterior = 0, numatual = 1;
            var arrayinteiro = new ArrayList(); // construção array

            
            for (int i = 0; i <_Fibonacci; i++) // inicio contador

            {
                numatual += numanterior; //  soma do número atual com anterior
                numanterior = numatual - numanterior; //  atribuição do atual com a subtração do anterior
                arrayinteiro.Add(numatual); //  populando o arraylist


            }
            _Arrayinteiro = arrayinteiro;
          

            if (_Arrayinteiro.ToArray().Contains(_Fibonacci)) // verificando se o número digitado está presente no array list
            {
                MessageBox.Show("O número: " + _Fibonacci.ToString() + " faz parte da sequencia de fibonacci"); // Exibindo caso verdadeiro
            }
            else
            {
                MessageBox.Show("O número: " + _Fibonacci.ToString() + " não faz parte da sequencia de fibonacci"); // Exibindo caso falso

              }
            return _Arrayinteiro;
        }
    }
}
