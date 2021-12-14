using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CartaoEstacionamento.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CartaoEstacionamento.ViewModels
{
    public class PessoaViewModel
    {
        // Deixe PessoaId apenas se for fazer a edição da mesma forma.
        [Key]
        public int PessoaViewId { get; set; }

        [Required(ErrorMessage = "Preencha o telefone")]
        [DisplayName("Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o endereço")]
        [DisplayName("Endereço")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O endereço deve ter entre 3 e 255 caracteres.")]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Preencha a cidade")]
        [DisplayName("Cidade")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "A cidade deve ter entre 3 e 255 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o estado")]
        [DisplayName("Estado")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O estado deve ter entre 3 e 255 caracteres.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Preencha o email")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O email deve ter entre 3 e 255 caracteres.")]
        public string Email { get; set; }


        /* Campos de Praticante */
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
        public DateTime DataNascimento { get; set; } = new DateTime();
   

        /* Campos de Estabelecimento */
        [Required(ErrorMessage = "Preencha o nome fantasia")]
        [DisplayName("Nome Fantasia")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome fantasia deve ter entre 3 e 255 caracteres.")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Preencha a razão social")]
        [DisplayName("Razão Social")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "A razão social deve ter entre 3 e 255 caracteres.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preencha o CNPJ")]
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Preencha o telefone comercial")]
        [DisplayName("Telefone Comercial")]
        [DataType(DataType.PhoneNumber)]
        public string TelComercial { get; set; }

        [DisplayName("Data de Abertura")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido")]
        [ScaffoldColumn(false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss tt}")]
        public DateTime DataAbertura { get; set; } = new DateTime();
        public TipoPessoa TipoPessoa { get; set; } 

        public PessoaViewModel(int pessoaViewId, string telefone, string endereco, string cidade, string estado, string email, string nome, string cPF, DateTime dataNascimento, string nomeFantasia, string razaoSocial, string cNPJ, string telComercial, DateTime dataAbertura, TipoPessoa tipoPessoa)
        {
            PessoaViewId = pessoaViewId;
            Telefone = telefone;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Email = email;
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            TelComercial = telComercial;
            DataAbertura = dataAbertura;
            TipoPessoa = tipoPessoa;
        }
    }
}