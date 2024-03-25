using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    // public UIManager uiManager;
    // public AchivementSystem achivementSystem;
    // public GameManager gameManager;
    // 이벤트 시스템을 이용하지 않은 방법 -> 깔끔하지 못함, 스파게티 코드 발생 우려

    public UnityEvent onPlayerDead;

    private void Dead(){
        // uiManager.OnPlayerDead();
        // achivementSystem.UnLockAchivement("Newton's laws of motion");
        // gameManager.OnPlayerDead();
        onPlayerDead.Invoke();
        Debug.Log("죽었다!");
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other){
        Dead();

    }
}
