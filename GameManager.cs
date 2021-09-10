using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject ButtonRight;
    public GameObject ButtonLeft;
    public GameObject Image;
    public GameObject Decision;
    public GameObject GameOver;
    public bool flagRight;
    public bool flagLeft; 
    // Start is called before the first frame update
    void Start()
    {
        ButtonRight=GameObject.Find("ButtonRight");
        Image=GameObject.Find("Image");
        //flagRight = false;
        //flagLeft = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnclickRightButton(){
        //ButtonRight.GetComponent<Image>().color=Color.black;
        //Image.GetComponent<Image>().color=Color.white;
        flagRight = !flagRight;
     // GetComponent<Renderer>().ButtonRight.color = Color.red;
    }
    public void OnclickLeftButton(){
        //GameOver.SetActive(true);
        flagLeft = !flagLeft;
    }

    public void OnclickDecision(){
        if(flagRight == true && flagLeft == false){
            Image.GetComponent<Image>().color=Color.white;
        }
    }
}
