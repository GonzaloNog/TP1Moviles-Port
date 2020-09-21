using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasControler : MonoBehaviour
{
    public GameObject Creditos;
    void Update()
    {
        if (ConfigControler.instance.GetCreditos())
        {
            Creditos.SetActive(true);
            ConfigControler.instance.SetCreditos(false);
        }
    }
    public void Load()
    {
        SceneManager.LoadScene("conduccion9");
    }
}
