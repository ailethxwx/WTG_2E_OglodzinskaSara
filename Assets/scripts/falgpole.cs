using UnityEngine;
using UnityEngine.SceneManagement;

public class falgpole : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.CompareTag("Player"))
        {
            //go to next level
            SceneController.instance.NextLevel();
        }
   }
}

