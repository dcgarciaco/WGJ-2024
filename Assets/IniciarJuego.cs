using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);   
    }

}
