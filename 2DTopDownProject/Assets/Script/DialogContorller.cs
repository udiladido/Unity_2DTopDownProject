using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogController : MonoBehaviour
{

    private TopDownController controller;
    [SerializeField]
    private TopDownMovement scanInfo;
    [SerializeField]
    private TMP_Text dialogText;
    [SerializeField] 
    protected InGameData gameData;
    [SerializeField]
    private GameObject ChatUI;
    private GameObject scanObj;


    protected Dictionary<string, Dictionary<int, string[]>> NPCTalkDB = new Dictionary<string, Dictionary<int, string[]>>();

    private void Awake()
    {
        scanInfo = GetComponent<TopDownMovement>();
        controller = GetComponent<TopDownController>();

        UpdateNPCText();
    }

    private void Start()
    {
        controller.OnInteractiveEvent += DialogText;

    }

    private void UpdateNPCText()
    {

        for (int i = 0; i < gameData.NPCDialog.Count; i++)
        {
            string npcName = gameData.NPCDialog[i].name;
            int dialogType = gameData.NPCDialog[i].Type;
            string[] dialogText = gameData.NPCDialog[i].Text;

            if (!NPCTalkDB.ContainsKey(npcName))
            {
                NPCTalkDB[npcName] = new Dictionary<int, string[]>();
            }

            NPCTalkDB[npcName][dialogType] = dialogText;
        }

    }


    private void DialogText()
    {


        if (scanInfo.scanObject != null && controller.isAction)
        {
           
            scanObj = scanInfo.scanObject;
            string FindName = null; 
            FindName = scanObj.name;

            Debug.Log(NPCTalkDB[FindName][0][0]);
       

            dialogText.text = NPCTalkDB[FindName][0][0];


        }
        else
        { 
            
        

        }

        ChatUI.SetActive(controller.isAction);

    }





}
