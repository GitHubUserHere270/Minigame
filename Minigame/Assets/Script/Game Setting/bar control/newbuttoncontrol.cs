using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class newbuttoncontrol : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    bool buttonPressed;

    public GameObject bar;

    public float speed;

    int k = 1;

    public void OnPointerDown(PointerEventData eventData) {
        if (this.name == "leftButton") {
            k = 1;
        } else if (this.name == "rightButton") {
            k = -1;
        }
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        buttonPressed = false;
    }


    void Update() {

        if (buttonPressed) {

            bar.transform.Rotate(0, 0, speed * k * Time.deltaTime);
        }

    }


    
    
}