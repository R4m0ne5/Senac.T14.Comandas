using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas
{
    public class Usuario
    {
        // propiedades da classe 
        // colunas da tabela usuario
        [Key] // chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AI
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

    }
}
