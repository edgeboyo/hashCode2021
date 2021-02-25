using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Writer
{
    private StreamWriter _sw;

    /*
    public void Write(string path, Result result)
    {
        _sw = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write), Encoding.ASCII);
        
        String start = result.pizzaOrders.Count.ToString();
        _sw.WriteLine(start);

        foreach(var order in result.pizzaOrders)
        {
            string s = order.TeamSize + " ";
            for(int i=0; i<order.TeamSize-1; i++){
                s += order.Pizzas[i].uniqueID;
                s += " ";
            }
            s += order.Pizzas[order.TeamSize-1].uniqueID;

            _sw.WriteLine(s);
        }

        _sw.Close();
    }
    */
}