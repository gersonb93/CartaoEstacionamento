using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CartaoEstacionamento.Models;

namespace CartaoEstacionamento.Models
{
    public class PessoaFisica : Pessoa
    {
    
        public int IdPfisica { get; set; }

        [Required(ErrorMessage = "Preencha o nome")]
        [DisplayName("Nome")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o CPF")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Data de Nascimento")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido")]
        [ScaffoldColumn(false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss tt}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o sexo")]
        [DisplayName("Sexo")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "A profissão deve ter entre 3 e 255 caracteres.")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "Preencha o RG")]
        [DisplayName("Rg")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O estado civil deve ter entre 3 e 255 caracteres.")]
        public string Rg { get; set; }

        public Pessoa Pessoa { get; set; }

        public PessoaFisica(int idPfisica, string nome, string cPF, DateTime dataNascimento, string profissao, string rg, Pessoa pessoa)
        {
            IdPfisica = idPfisica;
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Profissao = profissao;
            Rg = rg;
            Pessoa = pessoa;
        }

        public PessoaFisica()
        {
        }
    }
}

