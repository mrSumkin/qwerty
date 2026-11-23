using System;

// Token: 0x02000C43 RID: 3139
public sealed class q6 : jn
{
	// Token: 0x060046B8 RID: 18104 RVA: 0x001D2CA4 File Offset: 0x001D0EA4
	public q6() : base("jy_jenny", "creature\\characters\\jy_jenny")
	{
	}

	// Token: 0x060046B9 RID: 18105 RVA: 0x001D2CB8 File Offset: 0x001D0EB8
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jysaveJenny_completed", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jytjenny_cured", new bool?(false)).Value)
		{
			return "jyt4";
		}
		return "jytd1";
	}

	// Token: 0x060046BA RID: 18106 RVA: 0x001D2D18 File Offset: 0x001D0F18
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			bn5 bn = c5x.GetAspect<j7>() as bn5;
			if (bn != null)
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_jytjenny_cured", new bool?(false)).Value && A_2 == "jyt4")
				{
					bn.b("events\\jyt_CliffAndJenny");
					return;
				}
				bn.b("characters\\jyt_jenny");
			}
		}
	}
}
