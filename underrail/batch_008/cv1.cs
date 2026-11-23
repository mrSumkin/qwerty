using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019E8 RID: 6632
[eiz("MAWSCHC")]
[Serializable]
public sealed class cv1 : d3e, ISerializable
{
	// Token: 0x06008E9A RID: 36506 RVA: 0x00395C48 File Offset: 0x00393E48
	private cv1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (WeaponAggregateSubtype)A_0.GetValue("MAWSCHC:S", typeof(WeaponAggregateSubtype));
		this.b = A_0.GetDouble("MAWSCHC:C");
	}

	// Token: 0x06008E9B RID: 36507 RVA: 0x00395C84 File Offset: 0x00393E84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MAWSCHC:S", this.a);
		info.AddValue("MAWSCHC:C", this.b);
	}

	// Token: 0x06008E9C RID: 36508 RVA: 0x00395CB8 File Offset: 0x00393EB8
	public WeaponAggregateSubtype b()
	{
		return this.a;
	}

	// Token: 0x06008E9D RID: 36509 RVA: 0x00395CC0 File Offset: 0x00393EC0
	public void a(WeaponAggregateSubtype A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E9E RID: 36510 RVA: 0x00395CCC File Offset: 0x00393ECC
	public double a()
	{
		return this.b;
	}

	// Token: 0x06008E9F RID: 36511 RVA: 0x00395CD4 File Offset: 0x00393ED4
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008EA0 RID: 36512 RVA: 0x00395CE0 File Offset: 0x00393EE0
	public cv1()
	{
	}

	// Token: 0x06008EA1 RID: 36513 RVA: 0x00395CE8 File Offset: 0x00393EE8
	public cv1(double A_0, WeaponAggregateSubtype A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06008EA2 RID: 36514 RVA: 0x00395D00 File Offset: 0x00393F00
	public override string b2()
	{
		string text = dh9.c("WeaponAggregateSubtype_DisplayName_" + this.a.ToString());
		if (string.IsNullOrEmpty(text))
		{
			text = as3.am[this.a];
		}
		text = text.ToLowerInvariant();
		if (this.b >= 0.0)
		{
			return qv.a("StaticEffects/ModifyAggregateWeaponSubtypeCriticalHitChance_Positive", new object[]
			{
				text,
				Convert.ToInt32(this.b * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyAggregateWeaponSubtypeCriticalHitChance_Negative", new object[]
		{
			text,
			Math.Abs(Convert.ToInt32(this.b * 100.0))
		});
	}

	// Token: 0x06008EA3 RID: 36515 RVA: 0x00395DD0 File Offset: 0x00393FD0
	public override d3e b3()
	{
		cv1 cv = new cv1();
		this.xx(cv);
		return cv;
	}

	// Token: 0x06008EA4 RID: 36516 RVA: 0x00395DEC File Offset: 0x00393FEC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		cv1 cv = (cv1)A_0;
		cv.b = this.b;
		cv.a = this.a;
	}

	// Token: 0x06008EA5 RID: 36517 RVA: 0x00395E18 File Offset: 0x00394018
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.a().Offense.u().TypedDefinition);
			if (weaponSubtype != null && euf.a(weaponSubtype.Value, this.a))
			{
				dcu dcu = A_0.a().Offense;
				dcu.c(dcu.a0() + this.b);
			}
		}
	}

	// Token: 0x040037DA RID: 14298
	private new WeaponAggregateSubtype a;

	// Token: 0x040037DB RID: 14299
	private double b;
}
