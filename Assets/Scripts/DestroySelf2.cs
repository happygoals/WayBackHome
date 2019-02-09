using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf2 : MonoBehaviour
{
    public float DestroyTime = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
}
