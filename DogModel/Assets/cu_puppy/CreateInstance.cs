using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class CreateInstance : MonoBehaviour {

	public Animator animator;

	public Transform cu_puppy1;
	public Transform cu_puppy2;
	public Transform cu_puppy3;
	public Transform cu_puppy4;
	public Transform cu_puppy5;
	public Transform cu_puppy6;
	public Transform cu_puppy7;
	public Transform cu_puppy8;
	public Transform cu_puppy9;
	public Transform cu_puppy10;
	public Transform cu_puppy11;
	public Transform cu_puppy12;

	// Use this for initialization
	void Start () {
		
	
		
		// GameObject prefab = Resources.Load("1.black");
		// GameObject gameObject = Instantiate<GameObject>(prefab, new Vector3(322, 85,-2), Quaternion.identity) as GameObject;
	}
	int done =0;
	// Update is called once per frame
	void Update () {
		if(done != 1)
		{
			while(!File.Exists(@"C:\Users\ndh83\Documents\DogModel\test.txt"))
			{}
			done = 1;
			string path = @"C:\Users\ndh83\Documents\DogModel\test.txt";
			
			string[] lines = System.IO.File.ReadAllLines (path);
		
			int input= 0;
			Int32.TryParse(lines[0], out input);
	
			Transform temp;
	
			switch(input) { 
			    case 1:
			    	temp =Instantiate(cu_puppy1, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 2: 
			    	temp =Instantiate(cu_puppy2, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 3: 
			    	temp =Instantiate(cu_puppy3, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 4: 
			    	temp =Instantiate(cu_puppy4, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 5: 
			    	temp =Instantiate(cu_puppy5, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 6: 
			    	temp =Instantiate(cu_puppy6, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 7: 
			    	temp =Instantiate(cu_puppy7, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 8: 
			    	temp =Instantiate(cu_puppy8, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 9: 
			    	temp =Instantiate(cu_puppy9, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 10: 
			    	temp =Instantiate(cu_puppy10, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    case 11: 
			    	temp =Instantiate(cu_puppy11, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break; 
			    default:
			    	temp =Instantiate(cu_puppy12, new Vector3(322, 85,-2), Quaternion.identity) as Transform;
			    	break;
			      //optional 
			      //statements 
			}
			
			temp.transform.localScale = new Vector3(8,8,8);
	
			temp.transform.rotation = Quaternion.Euler(0,180,0);
			
			animator = temp.GetComponent<Animator>();

			animator.Play("cu_puppy@B_paw");
			animator.enabled = true;
		}
	}
}
