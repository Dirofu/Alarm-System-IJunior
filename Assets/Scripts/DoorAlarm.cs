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
            _audio.volume += Mathf.MoveTowards(0f, 1f, _step);
        }
        else
        {
            _audio.volume -= Mathf.MoveTowards(0f, 1f, _step);
        }
    }
}
