using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speed 
    private float speed = 15.0f;
    private float turnSpeed = 12.0f;

    //inputs dont have to be spacifc but it helps to name them correctly
    private float a;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //turning imput
        Debug.Log(Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * a);
    }
}
