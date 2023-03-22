using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Succeed : MonoBehaviour
{
    private Vector3 scaleDirection = new Vector3(0.3F, 0.3F, 0);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ScaleOut());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ScaleOut()
    {
        while (transform.localScale.x < 80)
        {
            transform.localScale += scaleDirection;
            yield return new WaitForSeconds(0.001F);
        }
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
