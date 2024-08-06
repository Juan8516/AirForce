using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    public int speed = 5;

    [SerializeField]
    private GameObject _shootSingle;

    // Start is called before the first frame update
    void Start()
    {
        //Reset position
        transform.position = new Vector3(0, -4.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Movement Player
        MovementPlayer();
        
        //Limits horizontal and vertical
        LimitsPlayer();

        //Shoot single
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_shootSingle, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
        }
        
    }

    private void MovementPlayer()
    {
        //Movement horizontal and vertical of player
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * inputHorizontal);
        transform.Translate(Vector3.up * Time.deltaTime * speed * inputVertical);
    }

    private void LimitsPlayer()
    {
        //Limits player in X
        if (transform.position.x > 9.2f)
        {
            transform.position = new Vector3(-9.2f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.2f)
        {
            transform.position = new Vector3(9.2f, transform.position.y, 0);
        }

        //Limits player in Y
        if (transform.position.y > 4.3f)
        {
            transform.position = new Vector3(transform.position.x, -4.3f, 0);
        }
        else if (transform.position.y < -4.3f)
        {
            transform.position = new Vector3(transform.position.x, 4.3f, 0);
        }
    }
}
