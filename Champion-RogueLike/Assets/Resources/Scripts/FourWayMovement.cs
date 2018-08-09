using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

public class FourWayMovement : MonoBehaviour
{
	public FloatReference maxSpeed;
	public FloatReference accel;

	private Rigidbody2D myBody;

	private float _moveX, _moveY;
	private Vector3 movement;
	//private bool canDash = true;
	private Vector3 mousePosition;
	private Quaternion attackRot;

	// Use this for initialization
	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_moveX = Input.GetAxisRaw("Horizontal");
		_moveY = Input.GetAxisRaw("Vertical");
		movement = new Vector3(_moveX, _moveY).normalized;
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
	}
}
