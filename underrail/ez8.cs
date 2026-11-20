using System;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001786 RID: 6022
[z1("laylow")]
internal sealed class ez8 : c1f
{
	// Token: 0x06008131 RID: 33073 RVA: 0x003678D4 File Offset: 0x00365AD4
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new e15(0.15f),
			new dpw(SkillEnum.Stealth.ToString(), 20),
			new e3r(DamageType.Bio, -0.1)
		};
		A_1 = null;
		A_2 = null;
	}
}
