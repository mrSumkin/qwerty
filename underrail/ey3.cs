using System;
using System.Runtime.Serialization;

// Token: 0x02000C82 RID: 3202
[eiz("RSFL12DE")]
[Serializable]
public sealed class ey3 : d4
{
	// Token: 0x06004862 RID: 18530 RVA: 0x001DA134 File Offset: 0x001D8334
	private ey3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004863 RID: 18531 RVA: 0x001DA140 File Offset: 0x001D8340
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004864 RID: 18532 RVA: 0x001DA14C File Offset: 0x001D834C
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x06004865 RID: 18533 RVA: 0x001DA15C File Offset: 0x001D835C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x06004866 RID: 18534 RVA: 0x001DA16C File Offset: 0x001D836C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004867 RID: 18535 RVA: 0x001DA17C File Offset: 0x001D837C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004868 RID: 18536 RVA: 0x001DA18C File Offset: 0x001D838C
	public ey3() : base(ey3.a)
	{
	}

	// Token: 0x06004869 RID: 18537 RVA: 0x001DA19C File Offset: 0x001D839C
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x0600486A RID: 18538 RVA: 0x001DA1B0 File Offset: 0x001D83B0
	protected override void gg(cyt A_0)
	{
		A_0.a(new bw0("xpbl_l12", new cz4(), 1));
	}

	// Token: 0x04001CB5 RID: 7349
	public new static readonly string a = "removeSormirbarenFromL12";
}
