using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        public List<Supplier> GetSuppliers()
            => SupplierDAO.Instance.GetSuppliers();

        public Supplier GetSupplierById(int? id)
            => SupplierDAO.Instance.GetSupplierById(id);

        public Supplier GetSupplierByName(string name)
            => SupplierDAO.Instance.GetSupplierByName(name);
    }
}
