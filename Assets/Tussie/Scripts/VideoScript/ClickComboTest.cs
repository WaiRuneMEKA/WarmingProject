using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ClickComboTest : MonoBehaviour
{
    public Slider slider;
    public GameObject sliderObj;
    public GameObject Btn;
    public int comboNum;
    public string SceneName;
    public string finishDescription;
    public float EnumNum;
    public TMP_Text finishText;

    void Start()
    {
        finishText.text = string.Empty;
        StartCoroutine(DecreaseNum(EnumNum));
    }

    private void Update()
    {
        slider.value = comboNum;

        if (slider.value >= 20)
        {
            StartCoroutine(DelayChangeScene(SceneName));
        }
    }
    public void OnClickBtn()
        {
            comboNum++;
        }

    IEnumerator DecreaseNum(float num)
    {
        while (true)
        {
            yield return new WaitForSeconds(num);

            if (comboNum <= 0)
            {
                comboNum = 0;
            }
            else
            {
                comboNum--;
            }
        }
    }

    IEnumerator DelayChangeScene(string sceneName)
    {
        sliderObj.SetActive(false);
        Btn.SetActive(false);
        finishText.text = finishDescription;
        yield return new WaitForSecondsRealtime(3);
        finishText.text = "";
        SceneManager.LoadScene(sceneName);
    }

    
}
