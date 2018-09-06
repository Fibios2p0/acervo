﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    /*  Saulo Silva Castilhos
        Bruno de Oliveira Silva */
    class Program
    {
        //inicializando variaveis e classes

        static Livros acervo = new Livros();
        static Livro livro;
        static void Main(string[] args)
        {
           
           
            int opcao = 0;
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1.Adicionar livro");
                Console.WriteLine("2.Pesquisar livro(sintético)");
                Console.WriteLine("3.Pesquisar livro(analítico)");
                Console.WriteLine("4.Adicionar exemplar");
                Console.WriteLine("5.Registrar empréstimo");
                Console.WriteLine("6.Registrar devolução");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1: adicionarLivro(); break;
                    case 2: pesquisarLivroSintetico(); break;
                    case 3: pesquisarLivroAnalitica(); break;
                    case 4: adicionarExemplar(); break;
                   // case 5: registrarEmprestimo(); break;
                    case 6: registrarDevolucao(); break;
                }


            } while (opcao != 0);


            Console.ReadKey();
        }
        static public void adicionarLivro()
        {
            int isbn;
            string titulo, autor, editora;
            Console.WriteLine("Dados do Livro que deseja adicionar");
            Console.WriteLine("ISBN: ");
            isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("Título: ");
            titulo = Console.ReadLine();
            Console.WriteLine("Autor: ");
            autor = Console.ReadLine();
            Console.WriteLine("Editora: ");
            editora = Console.ReadLine();

            Livro livro = new Livro (isbn, titulo, autor, editora);
            acervo.adicionar(livro);
        }
        static public void pesquisarLivroSintetico()
        {
            int isbn;
            Console.WriteLine("Digite o número do ISBN do Livro que deseja encontrar: ");
            isbn = int.Parse(Console.ReadLine());
            Livro livro = new Livro(isbn, "", "", "");
            livro = acervo.pesquisar(livro);
            Console.WriteLine("{0}", livro.dados());
        }
        static public void pesquisarLivroAnalitica()
        {
            int isbn;
            Console.WriteLine("Digite o número do ISBN do Livro que deseja encontrar: ");
            isbn = int.Parse(Console.ReadLine());
            Livro livro = new Livro(isbn, "", "", "");
            livro = acervo.pesquisar(livro);
            Console.WriteLine("{0}", livro.dados2());
        }
        static public void adicionarExemplar()
        {
            Livro livro = new Livro(isbn);
            Console.WriteLine("Adicionar Exemplar \n ________________");
            Console.WriteLine("Digite o ISBN do Livro que deseja: ");
            int isbn = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o tombo do Exemplar: ");
            int tombo = int.Parse(Console.ReadLine());
            Exemplar exemplar = new Exemplar(tombo);
            acervo.pesquisar(livro).adicionarExemplar(exemplar);
        }
        static public void registrarEmprestimo()
        {
            int  tombo;
            Console.WriteLine("Digite o número do Tombo do Livro que deseja emprestar: ");
            tombo = int.Parse(Console.ReadLine());
            Exemplar exemplar = new Exemplar(isbn, "", "", "");
            
        }
        static public void registrarDevolucao()
        {

        }
    }
}
