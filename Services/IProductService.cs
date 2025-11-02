using API_Project.DTOs;

namespace API_Project.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(CreateProductDto productDto);
        Task<ProductDto> UpdateProductAsync(int id, CreateProductDto productDto);
        Task<bool> DeleteProductAsync(int id);
    }
}
