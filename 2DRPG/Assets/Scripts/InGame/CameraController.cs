using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    public void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void Update()
    {
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        transform.position = temp;
    }

}
