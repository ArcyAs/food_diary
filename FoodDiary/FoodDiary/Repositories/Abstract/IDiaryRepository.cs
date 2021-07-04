using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodDiary.Repositories.Entities;

namespace FoodDiary.Repositories.Abstract
{
    public interface IDiaryRepository
    {
        Task<List<DiaryEntity>> GetDiaryByUserDiaryId(Guid id, DateTime? fromDate, DateTime? endDate);
        Task AddDiary(DiaryEntity diaryEntity);
        Task AddProductToDiary(ProductEntity productEntity, Guid userId, Guid diaryId);
        Task<List<DiaryEntity>> GetDiaryByDate(DateTime? from, DateTime? to);
        Task<DateTime> GetLastDate(Guid userId);
    }
}