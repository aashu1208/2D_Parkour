using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeMonkey : MonoBehaviour
{
    public static CodeMonkey instance { get; private set; }
    public Dictionary<string, int> dict = new Dictionary<string, int>();
    public List<string> list = new List<string>();
    public int[] arr;
    private void Awake()
    {


    }

    // Start is called before the first frame update
    void Start()
    {
        //SetNumber();
    }
    
}
