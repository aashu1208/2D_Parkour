using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private float length, startPos;
    private GameObject cam;
    [SerializeField] private float parallaxEffect;
    [SerializeField] private float offset = 20.0f; // Small offset to update the background earlier

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        if (temp > startPos + length - offset)
        {
            startPos += length;
        }
        else if (temp < startPos - length + offset)
        {
            startPos -= length;
        }
    }
}
