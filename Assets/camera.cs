using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float ySens = 10f, xSens = 10f;

    float xRotation = 0f;

    public Transform playerHead;
    
    void Start()
    {
        //travando a camera e desligando o cursor da tela
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //definindo o movimento do mouse
        float mouseY = Input.GetAxis("Mouse Y") * ySens * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * xSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerHead.Rotate(Vector3.up * mouseX);
    }
}
