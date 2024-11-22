using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float velocidade = 1;

    private int direcao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direcao = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += velocidade * Time.deltaTime * direcao;
        
        
        
        if(pos.x > 11)
        {
            if(velocidade < 20)
                velocidade *= 1.05f;
            direcao = -1;
        }
        else if(pos.x < -11)
        {
            if(velocidade < 20)
                velocidade *= 1.05f;
            direcao = 1;
        }

        transform.position = pos;

    }
}
