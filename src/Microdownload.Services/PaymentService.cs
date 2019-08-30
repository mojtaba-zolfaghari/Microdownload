using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microdownload.Services
{
    public interface IPaymentService
    {
        Task<long> InsertPayment(long price, string bankName, int userId, PaymentType paymentType);
        Task UpdatePayment(long paymentId, string vresult, long saleReferenceId, string refId, bool paymentFinished = false, int factorId = 0);

        Task<bool> DeletePayment(long paymentId);


        Task<PaymentViewModel> GetPayment(long paymentId);

        Task<List<PaymentViewModel>> GetAllPaymentsByUserId(int userId);
        Task<PagingViewModel<PaymentViewModel>> GetAllPayments(int pageNumber, int pageSize);

    }
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly DbSet<Payment> _Payment;
        private readonly IMapper _mapper;

        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _Payment = unitOfWork.Set<Payment>();
            _mapper = mapper;
        }
        public async Task<bool> DeletePayment(long paymentId)
        {
            try
            {
                var payment = await _Payment.FindAsync(paymentId);
                _Payment.Remove(payment);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<PagingViewModel<PaymentViewModel>> GetAllPayments(int pageNumber, int pageSize)
        {
            var offset = (pageSize * pageNumber) - pageSize;

            var query = await _Payment
            .AsNoTracking()
            .OrderByDescending(pay => pay.PaymentId)
            .ProjectTo<PaymentViewModel>().ToListAsync();


            return new PagingViewModel<PaymentViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count
                },
                List = query.Skip(offset).Take(pageSize).ToList()
            };



        }

        public async Task<List<PaymentViewModel>> GetAllPaymentsByUserId(int userId)
        {
            var result = await _Payment.ToListAsync();

            var userpay = (from p in result
                           where p.UserId == userId
                           select p).ToList();
            var model = _mapper.Map<List<Payment>, List<PaymentViewModel>>(userpay);

            return model;
        }

        public async Task<PaymentViewModel> GetPayment(long paymentId)
        {
            var payment = await _Payment.FindAsync(paymentId);
            var model = _mapper.Map<Payment, PaymentViewModel>(payment);
            return model;
        }

        public async Task<long> InsertPayment(long price, string bankName, int userId, PaymentType paymentType)
        {
            long paymentId = 0;
            try
            {
                var payment = new Payment();
                payment.Amount = price;
                payment.SaleReferenceId = 0;
                payment.BankName = bankName;
                payment.PaymentFinished = false;
                payment.UserId = userId;
                payment.PaymentType = paymentType;
                await _Payment.AddAsync(payment);

                await _UnitOfWork.SaveChangesAsync();

                paymentId = payment.PaymentId;
            }
            catch
            {
            }

            return paymentId;
        }

        public async Task UpdatePayment(long paymentId, string vresult, long saleReferenceId, string refId, bool paymentFinished = false, int factorId = 0)
        {
            var payment = await _Payment.FindAsync(paymentId);

            if (payment != null)
            {
                payment.StatusPayment = vresult;
                payment.SaleReferenceId = saleReferenceId;
                payment.PaymentFinished = paymentFinished;
                payment.FactorId = factorId;


                if (refId != null)
                {
                    payment.ReferenceNumber = refId;
                }
            }
            else
            {

            }
        }
    }
}
