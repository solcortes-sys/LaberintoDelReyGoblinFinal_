using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSecond : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {

        SceneManager.LoadScene(1);
        Debug.Log($"Cargando siguiente escena: índice 1");
    }
}
