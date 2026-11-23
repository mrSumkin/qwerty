using System;
using System.Runtime.Serialization;

// Token: 0x020019DD RID: 6621
[eiz("MCEPCCME")]
[Serializable]
public sealed class a7z : cdh, ISerializable, d7s
{
	// Token: 0x06008E2A RID: 36394 RVA: 0x00394C68 File Offset: 0x00392E68
	private a7z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MCEPCCME:M");
	}

	// Token: 0x06008E2B RID: 36395 RVA: 0x00394C84 File Offset: 0x00392E84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCEPCCME:M", this.a);
	}

	// Token: 0x06008E2C RID: 36396 RVA: 0x00394CA0 File Offset: 0x00392EA0
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008E2D RID: 36397 RVA: 0x00394CA8 File Offset: 0x00392EA8
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E2E RID: 36398 RVA: 0x00394CB4 File Offset: 0x00392EB4
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008E2F RID: 36399 RVA: 0x00394CC8 File Offset: 0x00392EC8
	public a7z()
	{
	}

	// Token: 0x06008E30 RID: 36400 RVA: 0x00394CD0 File Offset: 0x00392ED0
	public a7z(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E31 RID: 36401 RVA: 0x00394CE0 File Offset: 0x00392EE0
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Уменьшает шанс критического выстрела из созданных энергетических пистолетов на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Уменьшает шанс критического выстрела из созданных энергетических пистолетов на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008E32 RID: 36402 RVA: 0x00394D54 File Offset: 0x00392F54
	public override d3e b3()
	{
		a7z a7z = new a7z();
		this.xx(a7z);
		return a7z;
	}

	// Token: 0x06008E33 RID: 36403 RVA: 0x00394D70 File Offset: 0x00392F70
	public void cn(d3e A_0)
	{
		a7z a7z = A_0 as a7z;
		if (a7z != null)
		{
			this.a += a7z.a;
		}
	}

	// Token: 0x06008E34 RID: 36404 RVA: 0x00394DA0 File Offset: 0x00392FA0
	public bool co(d3e A_0)
	{
		return A_0 is a7z;
	}

	// Token: 0x06008E35 RID: 36405 RVA: 0x00394DAC File Offset: 0x00392FAC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((a7z)A_0).a = this.a;
	}

	// Token: 0x040037D0 RID: 14288
	private new double a;
}
