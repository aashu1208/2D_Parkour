using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeMonkey : MonoBehaviour
{
    /*public static CodeMonkey instance { get; private set; }
    public Dictionary<string, int> dict = new Dictionary<string, int>();
    public List<string> list = new List<string>();
    public int[] arr;
    public Stack<string> stackString = new Stack<string>();
    public Queue<string> queueString = new Queue<string>();
    public HashSet<string> hashsetString = new HashSet<string>();*/

    public struct PlayerStruct
    {
        public int a;
    }

    public class PlayerClass
    {
        public int b;

    }
    public void TestFuncStruct(PlayerStruct ps)
    {
        ps.a = 1;
        //Debug.Log(ps.a);
    }

    public void TestFuncClass(PlayerClass pc)
    {
        
        pc.b = 1;
        //Debug.Log(pc.b);
    }
    private void Awake()
    {

        /*stackString.Push("codemonkey");
        stackString.Push("aashu hindi games");
        queueString.Enqueue("1");
        queueString.Enqueue("2");
        //stackString.Pop();
        //Debug.Log(stackString.Pop());
        Debug.Log(queueString.Dequeue());*/
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerStruct ps = new PlayerStruct();
        ps.a = 2;
        PlayerClass pc = new PlayerClass();
        pc.b = 2;

        

        TestFuncStruct(ps);
        TestFuncClass(pc);

        Debug.Log("Player struct 2nd value of a: " + ps.a);
        Debug.Log("Player class 2nd value of b: " + pc.b);
    }
    
}
