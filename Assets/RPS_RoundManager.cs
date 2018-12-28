using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS_RoundManager : MonoBehaviour {

    private TextController controller;
    private RPS_Player player;

    // Use this for initialization
    void Start () {
        controller=GetComponent<TextController>();
        player = GetComponent<RPS_Player>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) RunRPSRound();
	}

    public void RunRPSRound()
    {
        StartCoroutine(RPSround());
    }

    private IEnumerator RPSround()
    {
        yield return new WaitForSeconds(.5f);
        controller.setText("Rock");
        yield return new WaitForSeconds(.5f);
        controller.setText("");
        yield return new WaitForSeconds(.5f);
        controller.setText("Paper");
        yield return new WaitForSeconds(.5f);
        controller.setText("");
        yield return new WaitForSeconds(.5f);
        controller.setText("Scissors");
        yield return new WaitForSeconds(.5f);
        controller.setText("");
        yield return new WaitForSeconds(.5f);
        controller.setText(player.Shoot());
        yield return new WaitForSeconds(.5f);
        controller.setText("");
    }
}
