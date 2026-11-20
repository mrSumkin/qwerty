using System;
using System.Runtime.Serialization;

// Token: 0x020019B3 RID: 6579
[eiz("SSDBME")]
[Serializable]
public sealed class erk : cdh, ISerializable, d7s
{
	// Token: 0x06008CA6 RID: 36006 RVA: 0x00391818 File Offset: 0x0038FA18
	private erk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("SSDBME:M");
	}

	// Token: 0x06008CA7 RID: 36007 RVA: 0x00391834 File Offset: 0x0038FA34
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSDBME:M", this.b);
	}

	// Token: 0x06008CA8 RID: 36008 RVA: 0x00391850 File Offset: 0x0038FA50
	public double a()
	{
		return this.b;
	}

	// Token: 0x06008CA9 RID: 36009 RVA: 0x00391858 File Offset: 0x0038FA58
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008CAA RID: 36010 RVA: 0x00391864 File Offset: 0x0038FA64
	public erk()
	{
	}

	// Token: 0x06008CAB RID: 36011 RVA: 0x00391870 File Offset: 0x0038FA70
	public override string b2()
	{
		if (this.b > 0.0)
		{
			return string.Format("Подсечение даёт {0}% дополнительного урона к вашей следующей атаке Подсечением. Истекает через {1}, если не используется. Складывается до {2} раз.", Convert.ToInt32(Math.Abs(this.b) * 100.0), l4.a(ert.b, false), ert.a);
		}
		return "";
	}

	// Token: 0x06008CAC RID: 36012 RVA: 0x003918D8 File Offset: 0x0038FAD8
	public override d3e b3()
	{
		erk erk = new erk();
		this.xx(erk);
		return erk;
	}

	// Token: 0x06008CAD RID: 36013 RVA: 0x003918F4 File Offset: 0x0038FAF4
	public void cn(d3e A_0)
	{
		erk erk = A_0 as erk;
		if (erk != null)
		{
			this.b += erk.b;
		}
	}

	// Token: 0x06008CAE RID: 36014 RVA: 0x00391924 File Offset: 0x0038FB24
	public bool co(d3e A_0)
	{
		return A_0 is erk;
	}

	// Token: 0x06008CAF RID: 36015 RVA: 0x00391930 File Offset: 0x0038FB30
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((erk)A_0).b = this.b;
	}

	// Token: 0x040037A1 RID: 14241
	public new static readonly int a = 4;

	// Token: 0x040037A2 RID: 14242
	private double b;
}
