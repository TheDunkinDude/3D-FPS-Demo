using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float sens = 200f;

    public Transform Bird;

    float   Xrotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        

        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation , -90f , 90f);
    
        transform.localRotation = Quaternion.Euler(Xrotation , 0f , 0f);   
        Bird.Rotate(Vector3.up * mouseX);
    }
}
