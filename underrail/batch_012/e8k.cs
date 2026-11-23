using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001CF7 RID: 7415
[eiz("HGS")]
[a1("Heavy Guns")]
[Serializable]
public sealed class e8k : cxd, ISerializable
{
	// Token: 0x0600A2F8 RID: 41720 RVA: 0x003EA85C File Offset: 0x003E8A5C
	private e8k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600A2F9 RID: 41721 RVA: 0x003EA868 File Offset: 0x003E8A68
	public override string fh()
	{
		return "Heavy Guns";
	}

	// Token: 0x0600A2FA RID: 41722 RVA: 0x003EA870 File Offset: 0x003E8A70
	public override string j6()
	{
		return "xphw";
	}

	// Token: 0x0600A2FB RID: 41723 RVA: 0x003EA878 File Offset: 0x003E8A78
	public e8k(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600A2FC RID: 41724 RVA: 0x003EA884 File Offset: 0x003E8A84
	protected override void av9(efk A_0, ref int A_1)
	{
		if (A_0 != null && A_0.Feats.Contains<biv>())
		{
			A_1 += biv.a;
		}
	}

	// Token: 0x0600A2FD RID: 41725 RVA: 0x003EA8A8 File Offset: 0x003E8AA8
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(eav),
				1f
			}
		};
	}

	// Token: 0x0600A2FE RID: 41726 RVA: 0x003EA8C4 File Offset: 0x003E8AC4
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(ct7),
				0.65f
			}
		};
	}
}
