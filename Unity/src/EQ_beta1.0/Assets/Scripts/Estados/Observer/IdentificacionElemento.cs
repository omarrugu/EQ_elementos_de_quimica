using UnityEngine;
using System.Collections;

namespace Vuforia{
	public class IdentificacionElemento : State{


		void start(){
			state = 1;
		}

		public override void changeState(int state){
			this.state += state;
			string nombre = FirstTrackableEventHandler.elem.nombre;
		}

		public override int getState(){
			return state;
		}
	}
}

