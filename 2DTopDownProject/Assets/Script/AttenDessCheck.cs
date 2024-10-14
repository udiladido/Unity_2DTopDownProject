using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttenDessCheck : MonoBehaviour
{
    private string targetTag = "Player";
    private string playerNameTag = "PlayerNameTag";


    [SerializeField]
    private RectTransform parent;
    [SerializeField]
    private Transform originParent;


    public void PlayerCount()
    {


         PlayerCountInMap();
    }

    public void ResetCount()
    {

        PlayerResetCount();
    }


    private void PlayerCountInMap()
    {
        GameObject[] existPlayer = GameObject.FindGameObjectsWithTag(targetTag);

        Sprite playerPortrait; 
       

        foreach (GameObject player in existPlayer)
        {

            GameObject obj = GameManager.Instance.ObjectPool.SpawnFromPool(playerNameTag, parent);
            


            playerPortrait = player.GetComponentsInChildren<SpriteRenderer>()[0].sprite;
            

            obj.GetComponent<NameTag>().playerName.text = player.name;
            obj.GetComponent<NameTag>().Portrait.sprite = playerPortrait;


        }

    }

    private void PlayerResetCount()
    {
        GameObject[] ReturnPlayer = new GameObject[parent.childCount];

        for (int i = 0; i < parent.childCount; i++)
        {
            ReturnPlayer[i] = parent.GetChild(i).gameObject;
        
        }

        foreach (GameObject obj in ReturnPlayer)
        {

            obj.SetActive(false);
            obj.transform.SetParent(originParent, false);

        }


    }


}
