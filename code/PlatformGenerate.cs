using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public Transform player;
    public GameObject platform_prefab;
    private GameObject new_platform;

    void OnTriggerEnter2D(Collider2D collision)
    {
        new_platform = (GameObject)Instantiate(platform_prefab, new Vector2(Random.Range(-2.5f, 2.5f), player.position.y + (Random.Range(0.5f, 1f))), Quaternion.identity);

        Destroy(collision.gameObject);
    }
}
