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
        
        
	}

    /// <summary>
    /// Currently randomly moves the monster randomly in a direction on the 'grid'.  Will eventually have some basic AI to hunt either player, or correct answers.
    /// </summary>
    /// <returns></returns>
    IEnumerator MoveMonster()
    {
        //int random = Random.Range(0, 3); // 0 - left, 1 - up, 2 - right, 3 - down

        while (true)
        {
            int random = Random.Range(0, 4); // 0 - left, 1 - up, 2 - right, 3 - down   Random.Range(int, int) is [inclusive, exclusive). so our range of 0-4 returns 0, 1, 2, 3

            if (random == 0 && MonsterTransform.position.x < 2) // right
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x + 1, MonsterTransform.position.y); // Moves the monster on the x-axis. +1 to move right, -1 to move left. y position stays the same
                yield return new WaitForSeconds(2);
            }
            if (random == 2 && MonsterTransform.position.x > -2) // left
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x - 1, MonsterTransform.position.y); 
                yield return new WaitForSeconds(2);
            }
            if (random == 1 && MonsterTransform.position.y < 2) // up
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x, MonsterTransform.position.y + 1); // Moves the monster on the y-axis. +1 up, -1 down.
                yield return new WaitForSeconds(2);
            }
            if (random == 3 && MonsterTransform.position.y > -2) // down
            {
                MonsterTransform.position = new Vector2(MonsterTransform.position.x, MonsterTransform.position.y - 1); 
                yield return new WaitForSeconds(2);
            }
        }
    }

    /// <summary>
    /// Checks to see if the monster runs into a number.  Will also check to see if the number is a correct value and 'munch' it if it is.
    /// </summary>
    /// <param name="collider">gets information about the gameobject that triggered</param>
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Number")
        {
            Debug.Log(gameObject.name + "ran into a number!");

        }
    }
}
