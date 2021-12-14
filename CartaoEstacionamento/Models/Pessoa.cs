using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CartaoEstacionamento.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

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
        public ICollection<PessoaJuridica> PessoaJuridicas { get; set; }
        public ICollection<PessoaFisica> PessoaFisicas { get; set; }


        public Pessoa()
        {
            
        }
        public Pessoa(int idPessoa, string telefone, string endereco, string cidade, string estado, string email)
        {
            IdPessoa = idPessoa;
            Telefone = telefone;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Email = email;
        }
    }
}

