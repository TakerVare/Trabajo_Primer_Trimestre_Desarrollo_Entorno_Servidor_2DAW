using Models;
namespace Models;
using Models.TarjetaCredito;

public class Cliente{

    public int? idCliente {get; set;}
    public string? nombre {get; set;}
    public string? apellido {get; set;}
    public string? email {get; set;}
    public string? password {get; set;}
    public string? telefono {get; set;}
    public bool activo {get; set;}
    public List<TarjetaCredito>? tarjetasCredito {get; set;}


    public Cliente()
    {
        this.activo = true;
    }

    public Cliente(idCliente _idCliente, nombre _nombre, apellido _apellido, email _email, password _password, telefono _telefono, tarjetasCredito _tarjetasCredito)
    {
        this.idCliente = _idCliente;
        this.nombre = _nombre;
        this.apellido = _apellido;
        this.email = _email;
        this.password = _password;
        this.telefono = _telefono;
        this.activo = true;
        this.tarjetasCredito = _tarjetasCredito;
        
    }
    
    
}
