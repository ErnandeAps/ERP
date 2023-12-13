using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Data;

[Table("PRODUTO")]
public class Produto
{
    [Key]
    public int ID_CADASTRO { get; set; }
    public string  ATIVO { get; set; }
    public decimal PRECO { get; set; }
    public string DESCRICAO { get; set; }   
    public string NOME { get; set; }   
    public long QUANTIDADE { get; set; }   
}