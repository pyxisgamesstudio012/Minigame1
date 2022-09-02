using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody body;
    public PlayerControl playerControl;

    private Vector3 playerMoveInput;
    private float speedFactor = 5;
    private Vector2 boxSize = new Vector2(1f, 1f);

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        playerControl = new PlayerControl();
        playerControl.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        playerControl.Player.Movement.performed += ctx => {
            playerMoveInput = new Vector3(ctx.ReadValue<Vector3>().x, ctx.ReadValue<Vector3>().z, ctx.ReadValue<Vector3>().y);
            speedFactor = 5;
        };
        playerControl.Player.Movement.canceled += ctx => {
            speedFactor = 0;
        };

        body.velocity = playerMoveInput * speedFactor;
        
    }

    void OnAttack()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, this.boxSize, 0, Vector2.left);
        if (hits.Length > 0)
        {
            Debug.Log(hits);
            foreach (RaycastHit2D rc in hits)
            {
                Debug.Log(rc.collider.gameObject.name);
                //if ()
                //{

                //}
            }
        }
    }
}
