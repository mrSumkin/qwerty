using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FF6 RID: 8182
public abstract class eb1 : cao, b6, amj
{
	// Token: 0x0600C0A0 RID: 49312 RVA: 0x0042C2A4 File Offset: 0x0042A4A4
	protected bool j()
	{
		return this.y;
	}

	// Token: 0x0600C0A1 RID: 49313 RVA: 0x0042C2AC File Offset: 0x0042A4AC
	protected void c(bool A_0)
	{
		this.y = A_0;
	}

	// Token: 0x0600C0A2 RID: 49314 RVA: 0x0042C2B8 File Offset: 0x0042A4B8
	public virtual bool aj9()
	{
		return false;
	}

	// Token: 0x0600C0A3 RID: 49315 RVA: 0x0042C2BC File Offset: 0x0042A4BC
	protected virtual bool ag4()
	{
		return false;
	}

	// Token: 0x0600C0A4 RID: 49316 RVA: 0x0042C2C0 File Offset: 0x0042A4C0
	protected virtual bool aqf()
	{
		return false;
	}

	// Token: 0x0600C0A5 RID: 49317 RVA: 0x0042C2C4 File Offset: 0x0042A4C4
	protected virtual bool aqg()
	{
		return true;
	}

	// Token: 0x0600C0A6 RID: 49318 RVA: 0x0042C2C8 File Offset: 0x0042A4C8
	protected virtual bool aqh()
	{
		return false;
	}

	// Token: 0x0600C0A7 RID: 49319 RVA: 0x0042C2CC File Offset: 0x0042A4CC
	public string r()
	{
		return this.w;
	}

	// Token: 0x0600C0A8 RID: 49320 RVA: 0x0042C2D4 File Offset: 0x0042A4D4
	public void c(string A_0)
	{
		this.w = A_0;
	}

	// Token: 0x0600C0A9 RID: 49321
	public abstract av zc();

	// Token: 0x0600C0AA RID: 49322 RVA: 0x0042C2E0 File Offset: 0x0042A4E0
	public Color p()
	{
		return this.l;
	}

	// Token: 0x0600C0AB RID: 49323 RVA: 0x0042C2E8 File Offset: 0x0042A4E8
	public void f(Color A_0)
	{
		this.l = A_0;
	}

	// Token: 0x0600C0AC RID: 49324 RVA: 0x0042C2F4 File Offset: 0x0042A4F4
	public Color n()
	{
		return this.m;
	}

	// Token: 0x0600C0AD RID: 49325 RVA: 0x0042C2FC File Offset: 0x0042A4FC
	public void g(Color A_0)
	{
		this.m = A_0;
	}

	// Token: 0x0600C0AE RID: 49326 RVA: 0x0042C308 File Offset: 0x0042A508
	public Color f()
	{
		return this.n;
	}

	// Token: 0x0600C0AF RID: 49327 RVA: 0x0042C310 File Offset: 0x0042A510
	public void a(Color A_0)
	{
		this.n = A_0;
	}

	// Token: 0x0600C0B0 RID: 49328 RVA: 0x0042C31C File Offset: 0x0042A51C
	public Color i()
	{
		return this.o;
	}

	// Token: 0x0600C0B1 RID: 49329 RVA: 0x0042C324 File Offset: 0x0042A524
	public void d(Color A_0)
	{
		this.o = A_0;
	}

	// Token: 0x0600C0B2 RID: 49330 RVA: 0x0042C330 File Offset: 0x0042A530
	public Color o()
	{
		return this.p;
	}

	// Token: 0x0600C0B3 RID: 49331 RVA: 0x0042C338 File Offset: 0x0042A538
	public void e(Color A_0)
	{
		this.p = A_0;
		if (this.p.A != 0)
		{
			this.q = Color.Lerp(this.p, Color.Black, 0.5f);
			return;
		}
		this.q = Color.Transparent;
	}

