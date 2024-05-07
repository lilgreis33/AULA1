using UnityEngine;

public class PuloPersonagem : MonoBehaviour
{
    public float forcaDoPulo = 10f; // For�a do pulo
    private bool estaNoChao; // Verifica se o personagem est� no ch�o

    // Refer�ncia ao componente Rigidbody do personagem
    private Rigidbody rb;

    void Start()
    {
        // Obt�m a refer�ncia ao componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Verifica se o personagem est� no ch�o
        estaNoChao = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Se o personagem estiver no ch�o e a tecla de espa�o for pressionada, ele pula
        if (estaNoChao && Input.GetKeyDown(KeyCode.Space))
        {
            // Aplica uma for�a para cima no personagem para faz�-lo pular
            rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse);
        }
    }
}