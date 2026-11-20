using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FF4 RID: 8180
public sealed class cie : euz, amj
{
	// Token: 0x0600C082 RID: 49282 RVA: 0x0042B70C File Offset: 0x0042990C
	public d48 d()
	{
		return this.c;
	}

	// Token: 0x0600C083 RID: 49283 RVA: 0x0042B714 File Offset: 0x00429914
	public int e()
	{
		return this.d;
	}

	// Token: 0x0600C084 RID: 49284 RVA: 0x0042B71C File Offset: 0x0042991C
	public cie(string A_0)
	{
		this.b = A_0;
		this.b();
	}

	// Token: 0x0600C085 RID: 49285 RVA: 0x0042B734 File Offset: 0x00429934
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.c.fu() is x2)
		{
			c3i c3i = ejh.a(this.c, null);
			if (c3i != null)
			{
				wj wj = wj.a();
				Point point = base.at();
				Rectangle a_;
				if (!wj.c() && this.IsMousedOver)
				{
					a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
					Texture2D resource = A_1.a.GetResource<Texture2D>("Locale\\Meta\\Blank", null);
					A_1.b().xa(resource, a_, adi.a * 0.15f);
				}
				a_ = new Rectangle(point.X + (base.Size.c - this.g.c) / 2, point.Y, this.g.c, this.g.d);
				if (!wj.c())
				{
					a_.Y += 3;
				}
				if (this.d >= ((x2)this.c.fu()).c())
				{
					c3i.a(A_1, a_, (this.d > 0) ? Color.White : Color.Black, 0, null);
				}
				else
				{
					int value;
					if (c3i.b.Count > 3)
					{
						value = c3i.b.Count - 3;
					}
					else
					{
						value = c3i.b.Count - 1;
					}
					Color black = Color.Black;
					c3i.a(A_1, a_, (this.d > 0) ? Color.White : black, 0, new int?(value));
				}
			}
		}
		if (this.f != null)
		{
			this.f.a(A_0);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C086 RID: 49286 RVA: 0x0042B91C File Offset: 0x00429B1C
	public override void ag5(e6d A_0)
	{
		if (this.f == null)
		{
			Point point = base.Parent.Parent.at();
			Rectangle value = new Rectangle(point.X, point.Y, base.Parent.Parent.Size.c, base.Parent.Parent.Size.d);
			this.f = bd1.a(this, this, new Rectangle?(value));
		}
		this.a();
		base.ag5(A_0);
	}

	// Token: 0x0600C087 RID: 49287 RVA: 0x0042B9A4 File Offset: 0x00429BA4
	public void c()
	{
		wj wj = wj.a();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		x2 x = this.c.fu() as x2;
		if (x != null)
		{
			if (!string.IsNullOrEmpty(this.c.fu().a5()) && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				this.d = serviceOrThrow.aqu().v().a(this.c.fu().a5());
			}
			else
			{
				this.d = 0;
			}
			this.e.Text = this.d.ToString() + " / " + x.c().ToString();
			if (this.d == x.c())
			{
				this.e.Color = new Color(118, 215, 222);
				if (wj.c())
				{
					if (egg.v)
					{
						this.e.a(egg.p);
					}
					else
					{
						this.e.a(egg.ac);
					}
				}
				else
				{
					this.e.a(wj.ev);
				}
			}
			else if (this.d > 0)
			{
				this.e.Color = Color.LightGray;
				if (wj.c())
				{
					if (egg.v)
					{
						this.e.a(egg.n);
					}
					else
					{
						this.e.a(egg.ad);
					}
				}
				else
				{
					this.e.a(wj.eu);
				}
			}
			else
			{
				this.e.Color = Color.DarkGray;
				this.e.Text = "";
				if (wj.c())
				{
					if (egg.v)
					{
						this.e.a(egg.n);
					}
					else
					{
						this.e.a(egg.ad);
					}
				}
				else
				{
					this.e.a(wj.eu);
				}
			}
		}
		else
		{
			this.d = 0;
			this.e.Text = "0 / ?";
			this.e.Color = Color.Gray;
			if (wj.c())
			{
				if (egg.v)
				{
					this.e.a(egg.n);
				}
				else
				{
					this.e.a(egg.ad);
				}
			}
			else
			{
				this.e.a(wj.eu);
			}
		}
		if (this.f != null)
		{
			this.f.b();
		}
	}

	// Token: 0x0600C088 RID: 49288 RVA: 0x0042BC60 File Offset: 0x00429E60
	public ecs yf(euz A_0)
	{
		if (this.d > 0)
		{
			coh coh = this.d();
			if (coh != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				return cq4.a(coh, (serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null, this, true, false, null, null, null, false);
			}
		}
		return null;
	}

	// Token: 0x0600C089 RID: 49289 RVA: 0x0042BCC0 File Offset: 0x00429EC0
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.f.b();
	}

	// Token: 0x0600C08A RID: 49290 RVA: 0x0042BCD8 File Offset: 0x00429ED8
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.f.b();
	}

	// Token: 0x0600C08B RID: 49291 RVA: 0x0042BCF0 File Offset: 0x00429EF0
	private void b()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			base.Size = cie.a;
			this.g = bj8.a;
		}
		else
		{
			base.Size = wj.et;
			this.g = wj.o;
		}
		this.e = new avo();
		this.e.Size = new esj(base.Size.c, base.Size.d - this.g.d);
		if (wj.c())
		{
			if (egg.v)
			{
				this.e.a(egg.n);
			}
			else
			{
				this.e.a(egg.ad);
			}
			this.e.Location = new Point(0, bj8.a.d + egg.b(this.e.g()));
		}
		else
		{
			this.e.a(wj.eu);
			this.e.Location = new Point(0, this.g.d + egg.b(this.e.g()) + 3);
		}
		this.e.a(cab.b);
		this.e.a(ad4.b);
		this.e.IsPrivateComponent = true;
		this.aox(this.e);
		string path = "Oddities\\" + this.b;
		this.c = new d48(ez2.CreateDefinitonProvider<x2>(path));
		this.c();
	}

	// Token: 0x0600C08C RID: 49292 RVA: 0x0042BE84 File Offset: 0x0042A084
	private void a()
	{
		if (this.f != null)
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
			this.f.a(a_);
		}
	}

	// Token: 0x0400458D RID: 17805
	public new static readonly esj a = new esj(53, 50);

	// Token: 0x0400458E RID: 17806
	private new string b;

	// Token: 0x0400458F RID: 17807
	private new d48 c;

	// Token: 0x04004590 RID: 17808
	private new int d;

	// Token: 0x04004591 RID: 17809
	private new avo e;

	// Token: 0x04004592 RID: 17810
	private new dsy f;

	// Token: 0x04004593 RID: 17811
	private new esj g;
}
