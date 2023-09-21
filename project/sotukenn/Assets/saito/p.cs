using UnityEngine;
using System.Collections;

public class p : MonoBehaviour
{

	private CharacterController enemyController;
	private Animator animator;
	//�@�ړI�n
	private Vector3 destination;
	//�@�����X�s�[�h
	[SerializeField]
	private float walkSpeed = 1.0f;
	//�@���x
	private Vector3 velocity;
	//�@�ړ�����
	private Vector3 direction;
	//�@�����t���O
	private bool arrived;
	//�@SetPosition�X�N���v�g
	private SetPosition setPosition;
	//�@�҂�����
	[SerializeField]
	private float waitTime = 5f;
	//�@�o�ߎ���
	private float elapsedTime;

	// Use this for initialization
	void Start()
	{
		enemyController = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
		setPosition = GetComponent<SetPosition>();
		setPosition.CreateRandomPosition();
		velocity = Vector3.zero;
		arrived = false;
		elapsedTime = 0f;
	}

	// Update is called once per frame
	void Update()
	{
		if (!arrived)
		{
			if (enemyController.isGrounded)
			{
				velocity = Vector3.zero;
				animator.SetFloat("Speed", 2.0f);
				direction = (destination - transform.position).normalized;
				transform.LookAt(new Vector3(destination.x, transform.position.y, destination.z));
				velocity = direction * walkSpeed;
				Debug.Log(destination);
			}
			velocity.y += Physics.gravity.y * Time.deltaTime;
			enemyController.Move(velocity * Time.deltaTime);

			//�@�ړI�n�ɓ����������ǂ����̔���
			if (Vector3.Distance(transform.position, destination) < 0.5f)
			{
				arrived = true;
				animator.SetFloat("Speed", 0.0f);
			}
			//�@�������Ă�����
		}
		else
		{
			elapsedTime += Time.deltaTime;

			//�@�҂����Ԃ��z�����玟�̖ړI�n��ݒ�
			if (elapsedTime > waitTime)
			{
				setPosition.CreateRandomPosition();
				destination = setPosition.GetDestination();
				arrived = false;
				elapsedTime = 0f;
			}
			Debug.Log(elapsedTime);
		}
	}
}
