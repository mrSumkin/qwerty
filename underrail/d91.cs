using System;
using System.Runtime.Serialization;

// Token: 0x020019E3 RID: 6627
[eiz("MSPE2")]
[Serializable]
public abstract class d91 : d3e, ISerializable
{
	// Token: 0x06008E6C RID: 36460 RVA: 0x003954E0 File Offset: 0x003936E0
	protected d91(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MSPE2:V");
	}

	// Token: 0x06008E6D RID: 36461 RVA: 0x003954FC File Offset: 0x003936FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSPE2:V", this.a);
	}

	// Token: 0x06008E6E RID: 36462 RVA: 0x00395518 File Offset: 0x00393718
	public double b()
	{
		return this.a;
	}

	// Token: 0x06008E6F RID: 36463 RVA: 0x00395520 File Offset: 0x00393720
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E70 RID: 36464 RVA: 0x0039552C File Offset: 0x0039372C
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008E71 RID: 36465 RVA: 0x00395540 File Offset: 0x00393740
	protected d91()
	{
	}

	// Token: 0x06008E72 RID: 36466 RVA: 0x00395548 File Offset: 0x00393748
	protected d91(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E73 RID: 36467 RVA: 0x00395558 File Offset: 0x00393758
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((d91)A_0).a = this.a;
	}

	// Token: 0x040037D6 RID: 14294
	private new double a;
}
