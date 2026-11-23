using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020017AC RID: 6060
internal class a7e : ak9
{
	// Token: 0x06008199 RID: 33177 RVA: 0x00369038 File Offset: 0x00367238
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new e3r(DamageType.Mechanical, -0.1),
			new bel(50),
			new ax6("Perception", -2),
			new dpw("Metathermics", -20),
			new dpw("Psychokinesis", -20),
			new dpw("ThoughtControl", -20),
			new dpw("TemporalManipulation", -20),
			new emn(-30)
			{
				Priority = int.MaxValue
			}
		};
		A_1 = null;
		A_1 = new wq[0];
		A_2 = null;
	}

	// Token: 0x0600819A RID: 33178 RVA: 0x003690D8 File Offset: 0x003672D8
	public override string o6()
	{
		return "DrinkPotion";
	}
}
