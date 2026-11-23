using System;

// Token: 0x02000C2B RID: 3115
public sealed class doo : jn
{
	// Token: 0x06004675 RID: 18037 RVA: 0x001D12A0 File Offset: 0x001CF4A0
	public doo() : base("rathoundKing", "creature\\characters\\rathoundKing")
	{
	}

	// Token: 0x06004676 RID: 18038 RVA: 0x001D12B4 File Offset: 0x001CF4B4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_rathoundKing_flees", new bool?(false)).Value)
		{
			return "dc-rh";
		}
		return "rkl2";
	}

	// Token: 0x06004677 RID: 18039 RVA: 0x001D12F0 File Offset: 0x001CF4F0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (string.Equals(A_2, "dc-rh", StringComparison.OrdinalIgnoreCase) && A_0.GetAspect<a6p>() != null)
		{
			A_0.RemoveAspect<a6p>();
		}
	}
}
