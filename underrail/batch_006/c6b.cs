using System;
using System.Runtime.Serialization;

// Token: 0x020019DA RID: 6618
[eiz("GKAPCFM")]
[Serializable]
public sealed class c6b : cdh, ISerializable, d7s
{
	// Token: 0x06008E0C RID: 36364 RVA: 0x00394978 File Offset: 0x00392B78
	private c6b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("TKAPCFM:M");
	}

	// Token: 0x06008E0D RID: 36365 RVA: 0x00394994 File Offset: 0x00392B94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TKAPCFM:M", this.a);
	}

	// Token: 0x06008E0E RID: 36366 RVA: 0x003949B0 File Offset: 0x00392BB0
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008E0F RID: 36367 RVA: 0x003949B8 File Offset: 0x00392BB8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E10 RID: 36368 RVA: 0x003949C4 File Offset: 0x00392BC4
	public override bool ae5()
	{
		return this.a > 0;
	}

	// Token: 0x06008E11 RID: 36369 RVA: 0x003949D0 File Offset: 0x00392BD0
	public c6b()
	{
	}

	// Token: 0x06008E12 RID: 36370 RVA: 0x003949D8 File Offset: 0x00392BD8
	public override string b2()
	{
		if (this.a < 0)
		{
			return string.Format("Стоимость очков действия при метании гранат уменьшена на {0}.", Math.Abs(this.a));
		}
		return string.Format("Стоимость очков действия при метании гранат увеличена на {0}.", this.a);
	}

	// Token: 0x06008E13 RID: 36371 RVA: 0x00394A18 File Offset: 0x00392C18
	public override d3e b3()
	{
		c6b c6b = new c6b();
		this.xx(c6b);
		return c6b;
	}

	// Token: 0x06008E14 RID: 36372 RVA: 0x00394A34 File Offset: 0x00392C34
	public void cn(d3e A_0)
	{
		c6b c6b = A_0 as c6b;
		if (c6b != null)
		{
			this.a += c6b.a;
		}
	}

	// Token: 0x06008E15 RID: 36373 RVA: 0x00394A64 File Offset: 0x00392C64
	public bool co(d3e A_0)
	{
		return A_0 is c6b;
	}

	// Token: 0x06008E16 RID: 36374 RVA: 0x00394A70 File Offset: 0x00392C70
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((c6b)A_0).a = this.a;
	}

	// Token: 0x040037CD RID: 14285
	private new int a;
}
