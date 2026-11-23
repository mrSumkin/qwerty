using System;
using System.Runtime.Serialization;

// Token: 0x02001A92 RID: 6802
[eiz("CMPS")]
[Serializable]
public sealed class d3t : els, ISerializable
{
	// Token: 0x060093A8 RID: 37800 RVA: 0x003A372C File Offset: 0x003A192C
	private d3t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093A9 RID: 37801 RVA: 0x003A3738 File Offset: 0x003A1938
	public d3t() : base("compass", "Компас", ci8.a)
	{
		base.Duration = 0;
		base.TickPeriod = 0;
		base.Icon = "Devices.16";
		base.VisualEffects.Add(new ud(this, "Compass"));
		base.Stacking = axm.b;
	}

	// Token: 0x060093AA RID: 37802 RVA: 0x003A378C File Offset: 0x003A198C
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Compass");
	}
}
