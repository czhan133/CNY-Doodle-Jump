using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerate : MonoBehaviour
{
    public GameObject platform_prefab;
    int num = 100;
    float width = 3;
    float minY = 0.5f;
    float maxY = 1f;

    void Start()
    {
        Vector3 spawn_position = new Vector3();

        for (int i = 0; i < num; i++) {
            //Vector3 spawn_position = new Vector3();
            spawn_position.y += Random.Range(minY, maxY);
            spawn_position.x = Random.Range(-width, width);
            Instantiate(platform_prefab, spawn_position, Quaternion.identity);
        }
    }
}
