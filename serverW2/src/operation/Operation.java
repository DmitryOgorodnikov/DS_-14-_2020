/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package operation;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;
import types.*;

/**
 *
 * @author TanatosX
 */
public interface Operation extends Remote{
    List<Autoparts> getListA ()throws RemoteException;
    List<Brands> getListB ()throws RemoteException;
    List<Promotions> getListP ()throws RemoteException;
    List<Suppliers> getListS ()throws RemoteException;
    List<Warranty> getListW ()throws RemoteException;
    
    List<Autoparts> remListA (int sr)throws RemoteException;
    List<Brands> remListB (int sr)throws RemoteException;
    List<Promotions> remListP (int sr)throws RemoteException;
    List<Suppliers> remListS (int sr)throws RemoteException;
    List<Warranty> remListW (int sr)throws RemoteException;
    
    List<Autoparts> addNewAutopart (Autoparts item)throws RemoteException;
    List<Brands> addNewBrand (Brands item)throws RemoteException;
    List<Promotions> addNewPromotion (Promotions item)throws RemoteException;
    List<Suppliers> addNewSupplier(Suppliers item)throws RemoteException;
    List<Warranty> addNewWarranty (Warranty item)throws RemoteException;
    int getSum ()throws RemoteException;
}
