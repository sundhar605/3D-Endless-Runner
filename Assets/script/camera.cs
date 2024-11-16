using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform Player;

    Vector3 offset;
    private void Start()
    {
        offset = transform.position - Player.position;
    }

    private void Update()
    {
        Vector3 targetpos = Player.position + offset;
        targetpos.x = 0;
        transform.position = targetpos;
    }

}
