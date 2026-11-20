using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020005B5 RID: 1461
public sealed class csg : ae1
{
	// Token: 0x060026FE RID: 9982 RVA: 0x000E3444 File Offset: 0x000E1644
	public override string gr()
	{
		return "base ability";
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x000E344C File Offset: 0x000E164C
	public override object gs(string A_0)
	{
		return A_0;
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x000E3450 File Offset: 0x000E1650
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		foreach (object obj in Enum.GetValues(typeof(BaseAbilityEnum)))
		{
			list.Add(((BaseAbilityEnum)obj).ToString().a());
		}
		return list;
	}
}
