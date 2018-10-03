using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamePopup : MonoBehaviour {

    public GameObject Text;

	void Start ()
    {
        Text.SetActive(false);
	}
    public void OnMouseOver()
    {
        Text.SetActive(true);
    }
    public void OnMouseExit()
    {
        Text.SetActive(false);
    }

}
