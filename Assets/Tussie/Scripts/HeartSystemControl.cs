using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystemControl : MonoBehaviour
{
    public void IncreaseHeart1()
    {
        HeartManager.HeartScore1++;
        Debug.Log(HeartManager.HeartScore1);
    }
    public void IncreaseHeart2()
    {
        HeartManager.HeartScore2++;
    }
    public void IncreaseHeart3()
    {
        HeartManager.HeartScore3++;
    }

    public void DecreaseHeart1()
    {
        HeartManager.HeartScore1--;
        Debug.Log(HeartManager.HeartScore1);
    }
    public void DecreaseHeart2()
    {
        HeartManager.HeartScore2--;
    }
    public void DecreaseHeart3()
    {
        HeartManager.HeartScore3--;
    }
}
