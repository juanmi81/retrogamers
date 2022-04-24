using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barradevida : MonoBehaviour
{
    public Image barraDevida;

    public float vidaActual;
    public float vidaInicial;

    public GameObject explosion_player;

    // Update is called once per frame
    void Update()
    {
        barraDevida.fillAmount = vidaActual / vidaInicial;
        if (barraDevida.fillAmount <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosion_player, transform.position, transform.rotation);
        }
    }
}

