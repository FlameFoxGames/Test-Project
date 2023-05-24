using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public GameObject Instructions;


   private string[] messages = {
    "Watch Out For Stink Breath",
    "If you Die you lose!",
    "Try to collect all the bits of food that corrospond to your characters top left",
    "You can use any sized message within this modal and it will resize it to make sure it fits the right way",
    "You can change the Text of the Body Dynamically from the Script itself vs having to change it or make multiple windows. Using the Singleton below."
   };

 public Sprite[] images; // Array of sprites to choose from for the display image


   public void GetNewMessage()
   {

    //since this is a singlton, you are able to call it from pretty much any script. Like the example shown below. "Modal Header"
    //can be changed to anything you want it to say, along with the messages you want. in this example they are random above. 
    //You can also pass an image as well. 

    ModalManager.instance.ShowModal("Change Header via Script", messages[Random.Range(0, messages.Length)], images[Random.Range(0, images.Length)]);
    
   }



   public void hideInstructions()
   {
    Instructions.SetActive(false);
    Debug.Log("Exit Play mode to reset instructions, Im too lazy to add another function haha");
   }

}
