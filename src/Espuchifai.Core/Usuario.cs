namespace Espuchifai.Core;
public class Usuario
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Contrasenia { get; set; }
    public uint IdUsuario { get; set; }

    public Usuario(string nombre, string apellido, string email, string contrasenia, uint idUsuario)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Email = email;
        this.Contrasenia = contrasenia;
        this.IdUsuario = idUsuario;

    }
}
