using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSecond : MonoBehaviour
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
            SceneManager.LoadScene(2);
            Debug.Log($"Cargando siguiente escena: índice 2");
        }
    }
}
