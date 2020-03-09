using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoPlayer : MonoBehaviour
{
    CharacterController controller;
    public GameObject lanterna;
    public bool ligada = true;

    public float speed = 12f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            if (ligada == true)
            {
                lanterna.SetActive(false);
                ligada = false;
            }
            else 
            {
                lanterna.SetActive(true);
                ligada = true;
            }
        }
    }
}