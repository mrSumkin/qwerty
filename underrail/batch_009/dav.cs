using System;

// Token: 0x02000C13 RID: 3091
public sealed class dav : jn
{
	// Token: 0x0600461D RID: 17949 RVA: 0x001CB7C0 File Offset: 0x001C99C0
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x0600461E RID: 17950 RVA: 0x001CB7C8 File Offset: 0x001C99C8
	public dav() : base("xpbl_donnie", "creature\\characters\\xpbl\\Donnie")
	{
	}

	// Token: 0x0600461F RID: 17951 RVA: 0x001CB7E0 File Offset: 0x001C99E0
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_donnie_returnedToPost", new bool?(false)).Value)
		{
			return "xpbl_f2";
		}
		return "xpbl_g2";
	}

	// Token: 0x06004620 RID: 17952 RVA: 0x001CB81C File Offset: 0x001C9A1C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null && string.Equals(A_2, "xpbl_g2", StringComparison.OrdinalIgnoreCase) && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_donnie_talkedAfterReturning", new bool?(false)).Value)
		{
			aspect.y6()[ddq.bc] = "npc_xpbl_donnie_talkedAfterReturning";
		}
	}
}
