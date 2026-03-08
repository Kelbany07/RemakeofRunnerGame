using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float startPos, length;
    public float parallaxEffect;
    private GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = this.GetComponent<SpriteRenderer>().bounds.size.x;
        cam = GameObject.FindGameObjectWithTag(tag: "MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = cam.transform.position.x * parallaxEffect;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
        float temp = cam.transform.position.x * (1 - parallaxEffect);
        if (temp > startPos + length)
        {
            startPos += length;
        }
    }
}
