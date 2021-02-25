using System;
using System.Collections.Generic;

public class Node {

    public int id;
    public List<Street> streetIn = new List<Street>();
    public List<Street> streetOut = new List<Street>();

    public List<int> times;
    // schedule for brute 1
    public Street[] schedule;
    public void TryAddToSchedule(Street street, int time){
        if(schedule[time - 1] == null){
            schedule[time - 1] = street;
        }
    }
    public void PrintSchedule(){
        System.Console.WriteLine($"Node {id}: ");
        for(int i=0; i<schedule.Length - 1; i++){
            System.Console.WriteLine($"       {i + 1} {schedule[i]?.name}");
        }
    }
    
}