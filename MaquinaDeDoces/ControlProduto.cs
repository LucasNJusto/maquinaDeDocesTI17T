using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlProduto
    {
        Produto prod;
        private int opcao;

        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao = -1;  // ele nao começa em zero por conta do menu pois n representa nenhua das opçoes do menu

        }//Fim do construtor

        //Metodo getSet
        public int ModificarOpcao 
        { 
            get { return opcao; }
            set { opcao = value; }
        } //Fim do metodo get e set de opçao



        //Metodo menu
        public void Menu()
        {
            Console.Clear(); //Limpar o Console
            Console.WriteLine("Escolha uma das opçoes abaixo: \n" + "1. Cadastrar um produto \n" + "2.Consultar um produto \n" + "3. Atualizar Produto" + "4. Mudar Situaçao \n");

            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        } // Fim do metodo menu


        // Realizar a operação
        public void Operacao() 
        {
            do
            {

                Menu(); //Mostrando o menu na tela
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        ColetarDados();
                        break;

                    case 2:
                        Consultar();
                        break;

                    case 3:
                        Atualizar();
                        break;

                    case 4:
                        AlterarSituacao();

                        break;
                    default:
                        Console.WriteLine("Opçao escolhida nao é valida!");
                        break;

                } //FIm do switch
            } while(ModificarOpcao != 0);  // O do While é como se fosse o repita até
        }//Fim do metodo Operacao


        //Criar um metodo de solicitação de dados
        public void ColetarDados()
        {
            //Coletar Dados
            Console.WriteLine("Informe o codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Faça uma breve descriçao do prodto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe quando o produto ira vencer: ");
            DateTime dtValidade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situação: True - Ativo | False - Inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            //Cadastrar Produto
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, dtValidade, situacao);
            Console.WriteLine("Dado registrado!");

        }//Fim coletar dados

        //Consultar
        public void Consultar()
        {
            // Consltar os dados do produto
            Console.WriteLine("\n\n\n Iforme o codigo do produto que deseja consultar"); // o barra n serve parapular linha
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Escrever o resultado na tela
            Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
        } // Fim do metodo
          
            //Atualizar 

            public void Atualizar()
            {
                //Atualizar Produto
                Console.WriteLine("\n\n Informe o codigo do produto que deseja atualzar: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
            short campo = 0;
            do
            {
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regr a baixo \n" + "1. Nome \n" + "2. Descriçao \n" + "3. Preco \n" + "4. Quantidade \n" + "5. Data de Validade \n" + "6. Situção \n");
                campo = Convert.ToInt16(Console.ReadLine());

                // Avisar o usuario
                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro, escolha um codigo entre 1 e 6");
                }

            } while ((campo < 1) || (campo > 6));
            
            
            
                Console.WriteLine("Informe o dado para a atualização: ");
                String novoDado = Console.ReadLine();
                
                
                
                //Chamar o metodo de atualização
                prod.AtualizarProduto(codigo, campo, novoDado);
                Console.WriteLine("Atualizado!");
            }//Fim do etodo atualizar

            public void AlterarSituacao()
            {
                Console.WriteLine("Informe o codigo do produto que deseja alterar o status: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                //Chamar Metodo alterarSituacao - Classe Produto
                prod.AlterarSituacao(codigo);
                Console.WriteLine("Alterado!");
            }

        //

    }//Fim classe
}//Fim projeto
