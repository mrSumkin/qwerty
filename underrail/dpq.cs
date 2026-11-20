using System;
using System.Runtime.Serialization;

// Token: 0x02000C6E RID: 3182
[eiz("FTIDE")]
[Serializable]
public sealed class dpq : cd2
{
	// Token: 0x0600479A RID: 18330 RVA: 0x001D7A1C File Offset: 0x001D5C1C
	private dpq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600479B RID: 18331 RVA: 0x001D7A28 File Offset: 0x001D5C28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600479C RID: 18332 RVA: 0x001D7A34 File Offset: 0x001D5C34
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(60.0);
	}

	// Token: 0x0600479D RID: 18333 RVA: 0x001D7A44 File Offset: 0x001D5C44
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600479E RID: 18334 RVA: 0x001D7A54 File Offset: 0x001D5C54
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600479F RID: 18335 RVA: 0x001D7A64 File Offset: 0x001D5C64
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060047A0 RID: 18336 RVA: 0x001D7A74 File Offset: 0x001D5C74
	public dpq() : base(dpq.a)
	{
	}

	// Token: 0x060047A1 RID: 18337 RVA: 0x001D7A84 File Offset: 0x001D5C84
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x060047A2 RID: 18338 RVA: 0x001D7A98 File Offset: 0x001D5C98
	protected override void gg(cyt A_0)
	{
		A_0.r()["npc_forger_forgedTicketsReady"] = true;
	}

	// Token: 0x04001C9F RID: 7327
	public new static readonly string a = "forgedTickets";
}
