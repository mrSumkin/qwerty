using System;
using System.Runtime.Serialization;

// Token: 0x02001AB5 RID: 6837
[eiz("WLCASE")]
[Serializable]
public sealed class aee : els, ISerializable
{
	// Token: 0x06009445 RID: 37957 RVA: 0x003A5CC8 File Offset: 0x003A3EC8
	private aee(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009446 RID: 37958 RVA: 0x003A5CD8 File Offset: 0x003A3ED8
	public aee() : base(aee.a, "Аура беспроводной зарядки", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Abilities.76";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.TickAction = "WirelessChargingAuraTickAction";
		base.StaticEffects.Add(new dpw("Stealth", -10000));
		base.VisualEffects.Add(new ud(this, "WirelessChargingAura"));
		this.w = "WCAAJ";
		this.x = "WCARJ";
		this.ab = "WCAAJ";
		this.aa = "WCARJ";
		this.y = "WCARJ";
	}

	// Token: 0x06009447 RID: 37959 RVA: 0x003A5D8C File Offset: 0x003A3F8C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/WirelessChargingAura", new object[]
		{
			agj.e,
			Convert.ToInt32(agj.f * 100.0)
		});
	}

	// Token: 0x04003906 RID: 14598
	public new static readonly string a = "wirelessChargingAura";
}
