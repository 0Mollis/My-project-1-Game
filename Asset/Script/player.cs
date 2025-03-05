using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private int lifeAmmout = 0;
    [SerializeField] 
    private Image[] hearts;
    [SerializeField]
    private Image[] Buttons;
    private Vector3 moveVector;
    private Vector3 moveVectorX;
    public int moveDirection = 0;  
    
    void Start()
    {
        moveVector = new Vector3(0, speed);
        moveVectorX = new Vector3(speed,0);
        lifeAmmout = hearts.Length;
        Check();
    }

    private void updateMoveVectors()
    {
        moveVector = new Vector3(0, speed);
        moveVectorX = new Vector3(speed, 0);
    }

    public void bonusSpeed()
    {
        speed = 10.0f;
        updateMoveVectors();
        Invoke("defaultSpeed", 10);
    }
    private void defaultSpeed()
    {
        speed = 5.0f;
        updateMoveVectors();
    }

    public void lifeUpdate(int life)
    {
        if (life < 0)
        {
            lifeAmmout += life;
        }
        if (life > 0)
        {
            if(lifeAmmout < 4)
            {
                lifeAmmout += life;
            }
        }
        else

        if (lifeAmmout == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        for (int i = 0; i<hearts.Length;i++)
        {
            hearts[i].enabled = i < lifeAmmout;
        }
    }

    private void Check()
    {
        string s = SystemInfo.operatingSystem;
        Regex regex = new Regex("Windows");
        MatchCollection matches = regex.Matches(s);
        if (matches.Count > 0)
        {
            foreach(var button in Buttons)
            {
                button.enabled = false;
            }
        }
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (transform.position.y < 4 && vertical > 0)
        {
            transform.Translate(moveVector * Time.deltaTime);
        }
        else if (transform.position.y > -4 && vertical < 0)
        {
            transform.Translate(-moveVector * Time.deltaTime);
        }
        else if (transform.position.x > -7 && horizontal < 0 )
        {
            transform.Translate(-moveVectorX * Time.deltaTime);
        }
        else if (transform.position.x < 7 && horizontal > 0)
        {
            transform.Translate(moveVectorX * Time.deltaTime);
        }






        if (transform.position.y < 4 && moveDirection == 1)
        {
            transform.Translate(moveVector * Time.deltaTime);
        }
        else if (transform.position.y > -4 && moveDirection == -1)
        {
            transform.Translate(-moveVector * Time.deltaTime);
        }
        else if (transform.position.x > -7 && moveDirection == 2)
        {
            transform.Translate(-moveVectorX * Time.deltaTime);
        }
        else if (transform.position.x < 7 && moveDirection == -2)
        {
            transform.Translate(moveVectorX * Time.deltaTime);
        }
    }
}
