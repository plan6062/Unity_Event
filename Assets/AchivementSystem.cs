using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchivementSystem : MonoBehaviour
{
    public TextMeshProUGUI achivementText;

    public void UnLockAchivement (string title){
        Debug.Log("Achivement Unlock! - " + title);
        achivementText.text = "Achivement Unlock: " + title;
    }   
}
