using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Outside.OrderStreamSync
{
    public class DepartmentSync
    {
        private readonly IDepartmentFactory _departmentFactory;
        private readonly IDepartment _departmentPersister;

        public DepartmentSync(
            IDepartmentFactory departmentFactory,
            IDepartment department)
        {
            _departmentPersister = department;
            _departmentFactory = departmentFactory;
        }

        public async Task Add(Department _department)
        {
            var department = _departmentFactory.Add(_department);
            await _departmentPersister.Persist(department);
        }
        public async Task Update(Department _department)
        {
            var department = _departmentFactory.Update(_department);
            await _departmentPersister.Update(department);
        }
        public async Task Remove(Department _department)
        {
            var employee = _departmentFactory.Remove(_department, _department.id);
            await _departmentPersister.Remove(employee);
        }
    }
}
