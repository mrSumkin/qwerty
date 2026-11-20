using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200076D RID: 1901
public sealed class a9k : dzt
{
	// Token: 0x0600301A RID: 12314 RVA: 0x001245FC File Offset: 0x001227FC
	public void v5(cp9 A_0, b3u A_1)
	{
		wj wj = wj.a();
		esj iy;
		if (wj.c())
		{
			iy = new esj(26, 26);
		}
		else
		{
			iy = wj.iy;
		}
		c5x c5x = (c5x)A_1.b.b;
		if (c5x.f)
		{
			c0s b = c5x.u.b;
			if (b != null && b.g() != null)
			{
				e5q e5q = (e5q)A_1.b;
				mv mv = A_1.a as mv;
				if (mv != null)
				{
					ey0.a(mv, e5q);
					Point zero = Point.Zero;
					Point point;
					if (b.i() == dsu.a && (b.g().c == null || !b.g().c.Contains("forceNarration")))
					{
						double num = 1.0 / Math.Pow(1.2, (double)(mv.y - 1f));
						int num2;
						if (b.e() == emw.b)
						{
							num2 = e5q.m - (int)((double)mv.u.c * num * (double)mv.y) - b.g().b.c;
						}
						else
						{
							num2 = e5q.m + (int)((double)mv.u.c * num * (double)mv.y);
						}
						if (c5x.h.b != null && c5x.h.b.g != null && c5x.h.b.g.f != 0)
						{
							double num3 = 1.0 / Math.Pow(1.1, (double)(mv.y - 1f));
							point = new Point(num2 + 10, e5q.o.Value.Y - (int)((double)c5x.h.b.g.f * num3 * (double)mv.y) - b.g().b.d);
						}
						else
						{
							point = new Point(num2 + 10, e5q.i - (int)((float)b.g().b.d * mv.y) - 10);
						}
						if (c5x.h.b != null)
						{
							if (b.e() == emw.b)
							{
								point = d05.a(point, c5x.h.b.g.d, 1f, mv.y, false);
							}
							else
							{
								point = d05.a(point, c5x.h.b.g.c, 1f, mv.y, false);
							}
						}
						Rectangle a_;
						if (wj.c())
						{
							int width = Math.Max(b.g().b.c + 20, iy.c * 2);
							int height = Math.Max(b.g().b.d + 40, iy.d * 2);
							a_ = new Rectangle(point.X - 10, point.Y - 10, width, height);
						}
						else
						{
							int width = Math.Max(b.g().b.c + iy.c, iy.c * 2);
							int height = Math.Max(b.g().b.d + (int)((float)iy.d * 1.5f), iy.d * 2);
							zero = new Point(iy.c / 2, iy.d / 2);
							a_ = new Rectangle(point.X - zero.X, point.Y - zero.Y, width, height);
						}
						if (b.f() != null)
						{
							a_.Y += b.f().Value.Y;
							if (b.e() == emw.b)
							{
								a_.X -= b.f().Value.X;
							}
							else
							{
								a_.X += b.f().Value.X;
							}
						}
						if (wj.c())
						{
							c4o.a(A_0, (b.e() == emw.b) ? ci7.g() : ci7.h(), iy, Point.Zero, a_, Color.White * 0.7f, true, null);
						}
						else
						{
							Texture2D a_2 = A_0.a.us(wj.f, null);
							c4o.a(A_0, a_2, iy, Point.Zero, a_, Color.White * 0.7f, true, new Point?((b.e() == emw.b) ? wj.iz : wj.i0));
						}
					}
					else
					{
						point = new Point(e5q.m - b.g().b.c / 2, e5q.i - b.g().b.d);
					}
					if (b.f() != null)
					{
						point.Y += b.f().Value.Y;
						if (b.e() == emw.b)
						{
							point.X -= b.f().Value.X;
						}
						else
						{
							point.X += b.f().Value.X;
						}
					}
					b.g().a(point, A_0, null, 1f);
				}
			}
		}
	}
}
