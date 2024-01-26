using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShack : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public float duration = 1.0f;
    
    public void ClickToShake()
    {
        StartCoroutine(ShakeScreen());
    }

    IEnumerator ShakeScreen()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = animationCurve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;

            yield return null;
        }
        transform.position = startPosition;
    }
}
