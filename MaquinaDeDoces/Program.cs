using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program
    {
        static void Main(string[] args)
        {

            //Conecta com a classe Control Produto
            ControlProduto controlProd = new ControlProduto();

            //Chamar o metodo principal daquelas classes
            controlProd.Operacao();


            

            
            

            Console.ReadLine(); // Para manter a janela aberta (ele é como se fosse o leia do portugal visualg)
        } //Fim do metodo main
    } // Fim da classe
} // Fim do projeto
