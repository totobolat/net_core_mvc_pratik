using System;
using Dapper_API.Dtos.CategoryDtos;
using Dapper_API.Models.DapperContext;
using Dapper;
namespace Dapper_API.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into \"Categories\" (\"CategoryName\",\"CategoryStatus\") values (@CategoryName,@CategoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName", categoryDto.CategoryName);
            parameters.Add("@CategoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCategory(int id)
        {
            string query = "Delete From \"Categories\" Where \"CategoryId\"=@CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async Task<List<ResultCategoryDto>> GetAllCategory()
        {
            string query = "Select * From \"Categories\"";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetCategory(int id)
        {
            string query = "Select * From \"Categories\" Where \"CategoryId\"=@CategoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "Update \"Categories\" Set \"CategoryName\"=@CategoryName, \"CategoryStatus\"=@CategoryStatus Where \"CategoryId\"=@CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName",categoryDto.CategoryName);
            parameters.Add("@CategoryStatus", categoryDto.CategoryStatus);
            parameters.Add("CategoryId", categoryDto.CategoryId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}