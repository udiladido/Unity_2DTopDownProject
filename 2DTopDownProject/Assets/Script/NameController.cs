using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameController : MonoBehaviour
{


    [SerializeField] protected int playerID;
    [SerializeField] GameObject player;
    [SerializeField] protected InGameData gameData;
    [SerializeField] protected TMP_Text playerName;

    protected Dictionary<int, string> PlayerDB = new Dictionary<int, string>();


    protected virtual void Awake()
    {

        UpdatePlayer();

        Transform secondChild = player.transform.GetChild(1);
        playerName  = secondChild.GetComponentInChildren<TMP_Text>();
    }

 

    private void UpdatePlayer()
    {

        for (int i = 0; i < gameData.PlayerName.Count; i++)
        {
            PlayerDB.TryAdd(gameData.PlayerName[i].Playerindex, gameData.PlayerName[i].name);

        }

    }

}
