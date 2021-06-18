using FoodDiary.Data;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Repositories.Implementations
{
    public class DiaryRepository : IDiaryRepository
    {
        private readonly ApplicationDbContext _context;

        public DiaryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<DiaryEntity> GetDiaryByUserId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
