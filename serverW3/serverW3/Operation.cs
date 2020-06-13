using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverW3
{
    public interface Operation
    {
        List<Autoparts> getListA ();
        List<Brands> getListB ();
        List<Promotions> getListP ();
        List<Suppliers> getListS ();
        List<Warranty> getListW ();
    
        List<Autoparts> remListA (int sr);
        List<Brands> remListB (int sr);
        List<Promotions> remListP (int sr);
        List<Suppliers> remListS (int sr);
        List<Warranty> remListW (int sr);
    
        List<Autoparts> addNewAutopart (Autoparts item);
        List<Brands> addNewBrand (Brands item);
        List<Promotions> addNewPromotion (Promotions item);
        List<Suppliers> addNewSupplier(Suppliers item);
        List<Warranty> addNewWarranty (Warranty item);
        int getSum ();
    }
}
