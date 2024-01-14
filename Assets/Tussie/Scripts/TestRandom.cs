using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRandom : MonoBehaviour
{
    //public Animator anim;
    void Start()
    {
        var anim = GetComponent<Animator>();
        var state = anim.GetCurrentAnimatorStateInfo(layerIndex: 0);

        anim.Play(state.fullPathHash, layer: 0, normalizedTime: Random.Range(0, 1));

        //anim.Play(0, 1, Random.value);
    }

}
