using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSearch : MonoBehaviour
{
    public GameObject floor=null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        floor = collision.gameObject;
        //Debug.Log(collision.gameObject.layer);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        floor = null;
    }
}
