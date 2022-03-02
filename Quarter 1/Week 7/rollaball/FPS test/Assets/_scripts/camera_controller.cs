using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
   
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
