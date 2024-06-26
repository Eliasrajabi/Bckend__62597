
using backend.Database.Data_transfer_object.Request.SubCategory;
using backend.Models;

namespace backend.Controllers.Interfaces
{
    public interface ISubCategoryRepository
    {
        Task<IEnumerable<SubCategory>> GetAllSubCategoriesAsync();
        Task<SubCategory?> GetSubCategoryByIdAsync(int id);
        Task<SubCategory> CreateSubCategoryAsync(SubCategory subCategory);
        Task<SubCategory?> UpdateSubCategoryAsync(int id, Put_SubCategoryDto subCategoryDto);
        Task<SubCategory?> DeleteSubCategoryAsync(int id);
        Task<SubCategory?> SubCategoryNameExisting(string name);
        Task<bool? > SubCategoryExists(int id);
    }
}