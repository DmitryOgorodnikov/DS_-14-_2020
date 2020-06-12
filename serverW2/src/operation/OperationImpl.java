/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package operation;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;
import java.util.List;
import types.*;

/**
 *
 * @author TanatosX
 */

public class OperationImpl extends UnicastRemoteObject implements Operation {
    public OperationImpl ()throws RemoteException{
    }
    static List<Autoparts> lstA = new ArrayList<Autoparts>();
    static List<Brands> lstB = new ArrayList<Brands>();
    static List<Promotions> lstP = new ArrayList<Promotions>();
    static List<Suppliers> lstS = new ArrayList<Suppliers>();
    static List<Warranty> lstW = new ArrayList<Warranty>();
    static {
        lstB.add(new Brands("BMW","Немецкий производитель автомобилей, мотоциклов, двигателей, а также велосипедов"));
        lstB.add(new Brands("Toyota","Крупнейшая японская автомобилестроительная корпорация"));
        lstP.add(new Promotions("+1","06.10.2020",30,"Дополнительная гарантия на год"));
        lstP.add(new Promotions("Toyota30","06.10.2020",60,"Скидка в 30% на запчасти от Toyota"));
        lstS.add(new Suppliers("Аврора","г. Санкт-Петербург, ул. Софийская, д. 2, лит. Б",88123269217L,7804371992L));
        lstS.add(new Suppliers("Орум","г. Санкт-Петербург, ул. Лужская, д. 3",78122488550L,7810155397L));
        lstW.add(new Warranty("Стандартная BMW",12));
        lstW.add(new Warranty("Стандартная Toyota",18));
    }
    

    @Override
    public List<Autoparts> getListA ()throws RemoteException{
        return lstA;
    }
    
    @Override
    public List<Brands> getListB ()throws RemoteException{
        return lstB;  
    }
    
    @Override
    public List<Promotions> getListP ()throws RemoteException{
        return lstP;
    }
    
    @Override
    public List<Suppliers> getListS ()throws RemoteException{
        return lstS;
    }
    
    @Override
    public List<Warranty> getListW ()throws RemoteException{
        return lstW;
    }
    
    @Override
    public List<Autoparts> remListA (int sr)throws RemoteException{
        lstA.remove(sr);
        return lstA;
    }
    
    @Override
    public List<Brands> remListB (int sr)throws RemoteException{
        lstB.remove(sr);
        return lstB;
    }
    
    @Override
    public List<Promotions> remListP (int sr)throws RemoteException{
        lstP.remove(sr);
        return lstP;
    }
    
    @Override
    public List<Suppliers> remListS (int sr)throws RemoteException{
        lstS.remove(sr);
        return lstS;
    }
    
    @Override
    public List<Warranty> remListW (int sr)throws RemoteException{
        lstW.remove(sr);
        return lstW;
    }
    
    @Override
    public List<Autoparts> addNewAutopart (Autoparts item)throws RemoteException{
        lstA.add(item);
        return lstA;
    }
    
    @Override
    public List<Brands> addNewBrand (Brands item)throws RemoteException{
        lstB.add(item);
        return lstB;
    }
    
    @Override
    public List<Promotions> addNewPromotion (Promotions item)throws RemoteException{
        lstP.add(item);
        return lstP;
    }
    
    @Override
    public List<Suppliers> addNewSupplier (Suppliers item)throws RemoteException{
        lstS.add(item);
        return lstS;
    }
    
    @Override
    public List<Warranty> addNewWarranty (Warranty item)throws RemoteException{
        lstW.add(item);
        return lstW;
    }
    
    @Override
    public int getSum ()throws RemoteException{
        int sum = 0;
        for (Autoparts autoparts: lstA)
        {
            sum += autoparts.getKol()*autoparts.getPrice();
        }
        return sum;
    }
}
