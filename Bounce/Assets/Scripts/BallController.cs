using UnityEngine;

public class BallController : MonoBehaviour
{
    public float gravity = -50;
    public float impulso = 70;
    public float vx = 20;
    public float vy = 0;
    private float chao = -4;

    public float velocidade = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          vy = impulso;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        float vx = Input.GetAxis("Horizontal") * velocidade;
        
        vy += gravity * Time.fixedDeltaTime;
    
        Vector2 v = new Vector2(vx, vy);
        pos += v * Time.fixedDeltaTime;

        if(pos.y < chao)
        {
            pos.y = chao;
            vy = impulso;
        }

        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
