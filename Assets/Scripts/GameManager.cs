using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject finishPlatform;
    void Start()
    {
        finishPlatform.SetActive(true);
        StartCoroutine(PlatformFlicker());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator PlatformFlicker()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(0.3f);
            finishPlatform.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            finishPlatform.SetActive(false);
        }
        finishPlatform.SetActive(true);
    }
}
