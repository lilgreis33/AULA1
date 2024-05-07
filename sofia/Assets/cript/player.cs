using UnityEngine;

public class MovimentacaoPersonagem : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento do personagem

    void Update()
    {
        // Obtém os inputs de movimento do eixo horizontal e vertical
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");

        // Calcula o vetor de movimento com base nos inputs e na velocidade
        Vector3 movimento = new Vector3(movimentoHorizontal, 0f, movimentoVertical) * velocidade * Time.deltaTime;

        // Aplica o movimento ao personagem
        transform.Translate(movimento);
    }
}
