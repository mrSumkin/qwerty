using System;

// Token: 0x02000076 RID: 118
public sealed class exd : btm
{
	// Token: 0x0600024E RID: 590 RVA: 0x0000B860 File Offset: 0x00009A60
	public exd(b6d A_0, abr A_1, float A_2, b1g? A_3, bbs? A_4) : base(null)
	{
		czh.a(A_0, "audioManager");
		this.k = A_0;
		this.c = A_2;
		this.d = A_1;
		this.a = A_3;
		this.b = A_4;
	}

	// Token: 0x0600024F RID: 591 RVA: 0x0000B89C File Offset: 0x00009A9C
	protected override bool b4(e6d A_0)
	{
		this.l = 0.0;
		if (this.d != null)
		{
			this.e = this.d.a(0f);
		}
		else
		{
			this.e = null;
			this.i = true;
		}
		this.k.a(this.e);
		this.f = this.k.e();
		if (this.e != null && this.a == null)
		{
			this.a = new b1g?(this.e.b().d().f());
		}
		if (this.b == null)
		{
			if (this.f != null)
			{
				this.b = new bbs?(this.f.b().d().e());
			}
			else
			{
				this.b = new bbs?(bbs.a);
			}
		}
		if (this.k.e() != null)
		{
			bbs? bbs = this.b;
			bbs bbs2 = bbs.a;
			if (bbs.GetValueOrDefault() == bbs2 & bbs != null)
			{
				this.k.e().c();
				this.k.b(null);
				this.j = true;
			}
			else
			{
				this.h = (double)this.f.a() / (double)this.k.adk();
				this.j = false;
			}
		}
		else
		{
			this.j = true;
		}
		if (this.e != null)
		{
			b1g? b1g = this.a;
			b1g b1g2 = b1g.a;
			if (b1g.GetValueOrDefault() == b1g2 & b1g != null)
			{
				this.e.a(this.c * this.e.b().d().a());
				this.i = true;
			}
			else
			{
				this.e.a(0f);
				this.g = (double)(this.c * this.e.b().d().a() / (float)this.k.adk());
				this.i = false;
			}
			this.e.a(this.k);
		}
		return false;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0000BAD8 File Offset: 0x00009CD8
	protected override bool aen(e6d A_0)
	{
		this.l += A_0.a().ElapsedGameTime.TotalMilliseconds;
		if (this.i && this.j)
		{
			this.k.b(this.k.f());
			this.k.a(null);
			return true;
		}
		if (!this.j)
		{
			float num = Math.Max(0f, this.f.a() - (float)(this.h * A_0.a().ElapsedGameTime.TotalMilliseconds));
			this.f.a(num);
			if (num == 0f)
			{
				this.k.e().c();
				this.k.b(null);
				this.j = true;
			}
		}
		if (!this.i && (this.b.GetValueOrDefault() != bbs.b || this.l > (double)Math.Max(0, this.k.adk() - this.k.adm())))
		{
			float num2 = Math.Min(1f, this.e.a() + (float)(this.g * A_0.a().ElapsedGameTime.TotalMilliseconds));
			this.e.a(num2);
			if (num2 >= this.c * this.e.b().d().a())
			{
				this.e.a(this.c * this.e.b().d().a());
				this.i = true;
			}
			this.e.a(this.k);
		}
		return false;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0000BC9C File Offset: 0x00009E9C
	protected override void au7()
	{
		if (!this.j && this.k.e() != null)
		{
			this.k.e().c();
			this.k.b(null);
		}
		if (this.k.f() != null)
		{
			this.k.b(this.k.f());
			this.k.a(null);
		}
	}

	// Token: 0x0400039B RID: 923
	private b1g? a;

	// Token: 0x0400039C RID: 924
	private bbs? b;

	// Token: 0x0400039D RID: 925
	private float c;

	// Token: 0x0400039E RID: 926
	private new abr d;

	// Token: 0x0400039F RID: 927
	private new bxt e;

	// Token: 0x040003A0 RID: 928
	private new bxt f;

	// Token: 0x040003A1 RID: 929
	private new double g;

	// Token: 0x040003A2 RID: 930
	private double h;

	// Token: 0x040003A3 RID: 931
	private bool i;

	// Token: 0x040003A4 RID: 932
	private bool j;

	// Token: 0x040003A5 RID: 933
	private b6d k;

	// Token: 0x040003A6 RID: 934
	private double l;
}
