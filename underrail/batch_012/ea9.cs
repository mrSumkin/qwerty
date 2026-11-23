using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200178F RID: 6031
internal class ea9 : ak9
{
	// Token: 0x0600814C RID: 33100 RVA: 0x00367C64 File Offset: 0x00365E64
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		List<d3e> list = new List<d3e>();
		foreach (object obj in Enum.GetValues(typeof(SkillEnum)))
		{
			list.Add(new dpw(((SkillEnum)obj).ToString().a(), 5));
		}
		A_0 = list.ToArray();
		A_2 = null;
		A_1 = null;
	}
}
