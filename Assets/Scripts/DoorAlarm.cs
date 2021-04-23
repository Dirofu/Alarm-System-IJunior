using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAlarm : MonoBehaviour
{
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
            _audio.volume += Time.deltaTime;
        }
        else
        {
            _audio.volume -= Time.deltaTime;
        }
    }
}
