using System;
using System.Runtime.Serialization;

// Token: 0x02001AD0 RID: 6864
[eiz("VTSE0")]
[Serializable]
public sealed class ckc : els, ISerializable
{
	// Token: 0x060094CD RID: 38093 RVA: 0x003A7AE0 File Offset: 0x003A5CE0
	private ckc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094CE RID: 38094 RVA: 0x003A7AEC File Offset: 0x003A5CEC
	public ckc(int A_0) : base(ckc.a, "Турбо", ci8.b)
	{
		base.Icon = "xpbl_Abilities.3";
		base.Duration = A_0;
	}

	// Token: 0x060094CF RID: 38095 RVA: 0x003A7B14 File Offset: 0x003A5D14
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/VehicleTurbo", new object[]
		{
			Convert.ToInt32(cd8.c * 100.0),
			Convert.ToInt32(cd8.f * 100.0)
		});
	}

	// Token: 0x04003950 RID: 14672
	public new static readonly string a = "vehicleTurbo";
}
