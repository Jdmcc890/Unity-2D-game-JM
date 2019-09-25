using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cowwectable : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		HandleCollected();
	}
	void HandleCollected()
	{
		CollectibleManager.Instance.HandleCoinCollected();
		Destroy(gameObject);
	}

}
