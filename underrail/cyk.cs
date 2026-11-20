using System;
using System.Runtime.Serialization;

// Token: 0x020019D8 RID: 6616
[eiz("CATDSME")]
[Serializable]
public sealed class cyk : cdh, ISerializable, d7s
{
	// Token: 0x06008DF2 RID: 36338 RVA: 0x0039466C File Offset: 0x0039286C
	private cyk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("CATDSME:C");
	}

	// Token: 0x06008DF3 RID: 36339 RVA: 0x00394688 File Offset: 0x00392888
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CATDSME:C", this.a);
	}

	// Token: 0x06008DF4 RID: 36340 RVA: 0x003946A4 File Offset: 0x003928A4
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008DF5 RID: 36341 RVA: 0x003946AC File Offset: 0x003928AC
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DF6 RID: 36342 RVA: 0x003946B8 File Offset: 0x003928B8
	public override bool ae5()
	{
		return false;
	}

	// Token: 0x06008DF7 RID: 36343 RVA: 0x003946BC File Offset: 0x003928BC
	public cyk()
	{
	}

	// Token: 0x06008DF8 RID: 36344 RVA: 0x003946C4 File Offset: 0x003928C4
	public cyk(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DF9 RID: 36345 RVA: 0x003946D4 File Offset: 0x003928D4
	public override string b2()
	{
		return string.Format("Увеличивает шанс применить дополнительный эффект складывания при вызове Временного искажения на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008DFA RID: 36346 RVA: 0x00394700 File Offset: 0x00392900
	public override d3e b3()
	{
		cyk cyk = new cyk();
		this.xx(cyk);
		return cyk;
	}

	// Token: 0x06008DFB RID: 36347 RVA: 0x0039471C File Offset: 0x0039291C
	public void cn(d3e A_0)
	{
		cyk cyk = A_0 as cyk;
		if (cyk != null)
		{
			this.a = d05.b(0.0, this.a + cyk.a, 1.0);
		}
	}

	// Token: 0x06008DFC RID: 36348 RVA: 0x00394760 File Offset: 0x00392960
	public bool co(d3e A_0)
	{
		return A_0 is cyk;
	}

	// Token: 0x06008DFD RID: 36349 RVA: 0x0039476C File Offset: 0x0039296C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((cyk)A_0).a = this.a;
	}

	// Token: 0x040037CA RID: 14282
	private new double a;
}
