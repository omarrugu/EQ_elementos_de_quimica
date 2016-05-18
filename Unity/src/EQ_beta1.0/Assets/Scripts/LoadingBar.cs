using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadingBar : MonoBehaviour {

	public Transform LoadBar = null; //Componenete del load bar
	public Transform TextIndicator = null; //Componente del texto indicador
	public Transform TextLoading = null; //Componente del cargador
	[SerializeField] private float currentAmount; //Valor actual del porcentaje
	[SerializeField] private float speed; //Velocidad de carga


	// Update is called once per frame
	void Update () {

		//Verifica que el valor actual del porcentaje
		if (currentAmount < 100) { //Si es menor a 100, entonces aumenta la cantidad actual
			//print ("Current: " + currentAmount);
			currentAmount += speed * Time.deltaTime;
			//print ("Current: " + currentAmount + " Speed: " + speed);
			TextIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
			TextLoading.gameObject.SetActive (true);
		} else { //Si es mayor a 100 a terminado de cargar la aplicacion y cargamos una nueva escena
			//print ("Current: " + currentAmount);
			TextLoading.gameObject.SetActive (false);
			TextIndicator.GetComponent<Text>().text = "100%";
			Application.LoadLevel ("PantallaInicio");
		}
		//Pintamos el componente loadbar con respecto al total
		LoadBar.GetComponent<Image> ().fillAmount = currentAmount / 100; 
	}
}
