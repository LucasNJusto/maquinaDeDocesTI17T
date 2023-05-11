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
        private string descricao;
        private double valorTotal;
        private int FormaDePagamento;
        private DateTime dataHora;
        private int codCartao;
        private int bandeiraCartao;  // Dps colocar posibilidades para selecionar qual o  cartao que esta utilizando

        // Metodo Construtor
        public Pagamento()
        {
            ModificarCodigo = 0;
            ModificarDescricao = "";                             // isso é um construtor sem parametro pois eu dei valor as variaveis
            ModificarValorTotal = 0;
            ModificarFormaDePagamento = 0;
            ModificarDataHora = new DateTime();
            ModificarCodCartao = 0; //0000/00/00 00:00:00
            ModificarBandeiraCartao = 0;
        } // Fim do Metodo Construtor

        // Metodo Construtor com parametro
        public Pagamento(int codigo, string descricao, double valorTotal, int FormaDePagamento, DateTime dataHora, int codCartao, int bandeiraCartao)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;                             // isso é um construtor sem parametro pois eu dei valor as variaveis
            ModificarValorTotal = valorTotal;
            ModificarFormaDePagamento = FormaDePagamento;
            ModificarDataHora = dataHora;
            ModificarCodCartao = codCartao; //0000/00/00 00:00:00
            ModificarBandeiraCartao = bandeiraCartao;

        } // Fim do Metotodo Construtor com Parametro

        //Metodos get e set
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

        public string ModificarDescricao
        {
            get
            {
                return this.descricao;
            } //Fim do get - retornar Descricao

            set
            {
                this.descricao = value;
            } // Fim do set - Modificar a Descricao
        } // Fim do ModificarDescricao

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

        public int ModificarFormaDePagamento
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

        public int ModificarBandeiraCartao
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


        // Metodo Verificar Notas



        // Metodo Verificar Troco



        // Metodo Vaidar Cartao



        // Efetuar Pagamento
        


        // Consultar Pagamento  
        public string ConsultarPagamento(int codigo)
        {
            string msg = ""; //Criando uma variavel local 

            if (ModificarCodigo == codigo)     // if quer dezer "se"
            {
                msg = "\nCodigo: " + ModificarCodigo +
                      "\nNome: " + ModificarDescricao +
                      "\nDescricao: " + ModificarValorTotal +
                      "\nPreco: " + ModificarFormaDePagamento +
                      "\nQuantidade: " + ModificarDataHora +
                      "\nData de Validade: " + ModificarCodCartao +
                      "\nStuacao: " + ModificarBandeiraCartao;      

            }
            else        // serve como "se nao"
            {
                msg = "O código digitado não exixte!";
            }

            return msg;

        } // FIm do metodo



    } // Fim da classe
} // Fim do Projeto
