using UnityEngine;

public class PressButtonDeer : Interactable{
	
	//associated options - left to right
	public GameObject a;
	public GameObject b;
	public GameObject c;
	public GameObject d;
	
	//the gate to open
	public GameObject nextGate;
	
	//showing message to this camera
	public Camera cam;
	
	//the right answer(s) for this question panel is selected in unity interface
	public bool aAnswer;
	public bool bAnswer;
	public bool cAnswer;
	public bool dAnswer;
	
	public override void Interact(){
		
		base.Interact();
		
		//check if correct answer(s) ONLY is selected
		if(a.GetComponent<Options>().isLit == aAnswer && b.GetComponent<Options>().isLit == bAnswer && c.GetComponent<Options>().isLit == cAnswer && d.GetComponent<Options>().isLit == dAnswer)
			//if correct chosen, open the gate
			nextGate.GetComponent<OpenGate>().Open();
			
		//if not, display suggestion message
		else
			cam.GetComponent<ShowText>().ShowMessage("It can be pressed. But nothing happened... Maybe I should try to answer the question.", 5.0f);
	}
}
