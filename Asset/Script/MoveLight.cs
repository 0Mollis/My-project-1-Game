using UnityEngine;

public class MoveLight : MonoBehaviour
{
    [SerializeField] private float speed = 0.02f;
    private Vector3 moveVector;

    void Start()
    {
        moveVector = new Vector3(-speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        collision.gameObject.GetComponent<player>().bonusSpeed();
    }

    void Update()
    {
        transform.Translate(moveVector);
        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
