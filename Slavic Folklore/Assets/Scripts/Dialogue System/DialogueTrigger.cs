using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine.UI;
public class DialogueTrigger : MonoBehaviour
{
    [Tooltip("drag in the Player")]
    public GameObject dialogueTrigger;
    public TMP_Text pressE;
    public Image dialogueBubble;

    public AudioSource audioSource; // New AudioSource variable
    public AudioClip pressSound;    // AudioClip for the 'E' key press sound
    private bool inRange = false;
    
    //checking if dialogue bubble is already there 
    private bool isDialogueBubbleActive = false;
    
    void Start()
    {
        // Fetch AudioSource component from the same GameObject or add it if not present
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>(); 
    }
    
    void Update()
    {
        //if E is pressed AND the dialogueBubble is not already active
        if (Input.GetKeyDown(KeyCode.E) && !isDialogueBubbleActive && inRange == true)
        {
            //when E is pressed "Press E" instruction disappears 
            pressE.gameObject.SetActive(false);
            
            //when E is pressed the Dialogue bubble appears and dialogue is initiated
            dialogueBubble.gameObject.SetActive(true);
            
            //flagging that the dialogueBubble is ACTIVE (not to spawn it multiple time if player spams E
            isDialogueBubbleActive = true;

             // Play the press sound when 'E' is pressed
            if (pressSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(pressSound);
            }
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
        pressE.gameObject.SetActive(true);
        Debug.Log("Press E to talk");
       
        //doesn't show Press E text prompt if the dialogue bubble is still Active and player re-enters the trigger area
        if (dialogueBubble.IsActive())
        {
            pressE.gameObject.SetActive(false);
        }

        dialogueTrigger = other.gameObject;

    }

    public void OnTriggerExit(Collider other)
    {
        inRange = false;
        pressE.gameObject.SetActive(false);
        
        //reset isDialogueBubbleActive flag to be able to reactivate dialogues
        isDialogueBubbleActive = false;
    }
    
}
