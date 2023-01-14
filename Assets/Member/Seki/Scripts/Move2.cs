using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    bool moveFrag = true;
    [SerializeField]
    GameObject up, right, down, left, search = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            search = left;
            //Reset();
            //Trans(-1, 0, search);
            FloorJudge();
            if (moveFrag)
            {
                Trans(-1, 0, this.gameObject);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            search = right;
            //Reset();
            //Trans(1, 0, search);
            FloorJudge();
            if (moveFrag)
            {
                Trans(1, 0, this.gameObject);
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            search = up;
            //Reset();
            //Trans(0, 1, search);
            FloorJudge();
            if (moveFrag)
            {
                Trans(0, 1, this.gameObject);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            search = down;
            //Reset();
            //Trans(0, -1, search);
            FloorJudge();
            if (moveFrag)
            {
                Trans(0, -1, this.gameObject);
            }
        }
    }
    void Trans(float x, float y, GameObject obj)
    {
        obj.transform.Translate(x, y, 0);
    }
    void Reset()
    {
        //search.GetComponent<FloorSearch>().floor = null;
    }
    void FloorJudge()
    {
        Debug.Log(search.GetComponent<FloorSearch>().floor);
        if (search.GetComponent<FloorSearch>().floor == null)
        {
            moveFrag = false;
            return;
        }
        var floorLayer = search.GetComponent<FloorSearch>().floor.layer;
        if (this.gameObject.layer == floorLayer)
        {
            moveFrag = true;
        }
        else
        {
            moveFrag = false;
        }
    }

}
