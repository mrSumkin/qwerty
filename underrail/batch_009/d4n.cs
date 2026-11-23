using System;
using Microsoft.Xna.Framework;

// Token: 0x020011B6 RID: 4534
public sealed class d4n
{
	// Token: 0x06006096 RID: 24726 RVA: 0x002A34E8 File Offset: 0x002A16E8
	public d4n(crp A_0, amc A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06006097 RID: 24727 RVA: 0x002A3500 File Offset: 0x002A1700
	public void c()
	{
		this.a();
	}

	// Token: 0x06006098 RID: 24728 RVA: 0x002A3508 File Offset: 0x002A1708
	public void e()
	{
	}

	// Token: 0x06006099 RID: 24729 RVA: 0x002A350C File Offset: 0x002A170C
	public bool a(float A_0)
	{
		bool result = true;
		double num = this.d -= (double)(A_0 * 10f);
		if (num < 0.0)
		{
			this.d = 0.0;
			this.c += num;
			if (this.c <= 0.0)
			{
				this.c = 0.0;
				result = false;
			}
		}
		double num2 = (double)(1f / this.b.aa().MovementSpeed);
		this.a((double)A_0 * num2 * 10.0, true, false);
		return result;
	}

	// Token: 0x0600609A RID: 24730 RVA: 0x002A35B4 File Offset: 0x002A17B4
	public bool g()
	{
		return this.d + this.c > 0.0;
	}

	// Token: 0x0600609B RID: 24731 RVA: 0x002A35D0 File Offset: 0x002A17D0
	public void a(int A_0, bool A_1 = true)
	{
		if (A_0 > 0)
		{
			this.c -= (double)A_0;
			this.a((double)A_0, A_1, false);
			if (this.c < 0.0)
			{
				this.c = 0.0;
			}
		}
	}

	// Token: 0x0600609C RID: 24732 RVA: 0x002A3620 File Offset: 0x002A1820
	public void b(int A_0, bool A_1 = false)
	{
		double val = this.d;
		double num = this.d -= (double)A_0;
		if (num < 0.0)
		{
			this.d = 0.0;
			if (A_1)
			{
				this.c += num;
				if (this.c <= 0.0)
				{
					this.c = 0.0;
				}
			}
		}
		if (A_1)
		{
			this.a((double)A_0, true, false);
			return;
		}
		this.a(Math.Min(val, (double)A_0), true, false);
	}

	// Token: 0x0600609D RID: 24733 RVA: 0x002A36C0 File Offset: 0x002A18C0
	public void f()
	{
		this.a.ahq(this, true, true, true, null, true);
	}

	// Token: 0x0600609E RID: 24734 RVA: 0x002A36E8 File Offset: 0x002A18E8
	public bool d()
	{
		return this.c == 0.0 && this.d == 0.0;
	}

	// Token: 0x0600609F RID: 24735 RVA: 0x002A3714 File Offset: 0x002A1914
	public r0 b()
	{
		Vector3 vector = this.b.a8().aj();
		ak1 ak = this.b.a8().Area.b((int)vector.X, (int)vector.Y);
		if (ak != null)
		{
			return new r0(ak.Area.c(), new Vector2((float)ak.Location.X, (float)ak.Location.Y));
		}
		return new r0(-1, new Vector2(-1f, -1f));
	}

	// Token: 0x060060A0 RID: 24736 RVA: 0x002A37A0 File Offset: 0x002A19A0
	public void a(bool A_0 = false)
	{
		if (A_0 && this.b != null && this.b.aa().IsInControl && !this.b.aa().SpecialStates.g)
		{
			this.e = Math.Min((double)aiy.q, this.c);
		}
		double num = this.c + Math.Min(this.d, (double)aiy.h);
		if (num > 0.0)
		{
			this.a(num, true, A_0);
		}
		this.c = 0.0;
		this.d = 0.0;
	}

	// Token: 0x060060A1 RID: 24737 RVA: 0x002A3854 File Offset: 0x002A1A54
	internal void h()
	{
		this.c = (double)Convert.ToInt32(this.c);
		this.d = (double)Convert.ToInt32(this.d);
	}

	// Token: 0x060060A2 RID: 24738 RVA: 0x002A3880 File Offset: 0x002A1A80
	private void a()
	{
		this.c = (double)this.b.aa().Offense.n() + this.e;
		this.d = (double)this.b.aa().Offense.m();
		this.f = 0.0;
		this.g = 0.0;
	}

	// Token: 0x060060A3 RID: 24739 RVA: 0x002A38EC File Offset: 0x002A1AEC
	private void a(double A_0, bool A_1 = true, bool A_2 = false)
	{
		this.f += A_0;
		if (A_1 && this.f >= this.g + 10.0)
		{
			double a_ = (this.f - this.g) / 10.0;
			this.a.a(this, a_, A_2);
			this.g = this.f;
		}
	}

	// Token: 0x0400292B RID: 10539
	private crp a;

	// Token: 0x0400292C RID: 10540
	public amc b;

	// Token: 0x0400292D RID: 10541
	public double c;

	// Token: 0x0400292E RID: 10542
	public double d;

	// Token: 0x0400292F RID: 10543
	public double e;

	// Token: 0x04002930 RID: 10544
	private double f;

	// Token: 0x04002931 RID: 10545
	private double g;
}
