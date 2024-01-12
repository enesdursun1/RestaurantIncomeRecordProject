using Business.Dtos.Requests.Table;
using Business.Dtos.Responses.Table;

namespace Business.Abstract;

public interface ITableService
{
    public Task<CreatedTableResponse> AddAsync(CreateTableRequest createTableRequest);
    public Task<IList<GetListTableResponse>> GetListAsync();
    public Task<GetByIdTableResponse> GetByIdAsync(GetByIdTableRequest getByIdTableRequest);
    public Task<UpdatedTableResponse> UpdateAsync(UpdateTableRequest updateTableRequest);

    public Task<DeletedTableResponse> DeleteAsync(DeleteTableRequest deleteTableRequest);




}

