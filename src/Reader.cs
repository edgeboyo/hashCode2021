using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Reader
{
    private StreamReader _sr;
    private int _counter;

    /*
    public Info ReadInfo(string path)
    {
        _info = new Info();

        _sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.UTF8);
        _ps = new PizzaStr();

        string[] firstLine = _sr.ReadLine().Split(' ');

        _info.NoPizzas = int.Parse(firstLine[0]);
        _info.NoTeams2 = int.Parse(firstLine[1]);
        _info.NoTeams3 = int.Parse(firstLine[2]);
        _info.NoTeams4 = int.Parse(firstLine[3]);

        return _info;
    }
    */

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