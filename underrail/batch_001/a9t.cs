using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002024 RID: 8228
public class a9t : amm
{
	// Token: 0x0600C2C9 RID: 49865 RVA: 0x00436928 File Offset: 0x00434B28
	public bool j()
	{
		return this.c;
	}

	// Token: 0x0600C2CA RID: 49866 RVA: 0x00436930 File Offset: 0x00434B30
	public void a(bool A_0)
	{
		if (this.c != A_0)
		{
			this.c = A_0;
			this.a();
		}
	}

	// Token: 0x0600C2CB RID: 49867 RVA: 0x0043694C File Offset: 0x00434B4C
	public a9t()
	{
		this.b();
	}

	// Token: 0x0600C2CC RID: 49868 RVA: 0x00436978 File Offset: 0x00434B78
	private void b()
	{
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			this.d = wj.f;
			this.e = wj.b6;
			this.f = wj.b7;
			this.g = wj.ch;
			this.h = wj.ci;
			this.i = this.h.d;
		}
		this.a = new avo();
		this.a.a(cab.a);
		this.a.a(ad4.b);
		this.a.IsPrivateComponent = true;
		if (wj.d == UiSize.Classic)
		{
			if (egg.v)
			{
				this.a.a(egg.a);
				this.a.Location = new Point(10, 6);
			}
			else
			{
				this.a.a(egg.ap);
				this.a.Location = new Point(10, egg.b(this.a.g()));
			}
		}
		else
		{
			this.a.a(wj.ce);
			this.a.Location = new Point(wj.cf, egg.b(wj.ce));
		}
		this.a.Color = Color.Black;
		this.aox(this.a);
		this.b = new doz();
		if (wj.d == UiSize.Classic)
		{
			this.b.Size = new esj(this.i, this.i);
			this.b.a(bo1.ac);
			this.b.a(new Point(0, this.i * 2));
		}
		else
		{
			this.b.Size = wj.cg;
			this.b.a(wj.f);
			this.b.a(new Point(wj.ch.X, wj.ch.Y + wj.ci.d * 2));
		}
		this.b.IsPrivateComponent = true;
		this.b.c(new EventHandler<b25>(this.a));
		this.aox(this.b);
		this.a();
	}

	// Token: 0x0600C2CD RID: 49869 RVA: 0x00436BC4 File Offset: 0x00434DC4
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C2CE RID: 49870 RVA: 0x00436BD4 File Offset: 0x00434DD4
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C2CF RID: 49871 RVA: 0x00436BE4 File Offset: 0x00434DE4
	private void a(object A_0, b25 A_1)
	{
		base.z();
	}

	// Token: 0x0600C2D0 RID: 49872 RVA: 0x00436BEC File Offset: 0x00434DEC
	public override void iv(e6d A_0, cp9 A_1)
	{
		cne service = bpo.GetService<cne>();
		if (service != null)
		{
			wj wj = wj.a();
			Point point = base.at();
			if (wj.d == UiSize.Classic)
			{
				if (!string.IsNullOrEmpty(this.d))
				{
					Texture2D resource = service.GetResource<Texture2D>(this.d, null);
					if (resource != null)
					{
						esj a_ = c4o.a(resource, 3, 3);
						c4o.b(A_1, resource, a_, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), base.Color, true, null);
					}
				}
				Texture2D resource2 = service.GetResource<Texture2D>(bo1.ac, null);
				if (resource2 != null)
				{
					Rectangle a_2 = new Rectangle(point.X, point.Y, base.Size.c - (this.b.Visible ? (this.b.Size.c - 2) : 0), this.i);
					Rectangle a_3 = new Rectangle(0, this.b.Visible ? this.i : 0, 3 * this.i, this.i);
					c4o.a(A_1, resource2, a_3, a_2, base.Color);
				}
			}
			else
			{
				Texture2D texture2D = service.us(this.d, null);
				if (texture2D != null)
				{
					c4o.b(A_1, texture2D, this.f, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), base.Color, true, new Point?(this.e));
					Rectangle a_4 = new Rectangle(point.X, point.Y, base.Size.c - (this.b.Visible ? (this.b.Size.c - 2) : 0), this.h.d);
					Rectangle a_5 = new Rectangle(this.g.X, this.g.Y + (this.b.Visible ? this.h.d : 0), this.h.c * 3, this.h.d);
					c4o.a(A_1, texture2D, a_5, a_4, base.Color);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C2D1 RID: 49873 RVA: 0x00436E78 File Offset: 0x00435078
	private void a()
	{
		if (this.b != null)
		{
			this.b.Location = new Point(base.Size.c - this.b.Size.c, 0);
			this.b.Visible = this.c;
			this.a.Text = base.Text;
			this.a.Size = new esj(this.b.Location.X - this.a.Location.X, this.i);
		}
	}

	// Token: 0x0400468F RID: 18063
	private new avo a;

	// Token: 0x04004690 RID: 18064
	private new doz b;

	// Token: 0x04004691 RID: 18065
	private new bool c = true;

	// Token: 0x04004692 RID: 18066
	public new string d = bo1.m;

	// Token: 0x04004693 RID: 18067
	public new Point e;

	// Token: 0x04004694 RID: 18068
	public new esj f;

	// Token: 0x04004695 RID: 18069
	public new Point g;

	// Token: 0x04004696 RID: 18070
	public esj h;

	// Token: 0x04004697 RID: 18071
	public int i = 27;
}
