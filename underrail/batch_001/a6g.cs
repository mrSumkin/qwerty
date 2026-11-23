using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001780 RID: 6016
[z1("caveTear")]
internal sealed class a6g : c1f
{
	// Token: 0x06008123 RID: 33059 RVA: 0x00367624 File Offset: 0x00365824
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new e3r(DamageType.Mechanical, -0.2),
			new ax6("Strength", 2),
			new ax6("Perception", -3),
			new ax6("Dexterity", -3),
			new dpw("Metathermics", -30),
			new dpw("Psychokinesis", -30),
			new dpw("ThoughtControl", -30),
			new dpw("TemporalManipulation", -30),
			new emn(-40)
			{
				Priority = int.MaxValue
			}
		};
		A_1 = null;
		A_2 = null;
	}
}
