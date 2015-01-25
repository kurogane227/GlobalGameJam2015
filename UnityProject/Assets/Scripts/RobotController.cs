using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RobotController : MonoBehaviour {

	public List<Thruster> leftThrusterAssignment;
	public List<Thruster> rightThrusterAssignment;
	
	public List<Material> materialList;

	public Thruster frontThruster;
	public Thruster backThruster;
	public Thruster leftThruster;
	public Thruster rightThruster;
	
	public Transform baseRotation;

	// Use this for initialization
	void Start ()
	{
		leftThrusterAssignment = new List<Thruster>();
		rightThrusterAssignment = new List<Thruster>();
		AssignInitialThrusters ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		leftThrusterAssignment [0].thrust_1 = InputManager.pl_Controller.leftTrigger;
		leftThrusterAssignment [0].thrust_2 = InputManager.pl_Controller.leftTrigger;
		//rightThrusterAssignment [0].thrust_2 = InputManager.pl_Controller.rightTrigger;
		leftThrusterAssignment[0].leftTriggerIndex = 0;
		leftThrusterAssignment[0].rightTriggerIndex = 0;
		//rightThrusterAssignment[0].rightTriggerIndex = 0;

		leftThrusterAssignment [1].thrust_1 = InputManager.p2_Controller.leftTrigger;
		leftThrusterAssignment [1].thrust_2 = InputManager.p2_Controller.leftTrigger;
		//rightThrusterAssignment [1].thrust_2 = InputManager.p2_Controller.rightTrigger;
		leftThrusterAssignment[1].leftTriggerIndex = 1;
		leftThrusterAssignment[1].rightTriggerIndex = 1;
		//rightThrusterAssignment[1].rightTriggerIndex = 1;

		leftThrusterAssignment [2].thrust_1 = InputManager.p3_Controller.leftTrigger;
		leftThrusterAssignment [2].thrust_2 = InputManager.p3_Controller.leftTrigger;
		//rightThrusterAssignment [2].thrust_2 = InputManager.p3_Controller.rightTrigger;
		leftThrusterAssignment[2].leftTriggerIndex = 2;
		leftThrusterAssignment[2].rightTriggerIndex = 2;
		//rightThrusterAssignment[2].rightTriggerIndex = 2;

		leftThrusterAssignment [3].thrust_1 = InputManager.p4_Controller.leftTrigger;
		leftThrusterAssignment [3].thrust_2 = InputManager.p4_Controller.leftTrigger;
		//rightThrusterAssignment [3].thrust_2 = InputManager.p4_Controller.rightTrigger;
		leftThrusterAssignment[3].leftTriggerIndex = 3;
		leftThrusterAssignment[3].rightTriggerIndex = 3;
		//rightThrusterAssignment[3].rightTriggerIndex = 3;


		ClampVelocity();
		HandleRotation();

	}

	void AssignInitialThrusters()
	{
		leftThrusterAssignment.Add (frontThruster);
		leftThrusterAssignment.Add (backThruster);
		leftThrusterAssignment.Add (leftThruster);
		leftThrusterAssignment.Add (rightThruster);

		rightThrusterAssignment.Add (frontThruster);
		rightThrusterAssignment.Add (backThruster);
		rightThrusterAssignment.Add (leftThruster);
		rightThrusterAssignment.Add (rightThruster);

		ShuffleThrusterList (leftThrusterAssignment, rightThrusterAssignment);
		ShuffleThrusterList (rightThrusterAssignment, leftThrusterAssignment);
		MatchRobotColors();

	}

	void ShuffleThrusterList(List<Thruster> listToShuffle, List<Thruster> otherList)
	{
		int n = listToShuffle.Count;
		for (int i = 0; i < n; i++) 
		{
			int r = i + (int)(Random.Range(0, 1f) * (n-i));
			Thruster t = listToShuffle[r];
			listToShuffle[r] = listToShuffle[i];
			listToShuffle[i] = t;
		}
		PerformComparisonCheck (listToShuffle, otherList);
	}

	void PerformComparisonCheck(List<Thruster> shufflingList, List<Thruster> otherList)
	{
		if (shufflingList [0] == otherList [0])
		{
			if (shufflingList [1] != otherList[0])
			{
				Thruster tempThruster = shufflingList[1];
				shufflingList[1] = shufflingList[0];
				shufflingList[0] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[2];
				shufflingList[2] = shufflingList[0];
				shufflingList[0] = tempThruster;
			}
		}

		if (shufflingList [1] == otherList [1])
		{
			if (shufflingList [2] != otherList[1])
			{
				Thruster tempThruster = shufflingList[2];
				shufflingList[2] = shufflingList[1];
				shufflingList[1] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[3];
				shufflingList[3] = shufflingList[1];
				shufflingList[1] = tempThruster;
			}
		}

		if (shufflingList [2] == otherList [2])
		{
			if (shufflingList [3] != otherList[2])
			{
				Thruster tempThruster = shufflingList[3];
				shufflingList[3] = shufflingList[2];
				shufflingList[2] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[0];
				shufflingList[0] = shufflingList[2];
				shufflingList[2] = tempThruster;
			}
		}

		if (shufflingList [3] == otherList [3])
		{
			if (shufflingList [0] != otherList[3])
			{
				Thruster tempThruster = shufflingList[0];
				shufflingList[0] = shufflingList[3];
				shufflingList[3] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[1];
				shufflingList[1] = shufflingList[3];
				shufflingList[3] = tempThruster;
			}
		}
	}
	
	public void ClampVelocity()
	{
		if (rigidbody.velocity.magnitude > 4f)
		{
			Vector3 normalizedVelocity = rigidbody.velocity;
			normalizedVelocity.Normalize();
			
			rigidbody.velocity = normalizedVelocity * 4f;
		}
	}
	
	public void HandleRotation()
	{
		baseRotation.Rotate(Time.deltaTime * 30f, 0, 0);
	}
	
	public void MatchRobotColors()
	{
		
		//mats[3].mainTexture
	}
	
}

