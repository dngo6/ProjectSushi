using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************
 * Restaurant Class
 * Description: Attributes of the restaurant.
 * Attributes:
 * Name
 * Days
 * Money
 * 
 * Rent
 * Expenses (Array)
 * 
 * Beginning of the game, the player starts off with a small loan of 10,000 dollars.
 * 
 * **************************/

public class Restaurant : MonoBehaviour {
	public static bool running = false;
	//All attrivutes are public for debugging purposes.
	public string restaurantName = "default";
	public float day = 1;
	public float money = 10000;
	public float SECONDSINADAY = 90; //a simulated day is 90 seconds.

	public float timeLeft = 30;
	public float rent = 2000;
	public List<float> expenses = new List<float>();

	public float spawnRate = 30;
	public float reputation = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (running == true) {
			//Within this period of time, populate customers with orders.
			if (UnityEngine.Random.Range (0, 100) <= spawnRate) {
				money += 2; //simulate a customer buying an item.
			}

			timeLeft -= Time.deltaTime;
			if (timeLeft <= 0) {
				timeLeft = SECONDSINADAY;
				running = false;

				if (day % 2 == 0) {
					//pay for all expenses
					money -= rent;
					foreach (float price in expenses) {
						money -= price;
					}
				}
					
			}
		}

		if (Input.GetKeyDown (KeyCode.X)) {
			if (!running)
				runDay();
		}
	}

	/*
	 * Simulates a whole day.
	 */
	public void runDay () {
		running = true;
		day++;
	}

	public int addExpense (float price) {
		int expenseId = expenses.Count;

		expenses.Add(price);

		return expenseId;
	}
}