using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Target_Teste
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }


        public void fibo()
        {
            int numanterior = 0, numatual = 1, numdigitado = 0; //  var utilizadas
            var arrayinteiro = new ArrayList(); // construção array

            numdigitado = int.Parse(textBox1.Text); // Captura do número digitado
            for (int i = 1; i <= numdigitado; i++) // inicio contador

            {
                numatual += numanterior; //  soma do número atual com anterior
                numanterior = numatual - numanterior; //  atribuição do atual com a subtração do anterior
                arrayinteiro.Add(numatual); //  populando o arraylist
                listBox1.Items.Add(i.ToString()); // populando o list box

            }


            if (arrayinteiro.ToArray().Contains(numdigitado)) // verificando se o número digitado está presente no array list
            {
                MessageBox.Show("O número: " + numdigitado.ToString() + " faz parte da sequencia de fibonacci"); // Exibindo caso verdadeiro
            }
            else
            {
                MessageBox.Show("O número: " + numdigitado.ToString() + " não faz parte da sequencia de fibonacci"); // Exibindo caso falso
            }
            textBox1.Clear();
        }
        private void btn_Fibo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                Info info = new Info(); // Instância da classe
                info._Fibonacci = int.Parse(textBox1.Text);
                info.fibo();
                listBox1.Items.AddRange(info._Arrayinteiro.ToArray()); // populando o list box



            }
            else
            {
                MessageBox.Show("Por favor preencha o campo de texto em branco");
                textBox1.Focus();
            }




        }

        public void Sort()
        {
            string caracteres = textBox1.Text; // definindo string 
            int soma = 0; // contador
            int aux; // variavel auxiliar
            foreach (char c in caracteres) // para cada caracter na string
            {
                listBox1.Items.Add(c.ToString()); // adicione o caracter no listbox
                soma++; // incremento da soma
            }
           ;
            aux = soma; // atribuindo soma em aux
            caracteres = "";
            for (int i = 0; i < soma; i++) // Loop for
            {
                listBox1.Items.Add(listBox1.Items[aux - 1]); // Adicionando os itens da lista de cima para baixo
                caracteres += listBox1.Items[aux - 1]; // Adicionando os itens da lista de cima para baixo
                aux--; // decremento de aux

            }

            MessageBox.Show(caracteres);

        }




        private void btn_sort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text != "")
            {
                Info info = new Info(); // Instância da classe
                info._Reversesort = textBox1.Text; // alimentando por metodo publico
                info.Reverse(); // metodo
                textBox1.Clear(); // limpeza de campo
                textBox1.Text = info._Reversesort; // exibindo informação no text box
                listBox1.Items.Add(info._Reversesort); //exibindo informação no list box
            }
            else
            {
                MessageBox.Show("Por favor preencha o campo de texto em branco");
                textBox1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }




        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }
        public void Pct()
        {
            listBox1.Items.Clear();
           
            double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, outros = 19849.53, soma = 0, auxiliar = 0;
            soma = sp + rj + mg + es + outros; //equivale a 100%
            listBox1.Items.Add("Valor total = " + soma.ToString() + " Equivalente a 100%");

            auxiliar = (sp / soma) * 100;
            listBox1.Items.Add("SP = " + sp.ToString() + " - " + Math.Round(auxiliar).ToString() + "%");

            auxiliar = (rj / soma) * 100;
            listBox1.Items.Add("RJ = " + rj.ToString() + " - " + Math.Round(auxiliar).ToString() + "%");

            auxiliar = (mg / soma) * 100;
            listBox1.Items.Add("MG = " + mg.ToString() + " - " + Math.Round(auxiliar).ToString() + "%");

            auxiliar = (es / soma) * 100;
            listBox1.Items.Add("ES = " + es.ToString() + " - " + Math.Round(auxiliar).ToString() + "%");

            auxiliar = (outros / soma) * 100;
            listBox1.Items.Add("Outros estados = " + outros.ToString() + " - " + Math.Round(auxiliar).ToString() + "%");


            
        }
        private void btn_pct_Click(object sender, EventArgs e)
        {
            Pct();

        }

        private void btn_inversao_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                Sort();
            }
            else
            {
                MessageBox.Show("Por favor preencha o campo de texto em branco");
                textBox1.Focus();
            }
        }

        public void Deser()
        {
            double[] array = new double[30];
            int contador = 0;
            double med = 0;
            double soma = 0;
            string jsonString;
            double menor = 99999.9999;
            double maior = 0;

  
            ArrayList arraylist = new ArrayList();

            List<Faturamento> valores = new List<Faturamento>();

            using (StreamReader stream = new StreamReader(@"C:\dados\dados.json"))
            {
                jsonString = stream.ReadToEnd();
                valores = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);
            }

            foreach (var faturamento in valores)
            {



                if (faturamento.valor > 0.0)
                {
                    listBox1.Items.Add("Valor: " + faturamento.valor + "  Dia:" + faturamento.dia + "\n");
                    //listBox1.Items.Add(contador);
                    array[contador] = faturamento.valor;

                    

                   
              
                    soma += faturamento.valor;
                

                    if (maior < faturamento.valor)
                    {
                        maior = faturamento.valor;
                        
                      
                    }

                    if (menor > faturamento.valor)
                    {
                        menor = faturamento.valor;
                        

                    }

                    MessageBox.Show("Valor Atual do Array: " + contador.ToString() + "        -" + array[contador].ToString());
                    contador++;




                }

            }

            MessageBox.Show("Maior = " + maior.ToString());
            MessageBox.Show("menor = " + menor.ToString());

            med = soma / (contador+1);
            listBox1.Items.Add("\n\n\n" + soma.ToString() + "          " + contador.ToString() + "       Média = :" + Math.Round(med).ToString());

       





        }


        private void btn_teste_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            listBox1.Items.Add(SOMA.ToString());
            MessageBox.Show(SOMA.ToString());
        }
      
        
        public void DeserilizarListaDeObjetos()
        {
            Faturamento f = new Faturamento();
          
          
            string jsonString;

            double maior=0.0;
            double menor=0.0;

            List<Faturamento> valores = new List<Faturamento>();
         
            using (StreamReader stream = new StreamReader(@"C:\dados\dados.json"))
            {
                jsonString = stream.ReadToEnd();
                valores = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);

            }


           
            

            maior = valores.Max(maximo => maximo.valor);
            menor = valores.Min(minimo => minimo.valor);

            MessageBox.Show(maior.ToString());
            MessageBox.Show(menor.ToString());



        }

        private void btn_faturamento_Click(object sender, EventArgs e)
        {
            Faturamento.GetValues();
        }
    }
}



