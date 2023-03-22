using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class failed : MonoBehaviour
{
    public float Speed = 1;
    Vector3 dest = new Vector3(415, 236, -1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, dest, Speed * Time.deltaTime);
        if (transform.localPosition == dest)
        {
            StartCoroutine(Back());
        }
    }

    IEnumerator Back()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0); 
    }
}
