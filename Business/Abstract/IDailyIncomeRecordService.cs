using Business.Dtos.Requests.DailyIncomeRecord;
using Business.Dtos.Responses.DailyIncomeRecord;

namespace Business.Abstract;

public interface IDailyIncomeRecordService
{
    public Task<CreatedDailyIncomeRecordResponse> AddAsync(CreateDailyIncomeRecordRequest createDailyIncomeRecordRequest);
    public Task<IList<GetListDailyIncomeRecordResponse>> GetListAsync();
    public Task<GetByIdDailyIncomeRecordResponse> GetByIdAsync(GetByIdDailyIncomeRecordRequest getByIdDailyIncomeRecordRequest);
    public Task<UpdatedDailyIncomeRecordResponse> UpdateAsync(UpdateDailyIncomeRecordRequest updateDailyIncomeRecordRequest);
    public Task<DeletedDailyIncomeRecordResponse> DeleteAsync(DeleteDailyIncomeRecordRequest deleteDailyIncomeRecordRequest);
    public Task<IList<DeletedDailyIncomeRecordResponse>> DeleteRangeAsync(IList<DeleteDailyIncomeRecordRequest> deleteDailyIncomeRecordRequest);


    public Task<GetByProductNameDailyIncomeRecordResponse> GetByProductNameAsync(GetByProductNameDailyIncomeRecordRequest getByProductNameDailyIncomeRecordRequest);
}
