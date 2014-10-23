using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DLL.DAO;
using Shop.DLL.Getway;

namespace Shop.BLL
{
    class ProductBLL
    {
        ProductGetway aProductGetway=new ProductGetway();
        public string Save(Product aProduct)
        {
             if (aProduct.Code.Length < 3 || aProduct.Code.Length > 3)
            {
                return "A code length must be three character:";
            }
            if (aProduct.Name.Length<5 || aProduct.Name.Length >10)
            {
                return "A name length must be 5 to 10 charcter:";
            }
            
             if (HasThisCodeValid(aProduct.Code))
             {
                return "This code already exist:";
       
             }
            if (HasThisNameValid(aProduct.Name))
            {
                return "This name already exist:";
            }
            return aProductGetway.Save(aProduct);
            

        }

        public bool HasThisCodeValid(string code)
        {
            return aProductGetway.HasThisCodeValid(code);
        }

        public bool HasThisNameValid(string name)
        {
            return aProductGetway.HasThisNameValid(name);
        }

        public List<Product> GetTottalProductInfo()
        {
            return aProductGetway.GetTottalProductInfo();
        }

        public int GetTotalQuantiy()
        {
            return aProductGetway.GetTotalQuantiy();
        }
    }
}
