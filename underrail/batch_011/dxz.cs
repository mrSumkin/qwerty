using System;
using System.Runtime.Serialization;

// Token: 0x02000C74 RID: 3188
[eiz("LUPFDMGCDE")]
[Serializable]
public sealed class dxz : cd2
{
	// Token: 0x060047DB RID: 18395 RVA: 0x001D8B98 File Offset: 0x001D6D98
	private dxz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060047DC RID: 18396 RVA: 0x001D8BA4 File Offset: 0x001D6DA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060047DD RID: 18397 RVA: 0x001D8BB0 File Offset: 0x001D6DB0
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(60.0);
	}

	// Token: 0x060047DE RID: 18398 RVA: 0x001D8BC0 File Offset: 0x001D6DC0
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047DF RID: 18399 RVA: 0x001D8BD0 File Offset: 0x001D6DD0
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047E0 RID: 18400 RVA: 0x001D8BE0 File Offset: 0x001D6DE0
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x001D8BF0 File Offset: 0x001D6DF0
	public dxz() : base(dxz.a)
	{
	}

	// Token: 0x060047E2 RID: 18402 RVA: 0x001D8C00 File Offset: 0x001D6E00
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x060047E3 RID: 18403 RVA: 0x001D8C14 File Offset: 0x001D6E14
	protected override void gg(cyt A_0)
	{
		A_0.r()["loc_lup_freeDroneBase_gasStopped"] = true;
	}

	// Token: 0x04001CA6 RID: 7334
	public new static readonly string a = "lup_FreeDronesMutagenGasClearsDelayedEvent";
}
