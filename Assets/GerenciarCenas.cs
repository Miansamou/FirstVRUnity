using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciarCenas : MonoBehaviour
{
    public void ReiniciarCena()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
