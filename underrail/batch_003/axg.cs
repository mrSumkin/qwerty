using System;
using System.Runtime.Serialization;

// Token: 0x02001AA9 RID: 6825
[eiz("ETASE")]
[Serializable]
public sealed class axg : els, ISerializable
{
	// Token: 0x0600940F RID: 37903 RVA: 0x003A4ED0 File Offset: 0x003A30D0
	private axg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("ETASE:D", typeof(coh)) as coh);
	}

	// Token: 0x06009410 RID: 37904 RVA: 0x003A4EFC File Offset: 0x003A30FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ETASE:D", this.a);
	}

	// Token: 0x06009411 RID: 37905 RVA: 0x003A4F18 File Offset: 0x003A3118
	public axg(coh A_0) : base("electricTorchAura", "Свет электрического фонаря", ci8.b)
	{
		this.a = A_0;
		base.Duration = 0;
		base.Icon = "Devices.29";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.ControllerName = "ETASE1";
		base.StaticEffects.Add(new dpw("Stealth", -100000)
		{
			Priority = int.MaxValue
		});
		if (A_0 != null)
		{
			base.DynamicEffects.Add(new ead(A_0, c5c.d));
		}
	}

	// Token: 0x06009412 RID: 37906 RVA: 0x003A4FB0 File Offset: 0x003A31B0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ElectricTorchAura", new object[]
		{
			c5c.d,
			c5c.g
		});
	}

	// Token: 0x040038E6 RID: 14566
	public new coh a;
}
