using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020000FD RID: 253
public sealed class exm
{
	// Token: 0x060005F8 RID: 1528 RVA: 0x0001A11C File Offset: 0x0001831C
	public Vector2 a()
	{
		return this.b;
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x0001A124 File Offset: 0x00018324
	public void b(Vector2 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0001A130 File Offset: 0x00018330
	public Vector2 c()
	{
		return this.c;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x0001A138 File Offset: 0x00018338
	public void a(Vector2 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0001A144 File Offset: 0x00018344
	public float b()
	{
		return this.d;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x0001A14C File Offset: 0x0001834C
	public void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x0001A158 File Offset: 0x00018358
	public exm(bbg A_0, Vector2 A_1, Vector2 A_2)
	{
		czh.a(A_0, "config");
		this.e = A_0;
		this.b = A_1;
		this.c = A_2;
		this.f = new Point((int)A_2.X, (int)A_2.Y);
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0001A1A4 File Offset: 0x000183A4
	public p2 a(bde A_0)
	{
		p2 p = new p2();
		p.a(false);
		p.a(this.f);
		float num = this.c.X - this.b.X;
		float num2 = this.c.Y - this.b.Y;
		anl anl = new anl();
		anl.a(A_0);
		anl.a(new ut());
		anl.a(0f);
		anl.a(new Point((int)this.b.X, (int)this.b.Y));
		new Ray(new Vector3(this.b, 0.5f), new Vector3(num, num2, 0f));
		if (anl.d() != this.f && (num != 0f || num2 != 0f))
		{
			int num3 = (int)this.b.X;
			int num4 = (int)this.b.Y;
			double num5 = (double)(Math.Abs(num2) / Math.Abs(num));
			float num6;
			if (num2 == 0f)
			{
				num6 = 0f;
			}
			else if (num2 < 0f)
			{
				num6 = this.b.Y - (float)((int)this.b.Y);
			}
			else
			{
				num6 = 1f - (this.b.Y - (float)((int)this.b.Y));
			}
			float num7;
			if (num == 0f)
			{
				num7 = 0f;
			}
			else if (num < 0f)
			{
				num7 = this.b.X - (float)((int)this.b.X);
			}
			else
			{
				num7 = 1f - (this.b.X - (float)((int)this.b.X));
			}
			float num8 = (float)Math.Pow(num5, 2.0);
			float num9 = (float)Math.Sqrt((double)(1f + num8));
			float num10 = (float)Math.Sqrt((double)(1f + 1f / num8));
			float num11 = (num == 0f) ? float.PositiveInfinity : (num7 * num9);
			float num12 = (num2 == 0f) ? float.PositiveInfinity : (num6 * num10);
			float num13 = num9;
			float num14 = num10;
			int num15 = Math.Sign(num);
			int num16 = Math.Sign(num2);
			do
			{
				if (num11 < num12)
				{
					anl.a(num11);
					num11 += num13;
					num3 += num15;
				}
				else
				{
					anl.a(num12);
					num12 += num14;
					num4 += num16;
				}
				if (num11 >= this.e.b() && num12 >= this.e.b())
				{
					goto IL_313;
				}
				Point a_ = new Point(num3, num4);
				anl.a(a_);
				if (a_ == this.f)
				{
					goto IL_313;
				}
			}
			while (this.a(anl));
			return p;
		}
		if (this.e.d() && !this.a(anl))
		{
			return p;
		}
		IL_313:
		foreach (aue aue in this.e.c())
		{
			if (aue.q8(anl))
			{
				object a_2 = aue.rc(anl);
				p.g().Add(new ig(aue, a_2));
			}
		}
		p.a(true);
		return p;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x0001A544 File Offset: 0x00018744
	public static exm a(bbg A_0, Vector2 A_1, Vector2 A_2)
	{
		return new exm(A_0, A_1, A_2);
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0001A550 File Offset: 0x00018750
	private bool a(anl A_0)
	{
		using (List<ok>.Enumerator enumerator = this.e.a().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.g5(A_0))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x040004C7 RID: 1223
	public const float a = 0f;

	// Token: 0x040004C8 RID: 1224
	private Vector2 b;

	// Token: 0x040004C9 RID: 1225
	private Vector2 c;

	// Token: 0x040004CA RID: 1226
	private float d;

	// Token: 0x040004CB RID: 1227
	private bbg e;

	// Token: 0x040004CC RID: 1228
	private Point f;
}
