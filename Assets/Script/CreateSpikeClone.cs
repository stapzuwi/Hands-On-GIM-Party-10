using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpikeClone : MonoBehaviour
{
    public GameObject[] obstacle;
    private float spawnTime;
    private float timer;
    private int random;
    public PlayerMovement playerMovement;
    public float obsspeed;
    void Start()
    {
        spawnTime = 1;
        obsspeed = 1;
    }

    void Update()
    {
        if (GameManager.Instance.isPlaying)
        {
            if (timer>spawnTime)
            {
                spawnSpike();
                timer = 0;
                spawnTime = Random.Range(1f,2.5f);
            }
            timer += Time.deltaTime;
            if (obsspeed < 3)
            {
                obsspeed += Time.deltaTime/25;
            }
        }
    }
    private void spawnSpike()
    {
        random = Random.Range(0, obstacle.Length);
        GameObject spawnedObstacle = Instantiate(obstacle[random], obstacle[random].transform.position, Quaternion.identity);
        Rigidbody2D obsrb = spawnedObstacle.GetComponent<Rigidbody2D>();
        obsrb.velocity = new Vector2(-8*obsspeed,obsrb.velocity.y);
        Destroy(spawnedObstacle, 8);
    }
}
