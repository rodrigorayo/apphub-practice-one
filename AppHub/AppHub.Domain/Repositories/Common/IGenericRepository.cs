public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);  // Obtener un elemento por su ID.
    Task<IEnumerable<T>> GetAllAsync();  // Obtener todos los elementos.
    Task AddAsync(T entity);  // Agregar un nuevo elemento.
    void Update(T entity);  // Actualizar un elemento existente.
    void Delete(T entity);  // Eliminar un elemento.
}
