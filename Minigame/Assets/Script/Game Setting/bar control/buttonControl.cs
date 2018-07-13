using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMovement : MonoBehaviour {

    public GameObject bar;

    void leftbutton()
    {
        bar.transform.Rotate(0, 0, 1f);
    }

    void rightbutton()
    {
        bar.transform.Rotate(0, 0, 1f);
    }

}
