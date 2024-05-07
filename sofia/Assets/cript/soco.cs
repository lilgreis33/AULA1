using UnityEngine;

public class SocoPersonagem : MonoBehaviour
{
    public KeyCode teclaDoSoco = KeyCode.F; // Tecla que irá acionar o soco
    public float forcaDoSoco = 10f; // Força do soco

    // Referência ao componente Rigidbody do personagem
    private Rigidbody rb;

    void Start()
    {
        // Obtém a referência ao componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Verifica se a tecla do soco foi pressionada
        if (Input.GetKeyDown(teclaDoSoco))
        {
            // Aplica uma força para frente no personagem para simular o soco
            rb.AddForce(transform.forward * forcaDoSoco, ForceMode.Impulse);
        }
    }
}