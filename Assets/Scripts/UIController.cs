using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject stateText01;
    public GameObject stateText02;
    public GameObject stateText03;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.changeFormDelay)
        {
            viewNum();
        }
    }
    private void viewNum()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameManager.instance.setViewNum(0);
            stateText01.SetActive(true);
}
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameManager.instance.setViewNum(1);
            stateText02.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameManager.instance.setViewNum(2);
            stateText03.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameManager.instance.setViewNum(3);
        }
    }
}
