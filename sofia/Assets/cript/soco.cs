using UnityEngine;

public class SocoPersonagem : MonoBehaviour
{
    public KeyCode teclaDoSoco = KeyCode.F; // Tecla que ir� acionar o soco
    public float forcaDoSoco = 10f; // For�a do soco

    // Refer�ncia ao componente Rigidbody do personagem
    private Rigidbody rb;

    void Start()
    {
        // Obt�m a refer�ncia ao componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Verifica se a tecla do soco foi pressionada
        if (Input.GetKeyDown(teclaDoSoco))
        {
            // Aplica uma for�a para frente no personagem para simular o soco
            rb.AddForce(transform.forward * forcaDoSoco, ForceMode.Impulse);
        }
    }
}