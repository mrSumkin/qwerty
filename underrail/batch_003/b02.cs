using System;
using System.Runtime.Serialization;

// Token: 0x020019F5 RID: 6645
[eiz("JSSME")]
[Serializable]
public sealed class b02 : cdh, ISerializable, d7s
{
	// Token: 0x06008F20 RID: 36640 RVA: 0x0039728C File Offset: 0x0039548C
	private b02(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("JSSME:M");
	}

	// Token: 0x06008F21 RID: 36641 RVA: 0x003972A8 File Offset: 0x003954A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("JSSME:M", this.a);
	}

	// Token: 0x06008F22 RID: 36642 RVA: 0x003972C4 File Offset: 0x003954C4
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008F23 RID: 36643 RVA: 0x003972CC File Offset: 0x003954CC
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F24 RID: 36644 RVA: 0x003972D8 File Offset: 0x003954D8
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008F25 RID: 36645 RVA: 0x003972EC File Offset: 0x003954EC
	public b02()
	{
	}

	// Token: 0x06008F26 RID: 36646 RVA: 0x003972F4 File Offset: 0x003954F4
	public b02(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F27 RID: 36647 RVA: 0x00397308 File Offset: 0x00395508
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Уменьшает устойчивость при пилотировании гидроцикла на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Увеличивает устойчивость при пилотировании гидроцикла на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008F28 RID: 36648 RVA: 0x0039737C File Offset: 0x0039557C
	public override d3e b3()
	{
		b02 b = new b02();
		this.xx(b);
		return b;
	}

	// Token: 0x06008F29 RID: 36649 RVA: 0x00397398 File Offset: 0x00395598
	public void cn(d3e A_0)
	{
		b02 b = A_0 as b02;
		if (b != null)
		{
			this.a += b.a;
		}
	}

	// Token: 0x06008F2A RID: 36650 RVA: 0x003973C8 File Offset: 0x003955C8
	public bool co(d3e A_0)
	{
		return A_0 is b02;
	}

	// Token: 0x06008F2B RID: 36651 RVA: 0x003973D4 File Offset: 0x003955D4
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((b02)A_0).a = this.a;
	}

	// Token: 0x040037EB RID: 14315
	private new double a;
}
