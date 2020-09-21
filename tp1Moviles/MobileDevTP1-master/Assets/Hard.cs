using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!ConfigControler.instance.GetEasy())
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }

    }


}
