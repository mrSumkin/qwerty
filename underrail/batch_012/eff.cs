using System;
using System.Runtime.Serialization;

// Token: 0x02001AA0 RID: 6816
[eiz("BLO7")]
[Serializable]
public sealed class eff : els, ISerializable
{
	// Token: 0x060093E6 RID: 37862 RVA: 0x003A43F8 File Offset: 0x003A25F8
	private eff(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093E7 RID: 37863 RVA: 0x003A4404 File Offset: 0x003A2604
	public eff(int A_0, float A_1) : base(eff.a, "Замедление (липкое масло)", ci8.c)
	{
		base.Icon = "Status.BlackOilSlow";
		base.Duration = A_0;
		base.StaticEffects.Add(new i0(A_1, false, false, false));
	}

	// Token: 0x060093E8 RID: 37864 RVA: 0x003A4448 File Offset: 0x003A2648
	public override string cb(ll A_0)
	{
		i0 i = base.StaticEffects[0] as i0;
		return qv.a("StatusEffects/BlackOilSlow", new object[]
		{
			(int)Math.Abs(i.Amount * 100f)
		});
	}

	// Token: 0x040038D3 RID: 14547
	public new static readonly string a = "BlackOilSlow";
}
