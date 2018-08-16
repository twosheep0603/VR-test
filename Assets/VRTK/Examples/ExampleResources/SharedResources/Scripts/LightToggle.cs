namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    public class LightToggle : MonoBehaviour
    {
        public Light mylight;
        public VRTK_ControllerEvents controllerEvents;
        public VRTK_ControllerEvents.ButtonAlias toggleButton = VRTK_ControllerEvents.ButtonAlias.ButtonTwoPress;

    
        void Update() {
        Debug.Log("checked"+toggleButton);
        }
    }
}