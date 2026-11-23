using System;
using System.Runtime.Serialization;

// Token: 0x02000C70 RID: 3184
[eiz("FRDE")]
[Serializable]
public sealed class bbl : cd2
{
	// Token: 0x060047AE RID: 18350 RVA: 0x001D7B5C File Offset: 0x001D5D5C
	private bbl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060047AF RID: 18351 RVA: 0x001D7B68 File Offset: 0x001D5D68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060047B0 RID: 18352 RVA: 0x001D7B74 File Offset: 0x001D5D74
	public override TimeSpan ge()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("firearmRefurbishment_delay", null) != null)
		{
			return serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("firearmRefurbishment_delay", null).Value;
		}
		return TimeSpan.FromMinutes(60.0);
	}

	// Token: 0x060047B1 RID: 18353 RVA: 0x001D7BF4 File Offset: 0x001D5DF4
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047B2 RID: 18354 RVA: 0x001D7C04 File Offset: 0x001D5E04
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047B3 RID: 18355 RVA: 0x001D7C14 File Offset: 0x001D5E14
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047B4 RID: 18356 RVA: 0x001D7C24 File Offset: 0x001D5E24
	public bbl() : base(bbl.a)
	{
	}

	// Token: 0x060047B5 RID: 18357 RVA: 0x001D7C34 File Offset: 0x001D5E34
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x060047B6 RID: 18358 RVA: 0x001D7C48 File Offset: 0x001D5E48
	protected override void gg(cyt A_0)
	{
		A_0.r()["firearmRefurbishment_workingOnFirearm"] = false;
		A_0.r()["firearmRefurbishment_refurbishedFirearmReady"] = true;
		A_0.r().RemoveProperty("firearmRefurbishment_startTime");
		A_0.r().RemoveProperty("firearmRefurbishment_delay");
	}

	// Token: 0x04001CA1 RID: 7329
	public new static readonly string a = "rirearmRefurbishment";
}
