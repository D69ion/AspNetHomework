namespace AspNetHomework.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для работы с базовыми CRUD репозиториями.
    /// </summary>
    /// <typeparam name="TDto">Dto.</typeparam>
    /// <typeparam name="TModel">Доменная модель.</typeparam>
    public interface ICrudRepository<TDto, TModel> : 
        ICreatable<TDto, TModel>,
        IDeletable,
        IGettable<TDto, TModel>,
        IGettableById<TDto, TModel>,
        IUpdatable<TDto, TModel>
    {
    }
}
