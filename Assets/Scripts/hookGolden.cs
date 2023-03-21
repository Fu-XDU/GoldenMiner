using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookGolden : MonoBehaviour
{
    private bool collecting = false;

    private Vector3 startedPoint = new Vector3(419.9F, 352.8F, -1);
    private GameObject hook;

    // Start is called before the first frame update
    void Start()
    {
        hook = GameObject.Find("hook");
        hook.SetActive(false);
        hook.transform.position = startedPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if (collecting)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, startedPoint, 1F);
            if (transform.localPosition == startedPoint)
            {
                Destroy(this.gameObject);
                hook.SetActive(true);
                collecting = false;
            }
        }
    }
    
    void collect()
    {
        collecting = true;
    }
}
