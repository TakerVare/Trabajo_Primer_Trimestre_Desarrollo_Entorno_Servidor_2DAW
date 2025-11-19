using Models;
namespace Models;

public class TarjetaCredito {

    public int idTarjetaCredito {get;set;}
    public string? descripcion {get;set;}
    public string? numeroTarjeta {get;set;}
    public string? fechaCaducidad {get;set;}
    public DateTime? fechaCreacion {get;set;}
    public bool activo {get;set;}


    public TarjetaCredito()
    {
        this.activo = true;
    }

    public TarjetaCredito(idTarjetaCredito _idTarjetaCredito, descripcion _descripcion, numeroTarjeta _numeroTarjeta, fechaCaducidad _fechaCaducidad, fechaCreacion _fechaCreacion )
    {
        this.idTarjetaCredito = _idTarjetaCredito;
        this.descripcion = _descripcion;
        this.numeroTarjeta = _numeroTarjeta;
        this.fechaCaducidad = _fechaCaducidad;
        this.fechaCreacion = _fechaCreacion;
        this.activo = true;
    }

    
}