using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;

    public ObjectPoolManager ObjectPool { get; private set; }

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;

     
        ObjectPool = GetComponent<ObjectPoolManager>();

    }



}
