using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newday : MonoBehaviour
{
    private float speed = 2f;
    private float accelatation = 1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        accelatation += 0.1f;
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * accelatation);
        if(transform.position)
    }
}
