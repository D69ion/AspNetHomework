using AspNetHomework.Database.Contexts;
using AspNetHomework.Database.Domain;
using AspNetHomework.Models.DTO;
using AspNetHomework.Repositories.Interfaces.CRUD;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetHomework.Repositories
{
    /// <summary>
    /// Базовый класс для работы с CRUD.
    /// </summary>
    /// <typeparam name="TDto">Dto.</typeparam>
    /// <typeparam name="TModel">Доменная модель.</typeparam>
    public abstract class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel>
        where TDto : BaseDto
        where TModel : BaseEntity
    {
        private readonly IMapper _mapper;
        protected readonly AspNetHomeworkContext _context;
        protected DbSet<TModel> DbSet => _context.Set<TModel>();

        /// <summary>
        /// Инициализирует экземпляр <see cref="BaseRepository{TDto, TModel}"/>.
        /// </summary>
        /// <param name="context">Контекст.</param>
        /// <param name="mapper">Маппер.</param>
        protected BaseRepository(AspNetHomeworkContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc cref="ICreatable{TDto, TModel}.CreateAsync(TDto)"/>
        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await DbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await GetAsync(entity.Id);
        }

        /// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            var entities = await DbSet.Where(x => ids.Contains(x.Id)).ToListAsync();
            _context.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc cref="IGettable{TDto, TModel}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default)
        {
            var entities = await DbSet.AsNoTracking().ToListAsync();
            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);
            return dtos;
        }

        /// <inheritdoc cref="IGettableById{TDto, TModel}.GetAsync(long)"/>
        public async Task<TDto> GetAsync(long id)
        {
            var entity = await DbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }

        /// <inheritdoc cref="IUpdatable{TDto, TModel}.UpdateAsync(TDto, CancellationToken)"/>
        public async Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default)
        {
            var entity = _mapper.Map<TModel>(dto);
            _context.Update(entity);
            await _context.SaveChangesAsync(token);
            var newEntity = await GetAsync(entity.Id);
            return _mapper.Map<TDto>(newEntity);
        }
    }
}
