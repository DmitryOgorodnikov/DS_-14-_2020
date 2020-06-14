/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package registration;

import javax.xml.ws.Endpoint;
import service_endpoint.Service;

/**
 *
 * @author TanatosX
 */
public class PublicWS {
    public static void main (String[] argv) {
        Endpoint.publish("http://localhost:8080/WS/Service",
	new Service());
    }
}