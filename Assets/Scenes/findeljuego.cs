using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class findeljuego : MonoBehaviour
{ 

    public void Scena2()
    {
       // Time.timeScale = 1f;
        SceneManager.LoadScene("retrogamers2");
    }

    public void Scena3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("retrogamers3");
    }

    public void salir()
    {
        SceneManager.LoadScene("MENUPRINCIPAL");
    }
}
