using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10,10,10));
        transform.Translate(new Vector3(0.01f, 0, 0.01f));
    }
}
