using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI playerStateText;

    public void OnPlayerDead(){
        playerStateText.text = "You Die!";
    }
}
