using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroybyContact : MonoBehaviour {

    public GameObject explosion;
      
    
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("limite")) return;

        Instantiate(explosion, transform.position, transform.rotation);
  
        
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }
}
