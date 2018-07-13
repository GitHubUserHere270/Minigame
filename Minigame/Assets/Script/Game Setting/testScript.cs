using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class testScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public bool buttonPressed;

    public GameObject coin;


    int k = 1;

    public void OnPointerDown(PointerEventData eventData) {
        if (this.name == "leftBtn") {
            k = 1;
        } else if (this.name == "rightBtn") {
            k = -1;
        }
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        buttonPressed = false;
       
    }


    void Update() {

        if (buttonPressed) {

            coin.transform.position += new Vector3(0.01f*k, 0f, 0f);
        }

    }


    
    
}