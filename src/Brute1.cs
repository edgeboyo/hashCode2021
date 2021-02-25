using System;
using System.Collections.Generic;
using System.Linq;

public class Brute1{

    public Info info;

    public Brute1(Info info){
        this.info = info;
    } 

    public void Do(){

        foreach (var node in info.nodes)
        {
            node.schedule = new Street[info.time];
        }

        foreach (var car in info.cars)
        {
            int streetNo = car.streets.Count;
            int timer = 0;

            // first street - begin at end
            Street street = car.streets[0];
            Node node = street.goesTo;
            node.TryAddToSchedule(street, timer);

            for(int i=1; i<car.streets.Count; i++){
                street = car.streets[i];
                node = street.goesTo;
                timer += street.toCross;
                node.TryAddToSchedule(street, timer);
            }
        }

        foreach(var node in info.nodes)
        {
            node.PrintSchedule();
        }
    }
}