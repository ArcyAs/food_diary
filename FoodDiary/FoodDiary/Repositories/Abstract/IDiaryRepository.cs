using FoodDiary.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Repositories.Abstract
{
    public interface IDiaryRepository
    {
        Task<List<DiaryEntity>> GetDiaryByUserDiaryId(Guid id);
        Task AddDiary(DiaryEntity diaryEntity);
        Task AddProductToDiary(ProductEntity productEntity, Guid userId, Guid diaryId);
        Task<List<DiaryEntity>> GetDiaryByDate(DateTime from, DateTime to);
    }
}
