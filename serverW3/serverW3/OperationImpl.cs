using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverW3
{
    public class OperationImpl : MarshalByRefObject, Operation
    {
        public static List<Autoparts> lstA = new List<Autoparts>();
        public static List<Brands> lstB = new List<Brands>();
        public static List<Promotions> lstP = new List<Promotions>();
        public static List<Suppliers> lstS = new List<Suppliers>();
        public static List<Warranty> lstW = new List<Warranty>();

        public List<Autoparts> getListA (){
        return lstA;
        }
    
        public List<Brands> getListB (){
        return lstB;  
        }
    
        public List<Promotions> getListP (){
        return lstP;
        }
    
        public List<Suppliers> getListS (){
        return lstS;
        }
    
        public List<Warranty> getListW (){
        return lstW;
        }
    
        public List<Autoparts> remListA (int sr){
            lstA.RemoveAt(sr);
            return lstA;
        }
    
        public List<Brands> remListB (int sr){
            lstB.RemoveAt(sr);
            return lstB;
        }
    
        public List<Promotions> remListP (int sr){
            lstP.RemoveAt(sr);
            return lstP;
        }
    
        public List<Suppliers> remListS (int sr){
            lstS.RemoveAt(sr);
            return lstS;
        }
    
        public List<Warranty> remListW (int sr){
            lstW.RemoveAt(sr);
            return lstW;
        }
    
        public List<Autoparts> addNewAutopart (Autoparts item){
        lstA.Add(item);
        return lstA;
        }
    
        public List<Brands> addNewBrand (Brands item){
        lstB.Add(item);
        return lstB;
        }
    
        public List<Promotions> addNewPromotion (Promotions item){
        lstP.Add(item);
        return lstP;
        }
    
        public List<Suppliers> addNewSupplier (Suppliers item){
        lstS.Add(item);
        return lstS;
        }
    
        public List<Warranty> addNewWarranty (Warranty item){
        lstW.Add(item);
        return lstW;
        }
    
        public int getSum (){
            int sum = 0;
            foreach (Autoparts autoparts in lstA)
            {
                sum += autoparts.getKol()*autoparts.getPrice();
            }
            return sum;
        }
    }
}
