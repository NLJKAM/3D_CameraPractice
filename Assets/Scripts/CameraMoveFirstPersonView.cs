using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveFirstPersonView : MonoBehaviour
{
    public float turnSpeed = 5.0f;
    public float moveSpeed = 5.0f;
    private float rotate = 0;

    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;

        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        rotate = Mathf.Clamp(rotate + xRotateSize, -45, 80);

        transform.eulerAngles = new Vector3(rotate, yRotate, 0);
    }
}
