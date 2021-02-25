using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Reader
{
    private StreamReader _sr;

    public Info ReadInfo(string path)
    {
        Info inf = new Info();
        _sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.UTF8);

        String[] parse = _sr.ReadLine().Split(' ');
        int secs = Int32.Parse(parse[0]);
        int intersect = Int32.Parse(parse[1]);
        int streetsNo = Int32.Parse(parse[2]);
        int carsNo = Int32.Parse(parse[3]);
        int points = Int32.Parse(parse[4]);

        inf.time = secs;

        Node[] nodes = new Node[intersect];

        for(int i=0; i<intersect; i++)
            nodes[i] = new Node();

        Street[] streets = new Street[streetsNo];

        for(int i=0; i<streetsNo; i++) {
            parse = _sr.ReadLine().Split(' ');
            int from = Int32.Parse(parse[0]);
            int to = Int32.Parse(parse[1]);

            string name = parse[2];
            int takes = Int32.Parse(parse[3]);

            streets[i] = new Street(name, takes, nodes[from], nodes[to]);
            nodes[from].streetOut.Add(streets[i]);
            nodes[to].streetIn.Add(streets[i]);
        }

        inf.nodes = nodes;
        inf.streets = streets;

        Car[] cars = new Car[carsNo];

        for(int i=0; i<carsNo; i++) {
            cars[i] = new Car();
            parse = _sr.ReadLine().Split(' ');
            int howMany = Int32.Parse(parse[0]);

            int q = 1;
            while(howMany > 0) {
                Street s = inf.getStreetByName(parse[q++]);
                cars[i].streets.Add(s);
                howMany--;
            }
        }

        inf.cars = cars;

        return inf;
    }

    /*
    public Pizza ReadNextPizza()
    {
        string line;
        if ((line = _sr.ReadLine()) != null)
        {
            string[] subs = line.Split(' ');

            int noIngredients = int.Parse(subs[0]);
            int[] ingredients = new int[noIngredients];

            for (int i = 0; i < noIngredients; i++){
                ingredients[i] = _ps.GetID(subs[i + 1]);
            }

            Pizza pizza = new Pizza(noIngredients, ingredients);
            _counter ++;
            return pizza;
        }
        return null;
    }
    */
}