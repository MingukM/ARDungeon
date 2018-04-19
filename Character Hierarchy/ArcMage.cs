using System;

public class ArcMage: Mage {
	
	private float magicEfficiency;

	public ArcMage () {
		ClassName = "ArcMage";
		magicEfficiency = 10f;
		totalMp = totalMp * characterLvl / magicEfficiency;
	}

	public float MagicEfficiency{ get; set;}
}

