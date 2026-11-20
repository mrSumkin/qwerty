using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002068 RID: 8296
public sealed class a4c : au6
{
	// Token: 0x0600C5C6 RID: 50630 RVA: 0x00450F98 File Offset: 0x0044F198
	public Type c()
	{
		return this.e;
	}

	// Token: 0x0600C5C7 RID: 50631 RVA: 0x00450FA0 File Offset: 0x0044F1A0
	public void a(Type A_0)
	{
		this.e = A_0;
		this.a();
	}

	// Token: 0x0600C5C8 RID: 50632 RVA: 0x00450FB0 File Offset: 0x0044F1B0
	public a4c()
	{
		wj wj = wj.a();
		int num;
		int num2;
		int num3;
		this.a(out num, out num2, out num3);
		if (wj.c())
		{
			base.b(bo1.r);
		}
		else
		{
			base.b(wj.f);
			this.n = wj.b8;
			this.o = new esj?(wj.b9);
		}
		this.Focusable = false;
		this.a = new avo();
		if (wj.c())
		{
			this.a.a(egg.d);
			this.a.Location = new Point(60, 20);
		}
		else
		{
			int num4 = (wj.o.d - num2 * 2) / 2;
			this.a.a(wj.go);
			this.a.Location = new Point(wj.fv.c / 2 + wj.o.c, wj.fv.d + num4 + num2 / 2);
		}
		this.a.a(cab.a);
		this.a.a(ad4.a);
		this.a.IsPrivateComponent = true;
		this.a.Color = adi.c;
		this.b = new avo();
		if (wj.c())
		{
			if (egg.v)
			{
				this.b.a(egg.a);
			}
			else
			{
				this.b.a(egg.@as);
			}
			this.b.Location = new Point(10, 75);
		}
		else
		{
			this.b.a(wj.gg);
			this.b.Location = new Point(wj.fv.c / 2, this.a.Location.Y + (int)(2f * (float)num2));
		}
		this.b.Color = adi.a;
		this.b.a(cab.a);
		this.b.a(ad4.a);
		this.b.IsPrivateComponent = true;
		this.c = new avo();
		if (wj.c())
		{
			this.c.a(egg.b);
			this.c.Location = new Point(10, 370);
			this.c.Size = new esj(380, 150);
		}
		else
		{
			this.c.a(wj.gi);
		}
		this.c.a(cab.a);
		this.c.a(ad4.a);
		this.c.IsPrivateComponent = true;
		this.c.Text = dh9.c("CharScreen_Requirements");
		this.d = new avo();
		if (wj.c())
		{
			this.d.Location = new Point(10, 400);
			this.d.Size = new esj(380, 150);
			if (egg.v)
			{
				this.d.a(egg.a);
			}
			else
			{
				this.d.a(egg.@as);
			}
		}
		else
		{
			this.d.a(wj.gg);
		}
		this.d.Color = adi.a;
		this.d.a(cab.a);
		this.d.a(ad4.a);
		this.d.IsPrivateComponent = true;
		this.aox(this.a);
		this.aox(this.b);
		this.aox(this.c);
		this.aox(this.d);
		this.b();
		this.a();
	}

