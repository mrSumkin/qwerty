using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002003 RID: 8195
public sealed class i5 : au6
{
	// Token: 0x0600C16C RID: 49516 RVA: 0x0043078C File Offset: 0x0042E98C
	public coh c()
	{
		return this.b;
	}

	// Token: 0x0600C16D RID: 49517 RVA: 0x00430794 File Offset: 0x0042E994
	public void a(coh A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.f.a();
		}
	}

	// Token: 0x0600C16E RID: 49518 RVA: 0x004307B4 File Offset: 0x0042E9B4
	public bool e()
	{
		return this.c;
	}

	// Token: 0x0600C16F RID: 49519 RVA: 0x004307BC File Offset: 0x0042E9BC
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C170 RID: 49520 RVA: 0x004307C8 File Offset: 0x0042E9C8
	public efk d()
	{
		return this.d;
	}

	// Token: 0x0600C171 RID: 49521 RVA: 0x004307D0 File Offset: 0x0042E9D0
	public void a(efk A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600C172 RID: 49522 RVA: 0x004307DC File Offset: 0x0042E9DC
	public bool f()
	{
		return this.e;
	}

	// Token: 0x0600C173 RID: 49523 RVA: 0x004307E4 File Offset: 0x0042E9E4
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600C174 RID: 49524 RVA: 0x004307F0 File Offset: 0x0042E9F0
	public override bool hh()
	{
		return true;
	}

	// Token: 0x0600C175 RID: 49525 RVA: 0x004307F4 File Offset: 0x0042E9F4
	public i5() : base(bo1.t, null, i5.b())
	{
		this.a();
	}

	// Token: 0x0600C176 RID: 49526 RVA: 0x0043081C File Offset: 0x0042EA1C
	private static cs9 b()
	{
		if (wj.a().c())
		{
			return new se
			{
				PropagateMouseScrollEvent = true
			};
		}
		return new c1y
		{
			PropagateMouseScrollEvent = true
		};
	}

	// Token: 0x0600C177 RID: 49527 RVA: 0x0043084C File Offset: 0x0042EA4C
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.c)
		{
			Point point = base.at();
			wj wj = wj.a();
			if (wj.c())
			{
				Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.ap, null);
				if (resource != null)
				{
					esj a_ = base.a(resource);
					c4o.b(A_1, resource, a_, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), adi.c, false, null);
					return;
				}
			}
			else
			{
				Texture2D resource2 = A_1.a.GetResource<Texture2D>(wj.f, null);
				if (resource2 != null)
				{
					c4o.b(A_1, resource2, wj.d0, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), adi.c, false, new Point?(wj.dz));
				}
			}
		}
	}

	// Token: 0x0600C178 RID: 49528 RVA: 0x00430964 File Offset: 0x0042EB64
	private void a()
	{
		wj wj = wj.a();
		this.g = 26;
		this.i = 5;
		this.h = 10;
		base.d(true);
		if (!wj.c())
		{
			this.g = wj.bo.c;
			base.b(wj.f);
			this.n = wj.d5;
			this.o = new esj?(wj.d6);
		}
		this.f = new i5.a(this);
		this.f.PropagateMouseScrollEvent = true;
		this.aox(this.f);
		base.Size = new esj(100, 200);
		this.Focusable = false;
	}

	// Token: 0x0600C179 RID: 49529 RVA: 0x00430A18 File Offset: 0x0042EC18
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.f.Location = new Point(this.a, this.a);
		this.f.Size = new esj(base.Size.c - this.a * 2 - 10, base.Size.d - this.a * 2);
		this.f.a();
	}

	// Token: 0x040045F9 RID: 17913
	private new int a = 10;

	// Token: 0x040045FA RID: 17914
	private new coh b;

	// Token: 0x040045FB RID: 17915
	private new bool c;

	// Token: 0x040045FC RID: 17916
	private new efk d;

	// Token: 0x040045FD RID: 17917
	private new bool e = true;

	// Token: 0x040045FE RID: 17918
	private new i5.a f;

	// Token: 0x02002004 RID: 8196
	private new sealed class a : euz
	{
		// Token: 0x0600C17A RID: 49530 RVA: 0x00430A90 File Offset: 0x0042EC90
		public a(i5 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C17B RID: 49531 RVA: 0x00430AA4 File Offset: 0x0042ECA4
		public override void iv(e6d A_0, cp9 A_1)
		{
			base.iv(A_0, A_1);
			if (A_1.a != null)
			{
				Point point = base.at();
				if (this.a.b != null)
				{
					wj wj = wj.a();
					Vector2 vector = new Vector2((float)point.X, (float)point.Y);
					esj esj;
					if (wj.c())
					{
						esj = bj8.a;
					}
					else
					{
						esj = cq4.f();
					}
					if (this.a.e)
					{
						c3i c3i = ejh.b(this.a.b.Definition.a3(), A_1.a);
						if (c3i != null)
						{
							Rectangle a_ = new Rectangle(point.X, point.Y, esj.c, esj.d);
							c3i.a(A_1, a_, Color.White, 0, null);
							if (this.a.b.Stacks > 1)
							{
								if (wj.c())
								{
									as6.a(A_1, vector, this.a.b);
								}
								else
								{
									as6.a(A_1, vector, esj, cq4.e(), this.a.b);
								}
							}
							if (!wj.c())
							{
								Texture2D a_2 = A_1.a.us(wj.f, null);
								Vector2 value = esj.b() / wj.o.b();
								as6.a(A_1, wj.w * value, wj.x, a_.Location.b(), esj.b(), a_2, this.a.b);
							}
						}
					}
					if (this.b != null)
					{
						if (this.a.e)
						{
							this.b.a(new Point((int)(vector.X + (float)esj.c + 10f), (int)vector.Y), A_1, null, 1f);
						}
						else
						{
							this.b.a(new Point((int)vector.X, (int)vector.Y), A_1, null, 1f);
						}
					}
					int y = (int)Math.Max(vector.Y + (float)esj.d + 20f, vector.Y + (float)this.b.b.d + 10f);
					if (this.c != null)
					{
						this.c.a(new Point((int)vector.X, y), A_1, null, 1f);
					}
				}
			}
		}

		// Token: 0x0600C17C RID: 49532 RVA: 0x00430D2C File Offset: 0x0042EF2C
		public void a()
		{
			int a_ = 1;
			if (this.a.b == null)
			{
				this.b = null;
				this.c = null;
				base.Size = new esj(base.Size.c, this.a.Size.d - 50);
			}
			else
			{
				try
				{
					this.b = Enumerable.First<ecs>(cq4.c(this.a.b).a(base.Size.c - (10 + bj8.a.c), 0)).b();
				}
				catch
				{
					this.b = null;
				}
				try
				{
					base.at();
					Math.Max(bj8.a.d + 20, this.b.b.d + 10);
					this.c = Enumerable.First<ecs>(cq4.a(this.a.b, this.a.d, false, false, false, null, null, null, false).a(base.Size.c - 10, 10000)).b();
					a_ = Math.Max(bj8.a.d + 20, this.b.b.d + 10) + this.c.b.d + 10;
				}
				catch
				{
					this.c = null;
				}
			}
			base.Size = new esj(base.Size.c, a_);
			this.a.p();
		}

		// Token: 0x040045FF RID: 17919
		private new i5 a;

		// Token: 0x04004600 RID: 17920
		private new dn3 b;

		// Token: 0x04004601 RID: 17921
		private new dn3 c;
	}
}
