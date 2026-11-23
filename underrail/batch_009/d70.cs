using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200178E RID: 6030
internal class d70 : ak9
{
	// Token: 0x06008149 RID: 33097 RVA: 0x00367BB0 File Offset: 0x00365DB0
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new e3r(DamageType.Mechanical, -0.15),
			new bel(70),
			new ax6("Perception", -3),
			new dpw("Metathermics", -40),
			new dpw("Psychokinesis", -40),
			new dpw("ThoughtControl", -40),
			new dpw("TemporalManipulation", -40),
			new emn(-30)
			{
				Priority = int.MaxValue
			}
		};
		A_1 = null;
		A_1 = new wq[0];
		A_2 = null;
	}

	// Token: 0x0600814A RID: 33098 RVA: 0x00367C50 File Offset: 0x00365E50
	public override string o6()
	{
		return "DrinkPotion";
	}
}
