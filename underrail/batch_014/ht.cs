using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B12 RID: 6930
[eiz("XWSE")]
[Serializable]
public sealed class ht : els, ISerializable
{
	// Token: 0x060095FE RID: 38398 RVA: 0x003AC0E0 File Offset: 0x003AA2E0
	private ht(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095FF RID: 38399 RVA: 0x003AC0EC File Offset: 0x003AA2EC
	public ht(int A_0, double A_1) : base("exposedWeakness", "Раскрытая уязвимость", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "SpecialAttack.ExposeWeakness";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.Power = (int)(A_1 * 100.0);
		base.StaticEffects.Add(new ah(DamageType.Mechanical, 1.0 - A_1, true, true, false));
	}

	// Token: 0x06009600 RID: 38400 RVA: 0x003AC15C File Offset: 0x003AA35C
	public double a()
	{
		ah ah = base.StaticEffects[0] as ah;
		return 1.0 - ah.Value;
	}

	// Token: 0x06009601 RID: 38401 RVA: 0x003AC18C File Offset: 0x003AA38C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ExposedWeakness", new object[]
		{
			(int)(this.a() * 100.0)
		});
	}
}
