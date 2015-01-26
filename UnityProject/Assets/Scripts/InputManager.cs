using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	/*
	public static ControllerInput player1Controller;
	public static ControllerInput player2Controller;
	public static ControllerInput player3Controller;
	public static ControllerInput player4Controller;
*/

	public static bool disableTriggers;

	public struct XBoxController
	{
		public float leftTrigger;
		public float rightTrigger;
		public enum buttonState{	JUST_RELEASED,
									RELEASED,
									JUST_PRESSED,
									PRESSED
		}

		public buttonState y_Button;
		public buttonState x_Button;
		public buttonState b_Button;
		public buttonState a_Button;

	}

	public static XBoxController pl_Controller;
	public static XBoxController p2_Controller;
	public static XBoxController p3_Controller;
	public static XBoxController p4_Controller;

	// Use this for initialization
	void Start ()
	{
		InputManager.pl_Controller = new XBoxController ();
		InputManager.p2_Controller = new XBoxController ();
		InputManager.p3_Controller = new XBoxController ();
		InputManager.p4_Controller = new XBoxController ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!UIManager.Instance.disablePlayer1Input)
			UpdatePlayer1Input ();
		else
			ClearPlayer1Input();
			
		if (!UIManager.Instance.disablePlayer2Input)
			UpdatePlayer2Input ();
		else
			ClearPlayer2Input();
			
		if (!UIManager.Instance.disablePlayer3Input)
			UpdatePlayer3Input ();
		else
			ClearPlayer3Input();
			
		if (!UIManager.Instance.disablePlayer4Input)
			UpdatePlayer4Input ();
		else
			ClearPlayer4Input();
		

		

		//print (pl_Controller.a_Button + "   " + pl_Controller.b_Button + "   " + pl_Controller.x_Button + "   " + pl_Controller.y_Button);
		//print (Input.GetAxis ("TriggersR_1") + " " + Input.GetAxis ("TriggersL_1") + " === " + (Input.GetAxis ("TriggersR_1") + Input.GetAxis ("TriggersL_1")));

	}

	public void UpdatePlayer1Input ()
	{
		if (!disableTriggers)
		{
			InputManager.pl_Controller.leftTrigger = Input.GetAxis ("TriggersL_1");
			InputManager.pl_Controller.rightTrigger = Input.GetAxis ("TriggersR_1");
		}
		



		//a button
		if ((int)InputManager.pl_Controller.a_Button <= 1)
		{
			if (Input.GetButton("A_1"))
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("A_1"))
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}


		//b button
		if ((int)InputManager.pl_Controller.b_Button <= 1)
		{
			if (Input.GetButton("B_1"))
			{
				InputManager.pl_Controller.b_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.pl_Controller.b_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("B_1"))
			{
				InputManager.pl_Controller.b_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.pl_Controller.b_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}


		//x button
		if ((int)InputManager.pl_Controller.x_Button <= 1)
		{
			if (Input.GetButton("X_1"))
			{
				InputManager.pl_Controller.x_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.pl_Controller.x_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("X_1"))
			{
				InputManager.pl_Controller.x_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.pl_Controller.x_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}


		// y button
		if ((int)InputManager.pl_Controller.y_Button <= 1)
		{
			if (Input.GetButton("Y_1"))
			{
				InputManager.pl_Controller.y_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.pl_Controller.y_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("Y_1"))
			{
				InputManager.pl_Controller.y_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.pl_Controller.y_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
	}

	public void UpdatePlayer2Input ()
	{
		if (!disableTriggers)
		{
			InputManager.p2_Controller.leftTrigger = Input.GetAxis ("TriggersL_2");
			InputManager.p2_Controller.rightTrigger = Input.GetAxis ("TriggersR_2");
		}
		
		
		//a button
		if ((int)InputManager.p2_Controller.a_Button <= 1)
		{
			if (Input.GetButton("A_2"))
			{
				InputManager.p2_Controller.a_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p2_Controller.a_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("A_2"))
			{
				InputManager.p2_Controller.a_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p2_Controller.a_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		//b button
		if ((int)InputManager.p2_Controller.b_Button <= 1)
		{
			if (Input.GetButton("B_2"))
			{
				InputManager.p2_Controller.b_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p2_Controller.b_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("B_2"))
			{
				InputManager.p2_Controller.b_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p2_Controller.b_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		//x button
		if ((int)InputManager.p2_Controller.x_Button <= 1)
		{
			if (Input.GetButton("X_2"))
			{
				InputManager.p2_Controller.x_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p2_Controller.x_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("X_2"))
			{
				InputManager.p2_Controller.x_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p2_Controller.x_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		// y button
		if ((int)InputManager.p2_Controller.y_Button <= 1)
		{
			if (Input.GetButton("Y_2"))
			{
				InputManager.p2_Controller.y_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p2_Controller.y_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("Y_2"))
			{
				InputManager.p2_Controller.y_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p2_Controller.y_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
	}

	public void UpdatePlayer3Input ()
	{
		if (!disableTriggers)
		{
			InputManager.p3_Controller.leftTrigger = Input.GetAxis ("TriggersL_3");
			InputManager.p3_Controller.rightTrigger = Input.GetAxis ("TriggersR_3");
		}
		
		//print (Input.GetAxis ("TriggersL_3"));
		
		//a button
		if ((int)InputManager.p3_Controller.a_Button <= 1)
		{
			if (Input.GetButton("A_3"))
			{
				InputManager.p3_Controller.a_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p3_Controller.a_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("A_3"))
			{
				InputManager.p3_Controller.a_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p3_Controller.a_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		//b button
		if ((int)InputManager.p3_Controller.b_Button <= 1)
		{
			if (Input.GetButton("B_3"))
			{
				InputManager.p3_Controller.b_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p3_Controller.b_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("B_3"))
			{
				InputManager.p3_Controller.b_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p3_Controller.b_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		//x button
		if ((int)InputManager.p3_Controller.x_Button <= 1)
		{
			if (Input.GetButton("X_3"))
			{
				InputManager.p3_Controller.x_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p3_Controller.x_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("X_3"))
			{
				InputManager.p3_Controller.x_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p3_Controller.x_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		// y button
		if ((int)InputManager.p3_Controller.y_Button <= 1)
		{
			if (Input.GetButton("Y_3"))
			{
				InputManager.p3_Controller.y_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p3_Controller.y_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("Y_3"))
			{
				InputManager.p3_Controller.y_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p3_Controller.y_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
	}

	public void UpdatePlayer4Input ()
	{
	
		if (!disableTriggers)
		{
			InputManager.p4_Controller.leftTrigger = Input.GetAxis ("TriggersL_4");
			InputManager.p4_Controller.rightTrigger = Input.GetAxis ("TriggersR_4");
		}
		
		
		//a button
		if ((int)InputManager.pl_Controller.a_Button <= 1)
		{
			if (Input.GetButton("A_1"))
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("A_1"))
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.pl_Controller.a_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		//b button
		if ((int)InputManager.p4_Controller.b_Button <= 1)
		{
			if (Input.GetButton("B_4"))
			{
				InputManager.p4_Controller.b_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p4_Controller.b_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("B_4"))
			{
				InputManager.p4_Controller.b_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p4_Controller.b_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		//x button
		if ((int)InputManager.p4_Controller.x_Button <= 1)
		{
			if (Input.GetButton("X_4"))
			{
				InputManager.p4_Controller.x_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p4_Controller.x_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("X_4"))
			{
				InputManager.p4_Controller.x_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p4_Controller.x_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
		
		
		// y button
		if ((int)InputManager.p4_Controller.y_Button <= 1)
		{
			if (Input.GetButton("Y_4"))
			{
				InputManager.p4_Controller.y_Button = XBoxController.buttonState.JUST_PRESSED;
			}
			else
			{
				InputManager.p4_Controller.y_Button = XBoxController.buttonState.RELEASED;
			}
		}
		else
		{
			if (Input.GetButton("Y_4"))
			{
				InputManager.p4_Controller.y_Button = XBoxController.buttonState.PRESSED;
			}
			else
			{
				InputManager.p4_Controller.y_Button = XBoxController.buttonState.JUST_RELEASED;
			}
		}
	}
	
	public void ClearPlayer1Input()
	{
		InputManager.pl_Controller.leftTrigger = 0f;
		InputManager.pl_Controller.rightTrigger = 0f;
		InputManager.pl_Controller.a_Button = XBoxController.buttonState.RELEASED;
		InputManager.pl_Controller.b_Button = XBoxController.buttonState.RELEASED;
		InputManager.pl_Controller.x_Button = XBoxController.buttonState.RELEASED;
		InputManager.pl_Controller.y_Button = XBoxController.buttonState.RELEASED;
	}
	
	public void ClearPlayer2Input()
	{
		InputManager.p2_Controller.leftTrigger = 0f;
		InputManager.p2_Controller.rightTrigger = 0f;
		InputManager.p2_Controller.a_Button = XBoxController.buttonState.RELEASED;
		InputManager.p2_Controller.b_Button = XBoxController.buttonState.RELEASED;
		InputManager.p2_Controller.x_Button = XBoxController.buttonState.RELEASED;
		InputManager.p2_Controller.y_Button = XBoxController.buttonState.RELEASED;
	}
	
	public void ClearPlayer3Input()
	{
		InputManager.p3_Controller.leftTrigger = 0f;
		InputManager.p3_Controller.rightTrigger = 0f;
		InputManager.p3_Controller.a_Button = XBoxController.buttonState.RELEASED;
		InputManager.p3_Controller.b_Button = XBoxController.buttonState.RELEASED;
		InputManager.p3_Controller.x_Button = XBoxController.buttonState.RELEASED;
		InputManager.p3_Controller.y_Button = XBoxController.buttonState.RELEASED;
	}
	
	public void ClearPlayer4Input()
	{
		InputManager.p4_Controller.leftTrigger = 0f;
		InputManager.p4_Controller.rightTrigger = 0f;
		InputManager.p4_Controller.a_Button = XBoxController.buttonState.RELEASED;
		InputManager.p4_Controller.b_Button = XBoxController.buttonState.RELEASED;
		InputManager.p4_Controller.x_Button = XBoxController.buttonState.RELEASED;
		InputManager.p4_Controller.y_Button = XBoxController.buttonState.RELEASED;
	}
}
