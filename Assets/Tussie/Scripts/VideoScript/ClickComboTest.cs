using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickComboTest : MonoBehaviour
{
    public Slider slider;
    public GameObject Btn;
    public int comboNum;
    bool isClick;

    private void Update()
    {
        StartCoroutine(AreYouClicked());
    }

    public void OnClickBtn()
    {
        comboNum++;
        slider.value = comboNum;
        isClick = true;
        StartCoroutine(ClickCountdown());
    }

    IEnumerator AreYouClicked()
    {
        yield return new WaitForSecondsRealtime(3);
        isClick = false;
    }

    IEnumerator ClickCountdown()
    {
        yield return new WaitForSecondsRealtime(1);
        
        if (isClick)
        {
            comboNum--;
        }
    }
}
