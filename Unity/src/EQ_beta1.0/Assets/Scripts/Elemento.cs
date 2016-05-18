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
	public Elemento(string nombre){
		//Leer xml y asignarlos a cada atributo del elemento

		XmlReader reader = XmlReader.Create("Assets/xml/Config.xml");
		while (reader.Read()){
			if (reader.NodeType == XmlNodeType.Element && reader.Name == "Elementos"){
				while (reader.NodeType != XmlNodeType.EndElement){
					reader.Read();
					//Identifica el nodo del elemento
					if (reader.Name == nombre){
						while (reader.NodeType != XmlNodeType.EndElement){
							reader.Read();
							//Identifica el atributo nombre
							if(reader.Name == "Nombre"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.nombre = reader.Value;
										print("Nombre: " + this.nombre);
									}
								}
								reader.Read();
							}
							//Identifica el atributo Símbolo atómico
							if(reader.Name == "SimboloAtomico"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.simbolo = reader.Value;
										print("Símbolo Atómico: " + this.simbolo);
									}
								}
								reader.Read ();
							}

							//Identifica el atributo Descripción del elemento
							if(reader.Name == "DescripcionElemento"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.descripElem = reader.Value;
										print("Descripción del elemento: " + this.descripElem);
									}
								}
								reader.Read ();
							}

							//Identifica el atributo Descripción del modelo atómico
							if(reader.Name == "DescripcionModeloAtomico"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.descripModAto = reader.Value;
										print("Descripción del modelo atómico: " + this.descripModAto);
									}
								}
								reader.Read ();
							}

							//Identifica el atributo uso y aplicaciones
							if(reader.Name == "UsosAplicaciones"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.usoApli = reader.Value;
										print("Uso y aplicaciones: " + this.usoApli);
									}
								}
								reader.Read ();
							}

							//Identifica el atributo Masa atómica
							if(reader.Name == "MasaAtomica"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.masaAtomica = Single.Parse(reader.Value);
										print("Masa atómica: " + this.masaAtomica);
									}
								}
								reader.Read ();
							}

							//Identifica el atributo Número atómico
							if(reader.Name == "NumeroAtomico"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.numeroAtomico = Int32.Parse(reader.Value);
										print("Número atómico: " + this.numeroAtomico);
									}
								}
								reader.Read ();
							}

							//Identifica el atributo Número atómico
							if(reader.Name == "Fuente"){
								while (reader.NodeType != XmlNodeType.EndElement){
									reader.Read();
									if (reader.NodeType == XmlNodeType.Text){
										this.fuente = reader.Value;
										print("Fuente: " + this.fuente);
									}
								}
								reader.Read ();
							}
						}
					} 
				}
			}

		}
	}

	void Start(){
		Debug.Log ("Hola mundo");
		new Elemento ("Oro");
	}
}
