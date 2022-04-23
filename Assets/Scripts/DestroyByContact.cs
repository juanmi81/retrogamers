using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("limite")) return;
        
        Destroy(other.gameObject);
        Instantiate(explosion, transform.localPosition, Quaternion.identity);
        Destroy(gameObject);
        Destroy(explosion);
        return;
            
        
    }
}
