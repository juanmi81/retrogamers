using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuprincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    public void escenajuego()
    {
        SceneManager.LoadScene("JUEGO");  
    }

    public void cargarpartida()
    {
        SceneManager.LoadScene("JUEGO");
    }

    public void sonido()
    {

    }

    public void salir()
    {
        Application.Quit();
    }
}