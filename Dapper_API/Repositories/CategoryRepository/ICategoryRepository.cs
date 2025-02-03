using System;

namespace Dapper_API.Repositories.CategoryRepository;
using Dapper_API.Dtos.CategoryDtos;

public interface ICategoryRepository
{
        Task<List<ResultCategoryDto>> GetAllCategory();
        Task CreateCategory(CreateCategoryDto categoryDto);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIdCategoryDto> GetCategory(int id);
    
}
