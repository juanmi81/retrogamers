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
        Time.timeScale = 1f;
        SceneManager.LoadScene("retrogamers1");  
    }

    public void cargarpartida()
    {
        SceneManager.LoadScene("FINJUEGO");
    }

    public void sonido()
    {

    }

    public void salir()
    {
        Application.Quit();
        Debug.Log("salio del juego");
    }
}
