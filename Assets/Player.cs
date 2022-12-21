using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameManager;//置放GameManager物件公開變數
    public AudioClip Walk;
    public AudioClip Hurt;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //點擊左方向紐時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);//往左移動「3」
            audioSource.PlayOneShot(Walk);
        }
        //點擊右方向紐時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);//往右移動「3」
            audioSource.PlayOneShot(Walk);
        }
    }

    public void LbuttonDown()
    {
        transform.Translate(-3, 0, 0);
        audioSource.PlayOneShot(Walk);
    }
    public void RbuttonDown()
    {
        transform.Translate(3, 0, 0);
        audioSource.PlayOneShot(Walk);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="arr")
        {
            audioSource.PlayOneShot(Hurt);
            gameManager.GetComponent<GameManager>().DecreaseHp();//扣血
            print("0");
        }
      if (collision.tag == "fish")
            gameManager.GetComponent<GameManager>().addhp();//加血

    }
}
