/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package service_endpoint;

import java.util.List;
import javax.jws.WebMethod;
import javax.jws.WebService;
import operation.OperationImpl;
import types.*;
/**
 *
 * @author TanatosX
 */
@WebService()
public class Service {
    static OperationImpl obj = new OperationImpl();
    
    @WebMethod()
    public ListA getA(){
        ListA lstRet = null;
                
        List<Autoparts> lstA = obj.getListA();
        if(lstA != null){
            lstRet = new ListA();
            lstRet.setItem(lstA);
        }
        return lstRet; 
    }
    
    @WebMethod()
    public ListA setA(Autoparts autopart){
        ListA lstRet = null;
        
        List<Autoparts> lst = obj.addNewAutopart(autopart);
        if(lst != null){
            lstRet = new ListA();
            lstRet.setItem(lst);
        }
        return lstRet; 
    }
    
    public ListA remA(int sr){
        ListA lstRet = null;

        List<Autoparts> lst = obj.remListA(sr);
        if(lst != null){
            lstRet = new ListA();
            lstRet.setItem(lst);
        }
            return lstRet; 
    }
    
    @WebMethod()
    public int getSumA (){
        return obj.getSum();
    }
    
    @WebMethod()
    public ListB getB(){
        ListB lstRet = null;
                
        List<Brands> lstB = obj.getListB();
        if(lstB != null){
            lstRet = new ListB();
            lstRet.setItem(lstB);
        }
        return lstRet; 
    }
    
    @WebMethod()
    public ListB setB(Brands brand){
        ListB lstRet = null;
        
        List<Brands> lst = obj.addNewBrand(brand);
        if(lst != null){
            lstRet = new ListB();
            lstRet.setItem(lst);
        }
        return lstRet; 
    }
    
    public ListB remB(int sr){
    ListB lstRet = null;
        
    List<Brands> lst = obj.remListB(sr);
    if(lst != null){
        lstRet = new ListB();
        lstRet.setItem(lst);
    }
        return lstRet; 
    }

    @WebMethod()
    public ListP getP(){
        ListP lstRet = null;
                
        List<Promotions> lstP = obj.getListP();
        if(lstP != null){
            lstRet = new ListP();
            lstRet.setItem(lstP);
        }
        return lstRet; 
    }
    
    @WebMethod()
    public ListP setP(Promotions promotion){
        ListP lstRet = null;
        
        List<Promotions> lst = obj.addNewPromotion(promotion);
        if(lst != null){
            lstRet = new ListP();
            lstRet.setItem(lst);
        }
        return lstRet; 
    }
    
    public ListP remP(int sr){
    ListP lstRet = null;
        
    List<Promotions> lst = obj.remListP(sr);
    if(lst != null){
        lstRet = new ListP();
        lstRet.setItem(lst);
    }
        return lstRet; 
    }
    
    @WebMethod()
    public ListS getS(){
        ListS lstRet = null;
                
        List<Suppliers> lstS = obj.getListS();
        if(lstS != null){
            lstRet = new ListS();
            lstRet.setItem(lstS);
        }
        return lstRet; 
    }
    
    @WebMethod()
    public ListS setS(Suppliers supplier){
        ListS lstRet = null;
        
        List<Suppliers> lst = obj.addNewSupplier(supplier);
        if(lst != null){
            lstRet = new ListS();
            lstRet.setItem(lst);
        }
        return lstRet; 
    }
    
    public ListS remS(int sr){
    ListS lstRet = null;
        
    List<Suppliers> lst = obj.remListS(sr);
    if(lst != null){
        lstRet = new ListS();
        lstRet.setItem(lst);
    }
        return lstRet; 
    }
    
    @WebMethod()
    public ListW getW(){
        ListW lstRet = null;
                
        List<Warranty> lstW = obj.getListW();
        if(lstW != null){
            lstRet = new ListW();
            lstRet.setItem(lstW);
        }
        return lstRet; 
    }
    
    @WebMethod()
    public ListW setW(Warranty warranty){
        ListW lstRet = null;
        
        List<Warranty> lst = obj.addNewWarranty(warranty);
        if(lst != null){
            lstRet = new ListW();
            lstRet.setItem(lst);
        }
        return lstRet; 
    }
    
    public ListW remW(int sr){
    ListW lstRet = null;
        
    List<Warranty> lst = obj.remListW(sr);
    if(lst != null){
        lstRet = new ListW();
        lstRet.setItem(lst);
    }
        return lstRet; 
    }    
}
