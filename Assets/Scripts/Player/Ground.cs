using UnityEngine;

public class Ground : GameAction
{
    void Start()
    {
        bool isonground;
    }

    public override void Activate()
    {
        bool isonground = true;
    }

    public override void Deactivate()
    {
       bool isonground = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {

    }
}
