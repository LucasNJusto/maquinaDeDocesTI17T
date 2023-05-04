using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Produto
    {
        // Definição das variaveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Metodo Construtor
        public Produto()
        {
            ModificarCodigo = 0;
            ModificarNome = "";                             // isso é um construtor sem parametro pois eu dei valor as variaveis
            ModificarDescricao = "";
            ModificarPreco = 0;
            ModificarQuantidade = 0;
            ModificarDataValidade = new DateTime(); //0000/00/00 00:00:00
            ModificarSituacao = false;

        } // Fim do metodo Construtor

        // Metodo Construtor com parametro
        public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, bool situacao)
        {
            ModificarCodigo = codigo;  // O this ele faz referencia para o codigo ai ele entende que um lado e variavel e o outro é parametro
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;
        } // Fim do metodo construtor com parametro


        // Metodos get e set
        //Metodos de acesso e modificação
        public int ModificarCodigo
        {
            get{
                return this.codigo;
            } //Fim do get - retornar codigo 

            set{
                this.codigo = value; 

            } // FIm do set - Modificar o codigo
        } // FIm do ModificarCodigo


        public string ModificarNome
        { 
            get{ 
                return this.nome; 
            }
            
            set{ 
                this.nome = value; 
            } 
        } // Fim ModificarNome

        public string ModificarDescricao
        {
            get{ return this.descricao;
            
            }
            set{
                this.descricao = value;
            }
        } // Fim ModificarDescricao

        public double ModificarPreco
        { get { return this.preco; }
            set { this.preco = value; } 

        } // Fim ModificarPreco

        public int ModificarQuantidade
        {
            get { return this.quantidade; } 
            set { this.quantidade = value;}

        }  // Fim ModificarQuantidade
        
        public DateTime ModificarDataValidade
        { get { return this.dtValidade;
            
            }
            set{
                this.dtValidade = value;
            } 
        }  // Fim ModificarDataValidade

        public Boolean ModificarSituacao
        {
            get { return this.situacao;}
            set{this.situacao = value;}

        }  // Fim ModificarSituacao


        // Metodo Cadastrar Produto

        public void CadastrarProduto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidae, Boolean situacao)

        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidae;
            ModificarSituacao = situacao;


        }// Fim do método CadastrarProduto

        // Consultar Produto
        public string ConsultarProduto(int codigo)
        {
            string msg = ""; //Criando uma variavel local 

            if(ModificarCodigo == codigo)     // if quer dezer "se"
            {
                msg = "\nCodigo: " + ModificarCodigo +
                      "\nNome: " + ModificarNome +
                      "\nDescricao: " + ModificarDescricao +
                      "\nPreco: " + ModificarPreco +
                      "\nQuantidade: " + ModificarQuantidade +
                      "\nData de Validade: " + ModificarDataValidade +
                      "\nStuacao: " + ModificarSituacao;

            }else        // serve como "se nao"
            {
                msg = "O código digitado não exixte!";     
            }
            
            return msg;

        } // FIm do metodo 

        //Metodo atualizar
        public Boolean AtualizarProduto(int codigo, int campo, string novoDado) 
        
        { 
            Boolean flag = false;

            if(ModificarCodigo == codigo)
            {
                switch (campo)
                {
                    case 1: 
                        ModificarNome = novoDado;
                        flag = true;
                        break;  // ou voce tambem pode usar um return vazio que ele vai parar a situação

                    case 2:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;

                    case 3:
                        ModificarPreco = Convert.ToDouble(novoDado);
                        flag = true;
                        break;

                    case 4:
                        ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;

                    case 5:
                        ModificarDataValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;

                    case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;
                    default:
                        break;


                } //Fim do escolha
                return flag;

            }//Fim do if
            return flag;
        } //Fim do AtualizarProduto

        public Boolean AlterarSituacao(int codigo)
        {
            Boolean flag = false;

            if (ModificarCodigo == codigo)
            {
                if(ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }//Fim ModificarSituacao
                flag= true;
            }//Fim modificarCdigo
            return flag;
        } //Fim do DesativarProduto

        // SolicitarProduo
        public Boolean SolicitarProduto(int codigo) 
        {
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }

            }//Fim do if
            return false;
        }//Fim do SolicitarProduto

    } //Fim da classe
} // Fim projeto
