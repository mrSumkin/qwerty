using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200004F RID: 79
public abstract class cqy : cao, ebk, amj, ta, evy
{
	// Token: 0x0600010A RID: 266
	public abstract coh x6();

	// Token: 0x0600010B RID: 267 RVA: 0x0000681C File Offset: 0x00004A1C
	public virtual bool ah8()
	{
		return true;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00006820 File Offset: 0x00004A20
	public virtual bool ya()
	{
		return true;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00006824 File Offset: 0x00004A24
	public Color h()
	{
		return this.j;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0000682C File Offset: 0x00004A2C
	public void a(Color A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600010F RID: 271
	public abstract string x8();

	// Token: 0x06000110 RID: 272
	public abstract void x9(string A_0);

	// Token: 0x06000111 RID: 273 RVA: 0x00006838 File Offset: 0x00004A38
	public bool j()
	{
		return this.l;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00006840 File Offset: 0x00004A40
	public void e(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000684C File Offset: 0x00004A4C
	public coh yx()
	{
		return this.x6();
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00006854 File Offset: 0x00004A54
	public bool yy()
	{
		return true;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00006858 File Offset: 0x00004A58
	protected virtual bool anm()
	{
		return false;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000685C File Offset: 0x00004A5C
	protected bool? i()
	{
		return this.k;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00006864 File Offset: 0x00004A64
	public virtual Color ano()
	{
		return Color.White;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00006870 File Offset: 0x00004A70
	public virtual Color? anp()
	{
		return null;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00006888 File Offset: 0x00004A88
	public bool f()
	{
		return this.m;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00006890 File Offset: 0x00004A90
	public void c(bool A_0)
	{
		this.m = A_0;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0000689C File Offset: 0x00004A9C
	public Func<ebk, coh, bool> g()
	{
		return this.o;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000068A4 File Offset: 0x00004AA4
	public void a(Func<ebk, coh, bool> A_0)
	{
		this.o = A_0;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000068B0 File Offset: 0x00004AB0
	public Func<ebk, bool> k()
	{
		return this.p;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x000068B8 File Offset: 0x00004AB8
	public void a(Func<ebk, bool> A_0)
	{
		this.p = A_0;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x000068C4 File Offset: 0x00004AC4
	public virtual bool ath()
	{
		return false;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000068C8 File Offset: 0x00004AC8
	public bool l()
	{
		return this.q;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x000068D0 File Offset: 0x00004AD0
	public void d(bool A_0)
	{
		this.q = A_0;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000068DC File Offset: 0x00004ADC
	public bool zf()
	{
		return this.x8() == ItemExchangeParty.PlayerGear.ToString() || this.x8() == ItemExchangeParty.PlayerInventory.ToString();
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00006924 File Offset: 0x00004B24
	public virtual double? ann()
	{
		return null;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0000693C File Offset: 0x00004B3C
	public cqy()
	{
		this.b();
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00006988 File Offset: 0x00004B88
	public cqy(esj A_0, esj A_1)
	{
		this.f = A_0;
		this.g = A_1;
		this.b();
	}

	// Token: 0x06000126 RID: 294 RVA: 0x000069E4 File Offset: 0x00004BE4
	public string eu()
	{
		string text = d4f.a(this);
		if (text != null)
		{
			return text;
		}
		return null;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00006A04 File Offset: 0x00004C04
	public override void iv(e6d A_0, cp9 A_1)
	{
		wj wj = wj.a();
		chr service = bpo.GetService<chr>();
		d1a serviceOrThrow = bpo.GetServiceOrThrow<d1a>();
		if (A_1.a != null)
		{
			Vector2 vector = base.at().b();
			Texture2D resource = A_1.a.GetResource<Texture2D>(this.d, null);
			coh coh = this.x6();
			if (resource != null)
			{
				bool flag = serviceOrThrow.aa8() == this && service != null && service.ax() != null && this.iq(service.ax());
				Rectangle value = new Rectangle(this.e.X, this.e.Y, this.f.c, this.f.d);
				A_1.b().w5(resource, vector, new Rectangle?(value), this.h());
				if (this.s != null)
				{
					value = new Rectangle(this.e.X + 4 * this.f.c, this.e.Y, this.f.c, this.f.d);
					A_1.b().w5(resource, vector, new Rectangle?(value), this.s.Value);
				}
				if (this.u && this.x6() != null && this.IsMousedOver)
				{
					Color a_ = adi.ag[this.x6().Definition.bc()] * 0.25f;
					value = new Rectangle(this.e.X + 4 * this.f.c, this.e.Y, this.f.c, this.f.d);
					A_1.b().w5(resource, vector, new Rectangle?(value), a_);
				}
				if (!this.ah8() && this.x6() == null)
				{
					value.X = this.e.X + this.f.c;
					value.Y = this.e.Y;
				}
				else if (this.f())
				{
					value.X = this.e.X + this.f.c;
					value.Y = this.e.Y + this.f.d;
				}
				else if (flag)
				{
					value.X = this.e.X + this.f.c * 2;
					value.Y = this.e.Y;
				}
				else if (this.ath())
				{
					value.X = this.e.X + this.f.c * 2;
					value.Y = this.e.Y + this.f.d;
				}
				else
				{
					value.X = this.e.X;
					value.Y = this.e.Y + this.f.d;
				}
				A_1.b().w5(resource, vector, new Rectangle?(value), this.anp() ?? base.Color);
				if (this.anm())
				{
					bi3 service2 = bpo.GetService<bi3>();
					if (service2 != null)
					{
						eal eal = service2.aij() as eal;
						if (eal != null && eal.ati() != null && eal.ati().b9() != null && eal.ati().b9() == this.x6())
						{
							if (wj.c())
							{
								value.X = this.e.X + this.f.c;
								value.Y = this.e.Y + this.f.d;
							}
							else
							{
								value.X = this.e.X + 4 * this.f.c;
								value.Y = this.e.Y;
							}
							A_1.b().w5(resource, vector, new Rectangle?(value), cqy.c);
						}
					}
				}
			}
			this.aqp(A_0, A_1);
			if (coh != null)
			{
				c3i c3i = ejh.b(coh.Definition.a3(), A_1.a);
				Vector2 vector2 = new Vector2(vector.X + (float)((this.f.c - this.g.c) / 2), vector.Y + (float)((this.f.d - this.g.d) / 2));
				bool flag2 = service != null && service.ax() != null && service.ax().a() == this;
				Rectangle a_2 = new Rectangle((int)vector2.X, (int)vector2.Y, this.g.c, this.g.d);
				if (coh.CustomProperties.GetPrimitivePropertyValue<bool>(vo.h, new bool?(false)).Value)
				{
					c3i c3i2 = ejh.b("SpecialMerchandiseBackground", A_1.a);
					if (c3i2 != null)
					{
						c3i2.a(A_1, a_2, flag2 ? c69.a : this.ano(), 0, null);
					}
				}
				if (c3i != null)
				{
					c3i.a(A_1, a_2, flag2 ? c69.a : this.ano(), 0, null);
					ejh.a(A_1, a_2, coh, flag2 ? c69.a : this.ano());
				}
				if (this.q)
				{
					if (this.h != null)
					{
						as6.a(A_1, this.h.Value, this.i, a_2.Location.b(), this.g.b(), resource, coh);
					}
					else
					{
						as6.a(A_1, vector2, null, coh);
					}
				}
			}
			if (resource != null && this.i() != null)
			{
				Rectangle value2;
				if (wj.c())
				{
					value2 = new Rectangle(this.f.c, this.f.d, this.f.c, this.f.d);
				}
				else
				{
					value2 = new Rectangle(this.e.X + 4 * this.f.c, this.e.Y, this.f.c, this.f.d);
				}
				A_1.b().w5(resource, vector, new Rectangle?(value2), (this.i().Value ? Color.Blue : Color.Red) * 0.4f);
			}
			if (coh != null && coh.Stacks > 1)
			{
				if (wj.d == UiSize.Classic)
				{
					as6.a(A_1, vector, coh);
				}
				else if (!string.IsNullOrEmpty(this.r))
				{
					SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(this.r, null);
					if (resource2 != null)
					{
						string text = as6.a(coh.Stacks);
						Vector2 vector3 = resource2.MeasureString(text);
						esj esj = new esj((base.Size.c - this.g.c) / 2, (base.Size.d - this.g.d) / 2);
						Vector2 a_3 = new Vector2(vector.X + (float)base.Size.c - (float)esj.c - vector3.X - 3f, vector.Y + (float)base.Size.d - (float)esj.d - vector3.Y - 3f);
						A_1.b().xb(resource2, text, a_3, Color.White);
					}
				}
			}
		}
		if (this.n != null)
		{
			this.n.a(A_0);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00007284 File Offset: 0x00005484
	protected virtual void aqp(e6d A_0, cp9 A_1)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00007288 File Offset: 0x00005488
	public override void ag5(e6d A_0)
	{
		if (this.n == null)
		{
			this.n = bd1.a(this, this, this.aia());
		}
		this.a();
		base.ag5(A_0);
	}

	// Token: 0x0600012A RID: 298
	public abstract coh yb(coh A_0, bool A_1 = false);

	// Token: 0x0600012B RID: 299
	public abstract coh yd();

	// Token: 0x0600012C RID: 300 RVA: 0x000072B8 File Offset: 0x000054B8
	public virtual bool ye(ebk A_0, coh A_1)
	{
		bool flag = this.x7();
		if (this.o != null)
		{
			return flag && this.o(A_0, A_1);
		}
		return flag;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x000072F0 File Offset: 0x000054F0
	public virtual bool yg(ebk A_0)
	{
		bool flag = this.x7();
		if (this.p != null)
		{
			return flag && this.p(A_0);
		}
		return flag;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00007328 File Offset: 0x00005528
	public virtual void yc(coh A_0, int A_1, int A_2)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0000732C File Offset: 0x0000552C
	public virtual ecs yf(euz A_0)
	{
		coh coh = this.x6();
		if (coh != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
			return cq4.a(coh, (serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null, this, true, serviceOrThrow2.ak7(), serviceOrThrow2.ak8(), null, this.ann(), false);
		}
		return null;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000738C File Offset: 0x0000558C
	protected override void ag6(object A_0, etu A_1)
	{
		base.ag6(A_0, A_1);
		coh coh = A_1.b().c() as coh;
		ebk a_ = A_1.b().a() as ebk;
		bxd bxd = A_1.b().a() as bxd;
		ebk a_2 = this.anr();
		if (this.anq(coh) && (bxd == null || bxd.aoz(coh)) && c69.a(a_, a_2, coh, false))
		{
			e4z.c();
		}
		this.n.b();
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00007418 File Offset: 0x00005618
	protected override void vt(object A_0, b25 A_1)
	{
		base.vt(A_0, A_1);
		coh coh = this.x6();
		if (this.l && A_1.b() == eoo.d && coh != null && coh.Definition.a2().Count > 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				if (coh.Definition.a2().Count > 1)
				{
					this.k = new bool?(true);
					return;
				}
				av av = ecf.a(coh.Definition.a2()[0].Value, new dsx(), coh);
				this.k = new bool?(av != null && av.yw());
			}
		}
	}

	// Token: 0x06000132 RID: 306 RVA: 0x000074EC File Offset: 0x000056EC
	protected override void vu(object A_0, b25 A_1)
	{
		base.vu(A_0, A_1);
		this.k = null;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00007504 File Offset: 0x00005704
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.n.b();
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000751C File Offset: 0x0000571C
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.n.b();
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00007534 File Offset: 0x00005734
	private void b()
	{
		base.Size = this.f;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00007544 File Offset: 0x00005744
	private void a()
	{
		if (this.n != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			int a_;
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				a_ = (int)((double)djp.b * 2.5);
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				a_ = djp.b * 2;
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				a_ = (int)((double)djp.b * 1.5);
			}
			else
			{
				a_ = djp.b;
			}
			this.n.a(a_);
		}
	}

	// Token: 0x06000137 RID: 311
	protected abstract bool x7();

	// Token: 0x06000138 RID: 312 RVA: 0x000075F4 File Offset: 0x000057F4
	protected virtual Rectangle? aia()
	{
		return null;
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000760C File Offset: 0x0000580C
	protected virtual bool anq(coh A_0)
	{
		return true;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00007610 File Offset: 0x00005810
	protected virtual object yh()
	{
		return this;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00007614 File Offset: 0x00005814
	protected virtual ebk anr()
	{
		return this;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00007618 File Offset: 0x00005818
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		if (!this.x7())
		{
			return;
		}
		coh coh = this.x6();
		if (base.Pressed && this.ya() && coh != null)
		{
			KeyboardState state = Keyboard.GetState();
			if (state.IsKeyUp(Keys.LeftAlt) && state.IsKeyUp(Keys.RightAlt))
			{
				chr service = bpo.GetService<chr>();
				if (service != null && service.ax() == null)
				{
					e4z.d();
					e08 a_ = new e08(this.yh(), coh, TimelapseCursor.ItemDrag.ToString());
					service.az(a_);
				}
			}
		}
	}

	// Token: 0x04000287 RID: 647
	protected new static readonly string a = bo1.a8;

	// Token: 0x04000288 RID: 648
	public new static readonly esj b = bj8.a;

	// Token: 0x04000289 RID: 649
	private new static readonly Color c = new Color(0, 0, 255) * 0.5f;

	// Token: 0x0400028A RID: 650
	public new string d = cqy.a;

	// Token: 0x0400028B RID: 651
	public new Point e;

	// Token: 0x0400028C RID: 652
	public new esj f = cqy.b;

	// Token: 0x0400028D RID: 653
	public new esj g = bj8.a;

	// Token: 0x0400028E RID: 654
	public Vector2? h;

	// Token: 0x0400028F RID: 655
	public Vector2 i;

	// Token: 0x04000290 RID: 656
	private new Color j = Color.White;

	// Token: 0x04000291 RID: 657
	private new bool? k;

	// Token: 0x04000292 RID: 658
	private new bool l;

	// Token: 0x04000293 RID: 659
	private new bool m;

	// Token: 0x04000294 RID: 660
	private dsy n;

	// Token: 0x04000295 RID: 661
	private Func<ebk, coh, bool> o;

	// Token: 0x04000296 RID: 662
	private Func<ebk, bool> p;

	// Token: 0x04000297 RID: 663
	private bool q = true;

	// Token: 0x04000298 RID: 664
	public string r;

	// Token: 0x04000299 RID: 665
	public Color? s;

	// Token: 0x0400029A RID: 666
	public Color? t;

	// Token: 0x0400029B RID: 667
	public bool u;
}
