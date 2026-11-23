using System;
using System.Runtime.Serialization;

// Token: 0x02000C7B RID: 3195
[eiz("BSIAPDE")]
[Serializable]
public sealed class dss : cd2
{
	// Token: 0x06004821 RID: 18465 RVA: 0x001D96C8 File Offset: 0x001D78C8
	private dss(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004822 RID: 18466 RVA: 0x001D96D4 File Offset: 0x001D78D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004823 RID: 18467 RVA: 0x001D96E0 File Offset: 0x001D78E0
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x001D96F0 File Offset: 0x001D78F0
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x001D9700 File Offset: 0x001D7900
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x001D9710 File Offset: 0x001D7910
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x001D9720 File Offset: 0x001D7920
	public dss() : base(dss.a)
	{
	}

	// Token: 0x06004828 RID: 18472 RVA: 0x001D9730 File Offset: 0x001D7930
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0) && (A_0.v() != null && (A_0.v().b().Zone.y8() == "xpbl_c4" || A_0.v().b().Zone.y8() == "xpbl_d4" || A_0.v().b().Zone.y8() == "xpbl_e4" || A_0.v().b().Zone.y8() == "xpbl_f4" || A_0.v().b().Zone.y8() == "xpbl_g4" || A_0.v().b().Zone.y8() == "xpbl_h1" || A_0.v().b().Zone.y8() == "xpbl_h2" || A_0.v().b().Zone.y8() == "xpbl_h3" || A_0.v().b().Zone.y8() == "xpbl_h4"));
	}

	// Token: 0x06004829 RID: 18473 RVA: 0x001D98A0 File Offset: 0x001D7AA0
	protected override void gg(cyt A_0)
	{
		a72 a = new a72();
		a.b("events\\xpbl\\enteringBlackSeaAlone");
		a.d("player");
		a.c(A_0.v().Name);
		a.ym(A_0.v().b(), null, null);
	}

	// Token: 0x04001CAD RID: 7341
	public new static readonly string a = "blackSeaIntroNarrationAlternativePath";
}
