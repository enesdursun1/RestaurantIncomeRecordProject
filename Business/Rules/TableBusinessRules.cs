using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Rules;

public class TableBusinessRules
{
    private readonly ITableDal _tableDal;

    public TableBusinessRules(ITableDal tableDal)
    {
        _tableDal = tableDal;
    }

    public void TableShouldExistWhenSelected(Table table)
    {

        if (table == null)
            throw new Exception("Table not exists");
    }
    public async Task TableNameCanNotBeDuplicatedWhenInserted(string name)
    {
        Table? result = await _tableDal.GetAsync(p => p.Name.ToLower() == name.ToLower());
        if (result != null)
            throw new BusinessException("Table name exists");
    }
    public async Task CategoryNameCanNotBeDuplicatedWhenUpdated(Table table)
    {
        Table? result = await _tableDal.GetAsync(x => x.Id != table.Id && x.Name.ToLower() == table.Name.ToLower());
        if (result != null)
            throw new BusinessException("Table name exists");

    }
}