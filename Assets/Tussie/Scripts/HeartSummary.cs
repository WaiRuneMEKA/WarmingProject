using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSummary : MonoBehaviour
{
    //public HeartManager heartManager;

    public Slider[] slider;

    private void Start()
    {
        //HeartManager.HeartScore1 = 1;
        //Debug.Log(HeartManager.HeartScore1);

        slider[0].value = HeartManager.HeartScore1;
        slider[1].value = HeartManager.HeartScore2;
        slider[2].value = HeartManager.HeartScore3;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HeartManager.HeartScore1 += 1;
            HeartManager.HeartScore2 += 2;
            HeartManager.HeartScore3 += 3;
        }
        slider[0].value = HeartManager.HeartScore1;
        slider[1].value = HeartManager.HeartScore2;
        slider[2].value = HeartManager.HeartScore3;
    }
}
