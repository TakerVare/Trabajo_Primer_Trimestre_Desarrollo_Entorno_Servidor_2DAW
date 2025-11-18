using Models;
namespace Models;

public class MedioDePago {

    public int idMedioDePago {get;set;}
    public string descripcion {get;set;}
    public dateTime fechaCreacion {get;set;}
    public bool activo {get;set;}


    public MedioDePago()
    {
        this.activo = true;
    }

    public MedioDePago(idMedioDePago _idMedioDePago, descripcion _descripcion, fechaCreacion _fechaCreacion )
    {
        idMedioDePago=_idMedioDePago;
        descripcion=_descripcion;
        fechaCreacion=_fechaCreacion;
        this.activo = true;
    }


    
}