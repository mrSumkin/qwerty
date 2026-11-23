using System;
using System.Runtime.Serialization;

// Token: 0x020019D1 RID: 6609
[eiz("VBME")]
[Serializable]
public sealed class awc : cdh, ISerializable, d7s, bdr
{
	// Token: 0x06008DAC RID: 36268 RVA: 0x00393E60 File Offset: 0x00392060
	private awc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("VBME:M");
	}

	// Token: 0x06008DAD RID: 36269 RVA: 0x00393E7C File Offset: 0x0039207C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VBME:M", this.a);
	}

	// Token: 0x06008DAE RID: 36270 RVA: 0x00393E98 File Offset: 0x00392098
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008DAF RID: 36271 RVA: 0x00393EA0 File Offset: 0x003920A0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DB0 RID: 36272 RVA: 0x00393EAC File Offset: 0x003920AC
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008DB1 RID: 36273 RVA: 0x00393EC0 File Offset: 0x003920C0
	public awc()
	{
	}

	// Token: 0x06008DB2 RID: 36274 RVA: 0x00393EC8 File Offset: 0x003920C8
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Уменьшает процент значения навыка, используемого Универсальностью, на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Увеличивает процент значения навыка, используемого Универсальностью, на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008DB3 RID: 36275 RVA: 0x00393F3C File Offset: 0x0039213C
	public override d3e b3()
	{
		awc awc = new awc();
		this.xx(awc);
		return awc;
	}

	// Token: 0x06008DB4 RID: 36276 RVA: 0x00393F58 File Offset: 0x00392158
	public void cn(d3e A_0)
	{
		awc awc = A_0 as awc;
		if (awc != null)
		{
			this.a += awc.a;
		}
	}

	// Token: 0x06008DB5 RID: 36277 RVA: 0x00393F88 File Offset: 0x00392188
	public bool co(d3e A_0)
	{
		return A_0 is awc;
	}

	// Token: 0x06008DB6 RID: 36278 RVA: 0x00393F94 File Offset: 0x00392194
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((awc)A_0).a = this.a;
	}

	// Token: 0x040037C2 RID: 14274
	private new double a;
}
