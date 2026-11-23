using System;
using System.Runtime.Serialization;

// Token: 0x020019DC RID: 6620
[eiz("MCCPCCME")]
[Serializable]
public sealed class dbb : cdh, ISerializable, d7s
{
	// Token: 0x06008E1E RID: 36382 RVA: 0x00394B04 File Offset: 0x00392D04
	private dbb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MCCPCCME:M");
	}

	// Token: 0x06008E1F RID: 36383 RVA: 0x00394B20 File Offset: 0x00392D20
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCCPCCME:M", this.a);
	}

	// Token: 0x06008E20 RID: 36384 RVA: 0x00394B3C File Offset: 0x00392D3C
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008E21 RID: 36385 RVA: 0x00394B44 File Offset: 0x00392D44
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E22 RID: 36386 RVA: 0x00394B50 File Offset: 0x00392D50
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008E23 RID: 36387 RVA: 0x00394B64 File Offset: 0x00392D64
	public dbb()
	{
	}

	// Token: 0x06008E24 RID: 36388 RVA: 0x00394B6C File Offset: 0x00392D6C
	public dbb(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E25 RID: 36389 RVA: 0x00394B80 File Offset: 0x00392D80
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Уменьшает шанс критического выстрела из созданных химических пистолетов на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Увеличивает шанс критического выстрела из созданных химических пистолетов на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008E26 RID: 36390 RVA: 0x00394BF4 File Offset: 0x00392DF4
	public override d3e b3()
	{
		dbb dbb = new dbb();
		this.xx(dbb);
		return dbb;
	}

	// Token: 0x06008E27 RID: 36391 RVA: 0x00394C10 File Offset: 0x00392E10
	public void cn(d3e A_0)
	{
		dbb dbb = A_0 as dbb;
		if (dbb != null)
		{
			this.a += dbb.a;
		}
	}

	// Token: 0x06008E28 RID: 36392 RVA: 0x00394C40 File Offset: 0x00392E40
	public bool co(d3e A_0)
	{
		return A_0 is dbb;
	}

	// Token: 0x06008E29 RID: 36393 RVA: 0x00394C4C File Offset: 0x00392E4C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dbb)A_0).a = this.a;
	}

	// Token: 0x040037CF RID: 14287
	private new double a;
}
