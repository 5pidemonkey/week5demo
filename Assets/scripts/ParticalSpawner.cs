using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSpawner : MonoBehaviour
{

    public GameObject prefab;
    /// <summary>
    /// this sets how many seconds are left before spawning the next particle
    /// </summary>
    public float countDownToSpawn = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        countDownToSpawn -= Time.deltaTime;
        if (countDownToSpawn <= 0)
        {
            GameObject newSpawn = Instantiate(prefab, transform.position, Quaternion.identity);
            newSpawn.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0, 1, 1, 1, 1, 1);
            countDownToSpawn = Random.Range(0.03f, 0.06f);
        }
    }
}
