using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pZüge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movement(int pX, int pY)
    {
        transform.Translate(Vector3.up * 10 * pY);
        transform.Translate(Vector3.right * 10 * pX);

    }
}
