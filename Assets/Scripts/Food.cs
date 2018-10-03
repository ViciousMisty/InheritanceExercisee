using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Consume
{
    public int saturation;

    public override string AteText()
    {
        Saturation.saturation += saturation;
        return ("Eating..." + "You comsumed " + itemName + " and gained " + saturation + " saturation" +
            ". Uses left: " + uses);
    }
    public override string NoUsesLeft()
    {
        return ("No " + itemName + "s" + " left");
    }
}
