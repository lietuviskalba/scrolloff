using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMovement : MonoBehaviour {

    private GameObject player;

    public void MoveHorizontal(float newValue)
    {
        Vector3 pos = player.transform.position;
        pos.x = newValue;
        player.transform.position = pos;
    }
    
    public void MoveVertical(float newValue)
    {
        Vector3 pos = player.transform.position;
        pos.y = newValue;
        player.transform.position = pos;
    }

    private void Start()
    {
        player = GameObject.Find("Player");
    }
}
