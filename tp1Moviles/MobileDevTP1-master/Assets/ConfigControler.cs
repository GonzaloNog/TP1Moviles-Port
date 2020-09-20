using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigControler : MonoBehaviour
{
    static public ConfigControler instance;
    private bool creditos = false;
    private bool easy = true;
    void Awake()
    {
        //instance = this;
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            // Destroy(this);
            instance = this;
        }
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCreditos(bool _cred)
    {
        creditos = _cred;
    }
    public bool GetCreditos()
    {
        return creditos;
    }
    public void SetEasy(bool _easy)
    {
        easy = _easy;
    }
    public bool GetEasy()
    {
        return easy;
    }
}
