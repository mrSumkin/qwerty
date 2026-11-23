using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200177F RID: 6015
[z1("stalagDrop")]
internal sealed class e4q : c1f
{
	// Token: 0x06008121 RID: 33057 RVA: 0x0036756C File Offset: 0x0036576C
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new e3r(DamageType.Mechanical, -0.1),
			new ax6("Strength", 1),
			new ax6("Perception", -1),
			new ax6("Dexterity", -1),
			new dpw("Metathermics", -10),
			new dpw("Psychokinesis", -10),
			new dpw("ThoughtControl", -10),
			new dpw("TemporalManipulation", -10),
			new emn(-15)
			{
				Priority = int.MaxValue
			}
		};
		A_1 = null;
		A_2 = null;
	}
}
