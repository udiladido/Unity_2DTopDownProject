using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class InputNameCheckSystme : NameController
{

   
    [SerializeField] private TMP_InputField inputText;
    [SerializeField] private Toggle setNameMenuUI;
    [SerializeField] private GameObject setNameScreenUI;



    protected override void Awake()
    {
        base.Awake();
        


    }

    public void Onclick()
    {

        ChangeName();
        
    }


    private void ChangeName()
    {

        if (inputText.text.Length > 1)
        {
            gameObject.name = inputText.text;

           
            if (PlayerDB.ContainsKey(playerID))
            {
                PlayerDB[playerID] = gameObject.name;
            }

            else
            {
                PlayerDB.Add(playerID, gameObject.name);
            }

            gameData.PlayerName[playerID].name = gameObject.name;
            playerName.text = gameObject.name;


            setNameMenuUI.isOn = false;
            setNameScreenUI.SetActive(false);

        }



    }


}
