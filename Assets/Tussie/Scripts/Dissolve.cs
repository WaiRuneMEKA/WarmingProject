using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Dissolve : MonoBehaviour
{
    [SerializeField] private float _dissolveTime = 0.75f;

    SpriteRenderer[] _spriteRenderers;
    Material[] _materials;

    int _dissolveAmount = Shader.PropertyToID("_DissolveAmount");
    int _verticalDissolveAmount = Shader.PropertyToID("_VerticalDissolve");

    private void Start()
    {
        _spriteRenderers = GetComponentsInChildren<SpriteRenderer>();

        _materials = new Material[_spriteRenderers.Length];
        for(int i = 0; i < _spriteRenderers.Length; i++)
        {
            _materials[i] = _spriteRenderers[i].material;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(Vanich(true, false));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Appear(true, false));
        }
    }

    IEnumerator Vanich(bool useDissolve, bool useVertical)
    {
        float elapsedTime = 0f;
        while (elapsedTime < _dissolveTime)
        {
            elapsedTime += Time.deltaTime;

            float lerpedDissolve = Mathf.Lerp(0f, 1.1f, (elapsedTime / _dissolveTime));
            float lerpedVerticalDissolve = Mathf.Lerp(0f, 1.1f, (elapsedTime / _dissolveTime));

            for (int i = 0; i < _materials.Length; i++)
            {
                if (useDissolve)
                {
                    _materials[i].SetFloat(_dissolveAmount, lerpedDissolve);
                }

                if (useVertical)
                {
                    _materials[i].SetFloat(_verticalDissolveAmount, lerpedVerticalDissolve);
                }
            }

            yield return null;
        }
    }

    IEnumerator Appear(bool useDissolve, bool useVertical)
    {
        float elapsedTime = 0f;
        while (elapsedTime < _dissolveTime)
        {
            elapsedTime += Time.deltaTime;

            float lerpedDissolve = Mathf.Lerp(1.1f, 0f, (elapsedTime / _dissolveTime));
            float lerpedVerticalDissolve = Mathf.Lerp(1.1f, 0f, (elapsedTime / _dissolveTime));

            for (int i = 0; i < _materials.Length; i++)
            {
                if (useDissolve)
                {
                    _materials[i].SetFloat(_dissolveAmount, lerpedDissolve);
                }

                if (useVertical)
                {
                    _materials[i].SetFloat(_verticalDissolveAmount, lerpedVerticalDissolve);
                }
            }

            yield return null;
        }
    }
}
