using System;
using System.Collections.Generic;

public class Brute2 {

    void compute(Info inf) {
        List<StreetCounter> scounter = new List<StreetCounter>();

        for(int i=0; i<inf.streets.Length; i++) {
            scounter.Add(new StreetCounter());

            scounter[i].count = 0;
            scounter[i].street = inf.streets[i];
        }

        int sum = 0;
        foreach(Car car in inf.cars) {
            foreach(Street street in car.streets) {
                foreach(StreetCounter sc in scounter){
                    if(street == sc.street){
                        sc.count++;
                        sum++;
                    }
                }
            }
        }

        int time = inf.time;

        foreach(Node node in inf.nodes) {
            foreach(Street st in node.streetIn) {
                bool found = false;
                foreach(StreetCounter sc in scounter) {
                    if(st == sc.street) {
                        found = true;
                        double calc = time;
                        node.times.Add((int)Math.Round(calc/sc.count));
                    }
                }
                if(!found){
                    Console.WriteLine("Error!");
                }
            }
        }

        
    }
}

class StreetCounter {


    public int count;
    public Street street;
}

public class Result {

}