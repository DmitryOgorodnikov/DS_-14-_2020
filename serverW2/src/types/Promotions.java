/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package types;
import java.io.Serializable;

/**
 *
 * @author TanatosX
 */
public class Promotions implements Serializable{
    public String name;
    public String data;
    public int duration;
    public String essence;
    
    public Promotions() {
        this.name = "";
        this.data = "";
        this.duration = 0;
        this.essence= "";
    }

    public Promotions(String name, String data, int duration, String essence) {
        this.name = name;
        this.data = data;
        this.duration = duration;
        this.essence = essence;
    }

    public String getData() {
        return data;
    }

    public void setData(String data) {
        this.data = data;
    }

    public int getDuration() {
        return duration;
    }

    public void setDuration(int duration) {
        this.duration = duration;
    }

    public String getEssence() {
        return essence;
    }

    public void setEssence(String essence) {
        this.essence = essence;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    
}
