using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public interface IMachineRepo
    {
        IEnumerable<MachineACafeEntity> All { get; }

        MachineACafeEntity GetById(int id);

        void Save(MachineACafeEntity machineacafe);

    }
}
