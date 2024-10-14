using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{

    public GameObject InteractiveKey;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        InteractiveKey.SetActive(true);

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        InteractiveKey.SetActive(false);

    }


}
