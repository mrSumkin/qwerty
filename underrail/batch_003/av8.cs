using System;
using System.Runtime.Serialization;

// Token: 0x02001E16 RID: 7702
[eiz("IBA")]
[Serializable]
public sealed class av8 : to, ISerializable
{
	// Token: 0x0600AA8E RID: 43662 RVA: 0x003F4138 File Offset: 0x003F2338
	private av8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(av8);
		}
	}

	// Token: 0x0600AA8F RID: 43663 RVA: 0x003F4164 File Offset: 0x003F2364
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA90 RID: 43664 RVA: 0x003F4170 File Offset: 0x003F2370
	public av8() : base("Intelligence")
	{
	}

	// Token: 0x0600AA91 RID: 43665 RVA: 0x003F4180 File Offset: 0x003F2380
	public av8(int A_0) : base("Intelligence", A_0)
	{
	}

	// Token: 0x0600AA92 RID: 43666 RVA: 0x003F4190 File Offset: 0x003F2390
	public av8(bn2 A_0) : base(A_0, "Intelligence")
	{
	}

	// Token: 0x0600AA93 RID: 43667 RVA: 0x003F41A0 File Offset: 0x003F23A0
	public av8(bn2 A_0, int A_1) : base(A_0, "Intelligence", A_1)
	{
	}

	// Token: 0x04003FC5 RID: 16325
	private const string BaseAbilityName = "Intelligence";
}
