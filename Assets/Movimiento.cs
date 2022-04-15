using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    [Header("Movimiento")]
    public float speed;
    private Rigidbody rig;

    [Header("Armas")]
    public GameObject Disparo;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    void Start() {

        rig = GetComponent<Rigidbody>();   

    }

   
    void Update() {

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Disparo, shotSpawn.position, shotSpawn.rotation);
        }

        float movimientohorizontal = Input.GetAxis("Horizontal");

        float movimientovertical = Input.GetAxis("Vertical");

        Vector3 control = new Vector3(movimientohorizontal, 0f, movimientovertical);

        rig.velocity = control * speed;
       


    }


}
