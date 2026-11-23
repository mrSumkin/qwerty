using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B0B RID: 6923
[eiz("QGE")]
[Serializable]
public sealed class aah : els, ISerializable
{
	// Token: 0x060095E0 RID: 38368 RVA: 0x003ABAB8 File Offset: 0x003A9CB8
	private aah(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095E1 RID: 38369 RVA: 0x003ABAC8 File Offset: 0x003A9CC8
	public aah(int A_0) : base("irongut", "Стальной желудок", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.Irongut";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new e3r(DamageType.Bio, -aah.a));
	}

	// Token: 0x060095E2 RID: 38370 RVA: 0x003ABB18 File Offset: 0x003A9D18
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Irongut", new object[]
		{
			(int)(aah.a * 100.0)
		});
	}

	// Token: 0x040039B1 RID: 14769
	public new static readonly double a = 0.75;
}
