using UnityEngine;

public class PuloPersonagem : MonoBehaviour
{
    public float forcaDoPulo = 10f; // Força do pulo
    private bool estaNoChao; // Verifica se o personagem está no chão

    // Referência ao componente Rigidbody do personagem
    private Rigidbody rb;

    void Start()
    {
        // Obtém a referência ao componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Verifica se o personagem está no chão
        estaNoChao = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Se o personagem estiver no chão e a tecla de espaço for pressionada, ele pula
        if (estaNoChao && Input.GetKeyDown(KeyCode.Space))
        {
            // Aplica uma força para cima no personagem para fazê-lo pular
            rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse);
        }
    }
}