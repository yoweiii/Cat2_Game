using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);//3秒後刪除自己
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //當箭頭碰到其他有碰撞體的東西時
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);//碰到有碰撞體的東西就刪除自己

        if (collision.name == "add")
            gameManager.GetComponent<GameManager>().ad();//扣血
        if (collision.name == "fish")
            gameManager.GetComponent<GameManager>().addhp();//加血
    }

}
