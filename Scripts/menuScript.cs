using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void jugar(string juego)
    {
        SceneManager.LoadScene(juego);
    }
    public void salir()
    {
        Application.Quit();
    }
}

