using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class AnimatorController : MonoBehaviour
{

    protected Animator animator;
    protected TopDownController controller;


    protected virtual void Awake()
    { 
        controller = GetComponent<TopDownController>();
        animator = GetComponentInChildren<Animator>();
    
    }


}
