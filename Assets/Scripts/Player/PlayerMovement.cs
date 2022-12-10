using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int health;
    public Rigidbody2D rb;
    public Animator anim;
    Vector2 Movement;
    [SerializeField] float speed;
    public VectorValue startingPosition;
	private void Awake()
	{	
		startingPosition.initialValue = transform.position;
	}
    
    private void Start()
    {
        // transform.position = startingPosition.initialValue;
    }
    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Horizontal", Movement.x);
        anim.SetFloat("Vertical", Movement.y);
        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 ||  Input.GetAxisRaw("Vertical") == -1)
        {
            anim.SetFloat("LastMoveX",Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("LastMoveY",Input.GetAxisRaw("Vertical"));
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }
    }

    
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position+Movement.normalized*speed*Time.fixedDeltaTime);
    }
}
