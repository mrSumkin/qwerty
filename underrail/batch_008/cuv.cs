using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019E2 RID: 6626
[eiz("MAWSBDE")]
[Serializable]
public sealed class cuv : d91, ISerializable
{
	// Token: 0x06008E62 RID: 36450 RVA: 0x003952C8 File Offset: 0x003934C8
	private cuv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (WeaponAggregateSubtype)A_0.GetValue("MAWSBDE:S", typeof(WeaponAggregateSubtype));
	}

	// Token: 0x06008E63 RID: 36451 RVA: 0x003952F4 File Offset: 0x003934F4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MAWSBDE:S", this.a);
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x06008E64 RID: 36452 RVA: 0x00395314 File Offset: 0x00393514
	// (set) Token: 0x06008E65 RID: 36453 RVA: 0x0039531C File Offset: 0x0039351C
	public WeaponAggregateSubtype WeaponSubtype
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x06008E66 RID: 36454 RVA: 0x00395328 File Offset: 0x00393528
	public cuv()
	{
	}

	// Token: 0x06008E67 RID: 36455 RVA: 0x00395330 File Offset: 0x00393530
	public cuv(double A_0, WeaponAggregateSubtype A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x06008E68 RID: 36456 RVA: 0x00395344 File Offset: 0x00393544
	public override string b2()
	{
		string text = dh9.c("WeaponAggregateSubtype_DisplayName_" + this.a.ToString());
		if (string.IsNullOrEmpty(text))
		{
			text = as3.am[this.a];
		}
		text = text.ToLowerInvariant();
		if (base.b() >= 0.0)
		{
			return qv.a("StaticEffects/ModifyAggregateWeaponSubtypeBonusDamage_Positive", new object[]
			{
				text,
				Convert.ToInt32(base.b() * 100.0)
			});
		}
		return qv.a("StaticEffects/ModifyAggregateWeaponSubtypeBonusDamage_Negative", new object[]
		{
			text,
			Math.Abs(Convert.ToInt32(base.b() * 100.0))
		});
	}

	// Token: 0x06008E69 RID: 36457 RVA: 0x00395414 File Offset: 0x00393614
	public override d3e b3()
	{
		cuv cuv = new cuv();
		this.xx(cuv);
		return cuv;
	}

	// Token: 0x06008E6A RID: 36458 RVA: 0x00395430 File Offset: 0x00393630
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((cuv)A_0).a = this.a;
	}

	// Token: 0x06008E6B RID: 36459 RVA: 0x00395450 File Offset: 0x00393650
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.a().Offense.u().TypedDefinition);
			if (weaponSubtype != null && euf.a(weaponSubtype.Value, this.a))
			{
				cmn cmn = new cmn();
				cmn.b += base.b();
				A_0.a().Offense.a(as3.a, cmn);
			}
		}
	}

	// Token: 0x040037D5 RID: 14293
	private new WeaponAggregateSubtype a;
}
