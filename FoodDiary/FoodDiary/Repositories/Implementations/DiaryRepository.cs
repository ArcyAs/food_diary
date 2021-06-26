using FoodDiary.Data;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using FoodDiary.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLitePCL;

namespace FoodDiary.Repositories.Implementations
{
    public class DiaryRepository : IDiaryRepository
    {
        private readonly ApplicationDbContext _context;

        public DiaryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DiaryEntity>> GetDiaryByUserDiaryId(Guid userDiaryId, DateTime? fromDate, DateTime? endDate)
        {
            if (fromDate == null && endDate == null)
                return await _context.DiaryEntities.Where(x => x.DiaryId == userDiaryId && x.IdProduct != Guid.Empty).ToListAsync();

            return await _context.DiaryEntities.Where(p => p.DiaryId == userDiaryId && p.IdProduct != Guid.Empty && p.AddDate.Date >= fromDate.GetValueOrDefault() && p.AddDate.Date <= endDate.GetValueOrDefault()).ToListAsync();
        }

        public async Task<int> GetKcal(Guid userDiaryId)
        {
            var data = await _context.DiaryEntities.Where(x => x.DiaryId == userDiaryId && x.IdProduct != Guid.Empty).ToListAsync();
            var data1 = data.Where(x => x.AddDate.Date == DateTime.Today).ToList();
            var totalKcal = data1.AsEnumerable().Sum(row => row.Kcal);
            return totalKcal;
        }


        public async Task AddDiary(DiaryEntity diaryEntity)
        {
            _context.DiaryEntities.Add(diaryEntity);
            await _context.SaveChangesAsync();
        }

        public async Task AddProductToDiary(ProductEntity productEntity, Guid userId, Guid diaryId)
        {
            var rescaledKcal = RescalingKcalService.RescaleKcal(productEntity.Kcal, productEntity.Weight);

            var newDiaryEntity = new DiaryEntity()
            {
                Id = Guid.NewGuid(),
                IdProduct = productEntity.Id,
                DiaryId = diaryId,
                Weight = productEntity.Weight,
                Kcal = Convert.ToInt32(rescaledKcal),
                AddDate = DateTime.Now
            };
            _context.DiaryEntities.Add(newDiaryEntity);
            await _context.SaveChangesAsync();
        }

        public Task<List<DiaryEntity>> GetDiaryByDate(DateTime? @from, DateTime? to)
        {
            throw new NotImplementedException();
        }

        public async Task<DateTime> GetLastDate()
        {
            var lastDate = _context.DiaryEntities.OrderBy(x => x.AddDate).FirstOrDefault().AddDate;
            return lastDate;
        }

        public async Task<List<DiaryEntity>> GetDiaryByDate(DateTime from, DateTime to)
        {
            var data = await _context.DiaryEntities.Where(x => x.AddDate >= from && x.AddDate <= to).ToListAsync();
            return data;
        }
    }
}