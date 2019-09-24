using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{

    Vector3 velocity = new Vector3();
    public float gravity = 1;

    // Start is called before the first frame update
    void Start()
    {
        velocity = Random.onUnitSphere * 5;
    }

    // Update is called once per frame
    void Update()
    {
        //euler physics

        transform.position += velocity * Time.deltaTime;
        velocity -= new Vector3(0, gravity, 0) * Time.deltaTime;

        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }

    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        print("clicked");
    }

}
