using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

    public Transform player;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        // up
        if (Input.GetKeyDown(KeyCode.W) && player.position.y < 2)
            player.position = new Vector2(player.position.x, player.position.y + 1);

        // left
        if (Input.GetKeyDown(KeyCode.A) && player.position.x > -2)
            player.position = new Vector2(player.position.x - 1, player.position.y);

        // down
        if (Input.GetKeyDown(KeyCode.S) && player.position.y > -2)
            player.position = new Vector2(player.position.x, player.position.y - 1);

        // right
        if (Input.GetKeyDown(KeyCode.D) && player.position.x < 2)
            player.position = new Vector2(player.position.x + 1, player.position.y);
    }


}
