using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    
    // Script written following: https://stackoverflow.com/questions/62758335/how-to-make-camera-follow-only-the-horizontal-movement-x-axis-of-the-player
    
    [SerializeField] private GameObject player;
    
    void Start()
    {
        if (!player) player = GameObject.Find("Player");
    }
    
    void Update()
    {
        var position = transform.position;

        position.x = player.transform.position.x;

        transform.position = position;
    }
}
