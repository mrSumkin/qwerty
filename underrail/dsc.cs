using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002070 RID: 8304
public sealed class dsc : au6
{
	// Token: 0x0600C62C RID: 50732 RVA: 0x00454B84 File Offset: 0x00452D84
	public Type d()
	{
		return this.h;
	}

	// Token: 0x0600C62D RID: 50733 RVA: 0x00454B8C File Offset: 0x00452D8C
	public void a(Type A_0)
	{
		this.h = A_0;
		this.a();
	}

	// Token: 0x0600C62E RID: 50734 RVA: 0x00454B9C File Offset: 0x00452D9C
	public dsc()
	{
		this.c();
	}

	// Token: 0x0600C62F RID: 50735 RVA: 0x00454BB0 File Offset: 0x00452DB0
	private void c()
	{
		wj wj = wj.a();
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
			this.a.a(egg.e);
		}
		else
		{
			this.a.a(wj.gh);
		}
		this.a.a(cab.a);
		this.a.a(ad4.a);
		this.a.IsPrivateComponent = true;
		this.b = new avo();
		this.b.Color = adi.a;
		this.b.a(cab.a);
		this.b.a(ad4.a);
		this.b.IsPrivateComponent = true;
		this.c = new avo();
		this.c.a(cab.a);
		this.c.a(ad4.a);
		this.c.IsPrivateComponent = true;
		this.c.Text = dh9.c("CharScreen_RelatedBaseAbility");
		this.d = new avo();
		this.d.Color = adi.a;
		this.d.a(cab.a);
		this.d.a(ad4.a);
		this.d.IsPrivateComponent = true;
		this.e = new avo();
		this.e.a(cab.a);
		this.e.a(ad4.a);
		this.e.IsPrivateComponent = true;
		this.e.Text = dh9.c("CharScreen_Synergies");
		this.f = new avo();
		this.f.Color = adi.a;
		this.f.a(cab.a);
		this.f.a(ad4.a);
		this.f.IsPrivateComponent = true;
		this.g = new avo();
		this.g.Color = adi.a;
		this.g.a(cab.a);
		this.g.a(ad4.a);
		this.g.IsPrivateComponent = true;
		this.aox(this.a);
		this.aox(this.b);
		this.aox(this.c);
		this.aox(this.d);
		this.aox(this.e);
		this.aox(this.f);
		this.aox(this.g);
		this.b();
		this.a();
	}

	// Token: 0x0600C630 RID: 50736 RVA: 0x00454E5C File Offset: 0x0045305C
	private void b()
	{
		if (this.a == null)
		{
			return;
		}
		wj wj = wj.a();
		int a_ = 0;
		int num = 0;
		int num2 = 0;
		if (!wj.c())
		{
			cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
			try
			{
				a_ = serviceOrThrow.GetResource<SpriteFont>(wj.gg, null).LineSpacing;
				num = serviceOrThrow.GetResource<SpriteFont>(wj.gh, null).LineSpacing;
				num2 = serviceOrThrow.GetResource<SpriteFont>(wj.gi, null).LineSpacing;
			}
			catch
			{
			}
		}
		if (wj.c())
		{
			this.a.Location = new Point(10, 20);
			this.a.Size = new esj(base.Size.c - 2 * this.b.Location.X, 40);
		}
		else
		{
			this.a.Location = new Point(wj.fv.c / 2, wj.fv.d);
			this.a.Size = new esj(base.Size.c - 2 * this.b.Location.X, num + 2);
		}
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
			this.b.Location = new Point(10, 70);
		}
		else
		{
			this.b.a(wj.gg);
			this.b.Location = new Point(this.a.Location.X, this.a.Location.Y + (int)(1.5f * (float)num));
		}
		this.b.Size = new esj(base.Size.c - 2 * this.b.Location.X, base.Size.d - base.Location.Y);
		if (wj.c())
		{
			this.c.a(egg.b);
			this.c.Location = new Point(10, 350);
			this.c.Size = new esj(300, 80);
		}
		else
		{
			this.c.a(wj.gi);
			this.c.Location = new Point(this.b.Location.X, (int)((float)this.b.Size.d * 0.66f));
			this.c.Size = new esj(base.Size.c - 2 * this.c.Location.X, num2);
		}
		if (wj.c())
		{
			this.d.Location = new Point(10, 380);
			this.d.Size = new esj(300, 80);
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
			this.d.Location = new Point(this.c.Location.X, this.c.Location.Y + (int)(1.15f * (float)num2));
			this.d.Size = new esj(base.Size.c - 2 * this.d.Location.X, a_);
			this.d.a(wj.gg);
		}
		if (wj.c())
		{
			this.e.a(egg.b);
			this.e.Location = new Point(10, 420);
			this.e.Size = new esj(300, 80);
		}
		else
		{
			this.e.a(wj.gi);
			this.e.Location = new Point(this.c.Location.X, (int)((float)this.b.Size.d * 0.82f));
			this.e.Size = new esj(base.Size.c - this.e.Location.X, num2);
		}
		if (wj.c())
		{
			this.f.Location = new Point(10, 450);
			this.f.Size = new esj(300, 80);
			if (egg.v)
			{
				this.f.a(egg.a);
			}
			else
			{
				this.f.a(egg.@as);
			}
		}
		else
		{
			this.f.Location = new Point(this.e.Location.X, this.e.Location.Y + (int)(1.15f * (float)num2));
			this.f.Size = new esj(base.Size.c - 2 * this.f.Location.X, a_);
			this.f.Size = new esj(base.Size.c - 2 * this.f.Location.X, base.Size.d - this.f.Location.Y);
			this.f.a(wj.gg);
		}
		if (!wj.c())
		{
			this.g.Location = new Point((int)((float)base.Size.c * 0.7f), this.f.Location.Y);
			this.g.Size = new esj(base.Size.c - this.g.Location.X - 20, a_);
			this.g.Size = new esj(base.Size.c - this.g.Location.X - 20, base.Size.d - this.f.Location.Y);
			this.g.a(wj.gg);
			return;
		}
		this.g.Location = new Point(300, 450);
		this.g.Size = new esj(100, 80);
		if (egg.v)
		{
			this.g.a(egg.a);
			return;
		}
		this.g.a(egg.@as);
	}

	// Token: 0x0600C631 RID: 50737 RVA: 0x0045555C File Offset: 0x0045375C
	private void a()
	{
		if (this.h == null)
		{
			this.a.Text = qv.b("Skills/Skills");
			this.b.Text = qv.b("Skills/GeneralInfo");
			this.c.Visible = false;
			this.d.Visible = false;
			this.e.Visible = false;
			this.f.Visible = false;
			this.g.Visible = false;
			return;
		}
		csn csn = null;
		try
		{
			Type type = this.h;
			object[] array = new object[2];
			array[0] = 0;
			csn = (Activator.CreateInstance(type, array) as csn);
		}
		catch
		{
		}
		if (csn != null)
		{
			string str = csn.aib();
			this.a.Text = dh9.a("SkillEnum." + csn.Name);
			if (string.IsNullOrEmpty(this.a.Text))
			{
				this.a.Text = csn.Name;
			}
			this.b.Text = qv.b("Skills/" + csn.Name + str);
			this.c.Visible = (csn.BaseAbilityBonuses.Count > 0);
			this.d.Visible = (csn.BaseAbilityBonuses.Count > 0);
			this.d.Text = "";
			foreach (KeyValuePair<Type, float> keyValuePair in csn.BaseAbilityBonuses)
			{
				if (!string.IsNullOrEmpty(this.d.Text))
				{
					avo avo = this.d;
					avo.Text = avo.Text + " " + dh9.c("or") + " ";
				}
				string text = dh9.a("BaseAbilityEnum." + to.a(keyValuePair.Key));
				if (string.IsNullOrEmpty(text))
				{
					text = to.a(keyValuePair.Key);
				}
				avo avo2 = this.d;
				avo2.Text += text;
			}
			this.e.Visible = false;
			this.f.Visible = false;
			this.g.Visible = false;
			this.f.Text = "";
			this.g.Text = "";
			using (Dictionary<Type, float>.Enumerator enumerator = csn.Synergies.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<Type, float> keyValuePair2 = enumerator.Current;
					if (ddv.a(keyValuePair2.Key))
					{
						this.e.Visible = true;
						this.f.Visible = true;
						this.g.Visible = true;
						string text2 = dh9.a("SkillEnum." + ddv.b(keyValuePair2.Key));
						if (string.IsNullOrEmpty(text2))
						{
							text2 = ddv.b(keyValuePair2.Key);
						}
						avo avo3 = this.f;
						avo3.Text = avo3.Text + text2 + "\r\n";
						avo avo4 = this.g;
						avo4.Text = avo4.Text + (keyValuePair2.Value * 100f).ToString() + "%\r\n";
					}
				}
				return;
			}
		}
		this.c.Visible = false;
		this.d.Visible = false;
	}

	// Token: 0x0600C632 RID: 50738 RVA: 0x00455904 File Offset: 0x00453B04
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x040048CB RID: 18635
	private new avo a;

	// Token: 0x040048CC RID: 18636
	private new avo b;

	// Token: 0x040048CD RID: 18637
	private new avo c;

	// Token: 0x040048CE RID: 18638
	private new avo d;

	// Token: 0x040048CF RID: 18639
	private new avo e;

	// Token: 0x040048D0 RID: 18640
	private new avo f;

	// Token: 0x040048D1 RID: 18641
	private new avo g;

	// Token: 0x040048D2 RID: 18642
	private new Type h;
}
