﻿using System.ComponentModel.DataAnnotations;

namespace DevEs.App.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }

        [Display(Name = "Tipo")]
        public int TipoFornecedor { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
