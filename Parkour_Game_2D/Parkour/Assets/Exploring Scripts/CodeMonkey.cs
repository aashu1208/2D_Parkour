using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeMonkey : MonoBehaviour
{
    public static CodeMonkey instance { get; private set; }
    public Dictionary<string, int> dict = new Dictionary<string, int>();
    public List<string> list = new List<string>();
    public int[] arr;
    public Stack<string> stackString = new Stack<string>();
    public Queue<string> queueString = new Queue<string>();
    public HashSet<string> hashsetString = new HashSet<string>();
    private void Awake()
    {

        stackString.Push("codemonkey");
        stackString.Push("aashu hindi games");
        queueString.Enqueue("1");
        queueString.Enqueue("2");
        //stackString.Pop();
        //Debug.Log(stackString.Pop());
        Debug.Log(queueString.Dequeue());
    }

    // Start is called before the first frame update
    void Start()
    {
        //SetNumber();
    }
    
}
