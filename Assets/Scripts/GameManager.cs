using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerMoveformNum;
    public bool changeFormDelay=false;

   public static GameManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (!changeFormDelay)
        {
            viewNum();
        }
    }
    private void viewNum()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerMoveformNum = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerMoveformNum = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerMoveformNum = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            playerMoveformNum = 3;
        }

    }
}
