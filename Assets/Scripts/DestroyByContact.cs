using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;

    public float damage;

    void OnTriggerEnter(Collider other)
    {
        // Instantiate(explosion, transform.position, transform.rotation);
        if (other.CompareTag("limite")) return;
        if (other.CompareTag("Jugador")) { other.GetComponent<Barradevida>().vidaActual -= damage; }
        else { Destroy(other.gameObject); }
        Destroy(gameObject);
    }
}
