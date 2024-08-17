using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Exploring_Revisions : MonoBehaviour
{
    [SerializeField]private GameObject prefab;
    [SerializeField]private List<GameObject> pool = new List<GameObject>();
    [SerializeField]private int poolSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        SetPool();
    }

    // Update is called once per frame
    void Update()
    {

        // Press Left Mouse Button to Get Pool objects
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Get_Pool();
            if (obj != null)
            {
                StartCoroutine(Time_To_Return_Pool(obj));
            }
        }
    }

    //Set the Pool for the objects
    public void SetPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    //Get the objects from the pool
    public GameObject Get_Pool()
    {
        for (int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                pool[i].SetActive(true);
                return pool[i];
            }
        }
        return null;
    }

    //Return to Pool after 5 seconds
    IEnumerator Time_To_Return_Pool(GameObject obj)
    {
        yield return new WaitForSeconds(5f);
        obj.SetActive(false);
    }
}
