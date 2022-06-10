using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniSingleton : MonoBehaviour
{
    public static MiniSingleton msInst;

    protected virtual void Awake()
    {
        if (msInst == null)
        {
            msInst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        active = false;

    }


}
