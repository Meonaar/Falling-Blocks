using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("I'm here!");
            Destroy(this.gameObject);
        }
    }
}
