using UnityEngine;
using System.Collections;

public class NumberManager : MonoBehaviour {

    public TextMesh txtMesh;                // Get the mesh prefab

	void Awake ()
    {
        // Initialize the board of numbers
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            { 
                Instantiate(txtMesh, new Vector2(i - 2, j - 2), Quaternion.identity); // i and j values - 2 to line up with my grid since the middle is 0,0.  which means my 5x5 grid goes from -2 to 2 x/y
                txtMesh.text = Random.Range(0, 100).ToString(); // Fills each number with a value between 0 and 99 (inclusive, exclusive)
            }
        }
	}
	
	void Start ()
    {

    }

    void Update()
    {

    }

}
