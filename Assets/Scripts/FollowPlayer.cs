using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Offset = new Vector3(0, 6, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //offset the camera behind the player by adding the player's position
        transform.position = Player.transform.position + Offset; 
    }
}
