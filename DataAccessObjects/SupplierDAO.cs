
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SupplierDAO
    {
        private static SupplierDAO instance = null;
        private static object lockOject = new object();
        public SupplierDAO() { }
        public static SupplierDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SupplierDAO();
                }
                return instance;
            }
        }
        public List<Supplier> GetSuppliers()
        {
            using var db = new FStoreDBContext();
            return db.Suppliers.ToList();
        }
        public Supplier GetSupplierById(int? id)
        {
            using var db = new FStoreDBContext();
            return db.Suppliers.SingleOrDefault(f => f.SupplierId.Equals(id));
        }
        public Supplier GetSupplierByName(string name)
        {
            using var db = new FStoreDBContext();
            return db.Suppliers.SingleOrDefault(f => f.SupplierName.Equals(name));
        }
    }
}
