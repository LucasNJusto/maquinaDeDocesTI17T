using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        // Definição das variaveis
        private int codigo;
        private double valorTotal;
        private short FormaDePagamento;
        private DateTime dataHora;
        private int codCartao;
        private short bandeiraCartao;  // Dps colocar posibilidades para selecionar qual o  cartao que esta utilizando
        private double trocoMaquina;
        private double troco;

        // Metodo Construtor       (instanciar as variaveis da memoria da maquina dar vida no caso o conteudo)
        public Pagamento()
        {
            ModificarCodigo = 0;   // this para informar a variavel de cima
                            // isso é um construtor sem parametro pois eu dei valor as variaveis
            ModificarValorTotal = 0;
            ModificarFormaDePagamento = 0;                      //Para consultar a variavel é so colocar ModificarCodigo;
            ModificarDataHora = new DateTime();  //0000/00/00 00:00:00
            ModificarCodCartao = 0;
            ModificarBandeiraCartao = 0;
            ModificarTrocoMaquina = 100;
            ModificarTroco = 0;
        } // Fim do Metodo Construtor

        //Metodos get e set
        public double ModificarTroco()
        {
            get { return troco; };
            set { this.troco = value};
        }//Fim do metodo troco

        //Metodo de acesso e Modificação
        public int ModificarCodigo
        {
            get
            {
                return this.codigo;
            } //Fim do get - retornar codigo 

            set
            {
                this.codigo = value;

            } // FIm do set - Modificar o codigo
        } // FIm do ModificarCodigo

        public double ModificarValorTotal
        {
            get
            {
                return this.valorTotal;
            } // Fim do get - Retornar valor Total

            set
            {
                this.valorTotal = value;
            } // Fim do set - Modificar o valor Total
        } // Fim do ModificarValorTotal

        public short ModificarFormaDePagamento
        {
            get
            {
                return this.FormaDePagamento;
            } //Fim do get - Retornar Forma de Pagamento

            set
            {
                this.FormaDePagamento = value;
            } // Fim do set - Modificar Forma de Pagamento
        } // Fim do Modificar FormaDePagamento

        public DateTime ModificarDataHora
        {
            get
            {
                return this.dataHora;
            } // Fim do get - Retornar Data Hora

            set
            {
                this.dataHora = value;
            } //Fim do set - Modificar Data Hora
        } //FIm do ModificarDataHora

        public int ModificarCodCartao
        {
            get
            {
                return this.codCartao;
            } // Fim do get - Retornar Cartao

            set
            {
                this.codCartao = value;
            } // Fim do set - Modificar Cod Cartao
        } // Fim do ModificarCodCartao

        public short ModificarBandeiraCartao
        {
            get
            {
                return this.bandeiraCartao;
            } // Fim do get - Retornar Bandeira Cartao

            set
            {
                this.bandeiraCartao = value;
            } // Fim do set - Modificar Bandeira Cartao
        } //Fim do ModificarBandeiraCartao


        public double ModificarTrocoMaquina
        {
            get { return this.trocoMaquina; }
            set { this.trocoMaquina= value; }
        }
        //Modificar modelo do negodcio
        
        public string VerificarNotas(double entradaDinheiro, double valorProduto)
        {
            if(entradaDinheiro > valorProduto)
            {
            return "Ok";
            }
            else
            {
            return "NOK";
            }
        }  //fim verificarNotas
        
        public Boolean ExisteTroco(double entradaDinheiro, double valorProduto)
        {
                if (entradaDinheiro > valorProduto)
                {
                    return true;
                }
                return false;
        } //Fim existeTroco
    
        public void VerificarTroco(double entraDinheiro, double valorProduto)
        {
            Boolean respTroco = false; 
            respTroco = ExisteTroco(entraDinheiro, valorProduto);
            if(respTroco == true)
            {
                ModificarTroco = entraDinheiro - valorProduto;   // esta fazendo um operação nterna ent n precisa do return
            }
            else
            {
                ModificarTroco = 0;
            }         
        } //Fim verificarTroco

        public string EscolherFormaDePagamento()
        {
            return "Escolha uma das opções a baixo: " + "\n1. Dinheiro \n2. Cartão";
        }//Fim do metodo 

        public void ColetarFormaDePagamneto(short opcao)
        {
            ModificarFormaDePagamento = opcao;
        }//Fim do coletar

        public void EfetuarPagamentoDinheiro(double entradaPagamento, double valorProduto)
        {
            string resp = "";
            resp = VerificarNotas(entradaPagamento, valorProduto);

                    if (resp == "Ok")
                    {
                        ModificarCodigo = ModificarCodigo + 1;
                        ModificarValorTotal = valorProduto;
                        ModificarFormaDePagamento   = 1;
                        ModificarDataHora = DateTime.Now; //Pegar data hora da transação
                        ModificarTrocoMaquina += valorProduto;
                        VerificarTroco(entradaPagamento, valorProduto);
                        imprimir();
                    }

        } //Fim do metodo Efetuar pagamento


        public void EfetuarPagamentoCartao(double entradaPagamento, double valorProduto, int codCartao, short bandeiraCartao)
        {
            ModificarCodigo++;
            ModificarValorTotal = valorProduto;
            ModificarFormaPagamento = 2;
        }

        //Metodo Imprimir
        public string imprimir()
        {
            return "Codigo: "       + ModificarCodigo +
                   "\n Valor Total:  " + ModificarValorTotal +
                   "\n Troco: " + ModificarTroco +
                   "\n Forma de Pagamento " + ModificarFormaDePagamento +
                   "\n Data e Hora: " + ModificarDataHora;
        }//Fim do metodo imprimir

    
    } // Fim da classe
} // Fim do Projeto
