using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x02002029 RID: 8233
public sealed class c6a : a9t, amj
{
	// Token: 0x0600C2E1 RID: 49889 RVA: 0x004371A0 File Offset: 0x004353A0
	public override bool et()
	{
		if (base.IsMousedOver)
		{
			return true;
		}
		using (List<cao>.Enumerator enumerator = this.c.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsMousedOver)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600C2E2 RID: 49890 RVA: 0x00437214 File Offset: 0x00435414
	public c6a(b0b A_0, int A_1)
	{
		wj wj = wj.a();
		this.d = A_0;
		if (wj.c())
		{
			this.g = new esj(650, 30);
		}
		else
		{
			this.g = new esj(d05.a(650, A_1 / 2, wj.fq), wj.fr);
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.e = serviceOrThrow.aqu().q().b(this.d);
		if (this.e == null)
		{
			this.e = new string[10];
		}
		base.Text = "Заметки игрока";
		this.Focusable = true;
		for (int i = 0; i < 10; i++)
		{
			c68 c = this.c();
			if (wj.c())
			{
				c.Location = new Point(5, 30 + i * (c.Size.d + 2));
			}
			else
			{
				c.Location = new Point(10, wj.ci.d + 1 + i * (c.Size.d + 2));
			}
			c.Tag = i;
			c.e(new EventHandler<ane>(this.a));
			c.Text = (this.e[i] ?? "");
			c.j = c6a.a;
			if (string.IsNullOrWhiteSpace(c.Text))
			{
				c.b = Color.Gray;
			}
			else
			{
				c.b = Color.White;
			}
			this.aox(c);
			this.b.Add(c);
			cao cao = this.a();
			if (wj.c())
			{
				cao.Location = new Point(c.Location.X + c.Size.c - 30, c.Location.Y + 2);
			}
			else
			{
				cao.Location = new Point(c.Location.X + c.Size.c - cao.Size.c - 10, c.Location.Y + (c.Size.d - cao.Size.d) / 2);
			}
			cao.Tag = i;
			cao.Visible = (this.e[i] != null);
			this.aox(cao);
			this.c.Add(cao);
		}
		c68 c2 = this.b[9];
		esj esj;
		if (wj.c())
		{
			esj = new esj(c2.Size.c + 10, c2.Location.Y + c2.Size.d + 5);
			if (esj.d % 2 != 0)
			{
				esj = new esj(esj.c, esj.d + 1);
			}
		}
		else
		{
			esj = new esj(c2.Size.c + 20, c2.Location.Y + c2.Size.d + 5);
			wj.a(ref esj.d);
		}
		base.Size = esj;
		this.f = new dsy(this, this, esj.a(), cq4.a(300), null, null, 3000, false, false);
	}

	// Token: 0x0600C2E3 RID: 49891 RVA: 0x004375A4 File Offset: 0x004357A4
	public ecs yf(euz A_0)
	{
		string text = null;
		using (List<cao>.Enumerator enumerator = this.c.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsMousedOver)
				{
					text = "Нажмите, чтобы удалить заметку.";
					break;
				}
			}
		}
		if (text != null)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.White), text, null)
				})
			});
		}
		return null;
	}

	// Token: 0x0600C2E4 RID: 49892 RVA: 0x0043764C File Offset: 0x0043584C
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		this.f.a(A_0);
	}

	// Token: 0x0600C2E5 RID: 49893 RVA: 0x00437664 File Offset: 0x00435864
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (this.f != null)
		{
			this.f.b();
		}
	}

	// Token: 0x0600C2E6 RID: 49894 RVA: 0x00437688 File Offset: 0x00435888
	private c68 c()
	{
		wj wj = wj.a();
		c68 c = new c68();
		c.j = c6a.a;
		c.Size = this.g;
		if (wj.c())
		{
			c.e = bo1.b;
			c.a(egg.am);
		}
		else
		{
			c.e = wj.f;
			c.f = wj.fg;
			c.g = new esj?(wj.fh);
			c.a(wj.fo);
			c.a(wj.fp);
		}
		c.k = true;
		c.e(new EventHandler(this.a));
		c.i(new EventHandler(this.b));
		c.e(new EventHandler<ane>(this.b));
		c.a(new Vector2(32f, 1105f));
		return c;
	}

	// Token: 0x0600C2E7 RID: 49895 RVA: 0x00437774 File Offset: 0x00435974
	private void b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool flag = false;
			string[] array = this.e;
			for (int i = 0; i < array.Length; i++)
			{
				if (!string.IsNullOrWhiteSpace(array[i]))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				serviceOrThrow.aqu().q().a(this.d, this.e);
				return;
			}
			serviceOrThrow.aqu().q().c(this.d);
		}
	}

	// Token: 0x0600C2E8 RID: 49896 RVA: 0x00437800 File Offset: 0x00435A00
	private cao a()
	{
		wj wj = wj.a();
		doz doz = new doz();
		if (wj.c())
		{
			doz.a(bo1.bs);
			doz.a(new Point(50, 0));
			doz.Size = new esj(25, 25);
		}
		else
		{
			doz.a(wj.f);
			doz.a(new Point(wj.fs.X + 2 * wj.ft.c, wj.fs.Y));
			doz.Size = wj.ft;
		}
		doz.c(new EventHandler<b25>(this.e));
		doz.Gravity = axy.c;
		doz.j(new EventHandler<b25>(this.c));
		doz.l(new EventHandler<b25>(this.d));
		e4z.j(doz);
		return doz;
	}

	// Token: 0x0600C2E9 RID: 49897 RVA: 0x004378DC File Offset: 0x00435ADC
	protected override void aei(object A_0, ddj A_1)
	{
		base.aei(A_0, A_1);
		d1a serviceOrThrow = bpo.GetServiceOrThrow<d1a>();
		if (serviceOrThrow.aa7() is c68 && Enumerable.Contains<euz>(this.b, serviceOrThrow.aa7()))
		{
			base.a9();
		}
		bl9.a();
	}

	// Token: 0x0600C2EA RID: 49898 RVA: 0x00437928 File Offset: 0x00435B28
	private void b(object A_0, ane A_1)
	{
		c68 c = A_0 as c68;
		if (c != null)
		{
			this.a(c);
		}
	}

	// Token: 0x0600C2EB RID: 49899 RVA: 0x0043794C File Offset: 0x00435B4C
	private void a(c68 A_0)
	{
		if (A_0 != null)
		{
			int num = (int)A_0.Tag;
			if (string.IsNullOrWhiteSpace(A_0.Text))
			{
				A_0.b = Color.Gray;
				this.e[num] = null;
			}
			else
			{
				A_0.b = Color.White;
				this.e[num] = A_0.Text;
			}
			if (this.c != null && this.c.Count > num)
			{
				this.c[num].Visible = (this.e[num] != null);
			}
			this.b();
		}
	}

	// Token: 0x0600C2EC RID: 49900 RVA: 0x004379F8 File Offset: 0x00435BF8
	private void b(object A_0, EventArgs A_1)
	{
		c68 c = A_0 as c68;
		if (c != null)
		{
			this.a(c);
		}
		if (!(bpo.GetServiceOrThrow<d1a>().aa7() is c68))
		{
			base.a9();
		}
	}

	// Token: 0x0600C2ED RID: 49901 RVA: 0x00437A34 File Offset: 0x00435C34
	private void a(object A_0, EventArgs A_1)
	{
		c68 c = A_0 as c68;
		if (c != null)
		{
			bl9.a(c, aqo.a, null);
		}
	}

	// Token: 0x0600C2EE RID: 49902 RVA: 0x00437A60 File Offset: 0x00435C60
	protected override void y7(object A_0, ane A_1)
	{
		base.y7(A_0, A_1);
		if (A_1.a == Keys.Escape)
		{
			base.z();
		}
	}

	// Token: 0x0600C2EF RID: 49903 RVA: 0x00437A80 File Offset: 0x00435C80
	private void a(object A_0, ane A_1)
	{
		c68 c = A_0 as c68;
		if (c != null)
		{
			int num = (int)c.Tag;
			if (A_1.a == Keys.Up)
			{
				if (num > 0)
				{
					this.b[num - 1].a9();
					return;
				}
			}
			else if ((A_1.a == Keys.Down || A_1.a == Keys.Enter) && num < 9)
			{
				this.b[num + 1].a9();
			}
		}
	}

	// Token: 0x0600C2F0 RID: 49904 RVA: 0x00437B04 File Offset: 0x00435D04
	private new void e(object A_0, b25 A_1)
	{
		cao cao = A_0 as cao;
		if (cao != null)
		{
			cao.Visible = false;
			int num = (int)cao.Tag;
			this.e[num] = null;
			this.b[num].Text = "";
			this.b[num].b = Color.Gray;
			this.b();
		}
	}

	// Token: 0x0600C2F1 RID: 49905 RVA: 0x00437B70 File Offset: 0x00435D70
	private new void d(object A_0, b25 A_1)
	{
		this.f.b();
	}

	// Token: 0x0600C2F2 RID: 49906 RVA: 0x00437B80 File Offset: 0x00435D80
	private void c(object A_0, b25 A_1)
	{
		this.f.b();
	}

	// Token: 0x0600C2F3 RID: 49907 RVA: 0x00437B90 File Offset: 0x00435D90
	private void b(object A_0, b25 A_1)
	{
		this.f.b();
	}

	// Token: 0x0600C2F4 RID: 49908 RVA: 0x00437BA0 File Offset: 0x00435DA0
	private void a(object A_0, b25 A_1)
	{
		this.f.b();
	}

	// Token: 0x040046A9 RID: 18089
	private new static readonly string a = "  <заметка>";

	// Token: 0x040046AA RID: 18090
	private new List<c68> b = new List<c68>();

	// Token: 0x040046AB RID: 18091
	private new List<cao> c = new List<cao>();

	// Token: 0x040046AC RID: 18092
	private new b0b d;

	// Token: 0x040046AD RID: 18093
	private new string[] e;

	// Token: 0x040046AE RID: 18094
	private new dsy f;

	// Token: 0x040046AF RID: 18095
	private new esj g;
}
