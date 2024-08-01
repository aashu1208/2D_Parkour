using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Weapon : MonoBehaviour
{
    public abstract void Attack();
}

public class Sword : Weapon
{
    // Provide implementation for the Attack method
    public override void Attack()
    {
        Debug.Log("Swinging the sword.");
    }
}
public interface IDamageable
    {

    void takeDamage(int amount);
}

public class Exploring_Revisions : MonoBehaviour, IDamageable
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    private int poolSize = 10;

    Exploring_Revisions()
    {


    }

    void IDamageable.takeDamage(int amount)
    {
        throw new System.NotImplementedException();
        Debug.Log("");
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPool();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Get_Pool();
            if (obj != null)
            {
                StartCoroutine(Time_To_Return_Pool(obj));
            }
        }
    }

    public void SetPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
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

    IEnumerator Time_To_Return_Pool(GameObject obj)
    {
        yield return new WaitForSeconds(5f);
        obj.SetActive(false);
    }

    /*void IDamageable.takeDamage(int amount)
    {
        throw new System.NotImplementedException();
    }*/
}
