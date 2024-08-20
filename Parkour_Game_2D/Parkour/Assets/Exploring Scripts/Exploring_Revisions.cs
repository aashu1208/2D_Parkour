using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Exploring_Revisions : MonoBehaviour
{
    public GameObject prefabs;
    public List<GameObject> pool = new List<GameObject>();
    public int poolSize;

    private void Start()
    {
        Set_Pool();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject obj = Get_Pool();
            if (obj != null)
            {

                StartCoroutine(Return_To_Pool(obj));

            }
        }

        
    }

    public void Set_Pool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefabs);
            obj.SetActive(false);
            pool.Add(obj);
        }

    }

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

    public IEnumerator Return_To_Pool(GameObject obj)
    {
        yield return new WaitForSeconds(3f);
        obj.SetActive(false);

    }
}
