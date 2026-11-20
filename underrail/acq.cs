using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019FC RID: 6652
[eiz("MAWSAS")]
[Serializable]
public sealed class acq : d3e, ISerializable
{
	// Token: 0x06008F6E RID: 36718 RVA: 0x00397BD4 File Offset: 0x00395DD4
	private acq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MAWSAS:A");
		this.b = (WeaponAggregateSubtype)A_0.GetValue("MAWSAS:S", typeof(WeaponAggregateSubtype));
		this.c = A_0.GetInt32("MAWSAS:C");
	}

	// Token: 0x06008F6F RID: 36719 RVA: 0x00397C2C File Offset: 0x00395E2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MAWSAS:A", this.a);
		info.AddValue("MAWSAS:S", this.b);
		info.AddValue("MAWSAS:C", this.c);
	}

	// Token: 0x06008F70 RID: 36720 RVA: 0x00397C7C File Offset: 0x00395E7C
	public float c()
	{
		return this.a;
	}

	// Token: 0x06008F71 RID: 36721 RVA: 0x00397C84 File Offset: 0x00395E84
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F72 RID: 36722 RVA: 0x00397C90 File Offset: 0x00395E90
	public WeaponAggregateSubtype a()
	{
		return this.b;
	}

	// Token: 0x06008F73 RID: 36723 RVA: 0x00397C98 File Offset: 0x00395E98
	public void a(WeaponAggregateSubtype A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008F74 RID: 36724 RVA: 0x00397CA4 File Offset: 0x00395EA4
	public int b()
	{
		return this.c;
	}

	// Token: 0x06008F75 RID: 36725 RVA: 0x00397CAC File Offset: 0x00395EAC
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008F76 RID: 36726 RVA: 0x00397CB8 File Offset: 0x00395EB8
	public acq()
	{
	}

	// Token: 0x06008F77 RID: 36727 RVA: 0x00397CC0 File Offset: 0x00395EC0
	public acq(float A_0, int A_1, WeaponAggregateSubtype A_2)
	{
		this.a = A_0;
		this.c = A_1;
		this.b = A_2;
	}

	// Token: 0x06008F78 RID: 36728 RVA: 0x00397CE0 File Offset: 0x00395EE0
	public override string b2()
	{
		string text = dh9.c("WeaponAggregateSubtype_DisplayName_" + this.b.ToString());
		if (string.IsNullOrEmpty(text))
		{
			text = as3.am[this.b];
		}
		text = text.ToLowerInvariant();
		if (this.c >= 0)
		{
			return qv.a("StaticEffects/ModifyAggregateWeaponSubtypeAttackSpeed_Positive", new object[]
			{
				text,
				this.c
			});
		}
		return qv.a("StaticEffects/ModifyAggregateWeaponSubtypeAttackSpeed_Negative", new object[]
		{
			text,
			Math.Abs(this.c)
		});
	}

	// Token: 0x06008F79 RID: 36729 RVA: 0x00397D88 File Offset: 0x00395F88
	public override d3e b3()
	{
		acq acq = new acq();
		this.xx(acq);
		return acq;
	}

	// Token: 0x06008F7A RID: 36730 RVA: 0x00397DA4 File Offset: 0x00395FA4
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		acq acq = (acq)A_0;
		acq.c = this.c;
		acq.a = this.a;
		acq.b = this.b;
	}

	// Token: 0x06008F7B RID: 36731 RVA: 0x00397DDC File Offset: 0x00395FDC
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.a().Offense.u().TypedDefinition);
			if (weaponSubtype != null && euf.a(weaponSubtype.Value, this.b))
			{
				dcu dcu = A_0.a().Offense;
				dcu.a(dcu.ax() + this.a);
				dcu dcu2 = A_0.a().Offense;
				dcu2.e(dcu2.j() + this.c);
			}
		}
	}

	// Token: 0x040037F2 RID: 14322
	private new float a;

	// Token: 0x040037F3 RID: 14323
	private WeaponAggregateSubtype b;

	// Token: 0x040037F4 RID: 14324
	private int c;
}
