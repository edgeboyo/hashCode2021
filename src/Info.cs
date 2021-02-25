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

public class Node {

    public List<Street> streetIn;
    public List<Street> streetOut;
}

public class Street {

    public Street(string _name, int _toCross, Node _goesFrom, Node _goesTo) {
        name = _name;
        toCross = _toCross;
        goesFrom = _goesFrom;
        goesTo = _goesTo;
    }
    public string name;
    public int toCross;
    public Node goesFrom;
    public Node goesTo;
}

public class Car {
    public List<Street> streets;
}