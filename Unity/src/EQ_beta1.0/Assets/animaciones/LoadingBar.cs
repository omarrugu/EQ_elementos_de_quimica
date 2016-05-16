using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadingBar : MonoBehaviour {

	public Transform LoadBar = null;
	public Transform TextIndicator = null;
	public Transform TextLoading = null;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;


	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
			print ("Current: " + currentAmount);
			currentAmount += speed * Time.deltaTime;
			print ("Current: " + currentAmount + " Speed: " + speed);
			TextIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
			TextLoading.gameObject.SetActive (true);
		} else {
			print ("Current: " + currentAmount);
			TextLoading.gameObject.SetActive (false);
			TextIndicator.GetComponent<Text>().text = "FIN";	
		}

		LoadBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}
}
