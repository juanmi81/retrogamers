using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupausa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void escenajuego()
    {
        SceneManager.LoadScene("JUEGO");
    }

    public void guardarpartida()
    {

    }

    public void sonido()
    {
            
    }

    public void salir()
    {
        SceneManager.LoadScene("MENUPRINCIPAL");
    }
}
