using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyController : MonoBehaviour
{

	[SerializeField] private GameObject key;
	[SerializeField] private PlayerInv playerInv;


	public void OnClick()
	{
		playerInv.HasKey = true;
		key.SetActive(false);
	}

}
