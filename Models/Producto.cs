using Models;
namespace Models;


public class Producto{

    public int? idProducto {get; set;}
    public string? descripcion {get; set;}
    public string? precio {get; set;}
    public string? Tipo_IVA {get; set;}
    public DateTime? fechaCreacion  {get; set;}
    public bool activo {get; set;}


    public Producto()
    {
        this.activo = true;
    }

    public Producto(int _idCliente, string _nombre, string _apellido, string _email, string _password, string _telefono, List<TarjetaCredito> _tarjetasCredito)
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
