namespace ihcux_racha_ai_blazor.Models;

public class Grupo
{
    public string Nome { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public decimal ValorPendente { get; set; }
    public bool NoVermelho { get; set; }
}