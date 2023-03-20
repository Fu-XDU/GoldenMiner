using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookGolden : MonoBehaviour
{
    private bool collecting = false;
    // Start is called before the first frame update
    void Start()
    {
        if (collecting)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(420, 353, -1), 0.01F);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void collect()
    {
        Debug.Log("fxxk");
        collecting = true;
    }
}
