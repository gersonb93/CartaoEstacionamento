using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoEstacionamento.Models;
using CartaoEstacionamento.ViewModels;

namespace CartaoEstacionamento.Data
{
    public class SeedingService
    {
        private CartaoEstacionamentoContext _context;

        public SeedingService(CartaoEstacionamentoContext context)
        {
            _context = context;
        }
        // tem que rodar o Update-Database
        public void Seed()
        {
            if (//_context.Pessoa.Any() ||
                //_context.PessoaFisica.Any() ||
                _context.PessoaViewModel.Any())  
               // _context.PessoaJuridica.Any())
            {
                return; // DB has been seeded
            }
                  /*
                        Pessoa p1 = new Pessoa(1, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "RJ", "bgerson@gmail.com");
                        Pessoa p2 = new Pessoa(2, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "RJ", "bgerson@gmail.com");
                        Pessoa p3 = new Pessoa(3, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "RJ", "bgerson@gmail.com");
                        Pessoa p4 = new Pessoa(4, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "RJ", "bgerson@gmail.com");
                        Pessoa p5 = new Pessoa(5, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "RJ", "bgerson@gmail.com");
                        Pessoa p6 = new Pessoa(6, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "RJ", "bgerson@gmail.com");
                        Pessoa p7 = new Pessoa(7, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "RJ", "bgerson@gmail.com");

                   */
                        PessoaViewModel pv1 = new PessoaViewModel(1, "983118988", "Rua Soldade Jose de sousa", "Rio de Janeiro", "Rio de Janeiro", "bgerson@gmail.com", "Gerson Batista", "167.670.427-22", new DateTime(1995, 09, 25), " ", " ", " ", " ", new DateTime(2018, 09, 25), TipoPessoa.Fisica);
                        PessoaViewModel pv2 = new PessoaViewModel(2, "983105151", "Rua California", "Rio de Janeiro", "Rio de Janeiro", "gerson@maxxlatina", "Grupo Filial", " ", new DateTime(2021, 09, 25), "Maxx1", "maxxlatina", "28.023.0001/40", "36267753", new DateTime(2021, 09, 25), TipoPessoa.Juridica);

            /*
                        PessoaFisica d1 = new PessoaFisica(1, "Gerson Batista", "167.670.427-22", new DateTime(2018, 09, 25), "Programador", "25.155.55",p1);
                        PessoaFisica d2 = new PessoaFisica(2, "Gerson Batista", "167.670.427-22", new DateTime(2018, 09, 25), "Programador", "25.155.55", p7);
                        PessoaFisica d3 = new PessoaFisica(3, "Gerson Batista", "167.670.427-22", new DateTime(2018, 09, 25), "Programador", "25.155.55", p4);
                        PessoaFisica d4 = new PessoaFisica(4, "Gerson Batista", "167.670.427-22", new DateTime(2018, 09, 25), "Programador", "25.155.55", p2);

                        PessoaJuridica r1 = new PessoaJuridica(1, "28.023.0001/40", "Maxx1", "maxxlatina", p3);
                        PessoaJuridica r2 = new PessoaJuridica(2, "28.251.0001/51", "Rizona", "rizoma consultora", p5);
                        PessoaJuridica r3 = new PessoaJuridica(3, "28.036.0001/50", "RLeao", "leao comercio", p6);
                       
            
                        _context.Pessoa.AddRange(p1);

                        _context.PessoaFisica.AddRange(d1, d2, d3, d4);

                       

                        _context.PessoaJuridica.AddRange( r1, r2, r3);  */

                          _context.PessoaViewModel.AddRange(pv1, pv2);
            _context.SaveChanges();
        } 
    }
}