	// Token: 0x0600C0B4 RID: 49332 RVA: 0x0042C378 File Offset: 0x0042A578
	public Color h()
	{
		return this.r;
	}

	// Token: 0x0600C0B5 RID: 49333 RVA: 0x0042C380 File Offset: 0x0042A580
	public void h(Color A_0)
	{
		this.r = A_0;
	}

	// Token: 0x0600C0B6 RID: 49334 RVA: 0x0042C38C File Offset: 0x0042A58C
	public int m()
	{
		return this.z;
	}

	// Token: 0x0600C0B7 RID: 49335 RVA: 0x0042C394 File Offset: 0x0042A594
	public void a(int A_0)
	{
		this.z = A_0;
	}

	// Token: 0x0600C0B8 RID: 49336 RVA: 0x0042C3A0 File Offset: 0x0042A5A0
	public Color k()
	{
		return this.s;
	}

	// Token: 0x0600C0B9 RID: 49337 RVA: 0x0042C3A8 File Offset: 0x0042A5A8
	public void c(Color A_0)
	{
		this.s = A_0;
	}

	// Token: 0x0600C0BA RID: 49338 RVA: 0x0042C3B4 File Offset: 0x0042A5B4
	public Color q()
	{
		return this.t;
	}

	// Token: 0x0600C0BB RID: 49339 RVA: 0x0042C3BC File Offset: 0x0042A5BC
	public void b(Color A_0)
	{
		this.t = A_0;
	}

	// Token: 0x0600C0BC RID: 49340 RVA: 0x0042C3C8 File Offset: 0x0042A5C8
	public bool g()
	{
		return this.aa;
	}

	// Token: 0x0600C0BD RID: 49341 RVA: 0x0042C3D0 File Offset: 0x0042A5D0
	public void e(bool A_0)
	{
		this.aa = A_0;
	}

	// Token: 0x0600C0BE RID: 49342 RVA: 0x0042C3DC File Offset: 0x0042A5DC
	public Color? e()
	{
		return this.u;
	}

	// Token: 0x0600C0BF RID: 49343 RVA: 0x0042C3E4 File Offset: 0x0042A5E4
	public void a(Color? A_0)
	{
		this.u = A_0;
	}

	// Token: 0x0600C0C0 RID: 49344 RVA: 0x0042C3F0 File Offset: 0x0042A5F0
	public bool l()
	{
		return this.ab;
	}

	// Token: 0x0600C0C1 RID: 49345 RVA: 0x0042C3F8 File Offset: 0x0042A5F8
	public void b(bool A_0)
	{
		this.ab = A_0;
	}

	// Token: 0x0600C0C2 RID: 49346 RVA: 0x0042C404 File Offset: 0x0042A604
	private dsy c()
	{
		if (this.v == null)
		{
			this.v = new dsy(this, this, djp.a, djp.b, this.auf(), null, djp.c, false, false);
		}
		return this.v;
	}

	// Token: 0x0600C0C3 RID: 49347 RVA: 0x0042C450 File Offset: 0x0042A650
	public bool s()
	{
		return this.ac;
	}

	// Token: 0x0600C0C4 RID: 49348 RVA: 0x0042C458 File Offset: 0x0042A658
	public void d(bool A_0)
	{
		this.ac = A_0;
	}

	// Token: 0x0600C0C5 RID: 49349 RVA: 0x0042C464 File Offset: 0x0042A664
	public string d()
	{
		return this.ad;
	}

	// Token: 0x0600C0C6 RID: 49350 RVA: 0x0042C46C File Offset: 0x0042A66C
	public void b(string A_0)
	{
		this.ad = A_0;
	}

	// Token: 0x0600C0C7 RID: 49351 RVA: 0x0042C478 File Offset: 0x0042A678
	protected eb1() : this(eb1.a, bj8.a)
	{
	}

