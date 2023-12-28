using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject stateText01;
    public GameObject stateText02;
    public GameObject stateText03;

    public Text stateText;

    public GameObject mainCamera;
    public GameObject firstPersonViewCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stateText.text = $"현 상태 : {GameManager.instance.playerMoveformNum + 1} 번";

        if (!GameManager.instance.changeFormDelay)
        {
            viewNum();
        }
    }
    private void viewNum()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mainCamera.SetActive(true);
            firstPersonViewCamera.SetActive(false);

            GameManager.instance.setViewNum(0);
            stateText01.SetActive(true);
}
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mainCamera.SetActive(true);
            firstPersonViewCamera.SetActive(false);

            GameManager.instance.setViewNum(1);
            stateText02.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            firstPersonViewCamera.SetActive(true);
            mainCamera.SetActive(false);

            GameManager.instance.setViewNum(2);
            stateText03.SetActive(true);
        }
       /* else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameManager.instance.setViewNum(3);
        }*/
    }
}
