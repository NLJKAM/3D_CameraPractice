using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class UIController : MonoBehaviour
{
    public GameObject stateText01;
    public GameObject stateText02;
    public GameObject stateText03;

    public GameObject[] explanationText;

    public Text stateText;

    public GameObject mainCamera;
    public GameObject firstPersonViewCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stateText.text = $"       번호 키 입력(1~3)\n현 상태 : {GameManager.instance.playerMoveformNum + 1} 번";

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
            settingText();
            explanationText[0].SetActive(true);
            stateText01.SetActive(true);
}
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mainCamera.SetActive(true);
            firstPersonViewCamera.SetActive(false);

            GameManager.instance.setViewNum(1);
            settingText();
            explanationText[1].SetActive(true);
            stateText02.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            firstPersonViewCamera.SetActive(true);
            mainCamera.SetActive(false);

            GameManager.instance.setViewNum(2);
            settingText();
            explanationText[2].SetActive(true);
            stateText03.SetActive(true);
        }
    }
    private void settingText()
    {
        foreach (GameObject go in explanationText)
        {
            if (go != null)
            {
                go.SetActive(false);
            }
        }
    }
}
