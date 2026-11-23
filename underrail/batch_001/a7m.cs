using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x020001B9 RID: 441
public class a7m : dnn
{
	// Token: 0x06000CB3 RID: 3251 RVA: 0x00034334 File Offset: 0x00032534
	public override bool vl()
	{
		return true;
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x00034338 File Offset: 0x00032538
	public override bool vm()
	{
		return true;
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x0003433C File Offset: 0x0003253C
	public override bool vn()
	{
		return true;
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00034340 File Offset: 0x00032540
	public new bool g()
	{
		return this.ab;
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00034348 File Offset: 0x00032548
	public void b(bool A_0)
	{
		this.ab = A_0;
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00034354 File Offset: 0x00032554
	public bool j()
	{
		return this.ae;
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x0003435C File Offset: 0x0003255C
	public void a(bool A_0)
	{
		this.ae = A_0;
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00034368 File Offset: 0x00032568
	static a7m()
	{
		a7m.aq.ScissorTestEnable = true;
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00034384 File Offset: 0x00032584
	public a7m(dbn A_0) : base(A_0)
	{
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00034454 File Offset: 0x00032654
	public override void vo(e6d A_0, cp9 A_1)
	{
		Rectangle scissorRectangle = A_1.c.ScissorRectangle;
		A_1.a();
		RasterizerState rasterizerState = new RasterizerState();
		rasterizerState.ScissorTestEnable = true;
		A_1.c.ScissorRectangle = scissorRectangle;
		this.iu(A_1, SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, rasterizerState);
		this.vs();
		if (base.an9() != null)
		{
			this.al = -Convert.ToInt32((base.an9().t1().X - base.an9().t1().Y) * (float)this.@as.c * this.y);
			this.am = -Convert.ToInt32((base.an9().t1().Y + base.an9().t1().X) * (float)this.@as.d * this.y);
		}
		else
		{
			this.al = 0;
			this.am = 0;
		}
		this.an = (this.h.a == edg.a || this.i.a);
		if (this.f != null && this.f.b())
		{
			if (this.f.d() != null)
			{
				this.z = this.f.d();
			}
			else
			{
				this.z = dr3.a().GetResource<Texture2D>(this.f.e(), null);
			}
		}
		else
		{
			this.z = null;
		}
		this.aa = bpo.GetService<bn8>();
		if (base.m() == null || base.anz() == null || base.an9() == null)
		{
			return;
		}
		this.g += 1L;
		this.n.Clear();
		this.o = 0;
		this.m.Clear();
		this.q.Clear();
		this.u.Clear();
		this.v.Clear();
		this.w.Clear();
		this.y.Clear();
		this.p.Clear();
		foreach (List<a2f> list in this.x.Values)
		{
			list.Clear();
		}
		this.j = base.an9().t3().X + base.an9().t3().Y;
		this.k = (this.j % 2 == 0);
		this.l = base.an9().t3().X - base.an9().t3().Y;
		int num = Convert.ToInt32((this.y - 1f) / 0.5f);
		int num2 = this.ah + num;
		int num3 = this.ai + num;
		int num4 = this.aj + num;
		int num5 = this.ak + num;
		for (int i = -this.d - num2; i < this.d + 4 + num3; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				int num6 = (int)base.an9().t1().Y + i;
				int num7 = (int)base.an9().t1().X + i + j;
				for (int k = -this.c - num4; k < this.c + num5; k++)
				{
					int num8 = num7 + k;
					int num9 = num6 - k;
					this.a(num8, num9, false);
					this.i.a(num8, num9, this.g);
					if (num8 >= 0 && num9 >= 0 && num8 < base.anz().Size.c && num9 < base.anz().Size.d)
					{
						ak1 ak = base.anz().b(num8, num9);
						if (this.an || ak.a(this.c.d))
						{
							if (ak != null && this.h.a(ak.Location.X, ak.Location.Y) != this.g)
							{
								bool flag = false;
								this.b(ak, A_0, A_1);
								if (this.a(ak))
								{
									this.m.Add(ak);
									flag = true;
								}
								bool flag2 = this.b(ak);
								if (!flag)
								{
									if (flag2)
									{
										this.m.Add(ak);
									}
									else
									{
										this.a(ak, A_0, A_1);
										this.h.b(num8, num9, this.g);
										this.a(num8, num9, true);
									}
								}
							}
						}
						else
						{
							this.h.b(num8, num9, this.g);
							this.a(num8, num9, true);
						}
					}
					this.r.Clear();
					this.t.Clear();
					for (int l = 0; l < this.n.Count; l++)
					{
						dj2 dj = this.n[l];
						if (dj.f && dj.g)
						{
							for (int m = dj.c; m < dj.c + dj.e; m++)
							{
								for (int n = dj.b; n < dj.b + dj.d; n++)
								{
									ak1 ak2 = base.anz().b(n, m);
									if (ak2 != null)
									{
										if (this.i.b(ak2.Location.X, ak2.Location.Y) != this.g)
										{
											this.b(ak2, A_0, A_1);
											this.i.a(ak2.Location.X, ak2.Location.Y, this.g);
										}
										if (!this.r.Values.Contains(ak2))
										{
											this.r.Add(ak2, ak2);
										}
										if (this.m.Contains(ak2))
										{
											this.m.Remove(ak2);
										}
									}
								}
							}
							this.t.Add(dj.j, dj.j);
							this.q.Add(dj.j);
							this.n.RemoveAt(l);
							l--;
						}
					}
					b0b b0b = null;
					this.s.Clear();
					int count = this.t.Count;
					for (int num10 = 0; num10 <= this.t.Values.Count; num10++)
					{
						b0b = ((num10 == this.t.Values.Count) ? null : this.t.Values[num10]);
						foreach (ak1 ak3 in this.r.Values)
						{
							if (b0b == null || ak3.c.ContainsKey(b0b))
							{
								a7m.c c;
								this.s.TryGetValue(ak3, out c);
								if (c == null)
								{
									c = new a7m.c();
									this.s[ak3] = c;
								}
								c.a = c.b;
								c.b = b0b;
								if (this.h.b(ak3.Location.X, ak3.Location.Y) != this.g || c.a != null)
								{
									this.a(ak3, A_0, A_1, c.a, c.b);
									this.h.b(ak3.Location.X, ak3.Location.Y, this.g);
									this.a(ak3.Location.X, ak3.Location.Y, true);
								}
								else
								{
									this.a(ak3.Location.X, ak3.Location.Y, false);
								}
							}
						}
						if (b0b != null)
						{
							this.vp(b0b, A_0, A_1, false);
						}
					}
					for (int num11 = 0; num11 < this.m.Count; num11++)
					{
						ak1 ak4 = this.m[num11];
						if (!this.a(ak4))
						{
							this.a(ak4, A_0, A_1);
							this.m.Remove(ak4);
							num11--;
						}
					}
				}
			}
		}
		A_1.a();
		RasterizerState a_ = null;
		A_1.c.SetRenderTarget(null);
		if (scissorRectangle.X != 0 || scissorRectangle.Y != 0)
		{
			a_ = a7m.aq;
			A_1.c.ScissorRectangle = scissorRectangle;
		}
		A_1.b().w3(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, rasterizerState, null);
		this.a(A_1);
		A_1.a();
		A_1.a(a_);
		this.e(A_1);
		this.b(A_1);
		this.d(A_1);
		if (this.i.a && this.i.g)
		{
			this.c(A_1);
		}
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00034E34 File Offset: 0x00033034
	public virtual void iu(cp9 A_0, SpriteSortMode A_1, BlendState A_2, SamplerState A_3, DepthStencilState A_4, RasterizerState A_5)
	{
		A_0.b().w3(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, A_5, null);
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00034E60 File Offset: 0x00033060
	public override void vp(b0b A_0, e6d A_1, cp9 A_2, bool A_3)
	{
		if (!this.i.a && !A_0.g && !A_0.f && this.p.Contains(A_0.qe()))
		{
			float? num = A_0.ajl();
			if (num != null)
			{
				float? num2 = num;
				float num3 = (float)1;
				if (num2.GetValueOrDefault() < num3 & num2 != null)
				{
					return;
				}
			}
		}
		this.p.Add(A_0.qe());
		if ((!this.i.a || !this.i.e) && ((this.h.a == edg.b && !A_0.b(this.c.d)) || A_0.aa))
		{
			return;
		}
		if (!A_0.aa && this.i.f)
		{
			float? num4 = A_0.ajl();
			if (num4 != null && num4.Value < 1f)
			{
				return;
			}
		}
		bool flag = this.an || A_0.c(this.c.d);
		TimeSpan? a_ = null;
		if (flag)
		{
			if (A_0.j != cgy.b && !A_3)
			{
				return;
			}
		}
		else if (this.h.a == edg.c || (this.h.a == edg.b && A_0.j == cgy.c && !A_0.a(this.c.d)))
		{
			return;
		}
		Vector2 a_2 = this.vq(A_0.d.X, A_0.d.Y, A_0.d.Z);
		Vector2? vector = null;
		Color a_3 = this.a(A_0, flag);
		bym bym = this.k.aiy(A_0, this, A_1, new a44(flag, a_, null));
		if (bym != null && bym.c)
		{
			bym.b = A_0;
			bym.f = flag;
			if (bym.d)
			{
				this.e(A_2, bym);
			}
			foreach (a2f a2f in bym.a)
			{
				this.ir(a2f, a_3);
				if (a2f.t && A_0.d.Z != 0f)
				{
					if (vector == null)
					{
						vector = new Vector2?(this.vq(A_0.d.X, A_0.d.Y, 0f));
					}
					this.a(a2f, vector.Value);
				}
				else
				{
					this.a(a2f, a_2);
				}
				this.b(a2f);
				if (a2f.u != null)
				{
					List<a2f> list;
					if (!this.x.TryGetValue(a2f.u, out list))
					{
						list = new List<a2f>();
						this.x[a2f.u] = list;
					}
					list.Add(a2f);
				}
				else if (a2f.o && !this.w.Contains(a2f))
				{
					this.w.Add(a2f);
				}
				else
				{
					this.a(A_2, a2f, false, this);
				}
			}
			if (bym.d)
			{
				this.d(A_2, bym);
			}
			if (bym.e && !Enumerable.Contains<bym>(this.u, bym, a7m.b.a))
			{
				this.u.Add(bym);
			}
			if (this.i.a && this.i.g)
			{
				using (IEnumerator<cn7> enumerator2 = bym.b.Aspects.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current is bz2)
						{
							this.v.Add(bym);
							break;
						}
					}
				}
			}
			foreach (a2f a2f2 in bym.a)
			{
				a2f2.a();
			}
		}
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00035328 File Offset: 0x00033528
	public static Rectangle a(a2f A_0)
	{
		return A_0.m;
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00035330 File Offset: 0x00033530
	public override Vector2 vq(float A_0, float A_1, float A_2)
	{
		float num = (float)(this.b.X + Convert.ToInt32(Math.Ceiling((double)((A_0 - A_1) * (float)this.@as.c * this.y))));
		int num2 = this.b.Y + Convert.ToInt32(Math.Ceiling((double)(((A_1 + A_0) * (float)this.@as.d - A_2 * (float)this.ad) * this.y)));
		return new Vector2(num + (float)this.al, (float)(num2 + this.am));
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x000353BC File Offset: 0x000335BC
	public Point a(float A_0, float A_1, float A_2)
	{
		return this.vq(A_0, A_1, A_2).a();
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x000353D0 File Offset: 0x000335D0
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (base.anz() != null)
		{
			bag bag = this.c;
			long a_ = (bag != null) ? bag.d : 1L;
			float num = Convert.ToSingle(A_0.a().ElapsedGameTime.TotalSeconds * 3.0);
			float num2 = Convert.ToSingle(A_0.a().ElapsedGameTime.TotalSeconds * 3.0);
			bool flag = this.h.a == edg.b;
			bool flag2 = !flag;
			int count = base.anz().c.Count;
			List<b0b> list = base.anz().c;
			for (int i = 0; i < count; i++)
			{
				b0b b0b = list[i];
				bool flag4;
				bool flag3 = flag4 = (!flag || b0b.c(a_));
				if (!flag4)
				{
					flag4 = (!flag || (flag && b0b.b(a_)));
				}
				if (flag3)
				{
					if (b0b.ad < 0f)
					{
						b0b.ad = 1f;
					}
					else
					{
						b0b.ad = Math.Min(1f, b0b.ad + num2);
					}
				}
				else
				{
					b0b.ad = Math.Max(0f, b0b.ad - num2);
				}
				if (flag4)
				{
					if (flag2 || b0b.ac < 0f)
					{
						b0b.ac = 1f;
					}
					else
					{
						b0b.ac = Math.Min(1f, b0b.ac + num);
					}
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x00035598 File Offset: 0x00033798
	public override void ag5(e6d A_0)
	{
		if (!euz.DesignMode)
		{
			if (base.anz() == null)
			{
				base.c(null);
				base.b(null);
				return;
			}
			base.ag5(A_0);
			if (this.d != null)
			{
				this.a();
			}
			this.a(A_0.b().X, A_0.b().Y);
			if (this.ag != null)
			{
				d1a service = bpo.GetService<d1a>();
				if (service != null)
				{
					service.abb(d05.a(base.at(), this.ag.Value, false));
				}
			}
		}
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x0003563C File Offset: 0x0003383C
	public override ICollection<b0b> vr(Point A_0)
	{
		HashSet<b0b> hashSet = new HashSet<b0b>();
		for (int i = this.y.Count - 1; i >= 0; i--)
		{
			cy5 cy = this.y[i];
			if (!hashSet.Contains(cy.a.n.b) && this.a(cy.a, A_0))
			{
				hashSet.Add(cy.a.n.b);
			}
		}
		return hashSet;
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x000356BC File Offset: 0x000338BC
	public void a(ane A_0, bool A_1)
	{
		if (this.d != null && this.d.a())
		{
			if (A_0.a == this.at)
			{
				this.f.d(A_1);
				return;
			}
			if (A_0.a == this.au)
			{
				this.f.a(A_1);
				return;
			}
			if (A_0.a == this.av)
			{
				this.f.c(A_1);
				return;
			}
			if (A_0.a == this.aw)
			{
				this.f.b(A_1);
			}
		}
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x0003575C File Offset: 0x0003395C
	public new void i()
	{
		this.f.c();
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0003576C File Offset: 0x0003396C
	public new void h()
	{
		this.af = false;
		this.ag = null;
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00035784 File Offset: 0x00033984
	protected virtual bool @is(b0b A_0, ak1 A_1)
	{
		return false;
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00035788 File Offset: 0x00033988
	private bool b(ak1 A_0)
	{
		bool result = false;
		foreach (b0b b0b in A_0.c.Values)
		{
			if ((b0b.l.Count > 1 || b0b.x) && !this.q.Contains(b0b) && !this.a(b0b))
			{
				dj2 dj = default(dj2);
				int num = this.o;
				this.o = num + 1;
				dj.a = num;
				Point point;
				Point point2;
				b0b.a(out point, out point2);
				int num2 = point2.X;
				int num3 = point2.Y;
				if (b0b.x)
				{
					if (point2.X == point.X)
					{
						ak1 ak = A_0.Area.b(num2 + 1, num3);
						if (ak != null && !this.@is(b0b, ak))
						{
							point2.X++;
						}
					}
					if (point2.Y == point.Y)
					{
						ak1 ak2 = A_0.Area.b(num2, num3 + 1);
						if (ak2 != null && !this.@is(b0b, ak2))
						{
							point2.Y++;
						}
					}
				}
				Point point3 = new Point(point.X - 1, point2.Y + 1);
				Point point4 = new Point(point2.X + 1, point.Y - 1);
				dj.d = point4.X - point3.X - 1;
				dj.e = point3.Y - point4.Y - 1;
				int num4 = point3.X + point3.Y;
				int num5 = point4.X + point4.Y;
				int num6 = (num5 % 2 == ((!this.k) ? 1 : 0)) ? this.l : (this.l + 1);
				int num7 = (num4 % 2 == ((!this.k) ? 1 : 0)) ? this.l : (this.l + 1);
				Point point5 = new Point((num4 - num7) / 2 + num7, (num4 - num7) / 2);
				Point point6 = new Point((num5 - num6) / 2 + num6, (num5 - num6) / 2);
				if (point3.X < point5.X - (this.c - 1))
				{
					int num8 = (num4 % 2 == ((!this.k) ? 1 : 0)) ? (this.l + 1) : this.l;
					Point point7 = new Point((num4 - 1 - num8) / 2 + num8, (num4 - 1 - num8) / 2);
					point3 = new Point(point7.X + (this.c - 2), point7.Y - (this.c - 2));
					num4 = point3.X + point3.Y;
				}
				else if (point3.X > point5.X + (this.c - 1))
				{
					int num9 = (num4 % 2 == ((!this.k) ? 1 : 0)) ? (this.l + 1) : this.l;
					Point point8 = new Point((num4 + 1 - num9) / 2 + num9, (num4 + 1 - num9) / 2);
					point3 = new Point(point8.X - (this.c - 2), point8.Y + (this.c - 2));
					num4 = point3.X + point3.Y;
				}
				if (point4.X < point6.X - (this.c - 1))
				{
					int num10 = (num5 % 2 == ((!this.k) ? 1 : 0)) ? (this.l + 1) : this.l;
					Point point9 = new Point((num5 - 1 - num10) / 2 + num10, (num5 - 1 - num10) / 2);
					point4 = new Point(point9.X + (this.c - 2), point9.Y - (this.c - 2));
					num5 = point4.X + point4.Y;
				}
				else if (point4.X > point6.X + (this.c - 1))
				{
					int num11 = (num5 % 2 == ((!this.k) ? 1 : 0)) ? (this.l + 1) : this.l;
					Point point10 = new Point((num5 + 1 - num11) / 2 + num11, (num5 + 1 - num11) / 2);
					point4 = new Point(point10.X - (this.c - 2), point10.Y + (this.c - 2));
					num5 = point4.X + point4.Y;
				}
				dj.b = point.X;
				dj.c = point.Y;
				dj.j = b0b;
				dj.h = point3;
				dj.i = point4;
				dj.f = (this.i.b(point3.X, point3.Y) == this.g && !this.a(dj, point3.X, point3.Y));
				dj.g = (this.i.b(point4.X, point4.Y) == this.g && !this.a(dj, point4.X, point4.Y));
				if (num4 < this.j - this.d * 2 || num4 > this.j + this.d * 2 + 4)
				{
					dj.f = true;
				}
				if (num5 < this.j - this.d * 2 || num5 > this.j + this.d * 2 + 4)
				{
					dj.g = true;
				}
				this.n.Add(dj);
				result = true;
				if (b0b.x)
				{
					for (int i = point.Y; i <= point2.Y; i++)
					{
						for (int j = point.X; j <= point2.X; j++)
						{
							if (A_0.Location.X != j || A_0.Location.Y != i)
							{
								ak1 ak3 = base.anz().b(j, i);
								if (ak3 != null)
								{
									this.b(ak3);
								}
							}
						}
					}
				}
				else
				{
					foreach (ak1 ak4 in b0b.l)
					{
						if (ak4 != A_0)
						{
							this.b(ak4);
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00035E9C File Offset: 0x0003409C
	private bool a(b0b A_0)
	{
		using (List<dj2>.Enumerator enumerator = this.n.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.j == A_0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00035F04 File Offset: 0x00034104
	private void a(int A_0, int A_1, bool A_2)
	{
		for (int i = 0; i < this.n.Count; i++)
		{
			dj2 dj = this.n[i];
			bool flag = false;
			if (dj.h.X == A_0 && dj.h.Y == A_1)
			{
				dj.f |= (A_2 || !this.a(dj, A_0, A_1));
				flag = true;
			}
			if (dj.i.X == A_0 && dj.i.Y == A_1)
			{
				dj.g |= (A_2 || !this.a(dj, A_0, A_1));
				flag = true;
			}
			if (flag)
			{
				this.n[i] = dj;
			}
		}
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00035FE0 File Offset: 0x000341E0
	private bool a(dj2 A_0, int A_1, int A_2)
	{
		float num = base.anz().Playfield.Schema.a().b();
		bool result = false;
		foreach (dj2 dj in this.n)
		{
			if (A_0.a != dj.a)
			{
				BoundingBox boundingBox = new BoundingBox(new Vector3((float)A_0.b + num, (float)A_0.c + num, 0f), new Vector3((float)(A_0.b + A_0.d) - num, (float)(A_0.c + A_0.e) - num, 0f));
				BoundingBox box = new BoundingBox(new Vector3((float)dj.b + num, (float)dj.c + num, 0f), new Vector3((float)(dj.b + dj.d) - num, (float)(dj.c + dj.e) - num, 0f));
				if (!boundingBox.Intersects(box) && A_1 >= dj.b && A_2 >= dj.c && A_1 < dj.b + dj.d && A_2 < dj.c + dj.e && dj.b < A_0.b + A_0.d && dj.c < A_0.c + A_0.e)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00036190 File Offset: 0x00034390
	private bool a(ak1 A_0)
	{
		for (int i = 0; i < this.n.Count; i++)
		{
			dj2 dj = this.n[i];
			if (A_0.b.X >= dj.b && A_0.b.Y >= dj.c)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x000361F4 File Offset: 0x000343F4
	private void b(ak1 A_0, e6d A_1, cp9 A_2)
	{
		IList<b0b> values = A_0.c.Values;
		int count = values.Count;
		for (int i = 0; i < count; i++)
		{
			b0b b0b = values[i];
			if ((b0b.f || b0b.g) && b0b.l.Count == 1)
			{
				this.vp(b0b, A_1, A_2, false);
			}
		}
		this.b(A_2, A_0);
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00036264 File Offset: 0x00034464
	private void b(cp9 A_0, ak1 A_1)
	{
		if (this.z != null)
		{
			this.a(A_1, A_0);
		}
		this.a(A_0, A_1);
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00036284 File Offset: 0x00034484
	private void a(ak1 A_0, cp9 A_1)
	{
		Vector2 vector = this.vq((float)A_0.Location.X, (float)A_0.Location.Y, 0f);
		if (this.aa != null && this.aa.a(A_1, this.z, vector, this.y, A_0))
		{
			return;
		}
		Color a_;
		if (A_0.c.Count > 0)
		{
			a_ = this.f.a();
		}
		else
		{
			a_ = this.f.c();
		}
		A_1.b().w7(this.z, vector, new Rectangle?(new Rectangle(0, 0, this.@as.c * 2, this.@as.d * 2)), a_, 0f, Vector2.Zero, this.y, SpriteEffects.None, 0f);
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00036360 File Offset: 0x00034560
	private void a(ak1 A_0, e6d A_1, cp9 A_2)
	{
		for (int i = 0; i < A_0.c.Values.Count; i++)
		{
			b0b b0b = A_0.c.Values[i];
			if (!b0b.f && !b0b.g && b0b.l.Count == 1)
			{
				this.vp(b0b, A_1, A_2, false);
			}
		}
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x000363D0 File Offset: 0x000345D0
	private void a(ak1 A_0, e6d A_1, cp9 A_2, b0b A_3, b0b A_4)
	{
		bool flag = A_3 == null;
		bool flag2 = false;
		foreach (b0b b0b in A_0.c.Values)
		{
			if (flag2)
			{
				break;
			}
			if (flag && !b0b.f && !b0b.g && b0b.l.Count == 1 && !b0b.x)
			{
				this.vp(b0b, A_1, A_2, false);
			}
			if (b0b == A_3)
			{
				flag = true;
			}
			if (b0b == A_4)
			{
				flag2 = true;
			}
		}
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00036490 File Offset: 0x00034690
	private void a(cp9 A_0, a2f A_1, bool A_2, bkx A_3)
	{
		A_1.f3(A_0, A_3);
		if (!A_2 && A_1.q)
		{
			A_1.f4();
			this.w.Add(A_1);
			this.y.Add(new cy5(A_1, false));
			return;
		}
		if (A_1.p != dm6.a)
		{
			this.y.Add(new cy5(A_1, A_2));
		}
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x000364FC File Offset: 0x000346FC
	private Color a(b0b A_0, bool A_1)
	{
		if (this.i.a)
		{
			float scale = 1f;
			if (this.i.d && !A_0.f && !A_0.g)
			{
				scale = 0.4f;
			}
			if (this.i.c >= 0)
			{
				if (A_0.Layer == this.i.c)
				{
					return Color.White * scale;
				}
				return new Color(75, 75, 75, 255) * scale;
			}
			else if (!this.i.b)
			{
				return Color.White * scale;
			}
		}
		if (!A_1 && this.h.a != edg.a)
		{
			Color result = A_0.a(this.c);
			if (!this.ar)
			{
				result.R = (byte)((float)result.R * this.h.b);
				result.G = (byte)((float)result.G * this.h.b);
				result.B = (byte)((float)result.B * this.h.b);
			}
			return result;
		}
		return A_0.ap();
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x0003663C File Offset: 0x0003483C
	protected virtual void ir(a2f A_0, Color A_1)
	{
		Vector4 vector;
		if (A_0.e == null)
		{
			vector = Vector4.One;
		}
		else
		{
			vector = A_0.e.Value.ToVector4();
		}
		Vector4 vector2 = A_1.ToVector4();
		vector = new Vector4(vector.X * Math.Min(1f, (A_0.f + vector2.X * (1f - A_0.f)) * A_0.g), vector.Y * Math.Min(1f, (A_0.f + vector2.Y * (1f - A_0.f)) * A_0.g), vector.Z * Math.Min(1f, (A_0.f + vector2.Z * (1f - A_0.f)) * A_0.g), vector.W * Math.Min(1f, A_0.f + vector2.W * (1f - A_0.f)));
		A_0.e = new Color?(new Color(vector));
		if (A_0.h != null)
		{
			A_0.e = new Color?(A_0.e.Value * A_0.h.Value);
		}
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00036790 File Offset: 0x00034990
	protected virtual void a(a2f A_0, Vector2 A_1)
	{
		if (A_0 != null && A_0.d != null)
		{
			A_0.d.aco(A_1, this.y, this.@as);
		}
		if (this.y == 1f)
		{
			int width = (int)((float)A_0.c.Width * A_0.l.X);
			int height = (int)((float)A_0.c.Height * A_0.l.Y);
			A_0.m = new Rectangle((int)(A_1.X + (float)this.@as.c - (A_0.j.X + (float)this.@as.c) * A_0.l.X), (int)(A_1.Y + (float)this.@as.d - (A_0.j.Y + (float)this.@as.d) * A_0.l.Y), width, height);
		}
		else
		{
			float num = A_0.l.X * this.y;
			float num2 = A_0.l.Y * this.y;
			int width2 = (int)((float)A_0.c.Width * num);
			int height2 = (int)((float)A_0.c.Height * num2);
			A_0.m = new Rectangle((int)(A_1.X + (float)this.@as.c * this.y - (A_0.j.X + (float)this.@as.c) * num), (int)(A_1.Y + (float)this.@as.d * this.y - (A_0.j.Y + (float)this.@as.d) * num2), width2, height2);
		}
		if (A_0.d != null)
		{
			a2f[] array = A_0.d.acn();
			if (array != null && array.Length != 0)
			{
				foreach (a2f a2f in array)
				{
					if (a2f != null)
					{
						this.a(a2f, A_1);
					}
				}
			}
		}
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x000369AC File Offset: 0x00034BAC
	protected virtual void b(a2f A_0)
	{
		if (this.q.Count > 0)
		{
			for (int i = 0; i < this.q.Count; i++)
			{
				this.q[i].a(new at9(this, A_0));
			}
		}
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x000369FC File Offset: 0x00034BFC
	protected new virtual void e(cp9 A_0, bym A_1)
	{
		foreach (dzt dzt in this.l)
		{
			dzt.v5(A_0, new b3u(this, A_1));
		}
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00036A58 File Offset: 0x00034C58
	protected new virtual void d(cp9 A_0, bym A_1)
	{
		foreach (dzt dzt in this.m)
		{
			dzt.v5(A_0, new b3u(this, A_1));
		}
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00036AB4 File Offset: 0x00034CB4
	private new void c(cp9 A_0, bym A_1)
	{
		foreach (dzt dzt in this.n)
		{
			dzt.v5(A_0, new b3u(this, A_1));
		}
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x00036B10 File Offset: 0x00034D10
	private void b(cp9 A_0, bym A_1)
	{
		foreach (dzt dzt in this.o)
		{
			dzt.v5(A_0, new b3u(this, A_1));
		}
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00036B6C File Offset: 0x00034D6C
	private new void e(cp9 A_0)
	{
		foreach (bym a_ in this.u)
		{
			this.c(A_0, a_);
		}
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x00036BC8 File Offset: 0x00034DC8
	private new void d(cp9 A_0)
	{
		foreach (bym a_ in this.u)
		{
			this.b(A_0, a_);
		}
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x00036C24 File Offset: 0x00034E24
	private new void c(cp9 A_0)
	{
		foreach (bym a_ in this.v)
		{
			this.a(A_0, a_);
		}
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00036C80 File Offset: 0x00034E80
	private void a(cp9 A_0, bym A_1)
	{
		List<KeyValuePair<string, Color>> list = new List<KeyValuePair<string, Color>>();
		foreach (cn7 cn in A_1.b.Aspects)
		{
			bz2 bz = cn as bz2;
			if (bz != null)
			{
				KeyValuePair<string, Color>[] array = bz.avu();
				if (array != null)
				{
					list.AddRange(array);
				}
			}
		}
		if (list.Count > 0)
		{
			SpriteFont resource = A_0.a.GetResource<SpriteFont>("Fonts\\C10sb", null);
			if (resource != null)
			{
				int num = Enumerable.Min<a2f>(A_1.a, new Func<a2f, int>(a7m.a.a.a));
				int num2 = Enumerable.Min<a2f>(A_1.a, new Func<a2f, int>(a7m.a.a.b));
				for (int i = 0; i < list.Count; i++)
				{
					Vector2 a_ = new Vector2((float)num, (float)(num2 + i * resource.LineSpacing));
					A_0.b().xb(resource, list[i].Key, a_, list[i].Value);
				}
			}
		}
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00036DE8 File Offset: 0x00034FE8
	private void b(cp9 A_0)
	{
		Rectangle scissorRectangle = A_0.c.ScissorRectangle;
		bool flag = false;
		foreach (KeyValuePair<string, List<a2f>> keyValuePair in this.x)
		{
			if (keyValuePair.Value.Count > 0)
			{
				cmk cmk = b6l.a(keyValuePair.Key);
				if (cmk != null)
				{
					Effect effect = cmk.d3(A_0.a, this);
					if (effect != null)
					{
						if (!flag)
						{
							A_0.a();
							flag = true;
						}
						if (scissorRectangle.X != 0 || scissorRectangle.Y != 0)
						{
							RasterizerState a_ = a7m.aq;
							A_0.c.ScissorRectangle = scissorRectangle;
							A_0.b().w3(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, a_, effect);
						}
						else
						{
							A_0.b().w3(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone, effect);
						}
						foreach (a2f a_2 in keyValuePair.Value)
						{
							cmk.d4(effect, a_2, this);
							this.a(A_0, a_2, true, this);
						}
						A_0.b().an();
					}
				}
			}
		}
		if (flag)
		{
			RasterizerState a_3 = null;
			if (scissorRectangle.X != 0 || scissorRectangle.Y != 0)
			{
				a_3 = a7m.aq;
				A_0.c.ScissorRectangle = scissorRectangle;
			}
			A_0.a(a_3);
		}
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00036FC0 File Offset: 0x000351C0
	private void a(cp9 A_0)
	{
		foreach (a2f a_ in this.w)
		{
			this.a(A_0, a_, true, this);
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x0003701C File Offset: 0x0003521C
	private void a(cp9 A_0, ak1 A_1)
	{
		foreach (cgr cgr in this.p)
		{
			cgr.tu(A_0, new cz6(this, A_1));
		}
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x00037078 File Offset: 0x00035278
	private b0b a(int A_0, int A_1, out bool A_2)
	{
		b0b b0b = null;
		A_2 = false;
		int num;
		int num2;
		int num3;
		if (this.ac)
		{
			num = 0;
			num2 = this.y.Count;
			num3 = 1;
		}
		else
		{
			num = this.y.Count - 1;
			num2 = -1;
			num3 = -1;
		}
		for (int num4 = num; num4 != num2; num4 += num3)
		{
			cy5 cy = this.y[num4];
			a2f a2f = cy.a;
			if (this.a(a2f, new Point(A_0, A_1)))
			{
				if (a2f.p == dm6.b)
				{
					if (b0b == null || !cy.b || cy.a.r)
					{
						b0b = a2f.n.b;
						A_2 = true;
						if (!cy.b)
						{
							break;
						}
						if (cy.a.r)
						{
							break;
						}
					}
				}
				else if (a2f.p == dm6.c && this.g.a() == brh.b)
				{
					A_2 = true;
					break;
				}
			}
		}
		return b0b;
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00037188 File Offset: 0x00035388
	private bool a(a2f A_0, Point A_1)
	{
		cne service = bpo.GetService<cne>();
		if (A_0.d == null)
		{
			return false;
		}
		float num = A_0.l.X * this.y;
		float num2 = A_0.l.Y * this.y;
		Rectangle rectangle = a7m.a(A_0);
		if (A_1.X >= rectangle.Left && A_1.X < rectangle.Right && A_1.Y >= rectangle.Top && A_1.Y < rectangle.Bottom)
		{
			int num3 = A_1.X - rectangle.Left;
			int num4 = A_1.Y - rectangle.Top;
			Rectangle rectangle2 = new Rectangle(A_0.c.X + Convert.ToInt32((float)num3 / num), A_0.c.Y + Convert.ToInt32((float)num4 / num2), 1, 1);
			if (rectangle2.X < A_0.d.a().Width && rectangle2.Y < A_0.d.a().Height)
			{
				Color[] array = new Color[1];
				try
				{
					if (this.ao)
					{
						if (service != null)
						{
							ecg ecg = service.u0(A_0.d.a());
							if (ecg != null && !ecg.a)
							{
								if (ecg.a(rectangle2.X, rectangle2.Y))
								{
									return true;
								}
								return false;
							}
						}
						return false;
					}
					A_0.d.a().GetData<Color>(0, new Rectangle?(rectangle2), array, 0, 1);
				}
				catch
				{
				}
				if (array[0] != epu.a && array[0] != epu.b)
				{
					return true;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00037388 File Offset: 0x00035588
	private Vector2 b(int A_0, int A_1)
	{
		int num = (int)((float)(this.@as.c * 2) * this.y);
		int num2 = (int)((float)(this.@as.d * 2) * this.y);
		Point point = base.at();
		Point point2 = new Point(A_0 - point.X, A_1 - point.Y);
		Point point3 = new Point((int)base.an9().t1().X, (int)base.an9().t1().Y);
		Point point4 = this.a((float)point3.X, (float)point3.Y, 0f);
		int num3 = Convert.ToInt32((float)(point2.X - (point4.X + num / 2)) / (float)num);
		int num4 = Convert.ToInt32((float)(point2.Y - (point4.Y + num2 / 2)) / (float)num2);
		Point point5 = new Point(point3.X + num3 + num4, point3.Y - num3 + num4);
		Point a_ = this.a((float)point5.X, (float)point5.Y, 0f);
		Point point6 = d05.a(point2, a_, true);
		Point zero = Point.Zero;
		int num5 = num2 / 2 - point6.Y;
		int num6 = num / 2 - point6.X;
		if (num6 != 0 && num5 != 0 && (float)Math.Abs(num5) > (float)(num / 2 - Math.Abs(num6)) / this.a)
		{
			if (num5 > 0)
			{
				if (num6 > 0)
				{
					zero = new Point(-1, 0);
				}
				else
				{
					zero = new Point(0, -1);
				}
			}
			else if (num6 > 0)
			{
				zero = new Point(0, 1);
			}
			else
			{
				zero = new Point(1, 0);
			}
		}
		Point point7 = d05.a(point5, zero, false);
		Point a_2 = this.a((float)point7.X, (float)point7.Y, 0f);
		Point point8 = d05.a(point2, a_2, true);
		float num7 = (float)point7.X - 0.5f + (float)point8.Y / (float)num2 + (float)point8.X / (float)num;
		float num8 = (float)point7.Y + 0.5f + (float)point8.Y / (float)num2 - (float)point8.X / (float)num;
		return new Vector2(num7, num8);
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x000375C8 File Offset: 0x000357C8
	private ak1 a(Vector2 A_0)
	{
		Point point = new Point((int)Math.Floor((double)A_0.X), (int)Math.Floor((double)A_0.Y));
		if (point.X >= 0 && point.Y >= 0 && point.X < base.anz().Size.c && point.Y < base.anz().Size.d)
		{
			return base.anz().b(point.X, point.Y);
		}
		return null;
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00037660 File Offset: 0x00035860
	private void a(int A_0, int A_1)
	{
		ak1 a_ = null;
		b0b a_2 = null;
		bool flag = false;
		if (this.IsMousedOver || this.ab)
		{
			this.u = this.b(A_0, A_1);
			if (this.g.a() != brh.a)
			{
				a_2 = this.a(A_0, A_1, out flag);
			}
			else if (this.g.a() == brh.a && this.g.b == brh.b)
			{
				this.a(A_0, A_1, out flag);
			}
			if (base.an2() == null && (this.g.b == brh.c || (this.g.b == brh.b && !flag)))
			{
				a_ = this.a(this.u);
			}
		}
		base.c(a_);
		base.b(a_2);
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00037734 File Offset: 0x00035934
	private void a(Point A_0)
	{
		Point point = base.at();
		bool flag;
		this.e.d(flag = (A_0.Y >= point.Y && A_0.Y <= point.Y + this.d.c()));
		if (!flag)
		{
			this.e.a(A_0.Y >= point.Y + base.Size.d - this.d.c() && A_0.Y <= point.Y + base.Size.d);
		}
		this.e.c(flag = (A_0.X >= point.X && A_0.X <= point.X + this.d.c()));
		if (!flag)
		{
			this.e.b(A_0.X >= point.X + base.Size.c - this.d.c() && A_0.X <= point.X + base.Size.c);
		}
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x00037884 File Offset: 0x00035A84
	private void a()
	{
		if (this.d.a())
		{
			this.a(this.f);
		}
		if (this.d.b() && this.IsMousedOver)
		{
			this.a(this.e);
		}
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x000378D4 File Offset: 0x00035AD4
	private void a(efn A_0)
	{
		if (A_0.b())
		{
			if (A_0.a())
			{
				base.an9().uh(this.d.e());
				return;
			}
			if (A_0.e())
			{
				base.an9().ui(this.d.e());
				return;
			}
			base.an9().ug(this.d.e());
			return;
		}
		else if (A_0.d())
		{
			if (A_0.a())
			{
				base.an9().uk(this.d.e());
				return;
			}
			if (A_0.e())
			{
				base.an9().ul(this.d.e());
				return;
			}
			base.an9().uj(this.d.e());
			return;
		}
		else
		{
			if (A_0.a())
			{
				base.an9().un(this.d.e() / this.a);
				return;
			}
			if (A_0.e())
			{
				base.an9().um(this.d.e() / this.a);
			}
			return;
		}
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00037A08 File Offset: 0x00035C08
	public new void f()
	{
		this.vs();
		this.ad = ((av0)base.m()).b;
		this.@as = ((av0)base.m()).a;
		Point point = base.at();
		if (base.an9() != null)
		{
			this.b = new Point(point.X + base.Size.c / 2 - Convert.ToInt32((float)this.@as.c * this.y), point.Y + base.Size.d / 2 - Convert.ToInt32((int)((float)this.@as.d * this.y)));
			if (esj.c(base.Size, esj.a()) && esj.c(this.@as, esj.a()))
			{
				this.a = (float)(this.@as.c / this.@as.d);
				this.d = base.Size.d / 2 / Convert.ToInt32((float)(this.@as.d * 2) * this.y) + 2;
				this.c = base.Size.c / 2 / Convert.ToInt32((float)(this.@as.c * 2) * this.y) + 2;
			}
		}
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x00037B68 File Offset: 0x00035D68
	public override void vs()
	{
		if (base.an9() != null)
		{
			this.y = base.an9().ua();
			return;
		}
		this.y = 1f;
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x00037B94 File Offset: 0x00035D94
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		if (this.d != null && this.d.b())
		{
			this.a(A_1.a());
		}
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x00037BC8 File Offset: 0x00035DC8
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		if (this.ae && !this.i.a && this.af && this.ag != null)
		{
			float num = 0.03f;
			Point point = d05.a(A_1.a(), this.ag.Value, true);
			base.an9().t2(new Vector3(base.an9().t1().X - (float)(point.X + point.Y) * num, base.an9().t1().Y - (float)(point.Y - point.X) * num, base.an9().t1().Z));
			return;
		}
		if (this.d != null && this.d.b())
		{
			this.a(A_1.a());
		}
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00037CBC File Offset: 0x00035EBC
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.e.c();
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00037CD4 File Offset: 0x00035ED4
	protected override void vt(object A_0, b25 A_1)
	{
		if (this.ap)
		{
			this.a(A_1.a().X, A_1.a().Y);
		}
		base.vt(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			this.af = true;
			this.ag = new Point?(A_1.a());
		}
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00037D34 File Offset: 0x00035F34
	protected override void vu(object A_0, b25 A_1)
	{
		if (this.ap)
		{
			this.a(A_1.a().X, A_1.a().Y);
		}
		base.vu(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			this.af = false;
			this.ag = null;
		}
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00037D90 File Offset: 0x00035F90
	protected override void n6(object A_0, c1 A_1)
	{
		base.n6(A_0, A_1);
		this.af = false;
		this.ag = null;
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00037DB0 File Offset: 0x00035FB0
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.f();
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00037DC0 File Offset: 0x00035FC0
	protected override void vv(object A_0, c1 A_1)
	{
		base.vv(A_0, A_1);
		if (base.anz() != null)
		{
			this.h = new atc(base.anz().Size.c, base.anz().Size.d, 100);
			this.i = new atc(base.anz().Size.c, base.anz().Size.d, 100);
			return;
		}
		this.h = null;
		this.i = null;
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00037E4C File Offset: 0x0003604C
	protected override void vw(object A_0, c1 A_1)
	{
		this.f();
		base.vw(A_0, A_1);
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00037E5C File Offset: 0x0003605C
	protected override void g6(object A_0, ane A_1)
	{
		base.g6(A_0, A_1);
		if (this.d != null && this.d.a() && !this.d.d())
		{
			this.a(A_1, true);
		}
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00037E9C File Offset: 0x0003609C
	protected override void vx(object A_0, ane A_1)
	{
		base.vx(A_0, A_1);
		if (this.d != null && this.d.a() && !this.d.d())
		{
			this.a(A_1, false);
		}
	}

	// Token: 0x0400077A RID: 1914
	private new float a;

	// Token: 0x0400077B RID: 1915
	private new Point b;

	// Token: 0x0400077C RID: 1916
	private new int c;

	// Token: 0x0400077D RID: 1917
	private new int d;

	// Token: 0x0400077E RID: 1918
	private new efn e;

	// Token: 0x0400077F RID: 1919
	private new efn f;

	// Token: 0x04000780 RID: 1920
	private new long g;

	// Token: 0x04000781 RID: 1921
	private new atc h;

	// Token: 0x04000782 RID: 1922
	private new atc i;

	// Token: 0x04000783 RID: 1923
	private new int j;

	// Token: 0x04000784 RID: 1924
	private new bool k;

	// Token: 0x04000785 RID: 1925
	private new int l;

	// Token: 0x04000786 RID: 1926
	private new List<ak1> m = new List<ak1>(3000);

	// Token: 0x04000787 RID: 1927
	private new List<dj2> n = new List<dj2>(100);

	// Token: 0x04000788 RID: 1928
	private new int o;

	// Token: 0x04000789 RID: 1929
	private new HashSet<Guid> p = new HashSet<Guid>();

	// Token: 0x0400078A RID: 1930
	private new HashSet<b0b> q = new HashSet<b0b>();

	// Token: 0x0400078B RID: 1931
	private new SortedList<ak1, ak1> r = new SortedList<ak1, ak1>(16, cbt.a());

	// Token: 0x0400078C RID: 1932
	private Dictionary<ak1, a7m.c> s = new Dictionary<ak1, a7m.c>(16);

	// Token: 0x0400078D RID: 1933
	private SortedList<b0b, b0b> t = new SortedList<b0b, b0b>(cx0.a());

	// Token: 0x0400078E RID: 1934
	private new List<bym> u = new List<bym>();

	// Token: 0x0400078F RID: 1935
	private List<bym> v = new List<bym>();

	// Token: 0x04000790 RID: 1936
	private List<a2f> w = new List<a2f>();

	// Token: 0x04000791 RID: 1937
	private new Dictionary<string, List<a2f>> x = new Dictionary<string, List<a2f>>();

	// Token: 0x04000792 RID: 1938
	private new List<cy5> y = new List<cy5>();

	// Token: 0x04000793 RID: 1939
	private Texture2D z;

	// Token: 0x04000794 RID: 1940
	private bn8 aa;

	// Token: 0x04000795 RID: 1941
	private bool ab;

	// Token: 0x04000796 RID: 1942
	public bool ac;

	// Token: 0x04000797 RID: 1943
	private int ad;

	// Token: 0x04000798 RID: 1944
	private bool ae;

	// Token: 0x04000799 RID: 1945
	private new bool af;

	// Token: 0x0400079A RID: 1946
	private Point? ag;

	// Token: 0x0400079B RID: 1947
	public int ah;

	// Token: 0x0400079C RID: 1948
	public int ai;

	// Token: 0x0400079D RID: 1949
	public int aj;

	// Token: 0x0400079E RID: 1950
	public int ak;

	// Token: 0x0400079F RID: 1951
	protected int al;

	// Token: 0x040007A0 RID: 1952
	protected new int am;

	// Token: 0x040007A1 RID: 1953
	private bool an;

	// Token: 0x040007A2 RID: 1954
	public new bool ao;

	// Token: 0x040007A3 RID: 1955
	public new bool ap;

	// Token: 0x040007A4 RID: 1956
	private static readonly RasterizerState aq = new RasterizerState();

	// Token: 0x040007A5 RID: 1957
	public bool ar;

	// Token: 0x040007A6 RID: 1958
	private esj @as;

	// Token: 0x040007A7 RID: 1959
	public new Keys at = Keys.Up;

	// Token: 0x040007A8 RID: 1960
	public Keys au = Keys.Down;

	// Token: 0x040007A9 RID: 1961
	public Keys av = Keys.Left;

	// Token: 0x040007AA RID: 1962
	public Keys aw = Keys.Right;

	// Token: 0x020001BB RID: 443
	private new class b : IEqualityComparer<bym>
	{
		// Token: 0x06000D39 RID: 3385 RVA: 0x00038AB0 File Offset: 0x00036CB0
		public bool Equals(bym x, bym y)
		{
			return x.b == y.b;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00038AC0 File Offset: 0x00036CC0
		public int GetHashCode(bym obj)
		{
			return obj.b.GetHashCode();
		}

		// Token: 0x040007D0 RID: 2000
		public static readonly a7m.b a = new a7m.b();
	}

	// Token: 0x020001BD RID: 445
	private new sealed class c
	{
		// Token: 0x040007D7 RID: 2007
		public b0b a;

		// Token: 0x040007D8 RID: 2008
		public b0b b;
	}

	// Token: 0x020001BE RID: 446
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06000D43 RID: 3395 RVA: 0x00038B4C File Offset: 0x00036D4C
		internal int a(a2f A_0)
		{
			return A_0.m.Left;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00038B5C File Offset: 0x00036D5C
		internal int b(a2f A_0)
		{
			return A_0.m.Top;
		}

		// Token: 0x040007D9 RID: 2009
		public static readonly a7m.a a = new a7m.a();

		// Token: 0x040007DA RID: 2010
		public static Func<a2f, int> b;

		// Token: 0x040007DB RID: 2011
		public static Func<a2f, int> c;
	}
}
