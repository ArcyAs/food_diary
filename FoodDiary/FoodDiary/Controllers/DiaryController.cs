using FoodDiary.Data;
using FoodDiary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using FoodDiary.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;


namespace FoodDiary.Controllers
{
    public class DiaryController : Controller
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IDiaryRepository _diaryRepository;
        private readonly ApplicationDbContext _context;
        private readonly IProductsRepository _productsRepository;
        private readonly UserManager<AppUser> _userManager;
        

        public DiaryController(IRepositoryFactory repositoryFactory, UserManager<AppUser> userManager, ApplicationDbContext applicationDbContext, IDiaryRepository diaryRepository,
            ApplicationDbContext context, IProductsRepository productsRepository)
        {
            _repositoryFactory = repositoryFactory;
            _userManager = userManager;
            _applicationDbContext = applicationDbContext;
            _diaryRepository = diaryRepository;
            _context = context;
            _productsRepository = productsRepository;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = _userManager.Users.FirstOrDefault(p => p.Email == User.FindFirstValue(ClaimTypes.Email));
            var userDetailsEntity = _context.UserDetailsEntities.FirstOrDefault(p => p.UserId == Guid.Parse(currentUser.Id));

            var diaryByUserDiaryId = await _diaryRepository.GetDiaryByUserDiaryId(userDetailsEntity?.DiaryId ?? Guid.Empty);

            var viewModel = new DiaryViewModel()
            {
                Diary = await ConvertToDto(diaryByUserDiaryId),
                UserId = Guid.Parse(currentUser?.Id ?? Guid.Empty.ToString()),
                DiaryId = userDetailsEntity?.DiaryId ?? Guid.Empty,

                
            };
            return View(viewModel);
        }

        private async Task<List<Diary>> ConvertToDto(IEnumerable<DiaryEntity> diaryByUserDiaryId)
        {
            var toReturn = new List<Diary>();
            foreach (var diaryEntity in diaryByUserDiaryId ?? new List<DiaryEntity>())
            {
                toReturn.Add(new Diary()
                {
                    Id = diaryEntity.Id,
                    Kcal = diaryEntity.Kcal,
                    Weight = diaryEntity.Weight,
                    AddDate = diaryEntity.AddDate,
                    DiaryId = diaryEntity.DiaryId,
                    ProductName = (await _productsRepository.GetProductById(diaryEntity.IdProduct))?.ProductName ?? ""
                });
            }

            return toReturn;
        }
        public async Task<IActionResult> AddNew(ProductEntity productEntity)
        {
            var currentUser = _userManager.Users.FirstOrDefault(p => p.Email == User.FindFirstValue(ClaimTypes.Email));
            var userDetailsEntity = _context.UserDetailsEntities.FirstOrDefault(p => p.UserId == Guid.Parse(currentUser.Id));
            var userId = Guid.Parse(currentUser?.Id ?? Guid.Empty.ToString());
           
            var diaryByUserDiaryId = await _diaryRepository.GetDiaryByUserDiaryId(userDetailsEntity?.DiaryId ?? Guid.Empty);
            var diaryId = userDetailsEntity?.DiaryId ?? Guid.Empty;

            await _diaryRepository.AddProductToDiary(productEntity,userId,diaryId);


            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Add(Guid productId)
        {
            var product = await _productsRepository.GetProductById(productId);
            return View("Add",product);
        }
        public async Task<IActionResult> Show(DateTime from,DateTime to)
        {           
            await _diaryRepository.GetDiaryByDate(from, to);
            return RedirectToAction("Index");
        }

    }

    public class DiaryViewModel
    {
        public List<Diary> Diary { get; set; }
        public Guid UserId { get; set; }
        public Guid DiaryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime HelpTime { get; set; }
    }
}