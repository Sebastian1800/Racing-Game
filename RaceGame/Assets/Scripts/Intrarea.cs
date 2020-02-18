using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Intrarea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IntraMenu());
    }

    IEnumerator IntraMenu()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}