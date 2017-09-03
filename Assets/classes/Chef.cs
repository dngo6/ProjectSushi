using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************
 * Chef Class
 * Description: Contains the attributes of the individual chef of the restaurant.
 * Attributes:
 * Name
 * Skill
 * Speed 
 * 
 * **********************************/

public class Chef : MonoBehaviour {
	enum CHEF_TYPE {HEAD, NORMAL};
	public GameObject masterObject;
	public string name = "default";

	public float salary = 2000;
	public int expenseID = 0;

	//This is the skillset of the chef out of 100
	public float nigiri_skill = 20;
	public float roll_skill = 20;
	public float specialroll_skill = 20;

	//This is the speed of the sushi coming out.
	public float nigiri_speed = 1; //countdown in seconds
	public float roll_speed = 2;
	public float specialroll_speed = 4;

	void Start() {
		expenseID = masterObject.GetComponent<Restaurant> ().addExpense (salary);
	}

}
