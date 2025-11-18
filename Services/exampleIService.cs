namespace RestauranteAPI.Services
{
    public interface IBebidaService
    {
        Task<List<Bebida>> GetAllAsync(QueryParamsFiltters? nombreProducto);
        Task<Bebida?> GetByIdAsync(int id);
        Task AddAsync(Bebida bebida);
        Task UpdateAsync(Bebida bebida);
        Task DeleteAsync(int id);
        Task InicializarDatosAsync();

    }
}
