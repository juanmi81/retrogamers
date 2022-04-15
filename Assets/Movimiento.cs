using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float speed;
    private Rigidbody rig;

    void Start() {

        rig = GetComponent<Rigidbody>();   

    }

   
    void Update() {

        float movimientohorizontal = Input.GetAxis("Horizontal");

        float movimientovertical = Input.GetAxis("Vertical");

        Vector3 control = new Vector3(movimientohorizontal, 0f, movimientovertical);

        rig.velocity = control * speed;
       


    }
}
