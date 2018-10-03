using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consume : ItemsList
{
    public Text usesText;
    public int uses;
    public int maxUses;

    void Start()
    {
        uses = maxUses;
        usesText.text = "USES: " + uses;
    }

    private void OnMouseUpAsButton()
    {
        Use();
        if (uses >= 0)
        {
            Debug.Log(AteText());
            usesText.text = "USES: " + uses;

        }

    }

    public virtual string AteText()
    {
        return ("A");
    }

    void Use()
    {
        if (uses >= 0)
        {
            uses--;
        }
        else
        {
            Debug.Log(NoUsesLeft());
        }
    }
    public virtual string NoUsesLeft()
    {
        return ("B");
    }
    


    void Update()
    {

    }
}
