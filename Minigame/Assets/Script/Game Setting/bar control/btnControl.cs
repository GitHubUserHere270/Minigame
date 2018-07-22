using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnControl : MonoBehaviour {

    public GameObject bar;

    public bool buttonPressed;

    int k = 1;

    void leftbutton()
    {
          k = 1;

          buttonPressed = true;

        if (buttonPressed)
        {
            bar.transform.Rotate(0, 0, 0.01f * k);
        }
    }

    void rightbutton()
    {
          k = -1;

          buttonPressed = true;

        if (buttonPressed)
        {
            bar.transform.Rotate(0, 0, 0.01f * k);
        }
    }

   





}
