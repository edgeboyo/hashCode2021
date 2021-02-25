using System;
using System.Collections.Generic;
using System.Linq;

public class Brute1{

    public Info info;

    public Brute1(Info info){
        this.info = info;
    } 

    public void Do(){

        System.Console.WriteLine($"Time: {info.time}");

        // create schedules in nodes
        foreach (var node in info.nodes)
        {
            node.schedule = new Street[info.time + 1];
        }

        // do for each car
        foreach (var car in info.cars)
        {
            System.Console.WriteLine($"Car {car.id}");

            // count the whole time needed
            int wholeTime = 0;
            for(int i=1; i<car.streets.Count; i++){
                wholeTime += car.streets[i].toCross;
            }
            if(wholeTime > info.time){
                continue;
            }

            // first street - begin at end
            int timer = 1;
            Street street = car.streets[0];
            Node node = street.goesTo;
            System.Console.WriteLine($"{street.name}, {timer}");
            node.TryAddToSchedule(street, timer);

            // next streets
            for(int i=1; i<car.streets.Count; i++){
                street = car.streets[i];
                node = street.goesTo;
                timer += street.toCross;
                System.Console.WriteLine($"{street.name}, {timer}");
                node.TryAddToSchedule(street, timer);
            }
        }

        foreach(var node in info.nodes)
        {
            node.PrintSchedule();
        }
    }
}