﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public bool easy;
    private Image img;
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ConfigControler.instance.GetEasy())
        {
            if (easy)
                img.color = Color.gray;
            else
                img.color = Color.white;
        }
        else
        {
            if (!easy)
                img.color = Color.gray;
            else
                img.color = Color.white;
        }
    }
}
