using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    [SerializeField]
    GameObject WhiteFieldPlayer;
    [SerializeField]
    GameObject Key;
    [SerializeField]
    GameObject KeyDoor;
    [SerializeField]
    GameObject KeyDoorTileW;
    [SerializeField]
    GameObject KeyDoorTileB;

    private bool playerKeyItem = false;
    BoxCollider2D wBCol;
    BoxCollider2D bBCol;

    private void Start()
    {
        WhiteFieldPlayer.GetComponent<Transform>();
        wBCol = KeyDoorTileW.GetComponent<BoxCollider2D>();
        bBCol = KeyDoorTileB.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        //指定座標に入ったら
        if(WhiteFieldPlayer.transform.position.x >= 4.4 && WhiteFieldPlayer.transform.position.x <= 4.6 &&
            WhiteFieldPlayer.transform.position.y >= 9.4 && WhiteFieldPlayer.transform.position.y <= 9.6)
        {
            //鍵ゲット
            GetKey();
        }
        if (WhiteFieldPlayer.transform.position.x >= -3.6 && WhiteFieldPlayer.transform.position.x <= -3.4 &&
            WhiteFieldPlayer.transform.position.y >= 6.4 && WhiteFieldPlayer.transform.position.y <= 6.6)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //鍵チェック
                KeyCheck();
            }
        }
    }
    public void GetKey()
    {
        playerKeyItem = true;
        Key.SetActive(false);
    }
    public void KeyCheck()
    {
        if(playerKeyItem)
        {
            KeyDoor.SetActive(false);
            wBCol.enabled = true;
            bBCol.enabled = false;
        }
    }
}
