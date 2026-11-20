using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002009 RID: 8201
public sealed class a0d : euz, amj
{
	// Token: 0x0600C1A3 RID: 49571 RVA: 0x00431698 File Offset: 0x0042F898
	public esj e()
	{
		return this.d;
	}

	// Token: 0x0600C1A4 RID: 49572 RVA: 0x004316A0 File Offset: 0x0042F8A0
	public void a(esj A_0)
	{
		if (esj.c(this.d, A_0))
		{
			this.d = A_0;
			this.b();
		}
	}

	// Token: 0x0600C1A5 RID: 49573 RVA: 0x004316C0 File Offset: 0x0042F8C0
	public float d()
	{
		return this.e;
	}

	// Token: 0x0600C1A6 RID: 49574 RVA: 0x004316C8 File Offset: 0x0042F8C8
	public void a(float A_0)
	{
		if (this.e != A_0)
		{
			this.e = A_0;
			this.b();
		}
	}

	// Token: 0x0600C1A7 RID: 49575 RVA: 0x004316E4 File Offset: 0x0042F8E4
	public efk f()
	{
		return this.f;
	}

	// Token: 0x0600C1A8 RID: 49576 RVA: 0x004316EC File Offset: 0x0042F8EC
	public void a(efk A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600C1A9 RID: 49577 RVA: 0x004316F8 File Offset: 0x0042F8F8
	public a0d(efk A_0, esj A_1, float A_2)
	{
		this.f = A_0;
		this.d = A_1;
		this.e = A_2;
		this.b();
		this.k = new dsy(this, this, new esj(150, 0), 250, null, null, 1000, false, false);
		this.k.a(true);
	}

	// Token: 0x0600C1AA RID: 49578 RVA: 0x00431784 File Offset: 0x0042F984
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.f == null)
		{
			return;
		}
		cne service = bpo.GetService<cne>();
		if (service != null)
		{
			wj wj = wj.a();
			Point point = base.at();
			int num = 0;
			int num2 = 0;
			SpriteFont resource;
			if (wj.d == UiSize.Classic)
			{
				if (egg.v)
				{
					resource = service.GetResource<SpriteFont>(egg.n, null);
				}
				else
				{
					resource = service.GetResource<SpriteFont>(egg.ad, null);
				}
			}
			else
			{
				resource = service.GetResource<SpriteFont>(this.c(), null);
			}
			Color color = Color.White * ((float)this.g / 255f);
			foreach (els els in this.f.StatusEffects.d())
			{
				if (els.Visible)
				{
					string text;
					bool flag;
					a0d.a(els, dz6.e(), out text, out flag);
					Vector2 vector = new Vector2((float)(point.X + num2 * (this.l.c + this.n)), (float)(point.Y + num * (this.l.d + this.o + this.m + this.n)));
					c3i c3i = ejh.b(els.Icon, service);
					if (wj.d == UiSize.Classic)
					{
						if (c3i != null)
						{
							c3i.a(A_1, vector, flag ? color : Color.White, this.e, 0, null);
						}
					}
					else if (c3i != null)
					{
						Rectangle a_ = new Rectangle((int)vector.X, (int)vector.Y, this.l.c, this.l.d);
						c3i.a(A_1, a_, flag ? color : Color.White, 0, null);
					}
					if (resource != null)
					{
						if (text != null)
						{
							float num3 = ((float)this.l.c - resource.MeasureString(text).X) / 2f;
							A_1.b().xb(resource, text, new Vector2(vector.X + num3, vector.Y + (float)this.l.d + (float)this.o), Color.White);
						}
						if (els.Stacks > 1)
						{
							SpriteFont resource2;
							if (wj.c())
							{
								resource2 = service.GetResource<SpriteFont>(egg.n, null);
							}
							else
							{
								resource2 = service.GetResource<SpriteFont>(wj.s, null);
							}
							if (resource2 != null)
							{
								if (wj.c())
								{
									string text2 = els.Stacks.ToString();
									Vector2 vector2 = resource2.MeasureString(text2);
									A_1.b().xb(resource2, text2, new Vector2(vector.X + ((float)this.l.c - vector2.X), vector.Y + ((float)this.l.d - vector2.Y)), Color.White);
								}
								else
								{
									string text3 = els.Stacks.ToString();
									Vector2 vector3 = resource2.MeasureString(text3);
									Vector2 a_2 = new Vector2(vector.X + (float)this.l.c - vector3.X + 2f, vector.Y + (float)this.l.d - vector3.Y + (float)egg.b(wj.s) + 2f);
									A_1.b().xb(resource2, text3, a_2, Color.White);
								}
							}
						}
					}
					if (++num2 >= this.d.c)
					{
						if (++num >= this.d.d)
						{
							break;
						}
						num2 = 0;
					}
				}
			}
		}
		base.iv(A_0, A_1);
		this.k.a(A_0);
	}

	// Token: 0x0600C1AB RID: 49579 RVA: 0x00431BCC File Offset: 0x0042FDCC
	private string c()
	{
		UiSize uiSize = wj.b();
		if (uiSize == UiSize.Huge)
		{
			return egg.au;
		}
		if (uiSize == UiSize.Large)
		{
			return egg.am;
		}
		return egg.ad;
	}

	// Token: 0x0600C1AC RID: 49580 RVA: 0x00431C00 File Offset: 0x0042FE00
	public override void ag5(e6d A_0)
	{
		this.a();
		if (this.f == null)
		{
			return;
		}
		if ((this.i += A_0.a().TotalGameTime.TotalMilliseconds) > 200.0)
		{
			if (this.h)
			{
				if ((this.g += 15) == 255)
				{
					this.h = false;
				}
			}
			else if ((this.g -= 15) == 0)
			{
				this.h = true;
			}
			this.i -= 200.0;
		}
		els els = null;
		Point point = base.at();
		if (base.iz(A_0.b()))
		{
			int num = (A_0.b().Y - point.Y) / (this.l.d + this.o + this.m + this.n);
			int num2 = (A_0.b().X - point.X) / (this.l.c + this.n);
			int num3 = num * this.d.c + num2;
			int num4 = 0;
			if (num3 >= 0 && this.f.StatusEffects.d().Count > num3)
			{
				foreach (els els2 in this.f.StatusEffects.d())
				{
					if (els2.Visible)
					{
						if (num3 == num4)
						{
							els = els2;
							break;
						}
						num4++;
					}
				}
			}
		}
		if (els != this.j)
		{
			this.j = els;
			int num5 = Math.Min(this.d.c, this.f.StatusEffects.d().Count);
			this.k.a(new Rectangle?(new Rectangle(point.X + 5 + (num5 - 1) * (this.l.c + this.n), point.Y, this.l.c, this.l.d)));
			this.k.b();
		}
		base.ag5(A_0);
	}

	// Token: 0x0600C1AD RID: 49581 RVA: 0x00431E88 File Offset: 0x00430088
	public override bool iz(MouseState A_0)
	{
		return false;
	}

	// Token: 0x0600C1AE RID: 49582 RVA: 0x00431E8C File Offset: 0x0043008C
	public ecs yf(euz A_0)
	{
		ll a_ = new ll(this.f);
		if (this.j != null)
		{
			ecs ecs = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.d(), adi.ai[this.j.Nature]), this.j.LocalizedName, null)
				}),
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.White), null, null)
				})
			});
			string text = null;
			try
			{
				text = this.j.cb(a_);
			}
			catch
			{
			}
			if (text != null)
			{
				foreach (string a_2 in text.Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None))
				{
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), a_2, null)
					}));
				}
			}
			return ecs;
		}
		return null;
	}

	// Token: 0x0600C1AF RID: 49583 RVA: 0x00431FC8 File Offset: 0x004301C8
	private void b()
	{
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			this.l = esj.b(bj8.a, (double)this.e);
		}
		else
		{
			this.l = esj.b(wj.o, (double)this.e);
		}
		cne service = bpo.GetService<cne>();
		this.m = 0;
		if (service != null)
		{
			SpriteFont resource = service.GetResource<SpriteFont>(cq4.c(), null);
			if (resource != null)
			{
				this.m = resource.LineSpacing;
			}
		}
		base.Size = new esj(this.d.c * (this.l.c + this.n) - this.n, this.d.d * (this.l.d + this.o + this.m + this.n) - this.n);
	}

	// Token: 0x0600C1B0 RID: 49584 RVA: 0x004320B8 File Offset: 0x004302B8
	private void a()
	{
		if (this.k != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			int num = 250;
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				num = (int)((double)num * 2.5);
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				num *= 2;
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				num = (int)((double)num * 1.5);
			}
			this.k.a(num);
		}
	}

	// Token: 0x0600C1B1 RID: 49585 RVA: 0x00432154 File Offset: 0x00430354
	private static void a(els A_0, bool A_1, out string A_2, out bool A_3)
	{
		if (A_0.Duration > 0)
		{
			double num;
			if (A_0.p && A_0.Stacks > 1)
			{
				num = A_0.TimeLeft + (double)((A_0.Stacks - 1) * A_0.Duration);
			}
			else
			{
				num = A_0.TimeLeft;
			}
			A_2 = cq4.a(num, A_1);
			A_3 = (num <= (double)a0d.c);
			return;
		}
		A_2 = null;
		A_3 = false;
	}

	// Token: 0x04004613 RID: 17939
	private new const int a = 200;

	// Token: 0x04004614 RID: 17940
	private new const byte b = 15;

	// Token: 0x04004615 RID: 17941
	private new static readonly int c = d0u.b;

	// Token: 0x04004616 RID: 17942
	private new esj d;

	// Token: 0x04004617 RID: 17943
	private new float e;

	// Token: 0x04004618 RID: 17944
	private new efk f;

	// Token: 0x04004619 RID: 17945
	private new byte g = byte.MaxValue;

	// Token: 0x0400461A RID: 17946
	private bool h;

	// Token: 0x0400461B RID: 17947
	private double i;

	// Token: 0x0400461C RID: 17948
	private new els j;

	// Token: 0x0400461D RID: 17949
	private new dsy k;

	// Token: 0x0400461E RID: 17950
	private new esj l;

	// Token: 0x0400461F RID: 17951
	private new int m;

	// Token: 0x04004620 RID: 17952
	private int n = 3;

	// Token: 0x04004621 RID: 17953
	private int o = 2;
}
