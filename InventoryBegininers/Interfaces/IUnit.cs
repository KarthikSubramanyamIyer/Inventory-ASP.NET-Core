using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryBegininers.Models;

namespace InventoryBegininers.Interfaces
{
    public interface IUnit
    {
        List<Unit> GetItem();
        Unit GetUnit(int id);

        Unit Create(Unit unit);

        Unit Edit(Unit unit);

        Unit Delete(Unit unit);
           
    }
}
