using System;
using System.Collections.Generic;
using System.Linq;

public class Node {

    public int id;
    public List<Street> streetIn = new List<Street>();
    public List<Street> streetOut = new List<Street>();

    public List<int> times = new List<int>();

    // schedule for brute 1
    public Street[] schedule;
    
    public void TryAddToSchedule(Street street, int time){

        for(int i=time; i<=schedule.Length; i++){
            if(schedule[i - 1] == null){
                schedule[i - 1] = street;
                break;
            }
        }
    }
    public string GetSchedule(){

        /*
        System.Console.WriteLine($"Node {id}: ");
        for(int i=0; i<schedule.Length; i++){
            System.Console.WriteLine($"       {i + 1} {schedule[i]?.name}");
        }
        */
        
        string s = "";
        s += $"\n{id}";

        List<Pair> pairs = new List<Pair>();
        for(int i=0; i<schedule.Length -1; i++){
            Street street = schedule[i];
            if(street != null){
                var p = pairs.Where(t => t.street == street).FirstOrDefault();
                if(p != null){
                    p.count++;
                }
                else{
                    pairs.Add(new Pair(street, 1));
                }
            }
        }

        if(pairs.Count == 0)
            return "";

        s += $"\n{pairs.Count}";
        foreach(var pair in pairs){
            s += $"\n{pair.ToString()}";
        }

        return s;
    }

    public class Pair{

        public Pair(Street street, int count){
            this.street = street;
            this.count = count;
        }

        public Street street;
        public int count;

        public override string ToString()
        {
            if(count == 0)
                return "";
            else 
                return  ($"{street.name} {count}");
        }
    }
    
}