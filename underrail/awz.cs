using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B09 RID: 6921
[eiz("QPS")]
[Serializable]
public sealed class awz : els, ISerializable
{
	// Token: 0x060095D8 RID: 38360 RVA: 0x003AB88C File Offset: 0x003A9A8C
	private awz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095D9 RID: 38361 RVA: 0x003AB8A4 File Offset: 0x003A9AA4
	public awz(int A_0, double A_1 = 0.15) : base(awz.b, "Подавление боли", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.47";
		base.Stacking = axm.b;
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType a_ = (DamageType)obj;
			if (A_1 != awz.a)
			{
				this.c = A_1;
			}
			base.StaticEffects.Add(new e3r(a_, -this.c));
		}
	}

	// Token: 0x060095DA RID: 38362 RVA: 0x003AB968 File Offset: 0x003A9B68
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PainSuppression", new object[]
		{
			(int)(this.c * 100.0)
		});
	}

	// Token: 0x040039AC RID: 14764
	public new static readonly double a = 0.15;

	// Token: 0x040039AD RID: 14765
	public static readonly string b = "painSuppression";

	// Token: 0x040039AE RID: 14766
	private new double c = awz.a;
}
