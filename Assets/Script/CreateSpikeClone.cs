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
        spawnTime = Random.Range(0.75f,2.5f);
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
                spawnTime = Random.Range(1f,3f);
            }
            timer += Time.deltaTime;
            if (obsspeed < 2.5)
            {
                obsspeed += Time.deltaTime/60;
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
