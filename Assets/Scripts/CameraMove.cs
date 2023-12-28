using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float offsetX;
    public float offsetY;
    public float offsetZ;

    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x+ offsetX, player.transform.position.y + offsetY, player.transform.position.z+ offsetZ);
    }
}
