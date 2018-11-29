using ConsoleVinivius.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleVinivius
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var context = new ViniciusContext();
            context.Tablogin.Add(new Tablogin()
            {
                Id = 3,
                Descricao = "Vinicius Nadalin",
                Senha = "123",
                Situacao = "A",
                Usuario = "vi"
            });
            context.SaveChanges();

            context.Tablog.Add(new Tablog()
            {
                Id = 2,
                Descricao = "Vinicius log teste"
            });

            context.SaveChanges();



            context.TabCasa.AddRange(
                new List<TabCasa>() {
                    new TabCasa(){
                        Id = 1,
                        Descricao = "Casa do vi",
                        Numero = 24
                    },
                    new TabCasa() {
                        Id=2,
                        Descricao="Casa do Maestro",
                        Numero = 11
                    }
             });
            context.SaveChanges();

            Console.Read();
        }
    }
}
