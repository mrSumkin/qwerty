using System;
using System.Runtime.Serialization;

// Token: 0x020019F2 RID: 6642
[eiz("BTCMME")]
[Serializable]
public sealed class clu : cdh, ISerializable, d7s
{
	// Token: 0x06008EFE RID: 36606 RVA: 0x00396E4C File Offset: 0x0039504C
	private clu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("BTCMME:M");
	}

	// Token: 0x06008EFF RID: 36607 RVA: 0x00396E68 File Offset: 0x00395068
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BTCMME:M", this.a);
	}

	// Token: 0x06008F00 RID: 36608 RVA: 0x00396E84 File Offset: 0x00395084
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008F01 RID: 36609 RVA: 0x00396E8C File Offset: 0x0039508C
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F02 RID: 36610 RVA: 0x00396E98 File Offset: 0x00395098
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008F03 RID: 36611 RVA: 0x00396EAC File Offset: 0x003950AC
	public clu()
	{
	}

	// Token: 0x06008F04 RID: 36612 RVA: 0x00396EB8 File Offset: 0x003950B8
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Шанс вызвать страх от Жестокости уменьшен на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Шанс вызвать страх от Жестокости увеличен на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008F05 RID: 36613 RVA: 0x00396F2C File Offset: 0x0039512C
	public override d3e b3()
	{
		clu clu = new clu();
		this.xx(clu);
		return clu;
	}

	// Token: 0x06008F06 RID: 36614 RVA: 0x00396F48 File Offset: 0x00395148
	public void cn(d3e A_0)
	{
		clu clu = A_0 as clu;
		if (clu != null)
		{
			this.a += clu.a;
		}
	}

	// Token: 0x06008F07 RID: 36615 RVA: 0x00396F78 File Offset: 0x00395178
	public bool co(d3e A_0)
	{
		return A_0 is clu;
	}

	// Token: 0x06008F08 RID: 36616 RVA: 0x00396F84 File Offset: 0x00395184
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((clu)A_0).a = this.a;
	}

	// Token: 0x040037E7 RID: 14311
	private new double a;
}
