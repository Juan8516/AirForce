using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyShoot();
        transform.Translate(Vector3.up * speed *Time.deltaTime);
    }

    private void DestroyShoot()
    {
        if (transform.position.y >= 5.2f)
        {
            Destroy(gameObject);
        }
    }
}