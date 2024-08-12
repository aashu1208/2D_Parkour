using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(10f, 2.8f) * Time.deltaTime);
        Destroy(gameObject, 1.5f);
    }
}
