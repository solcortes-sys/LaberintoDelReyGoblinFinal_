using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorFirst : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {

            if (collision.gameObject.GetComponent<Player>().key == false)
            {
                Debug.Log("No tienes la llave para abrir la puerta");
                return;
            }
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            //int targetIndex = currentIndex ;
            int totalScenes = SceneManager.sceneCountInBuildSettings;
           // if (targetIndex >= totalScenes) targetIndex = 0;
            SceneManager.LoadScene(1);
            Debug.Log($"Cargando siguiente escena: índice {1}");
        }
    }
}
