using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChartScript : MonoBehaviour
{
    public float averageScore;
    public float generation;
    public float totalIterations;
    public float xRatio;
    public Text TwentyPct, FortyPct, SixtyPct, EightyPct, HundredPct;
    public GameObject dotPrefab;
    GameObject myDot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateValues(float theAverageScore, float theGeneration)
    {
        averageScore = theAverageScore;
        float currentIteration = (float) theGeneration;
        xRatio = 400/totalIterations;
        //Debug.Log("["+(currentIteration*xRatio).ToString()+","+(averageScore*14.25f).ToString()+"]");
        PlaceDot((float) currentIteration*xRatio, averageScore*14.25f);
    }
    public void PlaceDot(float xCor, float yCor)
    {
        Vector2 pos = new Vector2(this.transform.position.x+xCor, this.transform.position.y+yCor);
        myDot = Instantiate(dotPrefab, pos, Quaternion.identity) as GameObject;
        myDot.transform.SetParent(this.transform, true);
    }
    public void SetNumPop(int thePop)
    {
        totalIterations = thePop; 
        TwentyPct.text = ((totalIterations / 5) * 1).ToString();
        FortyPct.text = ((totalIterations / 5) * 2).ToString();
        SixtyPct.text = ((totalIterations / 5) * 3).ToString();
        EightyPct.text = ((totalIterations / 5) * 4).ToString();
        HundredPct.text = totalIterations.ToString();
    }
}
