using System;
using System.Runtime.Serialization;

// Token: 0x02001A37 RID: 6711
[eiz("PE3")]
[Serializable]
public sealed class bdx : d3e, ISerializable
{
	// Token: 0x06009185 RID: 37253 RVA: 0x0039D210 File Offset: 0x0039B410
	private bdx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009186 RID: 37254 RVA: 0x0039D21C File Offset: 0x0039B41C
	public bdx()
	{
	}

	// Token: 0x06009187 RID: 37255 RVA: 0x0039D224 File Offset: 0x0039B424
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.i = true;
	}

	// Token: 0x06009188 RID: 37256 RVA: 0x0039D238 File Offset: 0x0039B438
	public override d3e b3()
	{
		bdx bdx = new bdx();
		this.xx(bdx);
		return bdx;
	}
}
