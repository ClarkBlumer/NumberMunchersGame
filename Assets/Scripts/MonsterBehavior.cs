using UnityEngine;
using System.Collections;

public class MonsterBehavior : MonoBehaviour {

    public Transform MonsterTransform;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(MoveMonster());
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Testing monster movement horizontal
        
	}

    IEnumerator MoveMonster()
    {
        //int random = Random.Range(0, 3); // 0 - left, 1 - up, 2 - right, 3 - down

        while (true)
        {
            int random = Random.Range(0, 4); // 0 - left, 1 - up, 2 - right, 3 - down

            if (random == 0 && MonsterTransform.position.x < 2) // right
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x + 1, MonsterTransform.position.y); // Moves the monster on the x-axis every update. +1 to move right, -1 to move left. y position stays the same
                yield return new WaitForSeconds(4);
            }
            if (random == 2 && MonsterTransform.position.x > -2) // left
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x - 1, MonsterTransform.position.y); 
                yield return new WaitForSeconds(4);
            }
            if (random == 1 && MonsterTransform.position.y < 2) // up
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x, MonsterTransform.position.y + 1); 
                yield return new WaitForSeconds(4);
            }
            if (random == 3 && MonsterTransform.position.y > -2) // down
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x, MonsterTransform.position.y - 1); 
                yield return new WaitForSeconds(4);
            }
        }
    }
}
