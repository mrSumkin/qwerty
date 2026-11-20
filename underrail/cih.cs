using System;
using System.Runtime.Serialization;

// Token: 0x02001A51 RID: 6737
[eiz("HCE")]
[Serializable]
public sealed class cih : d3e, ISerializable
{
	// Token: 0x0600923F RID: 37439 RVA: 0x0039EF7C File Offset: 0x0039D17C
	private cih(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cih);
		}
	}

	// Token: 0x06009240 RID: 37440 RVA: 0x0039EFA8 File Offset: 0x0039D1A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06009241 RID: 37441 RVA: 0x0039EFB4 File Offset: 0x0039D1B4
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.f = true;
	}

	// Token: 0x06009242 RID: 37442 RVA: 0x0039EFC8 File Offset: 0x0039D1C8
	public cih()
	{
	}

	// Token: 0x06009243 RID: 37443 RVA: 0x0039EFD4 File Offset: 0x0039D1D4
	public override d3e b3()
	{
		cih cih = new cih();
		this.xx(cih);
		return cih;
	}
}
