using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finialbtnControl : MonoBehaviour {

    public bool buttonPressed;

    public GameObject bar;


    int k = 1;

    void OnPointerDown()
    {
        if (this.name == "leftButton")
        {
            k = 1;
        }
        else if (this.name == "rightButton")
        {
            k = -1;
        }
        buttonPressed = true;
    }

    void OnPointerUp()
    {
        buttonPressed = false;

    }


    void Update()
    {

        if (buttonPressed)
        {

            bar.transform.position += new Vector3(0.01f * k, 0f, 0f);
        }

    }

}
