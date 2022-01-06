using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject[] son;

    public void Awake()
    {
        foreach(var element in son )
        {
            DontDestroyOnLoad(element); 
        }
    }

}
