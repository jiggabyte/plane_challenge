using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameDownController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject vehicle;

    // private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;


    private bool downButtonHeld = false; // Flag to track if the button is held down

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPointerDown(PointerEventData eventData)
    {
        // This method is called when the button is initially pressed

        downButtonHeld = true;



        InvokeRepeating("Downward", 0f, 0.1f);


    }

    public void OnPointerUp(PointerEventData eventData)
    {

        // This method is called when the button is initially pressed

        downButtonHeld = false;

        CancelInvoke("Downward");


    }


    public void Downward()
    {
        int backwardMove = 0;
        backwardMove -= 1;
        // Move the vehicle backward.
        vehicle.transform.Translate(Vector3.forward * Time.deltaTime * speed * backwardMove);
    }
  


}
