using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement : MonoBehaviour
{
    public float speed = 15f;
    public float sidespeed = 12f;
    float horizontal;
    public float jumpforce = 700f;
    [SerializeField] LayerMask groundmask;

    public Rigidbody rb;

    bool alive = true;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwordmove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalmove = transform.right * sidespeed * horizontal * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + horizontalmove + forwordmove);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpmove();
        }

        horizontal = Input.GetAxis("Horizontal");

        if( transform.position.y < -8  )
        {
            deid();
        }
    }
    public void deid()
    {
        alive = false;

        Invoke("restart", 2);
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void jumpmove()
    {
        float hight = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, hight, groundmask);

        //if we jump
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpforce);
        }
       
    }
}
