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
    public class Faturamento
    {
        [JsonProperty("dia")]
        public string dia { get; set; }
        [JsonProperty("valor")]
        public double valor { get; set; }

      
        static public void GetValues()
        {
            int diasmes = 0;
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
                  //  listBox1.Items.Add("Valor: " + faturamento.valor + "  Dia:" + faturamento.dia + "\n");
                    //listBox1.Items.Add(contador);
                    





                    soma += faturamento.valor;
                

                    if (maior < faturamento.valor)
                    {
                        maior = faturamento.valor;
                        

                    }

                    if (menor > faturamento.valor)
                    {
                        menor = faturamento.valor;


                    }

                 
                  //  MessageBox.Show("Valor Atual do Array: " + contador.ToString() + "        -" + faturamento.valor.ToString());
                    contador++;

                    med = soma / contador;
                    if(faturamento.valor > med)
                    {
                        diasmes++;
                      //  MessageBox.Show(faturamento.valor.ToString() +"     >    " + med.ToString() + "       " + diasmes.ToString()) ;
                    }
               




                }

            }

            MessageBox.Show("Maior Valor = " + maior.ToString() + "\n" + "Menor Valor = " + menor.ToString() + "\n" + "Diario > Media = " + diasmes.ToString()); ; ;

            //MessageBox.Show("Valor: " + soma.ToString() + "   Dividido por :" + contador.ToString()); ;

        }



    }
}
