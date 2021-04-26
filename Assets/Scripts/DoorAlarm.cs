using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]

public class DoorAlarm : MonoBehaviour
{
    [SerializeField] private float _step;

    private Animator _animator;
    private AudioSource _audio;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_animator.GetBool("isOpen") == true)
        {
<<<<<<< HEAD
            _audio.volume += Mathf.MoveTowards(0f, 1f, _step);
        }
        else
        {
            _audio.volume -= Mathf.MoveTowards(0f, 1f, _step);
=======
            _audio.volume += Mathf.MoveTowards(0f, 1f, 0.01f);
        }
        else
        {
            _audio.volume -= Mathf.MoveTowards(0f, 1f, 0.01f);
>>>>>>> 54f1a75fb238f67f7c9752a9e3dfa7cbd137e3fa
        }
    }
}
