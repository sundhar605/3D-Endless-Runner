using UnityEngine;

public class coine : MonoBehaviour
{
    float trunspeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }


        if (other.gameObject.name != "Player") 
        { 
            return; 
        }

        //Add player score;
        GameManager.inst.Incrementscore();

        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(0, 0, trunspeed * Time.deltaTime);
    }
}
