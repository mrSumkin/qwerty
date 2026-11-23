using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012EE RID: 4846
[eiz("F9")]
[Serializable]
public sealed class eji : Aspect<c5x>, c98
{
	// Token: 0x06006BA5 RID: 27557 RVA: 0x002D34B0 File Offset: 0x002D16B0
	private eji(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (A_0.GetValue("F9:ON", typeof(List<a2y>)) as List<a2y>);
		this.b = (A_0.GetValue("F9:OF", typeof(List<a2y>)) as List<a2y>);
		this.g = A_0.GetDouble("F9:C");
		if (ell.a() >= 477)
		{
			this.d = A_0.GetBoolean("F9:R");
			this.e = A_0.GetInt32("F9:O");
			this.f = A_0.GetInt32("F9:F");
		}
	}

	// Token: 0x06006BA6 RID: 27558 RVA: 0x002D3570 File Offset: 0x002D1770
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("F9:ON", this.c);
		info.AddValue("F9:OF", this.b);
		info.AddValue("F9:C", this.g);
		info.AddValue("F9:R", this.d);
		info.AddValue("F9:O", this.e);
		info.AddValue("F9:F", this.f);
	}

	// Token: 0x06006BA7 RID: 27559 RVA: 0x002D35EC File Offset: 0x002D17EC
	public List<a2y> d()
	{
		return this.b;
	}

	// Token: 0x06006BA8 RID: 27560 RVA: 0x002D35F4 File Offset: 0x002D17F4
	public void b(List<a2y> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006BA9 RID: 27561 RVA: 0x002D3600 File Offset: 0x002D1800
	public List<a2y> b()
	{
		return this.c;
	}

	// Token: 0x06006BAA RID: 27562 RVA: 0x002D3608 File Offset: 0x002D1808
	public void a(List<a2y> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006BAB RID: 27563 RVA: 0x002D3614 File Offset: 0x002D1814
	public bool a()
	{
		return this.d;
	}

	// Token: 0x06006BAC RID: 27564 RVA: 0x002D361C File Offset: 0x002D181C
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006BAD RID: 27565 RVA: 0x002D3628 File Offset: 0x002D1828
	public eji(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006BAE RID: 27566 RVA: 0x002D364C File Offset: 0x002D184C
	public void r7(eds A_0)
	{
		if ((this.g -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			axh aspect = base.a8().GetAspect<axh>();
			if (aspect != null)
			{
				bool flag = aspect.i();
				List<a2y> list = flag ? this.b : this.c;
				if (this.d)
				{
					int num2;
					if (flag)
					{
						int num = this.f + 1;
						this.f = num;
						if (num >= list.Count)
						{
							this.f = 0;
						}
						num2 = this.f;
					}
					else
					{
						int num = this.e + 1;
						this.e = num;
						if (num >= list.Count)
						{
							this.e = 0;
						}
						num2 = this.e;
					}
					if (list.Count > num2)
					{
						this.g = list[num2].a().a();
					}
					else
					{
						this.g = 1000.0;
					}
					aspect.a(null, !flag, null);
					return;
				}
				if (list != null && list.Count > 0)
				{
					double num3 = eji.a.NextDouble();
					for (int i = list.Count - 1; i >= 0; i--)
					{
						if (i == 0 || num3 < list[i].b())
						{
							this.g = list[i].a().a();
							aspect.a(null, !flag, null);
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x04002C2C RID: 11308
	private static Random a = new Random();

	// Token: 0x04002C2D RID: 11309
	private List<a2y> b = new List<a2y>();

	// Token: 0x04002C2E RID: 11310
	private List<a2y> c = new List<a2y>();

	// Token: 0x04002C2F RID: 11311
	private bool d;

	// Token: 0x04002C30 RID: 11312
	private int e;

	// Token: 0x04002C31 RID: 11313
	private int f;

	// Token: 0x04002C32 RID: 11314
	private double g;
}
