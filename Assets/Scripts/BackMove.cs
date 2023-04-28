using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float leftLimit;
    [SerializeField] private float rightLimit;

    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * moveSpeed, 0);
        if (transform.position.x <= leftLimit)
        {
            transform.position = new Vector3(rightLimit, 0);
        }
    }
}
