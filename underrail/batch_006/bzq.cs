using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AE6 RID: 6886
[eiz("PTDSE")]
[Serializable]
public sealed class bzq : els, ISerializable
{
	// Token: 0x0600952F RID: 38191 RVA: 0x003A8F4C File Offset: 0x003A714C
	private bzq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009530 RID: 38192 RVA: 0x003A8F58 File Offset: 0x003A7158
	public bzq(int A_0, int A_1, int A_2, float A_3) : base(bzq.a, "Психо-временное растягивание", ci8.c)
	{
		base.Icon = "Psi.PsychotemporalDilation";
		base.Duration = A_0;
		base.ExpiredAction = "BlueExpirationAction";
		base.RemovedAction = "BlueExpirationAction";
		base.Power = A_1;
		base.StaticEffects.Add(new i0(-A_3, false, false, false));
		base.StaticEffects.Add(new d9(-A_1, true, false));
		base.StaticEffects.Add(new ba(-A_2, false, true, false));
	}

	// Token: 0x06009531 RID: 38193 RVA: 0x003A8FE4 File Offset: 0x003A71E4
	public override string cb(ll A_0)
	{
		d9 d = Enumerable.First<d9>(Enumerable.OfType<d9>(base.StaticEffects));
		ba ba = Enumerable.First<ba>(Enumerable.OfType<ba>(base.StaticEffects));
		return qv.a("StatusEffects/PsychotemporalDilation", new object[]
		{
			Math.Abs(d.Amount),
			Math.Abs(ba.Amount)
		});
	}

	// Token: 0x0400396C RID: 14700
	public new static readonly string a = "PsychotemporalDilation";
}
