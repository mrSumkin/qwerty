using System;
using System.Runtime.Serialization;

// Token: 0x020019D7 RID: 6615
[eiz("CTDSOM")]
[Serializable]
public sealed class cvl : cdh, ISerializable, d7s
{
	// Token: 0x06008DE4 RID: 36324 RVA: 0x00394478 File Offset: 0x00392678
	private cvl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("CTDSOM:C");
		this.b = A_0.GetInt32("CTDSOM:D");
	}

	// Token: 0x06008DE5 RID: 36325 RVA: 0x003944AC File Offset: 0x003926AC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CTDSOM:C", this.a);
		info.AddValue("CTDSOM:D", this.b);
	}

	// Token: 0x06008DE6 RID: 36326 RVA: 0x003944D8 File Offset: 0x003926D8
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008DE7 RID: 36327 RVA: 0x003944E0 File Offset: 0x003926E0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DE8 RID: 36328 RVA: 0x003944EC File Offset: 0x003926EC
	public int b()
	{
		return this.b;
	}

	// Token: 0x06008DE9 RID: 36329 RVA: 0x003944F4 File Offset: 0x003926F4
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008DEA RID: 36330 RVA: 0x00394500 File Offset: 0x00392700
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008DEB RID: 36331 RVA: 0x00394514 File Offset: 0x00392714
	public cvl()
	{
	}

	// Token: 0x06008DEC RID: 36332 RVA: 0x00394524 File Offset: 0x00392724
	public cvl(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DED RID: 36333 RVA: 0x00394540 File Offset: 0x00392740
	public override string b2()
	{
		if (this.a > 0.0)
		{
			return string.Format("Увеличивает шанс дезориентировать себя оружием ближнего боя или рукопашной атакой на {0}% в течение {1}.", Convert.ToInt32(Math.Abs(this.a) * 100.0), l4.a(this.b, false));
		}
		return string.Format("Уменьшает шанс дезориентировать себя оружием ближнего боя или рукопашной атакой на {0}% в течение {1}.", Convert.ToInt32(Math.Abs(this.a) * 100.0), l4.a(this.b, false));
	}

	// Token: 0x06008DEE RID: 36334 RVA: 0x003945CC File Offset: 0x003927CC
	public override d3e b3()
	{
		cvl cvl = new cvl();
		this.xx(cvl);
		return cvl;
	}

	// Token: 0x06008DEF RID: 36335 RVA: 0x003945E8 File Offset: 0x003927E8
	public void cn(d3e A_0)
	{
		cvl cvl = A_0 as cvl;
		if (cvl != null)
		{
			this.a += cvl.a;
		}
	}

	// Token: 0x06008DF0 RID: 36336 RVA: 0x00394618 File Offset: 0x00392818
	public bool co(d3e A_0)
	{
		cvl cvl = A_0 as cvl;
		return cvl != null && cvl.b == this.b;
	}

	// Token: 0x06008DF1 RID: 36337 RVA: 0x00394644 File Offset: 0x00392844
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		cvl cvl = (cvl)A_0;
		cvl.a = this.a;
		cvl.b = this.b;
	}

	// Token: 0x040037C8 RID: 14280
	private new double a;

	// Token: 0x040037C9 RID: 14281
	private int b = 1;
}
