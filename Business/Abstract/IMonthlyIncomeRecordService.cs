using Business.Dtos.Requests.MonthlyIncomeRecord;
using Business.Dtos.Responses.MonthlyIncomeRecord;

namespace Business.Abstract;

public interface IMonthlyIncomeRecordService
{
    public Task<CreatedMonthlyIncomeRecordResponse> AddAsync(CreateMonthlyIncomeRecordRequest createMonthlyIncomeRecordRequest);
    public Task<IList<GetListMonthlyIncomeRecordResponse>> GetListAsync();
    public Task<GetByIdMonthlyIncomeRecordResponse> GetByIdAsync(GetByIdMonthlyIncomeRecordRequest getByIdMonthlyIncomeRecordRequest);
    public Task<UpdatedMonthlyIncomeRecordResponse> UpdateAsync(UpdateMonthlyIncomeRecordRequest updateMonthlyIncomeRecordRequest);
    public Task<DeletedMonthlyIncomeRecordResponse> DeleteAsync(DeleteMonthlyIncomeRecordRequest deleteMonthlyIncomeRecordRequest);
    public Task<IList<DeletedMonthlyIncomeRecordResponse>> DeleteRangeAsync(IList<DeleteMonthlyIncomeRecordRequest> deleteMonthlyIncomeRecordRequest);


    public Task<GetByDateMonthlyIncomeRecordResponse> GetByDateAsync(GetByDateMonthlyIncomeRecordRequest getListByDateMonthlyIncomeRecordRequest);
}
