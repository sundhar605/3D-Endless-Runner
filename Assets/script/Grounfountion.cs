using UnityEngine;

public class Grounfountion : MonoBehaviour
{
    Groundspawner groundspawner;
    public GameObject obstacle;

    private void Start()
    {
        groundspawner = GameObject.FindObjectOfType<Groundspawner>();
        spwonpoint();
        coinspawn();
    }

    private void OnTriggerExit(Collider other)
    {
        groundspawner.spawn();
        Destroy(gameObject, 2);
    }
    void spwonpoint() 
    {
        int randomindex = Random.Range(2, 5);
        Transform spownpoint = transform.GetChild(randomindex).transform;

        Instantiate(obstacle, spownpoint.position, Quaternion.identity,transform);
    }

    public GameObject coinprefab;

    void coinspawn()
    {
        int coinspawn = 3;

        for (int i = 0; i < coinspawn; i++)
        {
            GameObject temp = Instantiate(coinprefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }


    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }

}
