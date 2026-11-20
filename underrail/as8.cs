using System;
using System.Runtime.Serialization;

// Token: 0x02000C6F RID: 3183
[eiz("FOLSPDDE")]
[Serializable]
public sealed class as8 : cd2
{
	// Token: 0x060047A4 RID: 18340 RVA: 0x001D7ABC File Offset: 0x001D5CBC
	private as8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060047A5 RID: 18341 RVA: 0x001D7AC8 File Offset: 0x001D5CC8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060047A6 RID: 18342 RVA: 0x001D7AD4 File Offset: 0x001D5CD4
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x060047A7 RID: 18343 RVA: 0x001D7AE4 File Offset: 0x001D5CE4
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047A8 RID: 18344 RVA: 0x001D7AF4 File Offset: 0x001D5CF4
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047A9 RID: 18345 RVA: 0x001D7B04 File Offset: 0x001D5D04
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047AA RID: 18346 RVA: 0x001D7B14 File Offset: 0x001D5D14
	public as8() : base(as8.a)
	{
	}

	// Token: 0x060047AB RID: 18347 RVA: 0x001D7B24 File Offset: 0x001D5D24
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x060047AC RID: 18348 RVA: 0x001D7B38 File Offset: 0x001D5D38
	protected override void gg(cyt A_0)
	{
		A_0.r()["npc_fo_leonie_waitingForSteelPlates"] = false;
	}

	// Token: 0x04001CA0 RID: 7328
	public new static readonly string a = "fo_LeonieSteelPlateDelivery";
}
