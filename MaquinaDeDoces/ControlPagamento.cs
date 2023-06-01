using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {
        Pagamento pagto;
        private int opcao;

        public ControlPagamento() 
        {
            pagto = new Pagamento();
            ModificarOpcao = -1; // ele nao começa em zero por conta do menu pois n representa nenhua das opçoes do menu
        }//Fim do Construtor

        //Metodo get e set
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        } //Fim do metodo get e set de opçao


        // Metodo Menu
        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo ⬇ \n" + "1'.  \n" + "2.  \n" + "3.  \n" + "4.  \n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }



    } // Fim da Classe
} //Fim do Projeto
