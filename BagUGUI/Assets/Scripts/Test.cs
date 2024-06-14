using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Transform BagPanel;
    public Button BeginBut;
    private Animation aanimation;
    // Start is called before the first frame update
    void Start()
    {
        aanimation = BagPanel.GetComponent<Animation>();
        aanimation.Stop();
        BeginBut.onClick.AddListener(() => {

            aanimation.Play();

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
