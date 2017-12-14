
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
	[SerializeField] public GameObject ValidBlock;
	[SerializeField] public GameObject InvalidBlock;
	[SerializeField] public GameObject CheckBlock;
	[SerializeField] public GameObject WallBlock;
	[SerializeField] public Camera MainCamera;
	

	[SerializeField] public int CanvasSizeX;
	[SerializeField] public int CanvasSizeY;
	
	
	// Use this for initialization
	void Start () {
		Assert.AreNotEqual (ValidBlock, null);
		Assert.AreNotEqual (InvalidBlock, null);
		Assert.AreNotEqual (CheckBlock, null);

		(MainCamera as Camera).orthographicSize = (CanvasSizeX > CanvasSizeY ? CanvasSizeX / 3 + 1 : CanvasSizeY / 3 + 1);
		
		PlaceWalls();

	}

	private void PlaceWalls()
	{
		
		int blockCountWidth = (int)(CanvasSizeX / WallBlock.transform.localScale.x);
		int blockCountHeight = (int)(CanvasSizeY / WallBlock.transform.localScale.y) - 2;

		//upper and lower wall
		int posX = CanvasSizeX / 2;
		int posY = CanvasSizeY / 2;
		
		for (int i = 0; i < blockCountWidth; i++)
		{
			float curPosX = - posX + i;
			Instantiate(WallBlock);
			WallBlock.transform.position = new Vector2(curPosX, posY);
			Instantiate(WallBlock);
			WallBlock.transform.position = new Vector2(curPosX, - posY);
		}
		
		for (int i = 0; i < blockCountHeight + 1; i++)
		{
			float curPosY = - posY + i + 1;
			Instantiate(WallBlock);
			WallBlock.transform.position = new Vector2(posX - 1, curPosY);
			Instantiate(WallBlock);
			WallBlock.transform.position = new Vector2(- posX, curPosY);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
