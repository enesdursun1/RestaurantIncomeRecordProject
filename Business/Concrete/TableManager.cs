using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.Category;
using Business.Dtos.Requests.Product;
using Business.Dtos.Requests.Table;
using Business.Dtos.Responses.Product;
using Business.Dtos.Responses.Table;
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

public class TableManager : ITableService
{
    private readonly ITableDal _tableDal;
    private readonly IMapper _mapper;   
    private readonly TableBusinessRules _tableBusinessRules;   

    public TableManager(ITableDal tableDal, IMapper mapper, TableBusinessRules tableBusinessRules)
    {
        _tableDal = tableDal;
        _mapper = mapper;
        _tableBusinessRules = tableBusinessRules;
    }

    public async Task<CreatedTableResponse> AddAsync(Dtos.Requests.Table.CreateTableRequest createTableRequest)
    {
        await ValidationManager.ValidateAsync(typeof(CreateTableValidator), createTableRequest);

        await _tableBusinessRules.TableNameCanNotBeDuplicatedWhenInserted(createTableRequest.Name);

        Table table = _mapper.Map<Table>(createTableRequest);

        Table createdTable = await _tableDal.AddAsync(table);

        CreatedTableResponse createdProductResponse = _mapper.Map<CreatedTableResponse>(createdTable);

        return createdProductResponse;
    }

    public async Task<DeletedTableResponse> DeleteAsync(DeleteTableRequest deleteTableRequest)
    {

        Table? table = await _tableDal.GetAsync(p => p.Id == deleteTableRequest.Id);

        _tableBusinessRules.TableShouldExistWhenSelected(table);

        Table? deletedTable = await _tableDal.DeleteAsync(table);

        DeletedTableResponse mappedTable = _mapper.Map<DeletedTableResponse>(deletedTable);

        return mappedTable;
    }

    public async Task<GetByIdTableResponse> GetByIdAsync(GetByIdTableRequest getByIdTableRequest)
    {
  
        Table? table = await _tableDal.GetAsync(p => p.Id == getByIdTableRequest.Id,enableTracking:false);

        _tableBusinessRules.TableShouldExistWhenSelected(table);
       
        GetByIdTableResponse getByIdTableResponse = _mapper.Map<GetByIdTableResponse>(table);


        return getByIdTableResponse;
    }


    public async Task<IList<GetListTableResponse>> GetListAsync()
    {
        var data = await _tableDal.GetListAsync(enableTracking: false);
        IList<GetListTableResponse> getListTableResponses = _mapper.Map<IList<GetListTableResponse>>(data);
        return getListTableResponses;
    }

   

    public async Task<UpdatedTableResponse> UpdateAsync(UpdateTableRequest updateTableRequest)
    {

        await ValidationManager.ValidateAsync(typeof(UpdateTableValidator), updateTableRequest);

        Table? table = await _tableDal.GetAsync(p => p.Id == updateTableRequest.Id);

        _tableBusinessRules.TableShouldExistWhenSelected(table);

        _mapper.Map(updateTableRequest, table);

        await _tableBusinessRules.CategoryNameCanNotBeDuplicatedWhenUpdated(table);

        Table? updatedTable = await _tableDal.UpdateAsync(table);

        UpdatedTableResponse mappedTable = _mapper.Map<UpdatedTableResponse>(updatedTable);

        return mappedTable;
    }
}
