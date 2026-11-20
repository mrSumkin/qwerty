using System;
using System.Runtime.Serialization;

// Token: 0x02000C7E RID: 3198
[eiz("SPOMDE")]
[Serializable]
public sealed class c2d : cd2
{
	// Token: 0x06004837 RID: 18487 RVA: 0x001D99D0 File Offset: 0x001D7BD0
	private c2d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004838 RID: 18488 RVA: 0x001D99DC File Offset: 0x001D7BDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004839 RID: 18489 RVA: 0x001D99E8 File Offset: 0x001D7BE8
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(20.0);
	}

	// Token: 0x0600483A RID: 18490 RVA: 0x001D99F8 File Offset: 0x001D7BF8
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600483B RID: 18491 RVA: 0x001D9A08 File Offset: 0x001D7C08
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600483C RID: 18492 RVA: 0x001D9A18 File Offset: 0x001D7C18
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600483D RID: 18493 RVA: 0x001D9A28 File Offset: 0x001D7C28
	public c2d() : base(c2d.a)
	{
	}

	// Token: 0x0600483E RID: 18494 RVA: 0x001D9A38 File Offset: 0x001D7C38
	protected override bool ez(cyt A_0)
	{
		base.ez(A_0);
		return false;
	}

	// Token: 0x0600483F RID: 18495 RVA: 0x001D9A44 File Offset: 0x001D7C44
	protected override void gg(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value)
		{
			A_0.a(new bw0("xpbl_i1", new dv(), 1));
		}
	}

	// Token: 0x04001CB0 RID: 7344
	public new static readonly string a = "spawnPiratesOutsideMedicalDelayedEvent";
}
