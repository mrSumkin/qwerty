using System;

// Token: 0x02000C0E RID: 3086
public sealed class eyi : jn
{
	// Token: 0x06004607 RID: 17927 RVA: 0x001CA4F0 File Offset: 0x001C86F0
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004608 RID: 17928 RVA: 0x001CA4F8 File Offset: 0x001C86F8
	public eyi() : base("xpbl_boneChieftain", "creature\\characters\\xpbl\\BoneChieftain")
	{
	}

	// Token: 0x06004609 RID: 17929 RVA: 0x001CA510 File Offset: 0x001C8710
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_boneyard_ambushTriggered", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_boneyard_ambushEnded", new bool?(false)).Value)
		{
			return "xpbl_g12";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_boneyard_ambushing", new bool?(false)).Value)
		{
			return "xpbl_h11";
		}
		return null;
	}
}
