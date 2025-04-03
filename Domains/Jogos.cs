using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Api_Jogos_Isaac.Domains
{
    [Table("Jogo")]
    [Index(nameof(NomeDoJogo), IsUnique = true)] //o Index serve para que nao se repita, nesse caso o NomeDoJogo
    public class Jogos //Public class srvve para criar uma classe
    {
        [Key] //kEY SERVE PARA DIZER QUE VAI SER CRIADA UMA KEY EM DIANTE (PRA NAO DAR PROBLEMA)
        public Guid JogosID { get; set; }
        //Guid serve para indentificar um valor unico

        [Column(TypeName = "VARCHAR(50)")] // coluna adicionar um limite de caracteres
        [Required(ErrorMessage = "O nome do Jogo é obrigatório")] // pra pessoa saber que esse campo e obrigatorio
        public string? NomeDoJogo { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "qua plataforma? OBS: obrigatório!")]
        public string? Plataforma { get; set; }
    }
}
