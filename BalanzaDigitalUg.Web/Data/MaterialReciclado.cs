
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
}
