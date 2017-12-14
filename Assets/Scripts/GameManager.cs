
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
	[SerializeField] public GameObject ValidBlock;
	[SerializeField] public GameObject InvalidBlock;
	[SerializeField] public GameObject CheckBlock;
	
	
	
	// Use this for initialization
	void Start () {
		Assert.AreNotEqual (ValidBlock, null);
		Assert.AreNotEqual (InvalidBlock, null);
		Assert.AreNotEqual (CheckBlock, null);

		PlaceRooms();

	}

	private void PlaceRooms()
	{
		ValidBlock.transform.position = new Vector2(0,0);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
