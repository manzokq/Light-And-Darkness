using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiotest : MonoBehaviour
{
    public AudioManager ins;
    // Start is called before the first frame update
    void Start()
    {
        ins = AudioManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ins.PlaySound("break");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ins.PlaySound("click");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ins.PlaySound("open");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ins.PlaySound("lock");
        }
    }
}
