using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Objects;
    void Start()
    {
        NewObject();
    }

    // Update is called once per frame

    public void NewObject()
    {
        Instantiate(Objects[Random.Range(0, Objects.Length)], transform.position, Quaternion.identity);
    }
}
