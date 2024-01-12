using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.DailyIncomeRecord;
using Business.Dtos.Requests.MonthlyIncomeRecord;
using Business.Dtos.Responses.DailyIncomeRecord;
using Business.Dtos.Responses.MonthlyIncomeRecord;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class DailyIncomeRecordManager : IDailyIncomeRecordService
{
    private readonly IDailyIncomeRecordDal _dailyIncomeRecordDal;
    private readonly IMapper _mapper;

    public DailyIncomeRecordManager(IDailyIncomeRecordDal dailyIncomeRecordDal, IMapper mapper)
    {
        _dailyIncomeRecordDal = dailyIncomeRecordDal;
        _mapper = mapper;
    }
   
    public async Task<CreatedDailyIncomeRecordResponse> AddAsync(CreateDailyIncomeRecordRequest createDailyIncomeRecordRequest)
    {
        


        DailyIncomeRecord dailyIncomeRecord = _mapper.Map<DailyIncomeRecord>(createDailyIncomeRecordRequest);
  
       DailyIncomeRecord createdDailyIncomeRecord = await _dailyIncomeRecordDal.AddAsync(dailyIncomeRecord);

       CreatedDailyIncomeRecordResponse createdDailyIncomeRecordResponse = _mapper.Map<CreatedDailyIncomeRecordResponse>(createdDailyIncomeRecord);

        return createdDailyIncomeRecordResponse;
    }

    public async Task<DeletedDailyIncomeRecordResponse> DeleteAsync(DeleteDailyIncomeRecordRequest deleteDailyIncomeRecordRequest)
    {
        DailyIncomeRecord? dailyIncomeRecord = await _dailyIncomeRecordDal.GetAsync(p => p.Id == deleteDailyIncomeRecordRequest.Id);

      

        DailyIncomeRecord? deletedDailyIncomeRecord = await _dailyIncomeRecordDal.DeleteAsync(dailyIncomeRecord);

        DeletedDailyIncomeRecordResponse mappedDailyIncomeRecord = _mapper.Map<DeletedDailyIncomeRecordResponse>(deletedDailyIncomeRecord);

        return mappedDailyIncomeRecord;
    }

    public async Task<IList<DeletedDailyIncomeRecordResponse>> DeleteRangeAsync(IList<DeleteDailyIncomeRecordRequest> deleteDailyIncomeRecordRequest)
    {
        IList<DailyIncomeRecord> dailyIncomeRecords = _mapper.Map<IList<DailyIncomeRecord>>(deleteDailyIncomeRecordRequest);

        IList<DailyIncomeRecord> deletedDailyIncomeRecords = await _dailyIncomeRecordDal.DeleteRangeAsync(dailyIncomeRecords);

        IList<DeletedDailyIncomeRecordResponse> mappedDailyIncomeRecords = _mapper.Map<IList<DeletedDailyIncomeRecordResponse>>(deletedDailyIncomeRecords);

        return mappedDailyIncomeRecords;
    }

    public async Task<GetByIdDailyIncomeRecordResponse> GetByIdAsync(GetByIdDailyIncomeRecordRequest getByIdDailyIncomeRecordRequest)
    {
        DailyIncomeRecord? dailyIncomeRecord = await _dailyIncomeRecordDal.GetAsync(p => p.Id == getByIdDailyIncomeRecordRequest.Id, enableTracking: false);

  

        GetByIdDailyIncomeRecordResponse getByIdDailyIncomeRecordResponse = _mapper.Map<GetByIdDailyIncomeRecordResponse>(dailyIncomeRecord);

        return getByIdDailyIncomeRecordResponse;
    }

    public async Task<GetByProductNameDailyIncomeRecordResponse> GetByProductNameAsync(GetByProductNameDailyIncomeRecordRequest getByProductNameDailyIncomeRecordRequest)
    {
        DailyIncomeRecord? dailyIncomeRecord = await _dailyIncomeRecordDal.GetAsync(p => p.ProductName.ToLower() == getByProductNameDailyIncomeRecordRequest.ProductName.ToLower(), enableTracking: false);
        GetByProductNameDailyIncomeRecordResponse getByProductNameDailyIncomeRecordResponse = _mapper.Map<GetByProductNameDailyIncomeRecordResponse>(dailyIncomeRecord);
        return getByProductNameDailyIncomeRecordResponse;
    }


    public async Task<IList<GetListDailyIncomeRecordResponse>> GetListAsync()
    {
        var data = await _dailyIncomeRecordDal.GetListAsync(enableTracking: false);

        IList<GetListDailyIncomeRecordResponse> getListDailyIncomeRecordResponses = _mapper.Map<IList<GetListDailyIncomeRecordResponse>>(data);

        return getListDailyIncomeRecordResponses;
    }

    public async Task<UpdatedDailyIncomeRecordResponse> UpdateAsync(UpdateDailyIncomeRecordRequest updateDailyIncomeRecordRequest)
    {
       

        DailyIncomeRecord? dailyIncomeRecord = await _dailyIncomeRecordDal.GetAsync(p => p.Id == updateDailyIncomeRecordRequest.Id, enableTracking: false);



        _mapper.Map(updateDailyIncomeRecordRequest, dailyIncomeRecord);


        DailyIncomeRecord? updatedDailyIncomeRecord = await _dailyIncomeRecordDal.UpdateAsync(dailyIncomeRecord);


        UpdatedDailyIncomeRecordResponse mappedDailyIncomeRecord = _mapper.Map<UpdatedDailyIncomeRecordResponse>(updatedDailyIncomeRecord);

        return mappedDailyIncomeRecord;
    }
}
