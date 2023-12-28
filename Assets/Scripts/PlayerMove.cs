using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
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
        //���ͺ� �϶�
        switch (playerformNum)
        {
            case 0://���ͺ� �̵�
                float h = Input.GetAxisRaw("Horizontal");
                float v = Input.GetAxisRaw("Vertical");

                Vector3 moveDirection = new Vector3(h, 0, v).normalized;
                transform.position += (moveDirection* moveSpeed * Time.deltaTime);

                transform.LookAt(transform.position+ moveDirection);
                break;
        }
    }
}
