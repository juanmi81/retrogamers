using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;


    void OnTriggerEnter(Collider other)
    {
        // Instantiate(explosion, transform.position, transform.rotation);
        if (other.CompareTag("limite")) return;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
