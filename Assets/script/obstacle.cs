using UnityEngine;

public class obstacle : MonoBehaviour
{
    Playermovement Playermovement;

    private void Start()
    {
        Playermovement = GameObject.FindObjectOfType<Playermovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Playermovement.deid();
        }
    }
}
