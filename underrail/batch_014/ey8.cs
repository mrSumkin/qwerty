using System;
using System.Runtime.Serialization;

// Token: 0x02000C83 RID: 3203
[eiz("FFEDE")]
[Serializable]
public sealed class ey8 : d4
{
	// Token: 0x0600486C RID: 18540 RVA: 0x001DA1D4 File Offset: 0x001D83D4
	private ey8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600486D RID: 18541 RVA: 0x001DA1E0 File Offset: 0x001D83E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600486E RID: 18542 RVA: 0x001DA1EC File Offset: 0x001D83EC
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600486F RID: 18543 RVA: 0x001DA1FC File Offset: 0x001D83FC
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004870 RID: 18544 RVA: 0x001DA20C File Offset: 0x001D840C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004871 RID: 18545 RVA: 0x001DA21C File Offset: 0x001D841C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004872 RID: 18546 RVA: 0x001DA22C File Offset: 0x001D842C
	public ey8() : base(ey8.a)
	{
	}

	// Token: 0x06004873 RID: 18547 RVA: 0x001DA23C File Offset: 0x001D843C
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x06004874 RID: 18548 RVA: 0x001DA250 File Offset: 0x001D8450
	protected override void gg(cyt A_0)
	{
		A_0.r()["loc_xpbl_camp_allowed"] = false;
	}

	// Token: 0x04001CB6 RID: 7350
	public new static readonly string a = "firedFromExpedition";
}
