using System;
using System.Runtime.Serialization;

// Token: 0x02000C72 RID: 3186
[eiz("CCTCHIRS")]
[Serializable]
public sealed class bsn : cd2
{
	// Token: 0x060047C5 RID: 18373 RVA: 0x001D7D9C File Offset: 0x001D5F9C
	private bsn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060047C6 RID: 18374 RVA: 0x001D7DA8 File Offset: 0x001D5FA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060047C7 RID: 18375 RVA: 0x001D7DB4 File Offset: 0x001D5FB4
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(2.0);
	}

	// Token: 0x060047C8 RID: 18376 RVA: 0x001D7DC4 File Offset: 0x001D5FC4
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047C9 RID: 18377 RVA: 0x001D7DD4 File Offset: 0x001D5FD4
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047CA RID: 18378 RVA: 0x001D7DE4 File Offset: 0x001D5FE4
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.2);
	}

	// Token: 0x060047CB RID: 18379 RVA: 0x001D7DF4 File Offset: 0x001D5FF4
	public bsn() : base(bsn.a)
	{
	}

	// Token: 0x060047CC RID: 18380 RVA: 0x001D7E04 File Offset: 0x001D6004
	public bsn(bool A_0) : base(bsn.a)
	{
	}

	// Token: 0x060047CD RID: 18381 RVA: 0x001D7E14 File Offset: 0x001D6014
	protected override void gg(cyt A_0)
	{
		A_0.r()["npc_cc_crook_leadingPos"] = 3;
	}

	// Token: 0x04001CA4 RID: 7332
	public new static readonly string a = "CCTchortistReachesSewers";
}
