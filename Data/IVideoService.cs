using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorDapperCRUD.Data
{
    public interface IVideoService
    {
        Task<bool> VideoInsert(Video video);
        Task<IEnumerable<Video>> VideoList();
        Task<Video> Video_GetOne(int Id);
        Task<bool> VideoUpdate(Video video);
    }
}