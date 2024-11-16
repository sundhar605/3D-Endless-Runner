using UnityEngine;

public class Groundspawner : MonoBehaviour
{
    public GameObject spawntail;

    Vector3 nextspawnpoint;


    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            spawn();
        }
    }
    public void spawn()
    {
        GameObject temp = Instantiate(spawntail, nextspawnpoint, Quaternion.identity);
        nextspawnpoint = temp.transform.GetChild(1).transform.position;
    }
}
