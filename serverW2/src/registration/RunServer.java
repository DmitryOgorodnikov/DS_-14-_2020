/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package registration;

import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import operation.OperationImpl;

/**
 *
 * @author TanatosX
 */
public class RunServer {      
  public static void main (String[] argv) {
    try {
                        // создание экземпляров классов для регистрации
			OperationImpl operationImpl = new OperationImpl();
			
			// создаём реестр
			Registry registry = LocateRegistry.createRegistry(1199);
			
			// регистрация классов
			registry.bind("rmiTest02", operationImpl);   
        
      System.out.println ("Server is ready.");
    } catch (Exception e) {
      System.out.println ("Server failed: " + e);
    }
  }

}
