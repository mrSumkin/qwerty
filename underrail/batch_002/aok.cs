using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020017C6 RID: 6086
internal class aok : ak9
{
	// Token: 0x060081DE RID: 33246 RVA: 0x0036AA74 File Offset: 0x00368C74
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new e3r(DamageType.Mechanical, -0.1),
			new ax6("Strength", 1),
			new ax6("Perception", -2),
			new ax6("Dexterity", -2),
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

	// Token: 0x060081DF RID: 33247 RVA: 0x0036AB28 File Offset: 0x00368D28
	public override string o6()
	{
		return "DrinkPotion";
	}

	// Token: 0x060081E0 RID: 33248 RVA: 0x0036AB34 File Offset: 0x00368D34
	public override void pw(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			string path = "components\\Containers\\bottle";
			if (ez2.GetItemDefinition<a1k>(path, true) != null)
			{
				fv a_ = new fv(ez2.CreateDefinitonProvider<a1k>(path));
				mk mk = new mk();
				mk.StaticItems.z3(a_, true);
				mk.ym(null, A_0, null);
			}
		}
	}
}
