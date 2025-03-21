using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float length, startingPoint;
    public GameObject cam;
    public float parallaxEffect;



    // Start is called before the first frame update
    void Start()
    {
        startingPoint = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }



    // Update is called once per frame
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startingPoint + dist, transform.position.y, transform.position.z);

        if (temp > startingPoint + length)
        {
            startingPoint += length;
            Debug.Log("563");
        }
        else if (temp < startingPoint - length) startingPoint -= length;
    }
}
