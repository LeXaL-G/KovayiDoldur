using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomWaterScript : MonoBehaviour
{
    public GameObject _water;
    public GameObject _waterSpawn;
    private Vector3 spawnVector;
    private float spawnTime = 0;
    private float x;
    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime > 1)
        {
            WaterSpawn();
            spawnTime = 0;
        }
    }

    public void WaterSpawn()
    {
        x = Random.Range(-8.5f, 8.5f);
        spawnVector = new Vector3(x, 7, 0);
        _waterSpawn = Instantiate(_water, spawnVector, Quaternion.identity);
    }
}
