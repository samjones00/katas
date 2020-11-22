using System;
using System.Collections.Generic;

public class TrainComposition
{
    public TrainComposition()
    {
        wagons = new LinkedList<int>();
    }

    private LinkedList<int> wagons;


    public void AttachWagonFromLeft(int wagonId)
    {
        wagons.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        wagons.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        var i = wagons.First.Value;
        wagons.RemoveFirst();
        return i;
    }

    public int DetachWagonFromRight()
    {
        var i = wagons.Last.Value;
        wagons.RemoveLast();
        return i;
    }


    public static void Main(string[] args)
    {
        TrainComposition train = new TrainComposition();
        train.AttachWagonFromLeft(7);
        train.AttachWagonFromLeft(13);
        Console.WriteLine(train.DetachWagonFromRight()); // 7 
        Console.WriteLine(train.DetachWagonFromLeft()); // 13
    }
}
