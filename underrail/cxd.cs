using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001CF8 RID: 7416
[eiz("OS")]
[Serializable]
public abstract class cxd : csn, ISerializable
{
	// Token: 0x0600A2FF RID: 41727 RVA: 0x003EA8E0 File Offset: 0x003E8AE0
	protected cxd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cxd);
		}
	}

	// Token: 0x0600A300 RID: 41728 RVA: 0x003EA90C File Offset: 0x003E8B0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600A301 RID: 41729 RVA: 0x003EA918 File Offset: 0x003E8B18
	public override SkillCategory fg()
	{
		return SkillCategory.Offense;
	}

	// Token: 0x0600A302 RID: 41730 RVA: 0x003EA91C File Offset: 0x003E8B1C
	protected cxd(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}
}
