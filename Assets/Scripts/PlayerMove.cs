using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 destinationPos;
    Vector3 dir;
    Quaternion lookTarget;

    bool move = false;
    public GameObject clickEffect;
    public float moveSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveform(GameManager.instance.playerMoveformNum);
    }
    void PlayerMoveform(int playerformNum)
    {
        //ÄõÅÍºä ÀÏ¶§
        switch (playerformNum)
        {
            case 0:
                PlayerQuarterViewWASD();
                break;
            case 1:
                PlayerQuarterViewMouseClick();
                break;
        }
    }
    private void PlayerQuarterViewWASD()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(h, 0, v).normalized;
        transform.position += (moveDirection * moveSpeed * Time.deltaTime);

        transform.LookAt(transform.position + moveDirection);
    }
    private void PlayerQuarterViewMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100f))
            {
                destinationPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                dir = destinationPos - transform.position;
                lookTarget = Quaternion.LookRotation(dir);
                move = true;
            }
            Destroy(Instantiate(clickEffect, destinationPos,Quaternion.identity) ,0.5f);
        }
        if (move)
        {
            transform.position += dir.normalized * Time.deltaTime * moveSpeed;
            transform.rotation = Quaternion.Lerp(transform.rotation, lookTarget, 0.25f);
            move = (transform.position - destinationPos).magnitude > 0.5f;
        }
    }
}
