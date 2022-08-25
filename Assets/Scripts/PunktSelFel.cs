using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunktSelFel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movement(char direction)
    {
        if(direction == 'u')
        {
            transform.Translate(Vector3.up * 10);
        }
        else
        if(direction == 'd')
        {
            transform.Translate(Vector3.up * -10);
        }
        else
        if(direction == 'r')
        {
            transform.Translate(Vector3.right * 10);
        }
        else 
        if(direction == 'l')
        {
            transform.Translate(Vector3.right * -10);
        }
    }
}
