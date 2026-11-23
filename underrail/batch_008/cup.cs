using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02000233 RID: 563
[eiz("DC1")]
[Serializable]
public sealed class cup : AreaEffectsContainer<cno>, ISerializable
{
	// Token: 0x06000FB5 RID: 4021 RVA: 0x00041058 File Offset: 0x0003F258
	private cup(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00041064 File Offset: 0x0003F264
	public cup(aud A_0) : base(A_0)
	{
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00041070 File Offset: 0x0003F270
	protected override cno aic(Guid A_0, string A_1)
	{
		return new cno(base.a(), A_0, A_1);
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00041080 File Offset: 0x0003F280
	protected override cno aid(string A_0)
	{
		return new cno(base.a(), A_0);
	}
}
