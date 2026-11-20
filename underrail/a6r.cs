using System;
using System.Runtime.Serialization;

// Token: 0x02000C6D RID: 3181
[eiz("FCACSDE")]
[Serializable]
public sealed class a6r : cd2
{
	// Token: 0x06004790 RID: 18320 RVA: 0x001D797C File Offset: 0x001D5B7C
	private a6r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004791 RID: 18321 RVA: 0x001D7988 File Offset: 0x001D5B88
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004792 RID: 18322 RVA: 0x001D7994 File Offset: 0x001D5B94
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(60.0);
	}

	// Token: 0x06004793 RID: 18323 RVA: 0x001D79A4 File Offset: 0x001D5BA4
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004794 RID: 18324 RVA: 0x001D79B4 File Offset: 0x001D5BB4
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004795 RID: 18325 RVA: 0x001D79C4 File Offset: 0x001D5BC4
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004796 RID: 18326 RVA: 0x001D79D4 File Offset: 0x001D5BD4
	public a6r() : base(a6r.a)
	{
	}

	// Token: 0x06004797 RID: 18327 RVA: 0x001D79E4 File Offset: 0x001D5BE4
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x06004798 RID: 18328 RVA: 0x001D79F8 File Offset: 0x001D5BF8
	protected override void gg(cyt A_0)
	{
		A_0.r()["npc_forger_forgedCACSReady"] = true;
	}

	// Token: 0x04001C9E RID: 7326
	public new static readonly string a = "forgedCACS";
}
