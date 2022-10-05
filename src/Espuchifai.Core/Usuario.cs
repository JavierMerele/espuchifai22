namespace Espuchifai.Core;
public class Usuario
{
    public string Usuario {get;set;}
    public string Apellido {get;set;}
    public string Email {get;set;}
    public string Contraseña {get;set;}
    public int idUsuario {get;set;}
    public List<Reproduccion> Reproducciones { get; private set; }
}
