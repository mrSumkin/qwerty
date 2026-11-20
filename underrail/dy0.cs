using System;
using System.Runtime.Serialization;

// Token: 0x0200190C RID: 6412
[eiz("GBIX")]
[Serializable]
public sealed class dy0 : dj3
{
	// Token: 0x0600881C RID: 34844 RVA: 0x00386328 File Offset: 0x00384528
	private dy0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("GBIX:E", typeof(dbj)) as dbj);
	}

	// Token: 0x0600881D RID: 34845 RVA: 0x00386354 File Offset: 0x00384554
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GBIX:E", this.a);
	}

	// Token: 0x0600881E RID: 34846 RVA: 0x00386370 File Offset: 0x00384570
	public new dbj a()
	{
		return this.a;
	}

	// Token: 0x0600881F RID: 34847 RVA: 0x00386378 File Offset: 0x00384578
	public new void a(dbj A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008820 RID: 34848 RVA: 0x00386384 File Offset: 0x00384584
	public override string tv()
	{
		return "Улучшение";
	}

	// Token: 0x06008821 RID: 34849 RVA: 0x0038638C File Offset: 0x0038458C
	public dy0()
	{
		base.a2().Add(new aia(typeof(cme)));
	}

	// Token: 0x06008822 RID: 34850 RVA: 0x003863B0 File Offset: 0x003845B0
	public override bk3 tw()
	{
		dy0 dy = new dy0();
		this.ai7(dy);
		return dy;
	}

	// Token: 0x06008823 RID: 34851 RVA: 0x003863CC File Offset: 0x003845CC
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		dy0 dy = (dy0)A_0;
		if (this.a != null)
		{
			dy.a = this.a.b();
		}
	}

	// Token: 0x0400366A RID: 13930
	private new dbj a;
}
