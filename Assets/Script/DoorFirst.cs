using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorFirst : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        SceneManager.LoadScene(0);
        Debug.Log($"Cargando siguiente escena: índice 0");
    }
}
