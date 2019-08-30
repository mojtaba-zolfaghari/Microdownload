using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microdownload.Services
{
    public interface IWalletService
    {
        Task<PagingViewModel<WalletViewModel>> GetAllTWallet(int userId, int pageNumber, int pageSize);

        Task<PagingViewModel<WalletViewModel>> GetAllPeymentRequest(int userId, int pageNumber, int pageSize);

        Task<PagingViewModel<WalletViewModel>> GetAllPeymentRequest(int pageNumber, int pageSize);

        Task<WalletViewModel> GetPeymentRequestById(int Id);

        Task<List<WalletViewModel>> GetAllTWallet(int userId);

        Task InsertTWalleTask(WalletViewModel tWallet);

        Task<IdentityResult> UpdateTWalleTask(WalletViewModel tWallet);




        Task<int> GetWalletInventory(int userId);
    }

    public class WalletService : IWalletService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _UnitOfWork;
        private readonly DbSet<Wallet> _Wallet;

        public WalletService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _UnitOfWork = unitOfWork;
            _Wallet = unitOfWork.Set<Wallet>();
        }

        public async Task<PagingViewModel<WalletViewModel>> GetAllPeymentRequest(int userId, int pageNumber, int pageSize)
        {
            var offset = (pageSize * pageNumber) - pageSize;
            var query = await _Wallet
            .AsNoTracking()
            .Include(c => c.User)
            .Where(c => c.User.RegistrarId == userId && (c.TType != WalletTransactionType.Deposit))
            .OrderByDescending(wallet => wallet.Id)
            .ProjectTo<WalletViewModel>().ToListAsync();


            return new PagingViewModel<WalletViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count
                },
                List = query.Skip(offset).Take(pageSize).ToList()
            };
        }

        public async Task<PagingViewModel<WalletViewModel>> GetAllPeymentRequest(int pageNumber, int pageSize)
        {
            var offset = (pageSize * pageNumber) - pageSize;
            var query = await _Wallet
            .AsNoTracking()
            .Include(c => c.User)
            .Where(c => (c.TType != WalletTransactionType.Deposit))
            .OrderByDescending(wallet => wallet.Id)
            .ProjectTo<WalletViewModel>().ToListAsync();


            return new PagingViewModel<WalletViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count
                },
                List = query.Skip(offset).Take(pageSize).ToList()
            };
        }

        public async Task<PagingViewModel<WalletViewModel>> GetAllTWallet(int userId, int pageNumber, int pageSize)
        {
            var offset = (pageSize * pageNumber) - pageSize;
            var query = await _Wallet
            .AsNoTracking()
            .Where(c => c.UserId == userId)
            .OrderByDescending(wallet => wallet.Id)
            .ProjectTo<WalletViewModel>().ToListAsync();


            return new PagingViewModel<WalletViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count
                },
                List = query.Skip(offset).Take(pageSize).ToList()
            };
        }

        public async Task<List<WalletViewModel>> GetAllTWallet(int userId)
        {
            var query = await _Wallet
            .AsNoTracking()
            .Where(c => c.UserId == userId)
            .OrderByDescending(wallet => wallet.Id)
            .ProjectTo<WalletViewModel>().ToListAsync();

            return query;
        }

        public async Task<WalletViewModel> GetPeymentRequestById(int Id)
        {
            var query = await _Wallet
                 .AsNoTracking()
                 .Where(c => c.Id == Id)
                 .ProjectTo<WalletViewModel>().FirstOrDefaultAsync();

            return query;

        }

        public async Task<int> GetWalletInventory(int userId)
        {
            var data = await GetAllTWallet(userId);

            var sumDeposit = data.Where(c => c.TType == WalletTransactionType.Deposit).Select(c => c.Amount).Sum();
            var sumRemoval = data.Where(c => c.TType == WalletTransactionType.Removal).Select(c => c.Amount).Sum();
            var sumwaiting = data.Where(c => c.TType == WalletTransactionType.Waiting).Select(c => c.Amount).Sum();
            return sumDeposit - sumRemoval - sumwaiting;

        }

        public async Task InsertTWalleTask(WalletViewModel tWallet)
        {
            var model = _mapper.Map<WalletViewModel, Wallet>(tWallet);
            await _Wallet.AddAsync(model);
        }

        public async Task<IdentityResult> UpdateTWalleTask(WalletViewModel tWallet)
        {

            var req = await GetPeymentRequestById(tWallet.Id.Value);
            req.TType = tWallet.TType;
            req.Description = tWallet.Description;
            var model = _mapper.Map<WalletViewModel, Wallet>(req);


            _UnitOfWork.Entry(model).State = EntityState.Modified;

            return IdentityResult.Success;
        }
    }

}
