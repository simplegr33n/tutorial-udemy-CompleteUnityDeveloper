using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;


    private bool moveRight = true;

    private float enemyPosition = 0;

    // Use this for initialization
    void Start()
    {
        foreach (Transform child in transform)
        {
            GameObject enemy = Instantiate(enemyPrefab, child.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = child;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (enemyPosition >= 6)
        {
            moveRight = false;
        }

        if (enemyPosition <= -6)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            enemyPosition += 0.1f;
            transform.position = new Vector2(enemyPosition, transform.position.y);
        }

        if (!moveRight)
        {
            enemyPosition -= 0.1f;
            transform.position = new Vector2(enemyPosition, transform.position.y);
        }


    }
}