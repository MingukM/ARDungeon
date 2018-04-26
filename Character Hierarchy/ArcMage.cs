using System;

public class ArcMage: Mage {
	
	private float magicEfficiency;

	public ArcMage () {
		ClassName = "ArcMage";
		magicEfficiency = 10f;
	}

	public float MagicEfficiency{ get; set;}
}

