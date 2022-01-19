using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetPos();
    }

    void SetPos()
    {
        transform.position = new Vector3(player.position.x+5, transform.position.y, transform.position.z);
    }
}
