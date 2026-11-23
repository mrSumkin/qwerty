using System;
using System.Runtime.Serialization;

// Token: 0x02001A1F RID: 6687
[eiz("C44")]
[Serializable]
public sealed class etj : d91, ISerializable
{
	// Token: 0x060090CA RID: 37066 RVA: 0x0039B6BC File Offset: 0x003998BC
	private etj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060090CB RID: 37067 RVA: 0x0039B6C8 File Offset: 0x003998C8
	public etj()
	{
	}

	// Token: 0x060090CC RID: 37068 RVA: 0x0039B6D0 File Offset: 0x003998D0
	public etj(double A_0) : base(A_0)
	{
	}

	// Token: 0x060090CD RID: 37069 RVA: 0x0039B6DC File Offset: 0x003998DC
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && A_0.a().Offense.u().TypedDefinition.ad() > as3.bk && A_0.a().Offense.u().TypedDefinition.e() != btz.g)
		{
			dcu dcu = A_0.a().Offense;
			dcu.h(dcu.ar() + base.b());
		}
	}

	// Token: 0x060090CE RID: 37070 RVA: 0x0039B760 File Offset: 0x00399960
	public override string b2()
	{
		if (base.b() >= 0.0)
		{
			return qv.a("StaticEffects/ModifyRangedWeaponAttackHitChance_Increased", new object[]
			{
				Convert.ToInt32(base.b() * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyRangedWeaponAttackHitChance_Decreased", new object[]
		{
			Convert.ToInt32(Math.Abs(base.b()) * 100.0)
		});
	}

	// Token: 0x060090CF RID: 37071 RVA: 0x0039B7E4 File Offset: 0x003999E4
	public override d3e b3()
	{
		etj etj = new etj();
		this.xx(etj);
		return etj;
	}
}
