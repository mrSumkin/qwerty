using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200177D RID: 6013
[z1("allIn")]
internal sealed class k5 : c1f
{
	// Token: 0x0600811D RID: 33053 RVA: 0x00367364 File Offset: 0x00365564
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		List<d3e> list = new List<d3e>();
		foreach (object obj in Enum.GetValues(typeof(BaseAbilityEnum)))
		{
			BaseAbilityEnum baseAbilityEnum = (BaseAbilityEnum)obj;
			int num = 3;
			if (baseAbilityEnum == BaseAbilityEnum.Intelligence)
			{
				num *= -1;
			}
			list.Add(new ax6(baseAbilityEnum.ToString().a(), num));
		}
		list.Add(new l5(1.0));
		list.Add(new e2e(1.0));
		A_0 = list.ToArray();
		A_1 = null;
		A_2 = null;
	}
}
