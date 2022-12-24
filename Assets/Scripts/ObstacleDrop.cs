using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDrop : MonoBehaviour
{
    private MeshRenderer mesh;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        //transform.Translate(0, -4f * Time.deltaTime, 0);
        if (transform.position.y <= 0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            player.score++;
            Debug.Log("Objects bumped into: " + player.score);
        }
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.red;
        StartCoroutine(DestroyObstacle());
    }

    private IEnumerator DestroyObstacle()
    {
        yield return new WaitForSeconds(1f);
    }
}
