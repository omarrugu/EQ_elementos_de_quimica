using UnityEngine;
using System.Collections;
using System;
using System.Xml;

//Objeto que crea un elemento con su respectiva información cargada desde un xml
public class Elemento : MonoBehaviour {

	public string nombre = ""; //Nombre del elemento
	string simbolo = ""; //Símbolo atómico
	string descripElem = ""; //Descripción del elemento
	string descripModAto = ""; //Descripción del model atómico
	string usoApli = ""; //Uso y aplicaciones 
	string fuente = ""; //fuente
	float masaAtomica = 0; //Masa atómica
	int numeroAtomico = 0; //Número atómico

	//Método constructor que crea un elemento con su respectivos valores de una rchivo fuente xml
	public Elemento(string name){

		//Creamos un documento y lo cargamos con los datos del XML.
		XmlDocument documento = new XmlDocument();
		documento.Load("Assets/xml/Config.xml");

		//Obtenemos una colección con todos los elementos.
		XmlNodeList listaElementos = documento.SelectNodes("elementos/elemento");

		//Creamos un único elemento.
		XmlNode elemento;

		//Recorremos toda la lista de empleados.
		for (int i = 0; i < listaElementos.Count; i++){
			//Obtenemos cada empleado.
			elemento = listaElementos.Item(i);

			//Seleccionamos el nombre del elemento.
			string nombreElem = Convert.ToString(elemento.SelectSingleNode("Nombre").InnerText);

			//Comprobamos que el id de empleado sea el mismo que el número introducido por el usuario.
			if (name == nombreElem) {

				print ("El nombre es el mismo");
				//Obtenemos el nombre.
				print ("Nombre: " + elemento.SelectSingleNode ("Nombre").InnerText);
				this.nombre = Convert.ToString(elemento.SelectSingleNode("Nombre").InnerText);
					
				//Obtenemos el símbolo atómico.
				print ("Símbolo atómico: " + elemento.SelectSingleNode ("SimboloAtomico").InnerText);
				this.simbolo = Convert.ToString(elemento.SelectSingleNode ("SimboloAtomico").InnerText);

				//Obtenemos la descripción del elemento.
				print ("Descripción del elemento: " + elemento.SelectSingleNode ("DescripcionElemento").InnerText);
				this.descripElem = Convert.ToString(elemento.SelectSingleNode ("DescripcionElemento").InnerText);
					
				//Obtenemos la descripción del modelo atómico.
				print ("Descripción del modelo atómico: " + elemento.SelectSingleNode ("DescripcionModeloAtomico").InnerText);
				this.descripModAto = Convert.ToString(elemento.SelectSingleNode ("DescripcionModeloAtomico").InnerText);

				//Obtenemos el uso y aplicaciones.
				print ("Uso y aplicaciones: " + elemento.SelectSingleNode ("UsosAplicaciones").InnerText);
				this.usoApli = Convert.ToString (elemento.SelectSingleNode ("DescripcionModeloAtomico").InnerText);

				//Obtenemos la masa atómica.
				print ("Masa atómica: " + elemento.SelectSingleNode ("MasaAtomica").InnerText);
				this.masaAtomica = Convert.ToSingle (elemento.SelectSingleNode ("MasaAtomica").InnerText);

				//Obtenemos el numero atómico.
				print ("Numero atómico: " + elemento.SelectSingleNode ("NumeroAtomico").InnerText);
				this.numeroAtomico = Convert.ToInt32 (elemento.SelectSingleNode ("NumeroAtomico").InnerText);

				//Obtenemos la fuente.
				print ("Fuente: " + elemento.SelectSingleNode ("Fuente").InnerText);
				this.fuente = Convert.ToString (elemento.SelectSingleNode ("Fuente").InnerText);

			} else {
				print ("El elemento no se encuentra en el XML o en la base de datos de vuforia");
			}
		}
		
	}
		
}