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

            
                if (!HasThisCodeValid(aProduct.Code))
                {
                    return aProductGetway.Save(aProduct);
                }


                return "Code allready exist";
            
            

        }

        public bool HasThisCodeValid(string code)
        {
            return aProductGetway.HasThisCodeValid(code);
        }

        public bool HasThisNameValid(string name)
        {
            return aProductGetway.HasThisNameValid(name);
        }
    }
}
