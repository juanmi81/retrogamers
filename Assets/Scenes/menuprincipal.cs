using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuprincipal : MonoBehaviour
{
    [SerializeField] private GameObject damenombre;

    public void jugadornombre()
    {
        damenombre.SetActive(true);
        // SceneManager.LoadScene("MENUDEPAUSA");
    }

    [SerializeField] private GameObject Ingresanombre;
    public InputField user;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DameNombre()
    {
        Ingresanombre.SetActive(true);
    }

    //
    public void escenajuego()
    {

      //  PlayerPrefs.SetString("name", user.text);
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
