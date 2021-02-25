using System;
using System.Collections.Generic;

public class Brute2 {

    public string compute(Info inf) {
        List<StreetCounter> scounter = new List<StreetCounter>();

        for(int i=0; i<inf.streets.Length; i++) {
            scounter.Add(new StreetCounter());

            scounter[i].count = 0;
            scounter[i].street = inf.streets[i];
        }

        Dictionary<Node, int> sums = new Dictionary<Node, int>();
        foreach(Car car in inf.cars) {
            foreach(Street street in car.streets) {
                foreach(StreetCounter sc in scounter){
                    if(street == sc.street){
                        sc.count++;
                        if(!sums.ContainsKey(street.goesTo)) {
                            sums.Add(street.goesTo, 0);
                        }
                        sums[street.goesTo]++;
                    }
                }
            }
        }

        int time = inf.time;

        foreach(Node node in inf.nodes) {
            bool moreThanZero = false;
            foreach(Street st in node.streetIn) {
                bool found = false;
                foreach(StreetCounter sc in scounter) {
                    if(st == sc.street) {
                        found = true;
                        if(sc.count == 0 || !sums.ContainsKey(node)) {
                            node.times.Add(0);
                            break;
                        }
                        moreThanZero = true;
                        float calc = MathF.Round(((float) sc.count / (float) sums[node]) * (float) time);
                        node.times.Add((int) calc);
                        break;
                    }
                }
                if(!found){
                    Console.WriteLine("Error!");
                }
            }

            if(!moreThanZero){
                node.times = null;
            }
        }

        string result = "";

        List<Result> r = new List<Result>();
        foreach(Node node in inf.nodes) {
            if(node.times == null)
                continue;

            Result res = new Result();
            res.nodeId = node.id;

            for(int i=0 ;i<node.times.Count; i++) {
                if(node.times[i] == 0)
                    continue;
                res.Add(node.times[i], node.streetIn[i].name);
            }
            r.Add(res);
        }

        result += r.Count + "\n";

        foreach(Result res in r) {
            result += res.nodeId +"\n";
            //Console.WriteLine(res.l.Count);
            result += res.l.Count +"\n";

            foreach(NodeResult nr in res.l) {
                result += nr.name + " " + nr.num + "\n";
            }
        }
        return result;
    }
}

class StreetCounter {


    public int count;
    public Street street;
}

public class Result {

    public int nodeId;
    public List<NodeResult> l = new List<NodeResult>();

    public void Add(int num, string name) {
        l.Add(new NodeResult(num, name));
    }
}

public class NodeResult {

    public NodeResult(int num, string name) {
        this.num = num;
        this.name = name;
    }
    public int num;
    public string name;
}