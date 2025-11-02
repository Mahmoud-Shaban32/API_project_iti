using API_Project.DTOs;

namespace API_Project.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto> GetCategoryByIdAsync(int id);
        Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto categoryDto);
        Task<CategoryDto> UpdateCategoryAsync(int id, CreateCategoryDto categoryDto);
        Task<bool> DeleteCategoryAsync(int id);
    }
}
