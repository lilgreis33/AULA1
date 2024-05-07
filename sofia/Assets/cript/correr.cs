using UnityEngine;

public class CorrerPersonagem : MonoBehaviour
{
    public KeyCode teclaDaCorrida = KeyCode.LeftShift; // Tecla que ir� acionar a corrida
    public float velocidadeCorrida = 10f; // Velocidade de corrida do personagem
    private float velocidadeOriginal; // Velocidade original do personagem antes da corrida

    // Refer�ncia ao componente CharacterController do personagem
    private CharacterController controller;

    void Start()
    {
        // Obt�m a refer�ncia ao componente CharacterController
        controller = GetComponent<CharacterController>();
        // Salva a velocidade original do personagem
        velocidadeOriginal = controller.speed;
    }

    void Update()
    {
        // Se a tecla da corrida estiver sendo pressionada, aumenta a velocidade do personagem para correr
        if (Input.GetKey(teclaDaCorrida))
        {
            controller.speed = velocidadeCorrida;
        }
        else
        {
            // Se a tecla da corrida n�o estiver sendo pressionada, retorna a velocidade original do personagem
            controller.speed = velocidadeOriginal;
        }
    }
}