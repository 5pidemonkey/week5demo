using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class CubeController : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [Range(1,10)] public float Speed = 1f;
    public bool isFlashing = false;



    // Start is called before the first frame update
    void Start()
    {
        //MeshRenderer meshRenderer = (MeshRenderer)GetComponent(typeof(MeshRenderer));  <-------BAD!!
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (meshRenderer != null && isFlashing == true)
        {
            float r = Random.Range(-1f, 1f);
            float g = Random.Range(-1f, 1f);
            float b = Random.Range(-1f, 1f);
            meshRenderer.material.color += new Color(r, g, b);
        }
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        transform.position += new Vector3(h, 0, v) * Time.deltaTime * Speed;

        //transform.position += new Vector3(0, 0, zSpeed) * Time.deltaTime;
    }

    void OnDestroy()
    {

    }
}
