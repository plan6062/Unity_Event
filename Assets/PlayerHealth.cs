using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public UIManager uiManager;

    public AchivementSystem achivementSystem;

    public GameManager gameManager;

    private void Dead(){
        uiManager.OnPlayerDead();
        achivementSystem.UnLockAchivement("Newton's laws of motion");
        gameManager.OnPlayerDead();

        Debug.Log("죽었다!");
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other){
        Dead();

    }
}
