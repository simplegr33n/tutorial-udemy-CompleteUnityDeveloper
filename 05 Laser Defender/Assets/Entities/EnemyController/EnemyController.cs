using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float minX = -2f;
    public float maxX = 2f;

    public float width = 10f;
    public float height = 5f;

    public float speed = 3f;

    public float spawnDelay = 0.2f;

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
        // get enemys if shipsCount  <= 0
        if (EnemyShip.shipsCount <= 0)
        {
                Respawn();         
        }

        // move the formation
        MoveFormation();

    }

    void MoveFormation()
    {

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

    void Respawn()
    {
        Transform freePosition = NextFreePosition();

        if (freePosition) { 
            GameObject enemy = Instantiate(enemyPrefab, freePosition.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
        }

        if (NextFreePosition())
        {
            Invoke("Respawn", spawnDelay);
        }       
    }

    Transform NextFreePosition()
    {
        foreach(Transform childPositionGameObject in transform)

        if (childPositionGameObject.childCount == 0) {
            return childPositionGameObject;
        }
        return null;
    }

}