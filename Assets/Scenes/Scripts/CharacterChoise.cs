using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChoise : MonoBehaviour
{
    public GameObject playerImg1;
    public GameObject playerImg2;

    public GameObject characterImg1;
    public GameObject characterImg2;
    public InputField nameTxt;
    public Text playerNameTxt;
    public GameObject panel;    
    
    public void OnCharacterPanel()
    {   
        if(panel.activeSelf==false)
        {
            panel.SetActive(true);
        }         
    }    
    public void OnChoiseImg()
    {   
        playerImg1.SetActive(true);
        playerImg2.SetActive(false);
        characterImg1.SetActive(true);
        characterImg2.SetActive(false);
        panel.SetActive(false);
    }    
    public void Finish()
    {                
        if(nameTxt.text.Length>2 && nameTxt.text.Length <11)
        { 

            playerNameTxt.text= nameTxt.text;
            panel.SetActive(false);
        } 
        else{Debug.Log("글자수가 맞지 않습니다");}
    }
}
