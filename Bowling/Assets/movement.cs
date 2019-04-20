﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rig;
    public float force = 0;
    public float speed;

    const float limiteDer = 4.024572f;

    bool bolaEnJuego = false;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = -Input.GetAxis("Vertical");
        float rSpeed = speed;

        if (!bolaEnJuego)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + horizontal * rSpeed);

            if (transform.position.z >= limiteDer)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, limiteDer);
            }

            if (transform.position.z <= -limiteDer)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -limiteDer);
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
                    force -= 100;
                }
                else if (Input.GetKeyUp(KeyCode.UpArrow))
                {
                    force += 100;
                }

                if (force < 0)
                {
                    force = 0;
                }
                Debug.Log("la fuerza de la bola es: " + force);
                
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                bolaEnJuego = true;
                force*= rSpeed;
                rig.AddForce(new Vector3(-force, 0, 0), ForceMode.Force);
            }
        }
    }
}
 