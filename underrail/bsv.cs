using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020017AF RID: 6063
internal class bsv : ak9
{
	// Token: 0x060081A1 RID: 33185 RVA: 0x0036921C File Offset: 0x0036741C
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		List<d3e> list = new List<d3e>();
		foreach (object obj in Enum.GetValues(typeof(SkillEnum)))
		{
			list.Add(new dpw(((SkillEnum)obj).ToString().a(), 3));
		}
		A_0 = list.ToArray();
		A_1 = null;
		A_2 = null;
	}
}
