using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private Material wall_mat;
    [SerializeField] private Material obstacle_mat;

    private MeshRenderer mesh;
    private void OnCollisionEnter(Collision other)
    {
        mesh = GetComponent<MeshRenderer>();
        if (other.gameObject.tag == "Player")
        {
            mesh.material.color = Color.red;
            StartCoroutine(WallRecolour());
        }
    }

    private IEnumerator WallRecolour()
    {
        yield return new WaitForSeconds(1.5f);
        if (transform.tag == "Wall")
        {
            mesh.material = wall_mat;
        }
        else if (transform.tag == "Obstacle")
        {
            mesh.material = obstacle_mat;
        }
    }
}
