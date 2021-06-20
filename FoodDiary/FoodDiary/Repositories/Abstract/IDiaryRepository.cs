using FoodDiary.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Repositories.Abstract
{
    public interface IDiaryRepository
    {
        Task<DiaryEntity> GetDiaryByUserId(Guid id);
        Task AddDiary(DiaryEntity diaryEntity);

    }
}
