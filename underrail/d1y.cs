using System;
using System.Runtime.Serialization;

// Token: 0x02001261 RID: 4705
[eiz("XPSEA")]
[a(typeof(bbw))]
[Serializable]
public sealed class d1y : cj4, ISerializable, chb, cmm
{
	// Token: 0x060065DF RID: 26079 RVA: 0x002B5E44 File Offset: 0x002B4044
	private d1y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("XPSEA:D");
		this.b = A_0.GetDouble("XPSEA:C");
	}

	// Token: 0x060065E0 RID: 26080 RVA: 0x002B5E70 File Offset: 0x002B4070
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPSEA:D", this.a);
		info.AddValue("XPSEA:C", this.b);
	}

	// Token: 0x060065E1 RID: 26081 RVA: 0x002B5E9C File Offset: 0x002B409C
	public double b()
	{
		return this.a;
	}

	// Token: 0x060065E2 RID: 26082 RVA: 0x002B5EA4 File Offset: 0x002B40A4
	public void b(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060065E3 RID: 26083 RVA: 0x002B5EB0 File Offset: 0x002B40B0
	public d1y(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060065E4 RID: 26084 RVA: 0x002B5EBC File Offset: 0x002B40BC
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			this.a(A_0.b.TotalMilliseconds);
			return;
		}
		this.a();
	}

	// Token: 0x060065E5 RID: 26085 RVA: 0x002B5EE0 File Offset: 0x002B40E0
	public void c()
	{
		this.a((double)d0u.b);
		this.b = 0.0;
	}

	// Token: 0x060065E6 RID: 26086 RVA: 0x002B5F00 File Offset: 0x002B4100
	private void a(double A_0)
	{
		double a_ = A_0 * this.a / 1000.0;
		this.td(null, a_, true);
		this.a();
	}

	// Token: 0x060065E7 RID: 26087 RVA: 0x002B5F30 File Offset: 0x002B4130
	private void a()
	{
		if (base.a8() != null)
		{
			axh aspect = base.a8().GetAspect<axh>();
			if (aspect != null)
			{
				bool flag = this.s8() > 0.0;
				if (aspect.i() != flag)
				{
					aspect.a(null, flag, null);
				}
			}
		}
	}

	// Token: 0x060065E8 RID: 26088 RVA: 0x002B5F8C File Offset: 0x002B418C
	public void c9(TimeSpan A_0)
	{
		this.a(A_0.TotalMilliseconds);
	}

	// Token: 0x060065E9 RID: 26089 RVA: 0x002B5F9C File Offset: 0x002B419C
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x04002A5C RID: 10844
	private double a;

	// Token: 0x04002A5D RID: 10845
	private double b;
}
