using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAudioThenLoad : MonoBehaviour
{


    //do an if state to play audio source when button pressed
    //do a IENumerator to do a countdown for loading the next scene ( make the count down legnth of audio source)
    
    private IEnumerator coroutine;
    public Button button;

    public LoadScreen sceneSwitching; 



    // Start is called before the first frame update
    void Start()
    {

        if(GetComponent<Button>())
        {
            
        //print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        //coroutine = WaitAndPrint(1.4f);
        //StartCoroutine(coroutine);

        //print("Before WaitAndPrint Finishes " + Time.time);
        
        }
      
    }

    public void OnClickStart()
    {
        coroutine = WaitAndPrint(1.4f);
        StartCoroutine(coroutine);
    }

      private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            //print("WaitAndPrint " + Time.time);

            sceneSwitching.LoadScene(sceneId: 1);
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
