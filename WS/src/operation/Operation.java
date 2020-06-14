/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package operation;

import java.util.List;
import types.*;

/**
 *
 * @author TanatosX
 */
public interface Operation{
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
