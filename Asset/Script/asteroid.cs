using UnityEngine;

public class asteroid : MonoBehaviour
{
    [SerializeField] private int damage = -1;
    [SerializeField] private float speed = 0.02f;
    private Vector3 moveVector;
    private GameObject scoreManager;

    void Start()
    {
        moveVector = new Vector3(-speed,0);
        scoreManager = GameObject.Find("ScoreManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        collision.gameObject.GetComponent<player>().lifeUpdate(damage);
    }

    void Update()
    {
        transform.Translate(moveVector);
        if (transform.position.x < -12)
        {
            scoreManager.GetComponent<Score>().addToScore();
            Destroy(gameObject);
        }
    }
}
