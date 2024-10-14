using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class CharacterAnimatorController : AnimatorController
{

  
    private static readonly int isRun = Animator.StringToHash("IsRun");
    private readonly float magnituteThreshold = 0.5f;

    [SerializeField]
    SpriteLibraryAsset[] spriteLibs;
    SpriteLibrary spriteLiber;
    int characterIndex;

    

    protected override void Awake()
    {
        base.Awake();
        spriteLiber = GetComponentInChildren<SpriteLibrary>();

    }

    private void Start()
    {
        controller.OnMoveEvent += Move;

    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(isRun, obj.magnitude > magnituteThreshold);

    }

    public void CharacterChangeSelect(int index)
    { 
    
        characterIndex = index % spriteLibs.Length;
        spriteLiber.spriteLibraryAsset = spriteLibs[characterIndex];

    }




}
