namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    public class toggle : MonoBehaviour {

        public Light myLight;
        public VRTK_ControllerEvents controllerEvents;
        public VRTK_ControllerEvents.ButtonAlias toggleButton = VRTK_ControllerEvents.ButtonAlias.ButtonTwoPress;
        bool enable = true;
        /*
        void Start()
        {
            Debug.Log("Start");
        }*/ 
        
                // Update is called once per frame
        void Update () {
            
            if(controllerEvents.IsButtonPressed(toggleButton)) {
                Debug.Log("pressed.");
                if (enable){
                    myLight.enabled = !myLight.enabled;
                }
                enable = false;
            }
            else enable = true;
        }
    }
}
