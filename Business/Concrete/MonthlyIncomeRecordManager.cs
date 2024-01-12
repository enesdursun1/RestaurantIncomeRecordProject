using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.Category;
using Business.Dtos.Requests.MonthlyIncomeRecord;
using Business.Dtos.Requests.Order;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.MonthlyIncomeRecord;
using Business.Dtos.Responses.Order;
using Business.Rules;
using Business.ValidationRules.FluentValidation.Category;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class MonthlyIncomeRecordManager : IMonthlyIncomeRecordService
{
    private readonly IMonthlyIncomeRecordDal _monthlyIncomeRecordDal;
    private readonly IMapper _mapper;

    public MonthlyIncomeRecordManager(IMonthlyIncomeRecordDal monthlyIncomeRecordDal, IMapper mapper)
    {
        _monthlyIncomeRecordDal = monthlyIncomeRecordDal;
        _mapper = mapper;
    }

    public async Task<CreatedMonthlyIncomeRecordResponse> AddAsync(CreateMonthlyIncomeRecordRequest createMonthlyIncomeRecordRequest)
    {

       


        MonthlyIncomeRecord monthlyIncomeRecord = _mapper.Map<MonthlyIncomeRecord>(createMonthlyIncomeRecordRequest);

        MonthlyIncomeRecord createdMonthlyIncomeRecord = await _monthlyIncomeRecordDal.AddAsync(monthlyIncomeRecord);

        CreatedMonthlyIncomeRecordResponse createdMonthlyIncomeRecordResponse = _mapper.Map<CreatedMonthlyIncomeRecordResponse> (createdMonthlyIncomeRecord);

        return createdMonthlyIncomeRecordResponse;
    }

    public async Task<DeletedMonthlyIncomeRecordResponse> DeleteAsync(DeleteMonthlyIncomeRecordRequest deleteMonthlyIncomeRecordRequest)
    {
        MonthlyIncomeRecord? monthlyIncomeRecord = await _monthlyIncomeRecordDal.GetAsync(p => p.Id == deleteMonthlyIncomeRecordRequest.Id);



        MonthlyIncomeRecord? deletedMonthlyIncomeRecord = await _monthlyIncomeRecordDal.DeleteAsync(monthlyIncomeRecord);

        DeletedMonthlyIncomeRecordResponse mappedMonthlyIncomeRecord = _mapper.Map<DeletedMonthlyIncomeRecordResponse>(deletedMonthlyIncomeRecord);

        return mappedMonthlyIncomeRecord;
    }

    public async Task<IList<DeletedMonthlyIncomeRecordResponse>> DeleteRangeAsync(IList<DeleteMonthlyIncomeRecordRequest> deleteMonthlyIncomeRecordRequest)
    {
        IList<MonthlyIncomeRecord> monthlyIncomeRecords = _mapper.Map<IList<MonthlyIncomeRecord>>(deleteMonthlyIncomeRecordRequest);

        IList<MonthlyIncomeRecord> deletedMonthlyIncomeRecords = await _monthlyIncomeRecordDal.DeleteRangeAsync(monthlyIncomeRecords);

        IList<DeletedMonthlyIncomeRecordResponse> mappedMonthlyIncomeRecords = _mapper.Map<IList<DeletedMonthlyIncomeRecordResponse>>(deletedMonthlyIncomeRecords);

        return mappedMonthlyIncomeRecords;
    }

    public async Task<GetByIdMonthlyIncomeRecordResponse> GetByIdAsync(GetByIdMonthlyIncomeRecordRequest getByIdMonthlyIncomeRecordRequest)
    {
        MonthlyIncomeRecord? monthlyIncomeRecord = await _monthlyIncomeRecordDal.GetAsync(p => p.Id == getByIdMonthlyIncomeRecordRequest.Id ,enableTracking: false);
      
   
       
        GetByIdMonthlyIncomeRecordResponse getByIdMonthlyIncomeRecordResponse = _mapper.Map<GetByIdMonthlyIncomeRecordResponse>(monthlyIncomeRecord);

        return getByIdMonthlyIncomeRecordResponse;
    }

    public async Task<IList<GetListMonthlyIncomeRecordResponse>> GetListAsync()
    {
        var data = await _monthlyIncomeRecordDal.GetListAsync(enableTracking: false);
        
        IList<GetListMonthlyIncomeRecordResponse> getListMonthlyIncomeRecordResponses = _mapper.Map<IList<GetListMonthlyIncomeRecordResponse>>(data);
       
        return getListMonthlyIncomeRecordResponses;
    }

    public async Task<GetByDateMonthlyIncomeRecordResponse> GetByDateAsync(GetByDateMonthlyIncomeRecordRequest getListByDateMonthlyIncomeRecordRequest)
    {
        MonthlyIncomeRecord? monthlyIncomeRecord = await _monthlyIncomeRecordDal.GetAsync(predicate:p=>p.Date==getListByDateMonthlyIncomeRecordRequest.Date, enableTracking: false);
        GetByDateMonthlyIncomeRecordResponse getByDateMonthlyIncomeRecordResponse = _mapper.Map<GetByDateMonthlyIncomeRecordResponse>(monthlyIncomeRecord);
        return getByDateMonthlyIncomeRecordResponse;
    }

    public async Task<UpdatedMonthlyIncomeRecordResponse> UpdateAsync(UpdateMonthlyIncomeRecordRequest updateMonthlyIncomeRecordRequest)
    {
       
       
        MonthlyIncomeRecord? monthlyIncomeRecord = await _monthlyIncomeRecordDal.GetAsync(p => p.Id == updateMonthlyIncomeRecordRequest.Id, enableTracking: false);

     

        _mapper.Map(updateMonthlyIncomeRecordRequest, monthlyIncomeRecord);


        MonthlyIncomeRecord? updatedMonthlyIncomeRecord = await _monthlyIncomeRecordDal.UpdateAsync(monthlyIncomeRecord);


        UpdatedMonthlyIncomeRecordResponse mappedMonthlyIncomeRecord = _mapper.Map<UpdatedMonthlyIncomeRecordResponse>(updatedMonthlyIncomeRecord);

        return mappedMonthlyIncomeRecord;
    }
}
