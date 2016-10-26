using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public int direction;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
         * DIRECTION INTEGER CODE
         * 1 = Up
         * 2 = Left
         * 3 = Right
         * 4 = Down
         */
        //Input = w
        if (Input.GetKey(KeyCode.W))
        {
            //Move Up
            transform.Translate(Vector2.up * speed);
            direction = 1;
        }
        //Input = a
        if (Input.GetKey(KeyCode.A))
        {
            //Move left
            transform.Translate(Vector2.left * speed);
            direction = 2;
        }
        //Input = d
        if (Input.GetKey(KeyCode.D))
        {
            //Move right
            transform.Translate(Vector2.right * speed);
            direction = 3;
        }
        //Input = s
        if (Input.GetKey(KeyCode.S))
        {
            //Move down
            transform.Translate(Vector2.down * speed);
            direction = 4;
        }
    }
}
