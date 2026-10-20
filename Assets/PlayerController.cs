using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    int jumpHeight = 200;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void OnJump(InputValue value)
    {
        print("jomped");
        rb.AddForce(Vector2.up * jumpHeight);
    }
}
