using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanagement : MonoBehaviour
{

    public TextMeshProUGUI vida1; // referente al componente TMPGui para mostrar la vida 1
    public TextMeshProUGUI vida2; // referente al componente TMPGui para mostrar la vida 2
    public TextMeshProUGUI vida3; // referente al componente TMPGui para mostrar la vida 3
    public TextMeshProUGUI cartel; // referente al componente TMPGui para mostrar la vida 3
    public int repeatCount;  // cantidad de vida del guerrero minimo 0 maximo 100
    public int vidacount1;
    public int vidacount2;
    public int vidacount3;
    private char character; // barra de vida






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();        // Obtiene la escena activa
        if (currentScene.name == "Room1")
        {
            cartel.text = "           Room: [ 1 ] > [   ] > [   ] > [   ]";// Imprime el nombre de la escena 1 en la consola
        }
        if (currentScene.name == "Room2")
        {
            cartel.text = "           Room: [   ] > [ 2 ] > [   ] > [   ]";// Imprime el nombre de la escena 2 en la consola
        }
        if (currentScene.name == "Room3")
        {
            cartel.text = "           Room: [   ] > [   ] > [ 3 ] > [   ]";// Imprime el nombre de la escena 3 en la consola
        }
        if (currentScene.name == "RoomFinal")
        {
            cartel.text = "           Room: [   ] > [   ] > [   ] > [END]";// Imprime el nombre de la escena 4 en la consola
        }
        character = '/'; // El carácter que repito
        repeatCount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        vidacount3 = 0;
        vidacount2 = 0;
        vidacount1 = 0;

        if (repeatCount > 0)
        {
            vidacount3 = 0;
            vidacount2 = 0;
            vidacount1 = repeatCount;
        }

        if (repeatCount > 33)
        {
            vidacount3 = 0;
            vidacount2 = repeatCount - 33;
            vidacount1 = 33;
        }

        if (repeatCount > 66)
        {
            vidacount3 = repeatCount - 66;
            vidacount2 = 33;
            vidacount1 = 33;
        }


        if (repeatCount > 99)
        {
            vidacount1 = 33;
            vidacount2 = 33;
            vidacount3 = 33;
        }

        vida1.text = new string(character, vidacount1);
        vida2.text = new string(character, vidacount2);
        vida3.text = new string(character, vidacount3);
    }
}
