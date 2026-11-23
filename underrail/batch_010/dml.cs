using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02000240 RID: 576
[eiz("SLAC")]
[Serializable]
public sealed class dml : AreaEffectsContainer<e4b>, ISerializable
{
	// Token: 0x06001050 RID: 4176 RVA: 0x00043A5C File Offset: 0x00041C5C
	private dml(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x00043A68 File Offset: 0x00041C68
	public dml(aud A_0) : base(A_0)
	{
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00043A74 File Offset: 0x00041C74
	protected override e4b aic(Guid A_0, string A_1)
	{
		return new e4b(base.a(), A_0, A_1);
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00043A84 File Offset: 0x00041C84
	protected override e4b aid(string A_0)
	{
		return new e4b(base.a(), A_0);
	}
}
