using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200177E RID: 6014
[z1("boolean")]
internal sealed class bml : c1f
{
	// Token: 0x0600811F RID: 33055 RVA: 0x0036743C File Offset: 0x0036563C
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		List<d3e> list = new List<d3e>();
		foreach (object obj in Enum.GetValues(typeof(BaseAbilityEnum)))
		{
			BaseAbilityEnum baseAbilityEnum = (BaseAbilityEnum)obj;
			int a_ = -3;
			list.Add(new ax6(baseAbilityEnum.ToString().a(), a_));
		}
		list.Add(new dpw("Metathermics", -20)
		{
			Priority = int.MaxValue
		});
		list.Add(new dpw("TemporalManipulation", -20)
		{
			Priority = int.MaxValue
		});
		list.Add(new dpw("ThoughtControl", -20)
		{
			Priority = int.MaxValue
		});
		list.Add(new dpw("Psychokinesis", -20)
		{
			Priority = int.MaxValue
		});
		list.Add(new emn(-30)
		{
			Priority = int.MaxValue
		});
		A_0 = list.ToArray();
		A_1 = null;
		A_2 = null;
	}
}
