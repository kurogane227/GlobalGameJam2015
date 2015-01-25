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

		//StartCoroutine(UpdatePlayerThrusterColors());
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
		
		//StartCoroutine(UpdatePlayerThrusterColors());
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
	
/*
	public IEnumerator UpdatePlayerThrusterColors()
	{
		yield return new WaitForSeconds(0.01f); // hack for setup timing
	
		// Handle UI thruster coloring
		// Front = Red, Right = Green, Back = Blue, Left = Yellow
		
		// Player 1
		if (leftThrusterAssignment[0] == frontThruster)
		{
			UIManager.Instance.player1LeftThrusterColor = "red";
		}
		else if (leftThrusterAssignment[0] == backThruster)
		{
			UIManager.Instance.player1LeftThrusterColor = "blue";
		}
		else if (leftThrusterAssignment[0] == leftThruster)
		{
			UIManager.Instance.player1LeftThrusterColor = "yellow";
		}
		else if (leftThrusterAssignment[0] == rightThruster)
		{
			UIManager.Instance.player1LeftThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		if (rightThrusterAssignment[0] == frontThruster)
		{
			UIManager.Instance.player1RightThrusterColor = "red";
		}
		else if (rightThrusterAssignment[0] == backThruster)
		{
			UIManager.Instance.player1RightThrusterColor = "blue";
		}
		else if (rightThrusterAssignment[0] == leftThruster)
		{
			UIManager.Instance.player1RightThrusterColor = "yellow";
		}
		else if (rightThrusterAssignment[0] == rightThruster)
		{
			UIManager.Instance.player1RightThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		// Player 2
		if (leftThrusterAssignment[1] == frontThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "red";
		}
		else if (leftThrusterAssignment[1] == backThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "blue";
		}
		else if (leftThrusterAssignment[1] == leftThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "yellow";
		}
		else if (leftThrusterAssignment[1] == rightThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		if (rightThrusterAssignment[1] == frontThruster)
		{
			UIManager.Instance.player2RightThrusterColor = "red";
		}
		else if (rightThrusterAssignment[1] == backThruster)
		{
			UIManager.Instance.player2RightThrusterColor = "blue";
		}
		else if (rightThrusterAssignment[1] == leftThruster)
		{
			UIManager.Instance.player2RightThrusterColor = "yellow";
		}
		else if (rightThrusterAssignment[1] == rightThruster)
		{
			UIManager.Instance.player2RightThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		// Player 3
		if (leftThrusterAssignment[2] == frontThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "red";
		}
		else if (leftThrusterAssignment[2] == backThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "blue";
		}
		else if (leftThrusterAssignment[2] == leftThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "yellow";
		}
		else if (leftThrusterAssignment[2] == rightThruster)
		{
			UIManager.Instance.player2LeftThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		if (rightThrusterAssignment[2] == frontThruster)
		{
			UIManager.Instance.player3RightThrusterColor = "red";
		}
		else if (rightThrusterAssignment[2] == backThruster)
		{
			UIManager.Instance.player3RightThrusterColor = "blue";
		}
		else if (rightThrusterAssignment[2] == leftThruster)
		{
			UIManager.Instance.player3RightThrusterColor = "yellow";
		}
		else if (rightThrusterAssignment[2] == rightThruster)
		{
			UIManager.Instance.player3RightThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		// Player 4
		if (leftThrusterAssignment[3] == frontThruster)
		{
			UIManager.Instance.player4LeftThrusterColor = "red";
		}
		else if (leftThrusterAssignment[3] == backThruster)
		{
			UIManager.Instance.player4LeftThrusterColor = "blue";
		}
		else if (leftThrusterAssignment[3] == leftThruster)
		{
			UIManager.Instance.player4LeftThrusterColor = "yellow";
		}
		else if (leftThrusterAssignment[3] == rightThruster)
		{
			UIManager.Instance.player4LeftThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		if (rightThrusterAssignment[3] == frontThruster)
		{
			UIManager.Instance.player4RightThrusterColor = "red";
		}
		else if (rightThrusterAssignment[3] == backThruster)
		{
			UIManager.Instance.player4RightThrusterColor = "blue";
		}
		else if (rightThrusterAssignment[3] == leftThruster)
		{
			UIManager.Instance.player4RightThrusterColor = "yellow";
		}
		else if (rightThrusterAssignment[3] == rightThruster)
		{
			UIManager.Instance.player4RightThrusterColor = "green";
		}
		else
		{
			Debug.Log("Incorrect thruster color assignment");
		}
		
		// Update the colors
		if (UIManager.Instance.HUDScript != null)
		{
			UIManager.Instance.HUDScript.player1HUD.GetComponent<UIPlayerHUD>().SetNewTriggerPanels(UIManager.Instance.player1LeftThrusterColor, UIManager.Instance.player1RightThrusterColor);
			UIManager.Instance.HUDScript.player2HUD.GetComponent<UIPlayerHUD>().SetNewTriggerPanels(UIManager.Instance.player2LeftThrusterColor, UIManager.Instance.player2RightThrusterColor);
			UIManager.Instance.HUDScript.player3HUD.GetComponent<UIPlayerHUD>().SetNewTriggerPanels(UIManager.Instance.player3LeftThrusterColor, UIManager.Instance.player3RightThrusterColor);
			UIManager.Instance.HUDScript.player4HUD.GetComponent<UIPlayerHUD>().SetNewTriggerPanels(UIManager.Instance.player4LeftThrusterColor, UIManager.Instance.player4RightThrusterColor);
		}
	}
*/
}

