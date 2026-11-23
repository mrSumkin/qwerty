using System;
using System.Runtime.Serialization;

// Token: 0x02000C87 RID: 3207
[eiz("MVDE")]
[Serializable]
public sealed class cxt : cd2
{
	// Token: 0x0600489C RID: 18588 RVA: 0x001DA6A4 File Offset: 0x001D88A4
	private cxt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600489D RID: 18589 RVA: 0x001DA6B0 File Offset: 0x001D88B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600489E RID: 18590 RVA: 0x001DA6BC File Offset: 0x001D88BC
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600489F RID: 18591 RVA: 0x001DA6CC File Offset: 0x001D88CC
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060048A0 RID: 18592 RVA: 0x001DA6DC File Offset: 0x001D88DC
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060048A1 RID: 18593 RVA: 0x001DA6EC File Offset: 0x001D88EC
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x060048A2 RID: 18594 RVA: 0x001DA6FC File Offset: 0x001D88FC
	public cxt() : base(cxt.a)
	{
	}

	// Token: 0x060048A3 RID: 18595 RVA: 0x001DA70C File Offset: 0x001D890C
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0) && (A_0.v() != null && (A_0.v().b().Zone.y8() == "xpbl_mc1" || A_0.v().b().Zone.y8() == "xpbl_mc2"));
	}

	// Token: 0x060048A4 RID: 18596 RVA: 0x001DA780 File Offset: 0x001D8980
	protected override void gg(cyt A_0)
	{
		a72 a = new a72();
		a.b("events\\xpbl\\medicalVisions");
		a.d("vision");
		a.c("Headache");
		a.ym(A_0.v().b(), null, null);
	}

	// Token: 0x04001CBD RID: 7357
	public new static readonly string a = "medicalVisions";
}
