using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002019 RID: 8217
public sealed class bdv : cao
{
	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x0600C264 RID: 49764 RVA: 0x00434C70 File Offset: 0x00432E70
	// (set) Token: 0x0600C265 RID: 49765 RVA: 0x00434C7C File Offset: 0x00432E7C
	public override bool CheckOnClick
	{
		get
		{
			return this.f == c7s.b;
		}
		set
		{
		}
	}

	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x0600C266 RID: 49766 RVA: 0x00434C80 File Offset: 0x00432E80
	// (set) Token: 0x0600C267 RID: 49767 RVA: 0x00434C88 File Offset: 0x00432E88
	[Category("Behavior")]
	public c7s FeatAvailability
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
			this.a();
		}
	}

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x0600C268 RID: 49768 RVA: 0x00434C98 File Offset: 0x00432E98
	public Type FeatType
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x0600C269 RID: 49769 RVA: 0x00434CA4 File Offset: 0x00432EA4
	public bdv(Type A_0, c7s A_1)
	{
		czh.a(A_0, "featType");
		wj wj = wj.a();
		this.g = A_0;
		if (this.g != null)
		{
			this.h = ck.b(this.g);
		}
		this.f = A_1;
		this.e = new avo();
		this.e.IsPrivateComponent = true;
		if (wj.c())
		{
			this.e.a(egg.b);
		}
		else
		{
			this.c = wj.f;
			this.d = wj.g0;
			this.a = wj.g1.c;
			this.b = wj.g1.d;
			this.e.a(wj.gm);
			this.i = wj.o.c / 4;
			this.j = new Point(this.i * 2 + wj.o.c, wj.gn);
		}
		this.e.a(cab.a);
		this.e.a(ad4.b);
		this.aox(this.e);
		this.a();
		e4z.f(this);
	}

	// Token: 0x0600C26A RID: 49770 RVA: 0x00434E1C File Offset: 0x0043301C
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C26B RID: 49771 RVA: 0x00434E30 File Offset: 0x00433030
	public override void iv(e6d A_0, cp9 A_1)
	{
		wj wj = wj.a();
		bool a_ = true;
		int y = 0;
		Color black;
		Color a_2;
		if (this.f == c7s.b)
		{
			if (base.Checked || this.IsMousedOver)
			{
				y = 1;
				black = Color.Black;
				a_2 = new Color(60, 60, 60);
			}
			else
			{
				black = adi.a;
				a_2 = new Color(165, 165, 165);
				y = 2;
				a_ = false;
			}
		}
		else if (this.f == c7s.c)
		{
			black = adi.b;
			a_2 = new Color(75, 75, 75);
			y = 3;
			a_ = false;
		}
		else
		{
			black = adi.a;
			a_2 = new Color(165, 165, 165);
		}
		cne cne = dr3.a();
		if (cne != null)
		{
			Texture2D resource = cne.GetResource<Texture2D>(this.c, null);
			Point point = base.at();
			if (resource != null)
			{
				c4o.b(A_1, resource, new esj(this.a, this.b), new Point(0, y), new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), Color.White, a_, new Point?(this.d));
			}
			if (this.g != null)
			{
				c3i c3i = ejh.b("Feat." + ck.a(this.g), null);
				if (c3i != null)
				{
					esj o;
					if (wj.c())
					{
						o = bj8.a;
					}
					else
					{
						o = wj.o;
					}
					Rectangle a_3 = new Rectangle(point.X + this.i, point.Y + (base.Size.d - o.d) / 2, o.c, o.d);
					c3i.a(A_1, a_3, a_2, 0, null);
				}
			}
		}
		this.e.Color = black;
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C26C RID: 49772 RVA: 0x0043503C File Offset: 0x0043323C
	private void a()
	{
		if (this.e != null)
		{
			this.e.Location = this.j;
			this.e.Size = new esj(base.Size.c - this.j.X, base.Size.d);
			if (this.g == null)
			{
				this.e.Text = string.Empty;
				return;
			}
			ai8 ai = ck.b(this.g);
			if (ai == null)
			{
				this.e.Text = string.Empty;
				return;
			}
			string text = ai.Name;
			string text2 = qv.b("FeatNames/" + text);
			if (!string.IsNullOrEmpty(text2))
			{
				text = text2;
			}
			if (text.Length > 25)
			{
				cne service = bpo.GetService<cne>();
				if (service != null)
				{
					SpriteFont resource = service.GetResource<SpriteFont>(this.e.g(), null);
					if (resource != null && resource.MeasureString(text).X - 5f > (float)this.e.Size.c)
					{
						text = text.Substring(0, 25) + ".";
					}
				}
				else
				{
					text = text.Substring(0, 25) + ".";
				}
			}
			this.e.Text = text;
		}
	}

	// Token: 0x04004651 RID: 18001
	private new int a = 43;

	// Token: 0x04004652 RID: 18002
	private new int b = 18;

	// Token: 0x04004653 RID: 18003
	private new string c = bo1.a;

	// Token: 0x04004654 RID: 18004
	private new Point d;

	// Token: 0x04004655 RID: 18005
	private new avo e;

	// Token: 0x04004656 RID: 18006
	private new c7s f = c7s.b;

	// Token: 0x04004657 RID: 18007
	private new Type g;

	// Token: 0x04004658 RID: 18008
	private ai8 h;

	// Token: 0x04004659 RID: 18009
	public int i = 15;

	// Token: 0x0400465A RID: 18010
	public new Point j = new Point(65, 8);
}
