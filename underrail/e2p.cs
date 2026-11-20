using System;
using System.Runtime.Serialization;

// Token: 0x02001ACB RID: 6859
[eiz("EASE0")]
[Serializable]
public sealed class e2p : els, ISerializable
{
	// Token: 0x060094B5 RID: 38069 RVA: 0x003A76B4 File Offset: 0x003A58B4
	private e2p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094B6 RID: 38070 RVA: 0x003A76C0 File Offset: 0x003A58C0
	public e2p() : base(e2p.a, "Электрошоковая аура", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "xpbl_Abilities.10";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.TickAction = "ElectroshockAuraTickAction";
		this.af = "ElectroshockAura_DamageTaken";
		this.ah = true;
		base.StaticEffects.Add(new dpw("Stealth", -10000)
		{
			Priority = int.MaxValue
		});
		base.VisualEffects.Add(new ud(this, "ElectroshockAura"));
	}

	// Token: 0x060094B7 RID: 38071 RVA: 0x003A775C File Offset: 0x003A595C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ElectroshockAura", new object[]
		{
			cs4.e,
			cs4.a().a(true),
			cs4.f,
			Convert.ToInt32(cs4.i * 100.0),
			l4.a(cs4.j, false)
		});
	}

	// Token: 0x04003948 RID: 14664
	public new static readonly string a = "electroshockAura";
}
