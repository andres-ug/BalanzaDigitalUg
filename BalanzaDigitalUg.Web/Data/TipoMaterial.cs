using System.ComponentModel.DataAnnotations;

namespace BalanzaDigitalUg.Web.Data;

public class TipoMaterial
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public ICollection<MaterialReciclado> MaterialesReciclados { get; set; } = [];
}