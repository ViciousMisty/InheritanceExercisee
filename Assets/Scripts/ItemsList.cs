using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsList : MonoBehaviour
{

    public string itemName;
    public int value;
    public int weight;

    float pricePerWeight;

    public float GetPriceperWeight()
    {
        return value / weight;
    }

    private void OnMouseEnter()
    {
        Debug.Log(ToString());
    }
    public override string ToString()
    {
        return "A well shaped " + itemName + " costs " + GetPriceperWeight() + " kr/" + "kg";
    }
}
