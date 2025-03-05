using System.Net.Sockets;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewMonoBehaviourScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private GameObject rocket;
    private player rocketScript;
    [SerializeField]
    private int moveDirection;

    public void OnPointerDown(PointerEventData eventData)
    {
        rocketScript.moveDirection = moveDirection;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rocketScript.moveDirection = 0;
    }

    void Start()
    {
        rocketScript = rocket.GetComponent<player>();
    }
}
