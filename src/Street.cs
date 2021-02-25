using System;
using System.Collections.Generic;

public class Street {

    public int id;
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