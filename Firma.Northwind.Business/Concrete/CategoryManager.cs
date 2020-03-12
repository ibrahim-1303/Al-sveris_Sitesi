using Firma.Northwind.Business.Abstact;
using Firma.Northwind.DataAccess.Abstract;
using Firma.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private  ICatergoryDal _categoryDal;
        public CategoryManager(ICatergoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
