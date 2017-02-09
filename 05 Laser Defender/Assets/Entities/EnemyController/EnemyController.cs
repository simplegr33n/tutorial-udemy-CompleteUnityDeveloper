using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float minX;
    public float maxX;

    public float width = 10f;
    public float height = 5f;

    public float speed = 5f;

    private bool moveRight = true;


    // Use this for initialization
    void Start()
    {


    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
    }

    // Update is called once per frame
    void Update()
    {
        // get enemys
        if (EnemyShip.shipsCount <= 0)
        {
            foreach (Transform child in transform)
            {
                GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
                enemy.transform.parent = child;
            }
        }



        if (transform.position.x >= maxX)
        {
            moveRight = false;
        }

        if (transform.position.x <= minX)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (!moveRight)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }


    }
}