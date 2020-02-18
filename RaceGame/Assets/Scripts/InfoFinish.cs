using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoFinish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InfoTermina());
    }

    IEnumerator InfoTermina()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(1);
    }

    
}
