using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform[] levelPart;
    [SerializeField] private Vector3 nextPartPosition;

    [SerializeField] private Transform player;
    private float distanceToSpawn = 50f;
    private float distanceToDelete = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GeneratePlatform();
    }

    private void GeneratePlatform()
    {
        while(Vector2.Distance(player.transform.position, nextPartPosition) > distanceToSpawn)
        {

            Transform part = levelPart[Random.Range(0, levelPart.Length)];
            Vector2 newposition = new Vector2(nextPartPosition.x - part.Find("StartPosition").position.x, 0);

            Transform newPart = Instantiate(part, newposition, transform.rotation, transform);
            nextPartPosition = newPart.Find("EndPosition").position;
        }
    }
}
