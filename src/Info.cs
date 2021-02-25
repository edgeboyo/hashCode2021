using System;
using System.Collections.Generic;

public class Info {
    public int time;

    public int points;

    public Node[] nodes;

    public Street[] streets;

    public Car[] cars;
    

    public Street getStreetByName(string name) {
        foreach(Street s in streets) {
            if(s.name.Equals(name)) {
                return s;
            }
        }

        return null;
    }
}