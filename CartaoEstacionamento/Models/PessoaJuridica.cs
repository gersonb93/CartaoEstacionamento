using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CartaoEstacionamento.Models
{
    public class PessoaJuridica : Pessoa
    {
       
        public int IdPjuridica { get; set; }
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

        public Pessoa Pessoa { get; set; }

        public PessoaJuridica(int idPjuridica, string nomeFantasia, string razaoSocial, string cNPJ, Pessoa pessoa)
        {
            IdPjuridica = idPjuridica;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            Pessoa = pessoa;
        }

        public PessoaJuridica()
        {
        }
    }
}
