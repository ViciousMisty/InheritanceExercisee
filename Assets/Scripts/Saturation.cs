using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saturation : MonoBehaviour
{

    public static int saturation;
    public Text text;

    void Update()
    {
        text.text = saturation.ToString("Saturation: 0");
    }
}
