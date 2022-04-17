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

    private int mleft=-550,mright=550,mtop= 0, mbotton=100, mcerca= -100, mlejos= 1500;
    void Start() {

        rig = GetComponent<Rigidbody>();   

    }

    void FixedUpdate()
    {
        float movimientohorizontal = Input.GetAxis("Horizontal");

        float movimientovertical = Input.GetAxis("Vertical");

        Vector3 control = new Vector3(movimientohorizontal, 0f, movimientovertical);

        rig.velocity = control * speed;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, mleft, mright), Mathf.Clamp(transform.position.y, mtop, mbotton), Mathf.Clamp(transform.position.z, mcerca, mlejos));

    }

    void Update() {

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Disparo, shotSpawn.position, shotSpawn.rotation);
        }

        

    }


}
