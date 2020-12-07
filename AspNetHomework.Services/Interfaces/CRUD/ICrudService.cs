namespace AspNetHomework.Services.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс сервиса с базовыми CRUD-операциями.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    public interface ICrudService<TDto> :
        ICreatable<TDto>,
        IDeletable,
        IGettable<TDto>,
        IGettableById<TDto>,
        IUpdatable<TDto>
    {
    }
}
