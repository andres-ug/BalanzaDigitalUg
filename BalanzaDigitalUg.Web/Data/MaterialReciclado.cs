
using System.ComponentModel.DataAnnotations;

namespace BalanzaDigitalUg.Web.Data;

public class MaterialReciclado
{
    [Key]
    public int Id { get; set; }
    public int TipoId { get; set; }
    public TipoMaterial Tipo { get; set; } = null!;
    public decimal Peso { get; set; }
    public int TamanioId { get; set; }
    public Tamanio Tamanio { get; set; } = null!;
    public DateTime FechaIngreso { get; set; }
    public string UsuarioId { get; set; } = null!;
    public ApplicationUser Usuario { get; set; } = null!;
    public Comuna Comuna { get; set; } = null!;
    public int ComunaId { get; set; }
}
