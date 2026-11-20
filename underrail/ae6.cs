using System;
using System.Runtime.Serialization;

// Token: 0x020019E7 RID: 6631
[eiz("C45")]
[Serializable]
public sealed class ae6 : d91, ISerializable
{
	// Token: 0x06008E94 RID: 36500 RVA: 0x00395B34 File Offset: 0x00393D34
	private ae6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008E95 RID: 36501 RVA: 0x00395B40 File Offset: 0x00393D40
	public ae6()
	{
	}

	// Token: 0x06008E96 RID: 36502 RVA: 0x00395B48 File Offset: 0x00393D48
	public ae6(double A_0) : base(A_0)
	{
	}

	// Token: 0x06008E97 RID: 36503 RVA: 0x00395B54 File Offset: 0x00393D54
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && A_0.a().Offense.u().TypedDefinition.e() == btz.g)
		{
			dcu dcu = A_0.a().Offense;
			dcu.h(dcu.ar() + base.b());
		}
	}

	// Token: 0x06008E98 RID: 36504 RVA: 0x00395BB4 File Offset: 0x00393DB4
	public override string b2()
	{
		if (base.b() >= 0.0)
		{
			return qv.a("StaticEffects/ModifyMeleeWeaponAttackHitChance_Increased", new object[]
			{
				base.b() * 100.0
			});
		}
		return qv.a("StaticEffects/ModifyMeleeWeaponAttackHitChance_Decreased", new object[]
		{
			Math.Abs(base.b()) * 100.0
		});
	}

	// Token: 0x06008E99 RID: 36505 RVA: 0x00395C2C File Offset: 0x00393E2C
	public override d3e b3()
	{
		ae6 ae = new ae6();
		this.xx(ae);
		return ae;
	}
}