	// Token: 0x0600C0C8 RID: 49352 RVA: 0x0042C48C File Offset: 0x0042A68C
	protected eb1(esj A_0, esj A_1)
	{
		this.d = A_0;
		this.e = A_1;
		this.f = new Vector2((float)((this.d.c - this.e.c) / 2), (float)((this.d.d - this.e.d) / 2));
		this.b();
	}

	// Token: 0x0600C0C9 RID: 49353 RVA: 0x0042C560 File Offset: 0x0042A760
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (A_1.a != null)
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(this.w, null);
			Vector2 vector = base.at().b();
			Rectangle value = new Rectangle(this.x.X, this.x.Y, this.d.c, this.d.d);
			if (resource != null)
			{
				if (this.Enabled && !this.ac)
				{
					chr service = bpo.GetService<chr>();
					bool flag = false;
					bool flag2 = false;
					if (service != null && service.ax() != null && service.ax().c() != null)
					{
						flag = true;
						if (service.ax().c() == this.zc())
						{
							flag2 = true;
						}
					}
					Color a_;
					if (this.zc() != null && this.zc().q())
					{
						a_ = this.m;
					}
					else if (!flag && this.zc() != null && (base.Parent == null || base.Parent.Enabled) && this.IsMousedOver && !base.Pressed)
					{
						a_ = this.l;
					}
					else
					{
						a_ = base.Color;
					}
					A_1.b().w5(resource, vector, new Rectangle?(value), a_);
					c3i c3i = null;
					c3i c3i2 = null;
					Color a_2 = Color.White;
					Vector2 vector2 = vector + this.f;
					if (this.zc() != null)
					{
						bool flag3 = this.zc().yw();
						bl6 bl = this.zc() as bl6;
						if (bl != null && bl.q())
						{
							flag3 = true;
						}
						if (this.y || !flag2)
						{
							c3i = ejh.a(this.zc(), A_1.a, this.aj9());
							a_2 = ((this.u != null && !flag3) ? this.u.Value : Color.White);
							if (!this.aj9() && this.ag4())
							{
								coh coh = this.zc().b9() as coh;
								bool flag4;
								if (coh != null)
								{
									flag4 = (coh.Definition.a2().Count > 1 || this.aqf());
								}
								else
								{
									flag4 = !string.IsNullOrEmpty(this.zc().i);
								}
								if (flag4)
								{
									c3i2 = ejh.a(this.zc(), A_1.a, true);
								}
							}
						}
					}
					if (c3i == null)
					{
						string text = this.zi();
						if (!string.IsNullOrEmpty(text))
						{
							c3i = ejh.b(text, A_1.a);
						}
					}
					if (c3i != null)
					{
						Rectangle a_3 = new Rectangle((int)vector2.X, (int)vector2.Y, this.e.c, this.e.d);
						c3i.a(A_1, a_3, a_2, 0, null);
					}
					if (c3i2 != null)
					{
						Vector2 vector3 = new Vector2(vector2.X, vector2.Y + (float)(this.e.d / 2));
						Rectangle a_4 = new Rectangle((int)vector3.X, (int)vector3.Y, this.e.c / 2, this.e.d / 2);
						c3i2.a(A_1, a_4, a_2, 0, null);
					}
					if (this.zc() != null)
					{
						bool flag5 = this.zc().yw();
						bool flag6 = false;
						bi3 service2 = bpo.GetService<bi3>();
						if (service2 != null)
						{
							eal eal = service2.aij() as eal;
							flag6 = (eal != null && eal.ati() == this.zc());
						}
						if (!this.aj9() && this.aqg())
						{
							if (this.j != null)
							{
								as6.a(A_1, this.j.Value, this.k, vector + this.f, this.e.b(), resource, this.zc().b9() as coh);
							}
							else
							{
								as6.a(A_1, vector + this.f, resource, this.zc().b9() as coh);
							}
						}
						if (base.Pressed || flag6)
						{
							value.X = this.d.c * 2;
							A_1.b().w5(resource, vector, new Rectangle?(value), flag5 ? this.f() : this.i());
						}
						if (!this.zc().r() || !this.zc().t())
						{
							Rectangle rectangle = new Rectangle((int)vector.X, (int)vector.Y + this.z, this.d.c, this.d.d - this.z);
							Rectangle value2 = new Rectangle(this.d.c * 2, this.z, rectangle.Width, rectangle.Height);
							A_1.b().w6(resource, rectangle, new Rectangle?(value2), this.t);
						}
						if (!flag5)
						{
							int num = (int)((float)(this.d.d - 2 * this.z) * this.zc().x());
							Rectangle rectangle2 = new Rectangle((int)vector.X, (int)vector.Y + this.z + num, this.d.c, this.d.d - (num + this.z));
							Rectangle value3 = new Rectangle(this.d.c * 2, this.z + num, rectangle2.Width, rectangle2.Height);
							A_1.b().w6(resource, rectangle2, new Rectangle?(value3), this.s);
						}
					}
					SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(this.i, null);
					if (resource2 != null)
					{
						if (!string.IsNullOrEmpty(base.Text))
						{
							Vector2 a_5 = vector + this.g;
							A_1.b().xb(resource2, base.Text, a_5, Color.White);
						}
						if (!this.aj9() && this.aa && this.zc() != null)
						{
							coh coh2 = this.zc().b9() as coh;
							if (coh2 != null && coh2.Stacks > 1)
							{
								SpriteFont resource3 = A_1.a.GetResource<SpriteFont>(this.h, null);
								if (resource3 != null)
								{
									string text2 = coh2.Stacks.ToString();
									Vector2 vector4 = resource3.MeasureString(text2);
									Vector2 a_6 = new Vector2(vector.X + ((float)base.Size.c - vector4.X - (this.g.X - 3f)), vector.Y + ((float)base.Size.d - vector4.Y - Math.Max(5f, this.g.Y / 2f)));
									A_1.b().xb(resource3, text2, a_6, Color.White);
								}
							}
						}
					}
				}
				else
				{
					value.X = this.d.c * 2;
					A_1.b().w5(resource, vector, new Rectangle?(value), Color.Black);
				}
				value.X = this.d.c;
				Color a_7;
				if (this.zc() != null)
				{
					if (this.zc().q())
					{
						a_7 = this.r;
					}
					else if (this.zc().x() == 1f)
					{
						a_7 = this.p;
					}
					else
					{
						a_7 = this.q;
					}
				}
				else
				{
					a_7 = this.p;
				}
				A_1.b().w5(resource, vector, new Rectangle?(value), a_7);
			}
		}
		this.c().a(A_0);
	}

	// Token: 0x0600C0CA RID: 49354 RVA: 0x0042CD94 File Offset: 0x0042AF94
	public virtual bool aka()
	{
		return this.zc() != null && this.zc().yw();
	}

	// Token: 0x0600C0CB RID: 49355 RVA: 0x0042CDB0 File Offset: 0x0042AFB0
	protected virtual string zi()
	{
		return null;
	}

	// Token: 0x0600C0CC RID: 49356 RVA: 0x0042CDB4 File Offset: 0x0042AFB4
	public ecs yf(euz A_0)
	{
		ecs result = null;
		if (this.zc() != null && (!this.ab || this.zc().yw()))
		{
			if (!this.aj9() && this.zc().b9() is coh && !this.aqh())
			{
				coh a_ = this.zc().b9() as coh;
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
				result = cq4.a(a_, (serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null, false, true, serviceOrThrow2.ak7(), serviceOrThrow2.ak8(), this.zc().p(), null, false);
			}
			else
			{
				result = cq4.a(this.zc(), this.d(), true);
			}
		}
		return result;
	}

	// Token: 0x0600C0CD RID: 49357 RVA: 0x0042CE94 File Offset: 0x0042B094
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		this.a();
		if (this.IsMousedOver)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.alj(this.zc() as eu7);
			}
		}
	}

	// Token: 0x0600C0CE RID: 49358 RVA: 0x0042CED8 File Offset: 0x0042B0D8
	public void a(av A_0)
	{
		this.zh(A_0);
	}

	// Token: 0x0600C0CF RID: 49359 RVA: 0x0042CEE4 File Offset: 0x0042B0E4
	private void b()
	{
		base.Size = this.d;
		this.ans();
	}

	// Token: 0x0600C0D0 RID: 49360 RVA: 0x0042CEFC File Offset: 0x0042B0FC
	private void a()
	{
		if (this.v != null)
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
			this.v.a(a_);
		}
	}

	// Token: 0x0600C0D1 RID: 49361 RVA: 0x0042CFAC File Offset: 0x0042B1AC
	protected virtual void ans()
	{
		e4z.b(this);
	}

	// Token: 0x0600C0D2 RID: 49362
	protected abstract void zh(av A_0);

	// Token: 0x0600C0D3 RID: 49363 RVA: 0x0042CFB8 File Offset: 0x0042B1B8
	protected virtual Rectangle? auf()
	{
		return null;
	}

	// Token: 0x0600C0D4 RID: 49364 RVA: 0x0042CFD0 File Offset: 0x0042B1D0
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.c().b();
	}

	// Token: 0x0600C0D5 RID: 49365 RVA: 0x0042CFE8 File Offset: 0x0042B1E8
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.c().b();
	}

	// Token: 0x0600C0D6 RID: 49366 RVA: 0x0042D000 File Offset: 0x0042B200
	protected override void ag6(object A_0, etu A_1)
	{
		base.ag6(A_0, A_1);
		this.c().b();
	}

	// Token: 0x04004597 RID: 17815
	public new static readonly esj a = new esj(41, 41);

	// Token: 0x04004598 RID: 17816
	public new static readonly Vector2 b = new Vector2(8f, 5f);

	// Token: 0x04004599 RID: 17817
	private new const double c = 0.001;

	// Token: 0x0400459A RID: 17818
	public new esj d;

	// Token: 0x0400459B RID: 17819
	public new esj e;

	// Token: 0x0400459C RID: 17820
	public new Vector2 f;

	// Token: 0x0400459D RID: 17821
	public new Vector2 g = eb1.b;

	// Token: 0x0400459E RID: 17822
	public string h = egg.n;

	// Token: 0x0400459F RID: 17823
	public string i = egg.ad;

	// Token: 0x040045A0 RID: 17824
	public new Vector2? j;

	// Token: 0x040045A1 RID: 17825
	public new Vector2 k;

	// Token: 0x040045A2 RID: 17826
	private new Color l;

	// Token: 0x040045A3 RID: 17827
	private new Color m = Color.White;

	// Token: 0x040045A4 RID: 17828
	private Color n;

	// Token: 0x040045A5 RID: 17829
	private Color o;

	// Token: 0x040045A6 RID: 17830
	private Color p;

	// Token: 0x040045A7 RID: 17831
	private Color q;

	// Token: 0x040045A8 RID: 17832
	private Color r;

	// Token: 0x040045A9 RID: 17833
	private Color s = new Color(0, 0, 0, 150);

	// Token: 0x040045AA RID: 17834
	private Color t = new Color(100, 0, 0, 150);

	// Token: 0x040045AB RID: 17835
	private Color? u;

	// Token: 0x040045AC RID: 17836
	private dsy v;

	// Token: 0x040045AD RID: 17837
	private string w = bo1.ad;

	// Token: 0x040045AE RID: 17838
	public Point x;

	// Token: 0x040045AF RID: 17839
	private bool y;

	// Token: 0x040045B0 RID: 17840
	private int z = 2;

	// Token: 0x040045B1 RID: 17841
	private bool aa = true;

	// Token: 0x040045B2 RID: 17842
	private bool ab;

	// Token: 0x040045B3 RID: 17843
	private bool ac;

	// Token: 0x040045B4 RID: 17844
	private string ad;
}
