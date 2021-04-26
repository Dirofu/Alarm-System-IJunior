using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class DoorOpen : MonoBehaviour
{
    private Animator _animator;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Movement>() && _animator.GetBool("isOpen") == false)
        {
            _animator.SetBool("isOpen", true);
        }
        else
        {
            _animator.SetBool("isOpen", false);
        }
    }
}
