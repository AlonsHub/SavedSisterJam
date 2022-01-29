using UnityEngine;



[RequireComponent (typeof (Animator))]
public class LocomotionSimpleAgent : MonoBehaviour {
	Animator anim;
	//NavMeshAgent agent;
	Vector2 smoothDeltaPosition = Vector2.zero;
	Vector2 velocity = Vector2.zero;

	Vector3 nextPos;

	[SerializeField]
	float moveSpeed;

	CharacterController cc;

	[SerializeField]
	string horizontalAxisName;
	[SerializeField]
	string verticalAxisName;

	void Start () {
		anim = GetComponent<Animator> ();
		//agent = GetComponent<NavMeshAgent> ();
		//agent.updatePosition = false;
		cc = GetComponent<CharacterController>();
	}
	Vector3 vel = new Vector3();
	void Update()
	{

		Vector3 inputVector = new Vector3(Input.GetAxis(horizontalAxisName), 0, Input.GetAxis(verticalAxisName));
		if (inputVector.magnitude > 1)
			inputVector.Normalize();

		inputVector *= moveSpeed * Time.deltaTime;

		//transform.Translate(inputVector, Space.Self);
		//Vector3 worldDeltaPosition = inputVector.x * transform.right + inputVector.y * transform.forward;
		cc.Move(inputVector);
		nextPos = transform.position + cc.velocity;
		bool shouldMove = cc.velocity.magnitude > .5f;

		anim.SetBool("move", shouldMove);
		anim.SetFloat("vely", cc.velocity.magnitude);

		if(shouldMove)
		transform.LookAt(nextPos);

		if (!cc.isGrounded)
		{
			vel -= Physics.gravity * -2f * Time.deltaTime;
		}
		cc.Move(vel * Time.deltaTime);

	}


    //void OnAnimatorMove()
    //{
    //    // Update postion to agent position
    //    //		transform.position = agent.nextPosition;

    //    // Update position based on animation movement using navigation surface height
    //    Vector3 position = anim.rootPosition;
    //    position.y = nextPos.y;
    //    transform.position = position;
    //}
}
