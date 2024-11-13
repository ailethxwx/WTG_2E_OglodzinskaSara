using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    public Transform respawnpoint;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnpoint.position;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    
}