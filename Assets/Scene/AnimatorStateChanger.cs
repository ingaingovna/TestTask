using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateChanger : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float[] _timings;

    private void Start(){
        StartCoroutine(IEStateChanger());
    }

    private IEnumerator IEStateChanger(){
        for(int i = 0;i<_timings.Length;i++){
            _animator.SetInteger("state",i);
            yield return new WaitForSeconds(_timings[i]);
        }
        //StartCoroutine(IEStateChanger());
    }
}
