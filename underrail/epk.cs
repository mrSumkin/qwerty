using System;
using System.Runtime.Serialization;

// Token: 0x020019D9 RID: 6617
[eiz("CTDTOM")]
[Serializable]
public sealed class epk : cdh, ISerializable, d7s
{
	// Token: 0x06008DFE RID: 36350 RVA: 0x00394788 File Offset: 0x00392988
	private epk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("CTDTOM:C");
		this.b = A_0.GetInt32("CTDTOM:D");
	}

	// Token: 0x06008DFF RID: 36351 RVA: 0x003947BC File Offset: 0x003929BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CTDTOM:C", this.a);
		info.AddValue("CTDTOM:D", this.b);
	}

	// Token: 0x06008E00 RID: 36352 RVA: 0x003947E8 File Offset: 0x003929E8
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008E01 RID: 36353 RVA: 0x003947F0 File Offset: 0x003929F0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E02 RID: 36354 RVA: 0x003947FC File Offset: 0x003929FC
	public int b()
	{
		return this.b;
	}

	// Token: 0x06008E03 RID: 36355 RVA: 0x00394804 File Offset: 0x00392A04
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008E04 RID: 36356 RVA: 0x00394810 File Offset: 0x00392A10
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008E05 RID: 36357 RVA: 0x00394824 File Offset: 0x00392A24
	public epk()
	{
	}

	// Token: 0x06008E06 RID: 36358 RVA: 0x00394834 File Offset: 0x00392A34
	public epk(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E07 RID: 36359 RVA: 0x0039484C File Offset: 0x00392A4C
	public override string b2()
	{
		if (this.a > 0.0)
		{
			return string.Format("Увеличивает шанс дезориентировать цель в оружием ближнего боя или рукопашной атакой на {0}% в течение {1}.", Convert.ToInt32(Math.Abs(this.a) * 100.0), l4.a(this.b, false));
		}
		return string.Format("Уменьшает шанс дезориентировать цель в оружием ближнего боя или рукопашной атакой на {0}% в течение {1}.", Convert.ToInt32(Math.Abs(this.a) * 100.0), l4.a(this.b, false));
	}

	// Token: 0x06008E08 RID: 36360 RVA: 0x003948D8 File Offset: 0x00392AD8
	public override d3e b3()
	{
		epk epk = new epk();
		this.xx(epk);
		return epk;
	}

	// Token: 0x06008E09 RID: 36361 RVA: 0x003948F4 File Offset: 0x00392AF4
	public void cn(d3e A_0)
	{
		epk epk = A_0 as epk;
		if (epk != null)
		{
			this.a += epk.a;
		}
	}

	// Token: 0x06008E0A RID: 36362 RVA: 0x00394924 File Offset: 0x00392B24
	public bool co(d3e A_0)
	{
		epk epk = A_0 as epk;
		return epk != null && epk.b == this.b;
	}

	// Token: 0x06008E0B RID: 36363 RVA: 0x00394950 File Offset: 0x00392B50
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		epk epk = (epk)A_0;
		epk.a = this.a;
		epk.b = this.b;
	}

	// Token: 0x040037CB RID: 14283
	private new double a;

	// Token: 0x040037CC RID: 14284
	private int b = 1;
}
