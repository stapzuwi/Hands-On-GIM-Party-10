using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpikeClone : MonoBehaviour
{
    public GameObject spike1;
    private float spawnTime;
    private float timer;

    void Start()
    {
        spawnTime = Random.Range(1f,4f);
    }

    void Update()
    {
        if (timer>spawnTime)
        {
            spawnSpike();
            timer = 0;
            spawnTime = Random.Range(1f,4f);
        }
        timer += Time.deltaTime;
    }
    private void spawnSpike()
    {
        Vector3 spawnPos = transform.position;
        GameObject spike_ = Instantiate(spike1, spawnPos, Quaternion.identity);

        Destroy(spike_,8);

    }
}
