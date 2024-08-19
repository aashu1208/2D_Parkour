using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPatterns : MonoBehaviour
{

    public DesignPatterns instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Instance Already Exists");
            Destroy(gameObject);
        }
        instance = this;
    }
}
