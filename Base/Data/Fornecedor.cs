﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Data;

[Table("FORNECEDOR")]
public class Fornecedor
{
    [Key]
    public int ID_CADASTRO { get; set; }
    public string  ATIVO { get; set; }
    public string DOCUMENTO { get; set; }
    public string CGC { get; set; }
    public string IE { get; set; }
    public string NOME { get; set; }
    public string FANTASIA { get; set; }
    public string LOGRADOURO { get; set; }
    public string NUMERO { get; set; }
    public string BAIRRO { get; set; }
    public string MUNICIPIO { get; set; }
    public string UF { get; set; }
    public string CEP { get; set; }
    public string EMAIL { get; set; }
    public string CONTATO { get; set; }
    public string FONE { get; set; }
    public string CELULAR { get; set; }
    public string  CADASTRO { get; set; }
    public string DATA_NASC { get; set; }
}