	// Token: 0x0600C5C9 RID: 50633 RVA: 0x00451374 File Offset: 0x0044F574
	private void a(out int A_0, out int A_1, out int A_2)
	{
		A_0 = 0;
		A_1 = 0;
		A_2 = 0;
		wj wj = wj.a();
		if (!wj.c())
		{
			base.b(wj.f);
			this.n = wj.b8;
			this.o = new esj?(wj.b9);
			cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
			try
			{
				A_0 = serviceOrThrow.GetResource<SpriteFont>(wj.gg, null).LineSpacing;
				A_1 = serviceOrThrow.GetResource<SpriteFont>(wj.go, null).LineSpacing;
				A_2 = serviceOrThrow.GetResource<SpriteFont>(wj.gi, null).LineSpacing;
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600C5CA RID: 50634 RVA: 0x0045143C File Offset: 0x0044F63C
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (dr3.a() != null && this.e != null)
		{
			Point point = base.at();
			c3i c3i = ejh.b("feat." + ck.a(this.e), null);
			if (c3i != null)
			{
				wj wj = wj.a();
				if (wj.c())
				{
					c3i.a(A_1, new Vector2((float)(point.X + 10), (float)(point.Y + 17)), Color.White, 1f, 0, null);
					return;
				}
				Rectangle a_ = new Rectangle(point.X + wj.fv.c / 2, Convert.ToInt32((float)point.Y + (float)wj.fv.d * 0.75f), wj.o.c, wj.o.d);
				c3i.a(A_1, a_, Color.White, 0, null);
			}
		}
	}

	// Token: 0x0600C5CB RID: 50635 RVA: 0x00451544 File Offset: 0x0044F744
	private void b()
	{
		if (this.a == null)
		{
			return;
		}
		wj wj = wj.a();
		if (wj.c())
		{
			this.a.Size = new esj(base.Size.c - 58, 80);
			this.b.Size = new esj(base.Size.c - 2 * this.b.Location.X, base.Size.d - base.Location.Y);
			return;
		}
		int num;
		int num2;
		int num3;
		this.a(out num, out num2, out num3);
		this.a.Size = new esj(base.Size.c - wj.fv.c - wj.o.c - 5, num2 * 2);
		this.b.Size = new esj(base.Size.c - 2 * this.b.Location.X, base.Size.d - this.b.Location.Y);
		this.c.Location = new Point(this.b.Location.X, (int)((float)this.b.Size.d * 0.875f));
		this.c.Size = new esj(base.Size.c - 2 * this.c.Location.X, num3);
		this.d.Location = new Point(this.c.Location.X, this.c.Location.Y + (int)(1.15f * (float)num3));
		this.d.Size = new esj(base.Size.c - 2 * this.c.Location.X, base.Size.d - this.d.Location.Y);
	}

	// Token: 0x0600C5CC RID: 50636 RVA: 0x00451750 File Offset: 0x0044F950
	private void a()
	{
		wj wj = wj.a();
		this.f = null;
		if (this.e != null)
		{
			this.f = ck.b(this.e);
		}
		if (this.e == null || this.f == null)
		{
			this.a.Text = qv.b("Feats/Feats");
			if (wj.c())
			{
				this.a.Location = new Point(10, 20);
				this.a.a(ad4.a);
			}
			else
			{
				int num;
				int num2;
				int num3;
				this.a(out num, out num2, out num3);
				int num4 = (wj.o.d - num2 * 2) / 2;
				this.a.Location = new Point(wj.fv.c / 2, wj.fv.d / 2 + num4 + num2 / 2);
				this.a.a(ad4.b);
			}
			this.b.Text = qv.b("Feats/GeneralInfo");
			this.c.Visible = false;
			this.d.Visible = false;
			return;
		}
		string text = this.f.Name;
		string text2 = qv.b("FeatNames/" + text);
		if (!string.IsNullOrEmpty(text2))
		{
			text = text2;
		}
		this.a.Text = text;
		this.a.a(ad4.b);
		if (wj.c())
		{
			this.a.Location = new Point(60, 3);
		}
		else
		{
			int num5;
			int num6;
			int num7;
			this.a(out num5, out num6, out num7);
			int num8 = (wj.o.d - num6 * 2) / 2;
			this.a.Location = new Point(wj.fv.c + wj.o.c, wj.fv.d / 2 + num8 + num6 / 2);
		}
		this.b.Text = qv.a("Feats/" + this.f.wn(), this.f.at());
		List<brl> list = this.f.j0();
		this.c.Visible = (list != null && list.Count > 0);
		this.d.Visible = (list != null && list.Count > 0);
		this.d.Text = "";
		if (list != null)
		{
			foreach (brl brl in list)
			{
				avo avo = this.d;
				avo.Text = avo.Text + "- " + brl.ToString() + "\r\n";
			}
		}
		if (!this.f.Purchasable)
		{
			this.a.Color = Color.OrangeRed;
			avo avo2 = this.b;
			avo2.Text += "\r\n\r\nЭто умение получено не при повышении уровня.";
			return;
		}
		if (this.f.Veteran)
		{
			this.a.Color = new Color(145, 238, 255);
			return;
		}
		this.a.Color = adi.c;
	}

	// Token: 0x0600C5CD RID: 50637 RVA: 0x00451AC0 File Offset: 0x0044FCC0
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x0400488A RID: 18570
	private new avo a;

	// Token: 0x0400488B RID: 18571
	private new avo b;

	// Token: 0x0400488C RID: 18572
	private new avo c;

	// Token: 0x0400488D RID: 18573
	private new avo d;

	// Token: 0x0400488E RID: 18574
	private new Type e;

	// Token: 0x0400488F RID: 18575
	private new ai8 f;
}
