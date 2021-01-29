using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Outside.OrderStreamSync
{
    public interface IDepartment
    {
        Task Persist(Department department);

        Task Update(Department department);

        Task Remove(Department department);
    }
}
