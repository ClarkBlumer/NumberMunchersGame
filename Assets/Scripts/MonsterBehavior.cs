using UnityEngine;
using System.Collections;

public class MonsterBehavior : MonoBehaviour {

    public Transform MonsterTransform;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Testing monster movement horizontal
        MonsterTransform.position = new Vector2(MonsterTransform.position.x + 0.008f, MonsterTransform.position.y); // Moves the monster on the x-axis every update. y position stays the same
	}
}
