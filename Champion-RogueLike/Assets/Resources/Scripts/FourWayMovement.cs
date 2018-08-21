using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

public class FourWayMovement : MonoBehaviour
{
	public FloatReference maxSpeed;
	public FloatReference accel;

	//North = 0, East = 1, South = 2, West = 3
	public IntVariable facing;

	private Rigidbody2D myBody;

	private float _moveX, _moveY;
	private Vector3 movement;
	private Vector3 mousePosition;
	private Quaternion attackRot;

	//Animator
	private Animator anim;

	// Use this for initialization
	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_moveX = Input.GetAxisRaw("Horizontal");
		_moveY = Input.GetAxisRaw("Vertical");
		movement = new Vector3(_moveX, _moveY).normalized;

		//movement = new Vector3( Input.GetAxisRaw("Horizontal"),  Input.GetAxisRaw("Vertical") ).normalized;

		//Update Animator values
		SetMove();
		SetFacing();
	}

	private void FixedUpdate()
	{
		Move();		
	}

	public void Move()
	{
		if ((myBody.velocity.x > maxSpeed && _moveX < 0) 
			|| (myBody.velocity.x < -maxSpeed && _moveX > 0) 
			|| Mathf.Abs(myBody.velocity.x) < maxSpeed)
				myBody.AddForce(new Vector3(movement.x, 0) * accel * Time.deltaTime);

		if ((myBody.velocity.y > maxSpeed && _moveY < 0) 
			|| (myBody.velocity.y < -maxSpeed && _moveY > 0) 
			|| Mathf.Abs(myBody.velocity.x) < maxSpeed)
				myBody.AddForce(new Vector3(0, movement.y) * accel * Time.deltaTime);

		//Set player facing

	}

	#region Animator

	public void SetMove()
	{
		if (movement.x != 0 || movement.y != 0)
		{
			anim.SetBool("isMoving", true);
			anim.SetFloat("moveX", movement.x);
			anim.SetFloat("moveY", movement.y);

			//Set Facing
			if (movement.y == 1)
				facing.SetValue(0);

			if (movement.x == 1)
				facing.SetValue(1);

			if (movement.y == -1)
				facing.SetValue(2);

			if (movement.x == -1)
				facing.SetValue(3);
		}
		else
		{
			anim.SetBool("isMoving", false);
		}
	}

	public void SetFacing()
	{
		anim.SetInteger("Facing", facing.Value);
	}

	#endregion
}
