using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001CFA RID: 7418
[eiz("PS4")]
[Serializable]
public abstract class eoh : csn, ISerializable
{
	// Token: 0x0600A309 RID: 41737 RVA: 0x003EA9C4 File Offset: 0x003E8BC4
	protected eoh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(eoh);
		}
	}

	// Token: 0x0600A30A RID: 41738 RVA: 0x003EA9F0 File Offset: 0x003E8BF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600A30B RID: 41739 RVA: 0x003EA9FC File Offset: 0x003E8BFC
	public override SkillCategory fg()
	{
		return SkillCategory.Psi;
	}

	// Token: 0x0600A30C RID: 41740 RVA: 0x003EAA00 File Offset: 0x003E8C00
	protected eoh(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}
}
