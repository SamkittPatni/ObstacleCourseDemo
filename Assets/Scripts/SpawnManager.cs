using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject dropObstacle;
    [SerializeField] private GameObject rollObstacle;
    void Start()
    {
        StartCoroutine(SpawnDrops());
        StartCoroutine(SpawnRolls());
    }

    void Update()
    {
        
    }

    private IEnumerator SpawnDrops()
    {
        yield return new WaitForSeconds(3f);
        while (true)
        {
            Instantiate(dropObstacle, new Vector3(Random.Range(-7f, 7f), 15f, Random.Range(-7f, 7f)), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(3f, 5f));
        }
    }

    private IEnumerator SpawnRolls()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            Instantiate(rollObstacle, new Vector3(-15f, 7f, Random.Range(-7f, 7f)), Quaternion.identity);
            Instantiate(rollObstacle, new Vector3(15f, 7f, Random.Range(-7f, 7f)), Quaternion.identity);
            yield return new WaitForSeconds(4f);
        }
    }
}
