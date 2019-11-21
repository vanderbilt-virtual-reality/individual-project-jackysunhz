using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public Transform back1, back2;
    private float longer_offset;
    private OVRGrabber[] hands;

    private void Start()
    {
        longer_offset = back2.position.z - back1.position.z;
        hands = player.GetComponentsInChildren<OVRGrabber>();
        //TP(new Vector3(0,0,100));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(testCount);
        //Debug.Log("front short? " + Is_Front_Of_Short(player.transform.position));
        //Debug.Log("back short? " + Is_Back_Of_Short(player.transform.position));
        
    }

    private void FixedUpdate()
    {
        if (Is_Front_Of_Short(player.transform.position))
        {
            TP(new Vector3(0,0,5000));
        }
        else if (Is_Back_Of_Short(player.transform.position))
        {               
            TP(new Vector3(0,0,longer_offset));
        }
        else if (Is_Front_Of_Long(player.transform.position))
        {
            TP(new Vector3(0, 0, -5000));
        }
        else if (Is_Back_Of_Long(player.transform.position))
        {
            TP(new Vector3(0, 0, -longer_offset));
        }
    }

    private bool Is_Front_Of_Short(Vector3 pos)
    {
        if (pos.z < -2.253f && pos.x > -1.75f && pos.x <1.75f)
        {
            return true;
        }

        return false;
    }

    private bool Is_Back_Of_Short(Vector3 pos)
    {
        if (pos.z > 2.253f && pos.z < 12.253f && pos.x > -1.75f && pos.x < 1.75f)
        {
            return true;
        }

        return false;
    }

    private bool Is_Front_Of_Long(Vector3 pos)
    {
        if (pos.z > 2000 && pos.z < 4999.7f && !(pos.x > -1.75f && pos.x < 1.75f))
        {
            return true;
        }

        return false;
    }

    private bool Is_Back_Of_Long(Vector3 pos)
    {
        if (pos.z > 5019.01f && !(pos.x > -1.75f && pos.x < 1.75f))
        {
            return true;
        }

        return false;
    }

    private void TP(Vector3 posVector)
    {
        if (HasRealityStone())
        {
            return;
        }
        else
        {
            player.transform.position += posVector;
        }
        
        //Debug.Log("Player teleported by " + posVector.ToString());
    }

    private bool HasRealityStone()
    {
        foreach(OVRGrabber hand in hands)
        {
            if(hand.grabbedObject != null)
            {
                if(hand.grabbedObject.tag == "RealityStone")
                {
                    return true;
                }
            }
        }

        return false;
    }
}
