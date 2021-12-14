using CartaoEstacionamento.ViewModels;
using CartaoEstacionamento.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoEstacionamento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CartaoEstacionamento.Controllers
{
    public class PessoasController : Controller
    {
        private readonly CartaoEstacionamentoContext _context;

        public PessoasController(CartaoEstacionamentoContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.PessoaViewModel.ToListAsync());

        }
        public IActionResult Create()
        {
            return View();

        }



        [HttpPost]
        public ActionResult Create(PessoaViewModel pessoaViewModel)
        {
            if (ModelState.IsValid)
            {
                if (pessoaViewModel.TipoPessoa == TipoPessoa.Fisica)
                {
                    var pessoafisica = new PessoaFisica()
                    {
                        IdPfisica = pessoaViewModel.PessoaViewId,
                        Telefone = pessoaViewModel.Telefone,
                        Endereco = pessoaViewModel.Endereco,
                        Cidade = pessoaViewModel.Cidade,
                        Estado = pessoaViewModel.Estado,
                        Email = pessoaViewModel.Email,
                        Nome = pessoaViewModel.Nome,
                        CPF = pessoaViewModel.CPF,

                    };

                    _context.PessoaFisica.Add(pessoafisica);
                }
                else
                {
                    PessoaJuridica pessoajuridica = new PessoaJuridica()
                    {
                        IdPjuridica = pessoaViewModel.PessoaViewId,
                        Telefone = pessoaViewModel.Telefone,
                        Endereco = pessoaViewModel.Endereco,
                        Cidade = pessoaViewModel.Cidade,
                        Estado = pessoaViewModel.Estado,
                        Email = pessoaViewModel.Email,
                        NomeFantasia = pessoaViewModel.NomeFantasia,
                        RazaoSocial = pessoaViewModel.RazaoSocial,
                        CNPJ = pessoaViewModel.CNPJ
                    };

                    _context.PessoaJuridica.Add(pessoajuridica);
                }

                _context.Add(pessoaViewModel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(pessoaViewModel);
        }



    }
}