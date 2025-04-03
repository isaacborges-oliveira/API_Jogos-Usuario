using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Api_Jogos_Isaac.Domains
{
    [Table("Usuario")]
    [Index(nameof(NickName), IsUnique = true)]
    public class Usuarios
    {
        [Key]
        public Guid UsuarioID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "O seu Nick é obrigatório")]
        public string? NickName { get; set; }

        //######################################

        public Guid JogoFavoritoID { get; set; }
        [ForeignKey("JogoFavorito")]
        public Jogos? Jogos { get; set; }
    }   
}
