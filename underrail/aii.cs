using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020005C4 RID: 1476
public sealed class aii : ae1
{
	// Token: 0x06002739 RID: 10041 RVA: 0x000E415C File Offset: 0x000E235C
	public override string gr()
	{
		return "skill";
	}

	// Token: 0x0600273A RID: 10042 RVA: 0x000E4164 File Offset: 0x000E2364
	public override object gs(string A_0)
	{
		return A_0;
	}

	// Token: 0x0600273B RID: 10043 RVA: 0x000E416C File Offset: 0x000E236C
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		foreach (object obj in Enum.GetValues(typeof(SkillEnum)))
		{
			list.Add(((SkillEnum)obj).ToString().a());
		}
		return list;
	}
}
