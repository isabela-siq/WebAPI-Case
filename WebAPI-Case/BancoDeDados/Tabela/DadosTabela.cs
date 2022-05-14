using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebAPI_Case.BancoDeDados.Tabela
{
    public class DadosTabela
    {
        public int? Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Nome { get; set; }
        public string? Email { get; set; }
           
    }
}
