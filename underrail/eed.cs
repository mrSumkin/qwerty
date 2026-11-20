using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x020005AA RID: 1450
public sealed class eed : a9t, ctv, etf, amj
{
	// Token: 0x0600268C RID: 9868 RVA: 0x000DB428 File Offset: 0x000D9628
	static eed()
	{
		eed.o[BlueprintCategory.All] = "Показать все чертежи.";
		eed.o[BlueprintCategory.Ammo] = "Показать только чертежи патронов, специальных болтов и метательных ножей.";
		eed.o[BlueprintCategory.Armor] = "Показать только чертежи различных частей брони.";
		eed.o[BlueprintCategory.Devices] = "Показать только чертежи различных механических и электронных устройств.";
		eed.o[BlueprintCategory.Grenades] = "Показать только чертежи гранат.";
		eed.o[BlueprintCategory.Medicine] = "Показать только чертежи обычных и специфических лекарств.";
		eed.o[BlueprintCategory.Processing] = "Показать только чертежи промежуточного ремесла.";
		eed.o[BlueprintCategory.Traps] = "Показать только чертежи различных ловушек и мин.";
		eed.o[BlueprintCategory.Weapons] = "Показать только чертежи оружия.";
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x000DB4D0 File Offset: 0x000D96D0
	public eed()
	{
		this.e();
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x000DB4EC File Offset: 0x000D96EC
	public euz r5(object A_0)
	{
		cwp cwp = A_0 as cwp;
		if (cwp != null && (this.m == BlueprintCategory.All || this.m == cwp.Category))
		{
			zt result;
			this.k.TryGetValue(cwp, out result);
			return result;
		}
		return null;
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x000DB534 File Offset: 0x000D9734
	public override void iv(e6d A_0, cp9 A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		this.g.Visible = dz6.e();
		base.iv(A_0, A_1);
		if (this.n != null)
		{
			foreach (KeyValuePair<dsy, BlueprintCategory> keyValuePair in this.n)
			{
				keyValuePair.Key.a(A_0);
			}
		}
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x000DB5BC File Offset: 0x000D97BC
	public override void ag5(e6d A_0)
	{
		if (this.l == null || this.l.Value != dz6.e())
		{
			this.b();
		}
		base.ag5(A_0);
		if (this.n != null)
		{
			wj wj = wj.a();
			Point point = base.at();
			Rectangle value = new Rectangle(point.X + 10, point.Y + wj.ci.d + wj.d3, (wj.eg.c + 2) * 9 - 2, wj.eg.d);
			foreach (KeyValuePair<dsy, BlueprintCategory> keyValuePair in this.n)
			{
				keyValuePair.Key.a(new Rectangle?(value));
				keyValuePair.Key.b();
			}
		}
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x000DB6C0 File Offset: 0x000D98C0
	public cb6 ar7()
	{
		if (this.d.j() != null)
		{
			dfw dfw = new dfw();
			foreach (cgo cgo in this.d.j().Slots.Values)
			{
				dfw.a().Add(cgo.a);
			}
			return dfw;
		}
		return null;
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x000DB74C File Offset: 0x000D994C
	public bool ar8(cqy A_0)
	{
		if (this.d.j() != null)
		{
			List<emy> list = new List<emy>();
			list.AddRange(this.d.c);
			list.AddRange(this.d.d);
			emy emy = null;
			foreach (emy emy2 in list)
			{
				if (emy2.ye(A_0, A_0.x6()) && A_0.yg(emy) && (emy == null || emy2.x6() == null))
				{
					emy = emy2;
					if (emy2.x6() == null)
					{
						break;
					}
				}
			}
			if (emy != null && c69.a(A_0, emy, A_0.x6(), false))
			{
				e4z.c();
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x000DB834 File Offset: 0x000D9A34
	public ecs yf(euz A_0)
	{
		if (A_0 != null)
		{
			foreach (KeyValuePair<dsy, BlueprintCategory> keyValuePair in this.n)
			{
				string a_;
				if (keyValuePair.Key.e() == A_0 && eed.o.TryGetValue(keyValuePair.Value, out a_))
				{
					return new ecs(new List<dl6>
					{
						new dl6(new List<bph>
						{
							new bph(new d22(cq4.c(), adi.a), a_, null)
						})
					});
				}
			}
		}
		return null;
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x000DB8F8 File Offset: 0x000D9AF8
	protected override void i0()
	{
		base.i0();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			serviceOrThrow.aqu().v().c(new EventHandler(this.e));
			serviceOrThrow.aqu().v().d(new EventHandler(this.d));
			serviceOrThrow.aqu().v().a(new EventHandler<EventArgs>(this.b));
			serviceOrThrow.aqu().v().b(new EventHandler<EventArgs>(this.a));
		}
		bpo.RegisterService<etf>(this);
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x000DB9A4 File Offset: 0x000D9BA4
	protected override void i1()
	{
		base.i1();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			serviceOrThrow.aqu().v().b(new EventHandler(this.e));
			serviceOrThrow.aqu().v().a(new EventHandler(this.d));
			serviceOrThrow.aqu().v().c(new EventHandler<EventArgs>(this.b));
			serviceOrThrow.aqu().v().d(new EventHandler<EventArgs>(this.a));
		}
		bpo.UnregisterService<etf>();
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x000DBA50 File Offset: 0x000D9C50
	protected override void aei(object A_0, ddj A_1)
	{
		this.d.f();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			cwp key = Enumerable.FirstOrDefault<KeyValuePair<cwp, zt>>(Enumerable.Where<KeyValuePair<cwp, zt>>(this.k, new Func<KeyValuePair<cwp, zt>, bool>(eed.a.a.a))).Key;
			serviceOrThrow.aqu().r()["SelectedBlueprint"] = ((key != null) ? key.TechnicalName : null);
			serviceOrThrow.aqu().r()["BlueprintListScrollPos"] = this.c.f();
			serviceOrThrow.aqu().r()["SelectedBlueprintCategory"] = this.m;
		}
		base.aei(A_0, A_1);
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x000DBB30 File Offset: 0x000D9D30
	private new void e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		wj wj = wj.a();
		base.Text = "Создание предметов";
		esj esj = a2x.a();
		esj esj2;
		if (wj.c())
		{
			esj2 = new esj((int)Math.Min(700.0, (double)esj.c * 0.45), (int)((double)esj.d * 0.7));
			if (esj2.d % 2 != 0)
			{
				esj2.d++;
			}
		}
		else
		{
			esj2 = new esj((int)Math.Min((double)wj.d1, (double)esj.c * 0.49), (int)Math.Max((double)wj.d2, (double)esj.d * 0.7));
			esj2.d += wj.g - esj2.d % wj.g;
		}
		base.Size = esj2;
		this.c();
		if (wj.c())
		{
			this.c = new cj5(this.i, this, typeof(se));
			this.c.Location = new Point(10, 40);
			this.c.Size = new esj(210, base.Size.d - 40 - 244 - 65);
			this.c.a(se.a);
			this.c.e(5);
			this.c.b(5);
			this.c.c(20);
		}
		else
		{
			this.m = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<BlueprintCategory>("SelectedBlueprintCategory", new BlueprintCategory?(BlueprintCategory.All)).Value;
			this.d();
			this.c = new cj5(this.j, this, typeof(c1y));
			this.c.Location = new Point(10, wj.ci.d + wj.d3 + wj.eg.d + wj.eg.d / 6);
			this.c.Size = new esj((int)((float)base.Size.c * 0.4f), base.Size.d - this.c.Location.Y - wj.ea - 2 * wj.d3);
			this.c.a(wj.bo.c);
			this.c.e(wj.eh);
			this.c.b(wj.ei);
			this.c.c(wj.ej);
			this.n = new Dictionary<dsy, BlueprintCategory>();
			float num = Math.Min(1f, (float)this.c.Size.c / (9f * (float)wj.eg.c));
			for (int i = 0; i <= 8; i++)
			{
				aqw aqw = new aqw();
				aqw.a = wj.f;
				aqw.b = new Point(wj.ef.X, wj.ef.Y + i * wj.eg.d);
				aqw.c = wj.eg;
				aqw.Size = esj.b(wj.eg, (double)num);
				aqw.d = (num != 1f);
				aqw.Location = new Point(10 + i * (aqw.Size.c + 1 + wj.c1), wj.ci.d + wj.d3);
				aqw.Checked = (this.m == (BlueprintCategory)i);
				aqw.p(new EventHandler<b25>(this.e));
				aqw.Tag = (BlueprintCategory)i;
				e4z.f(aqw);
				e4z.i(aqw);
				this.aox(aqw);
				dsy key = new dsy(aqw, this, esj.a(), base.Size.c / 2, null, null, 1000, false, false);
				this.n.Add(key, (BlueprintCategory)i);
			}
		}
		this.c.IsPrivateComponent = true;
		this.c.c = null;
		this.aox(this.c);
		this.b = new i5();
		this.b.IsPrivateComponent = true;
		if (wj.c())
		{
			this.b.Location = new Point(this.c.Location.X + this.c.Size.c + 5, 40);
			this.b.Size = new esj(base.Size.c - this.b.Location.X - 15, base.Size.d - 40 - 50);
		}
		else
		{
			this.a(wj, false);
		}
		if (serviceOrThrow.aqu() != null)
		{
			this.b.a(serviceOrThrow.aqu().v());
		}
		this.aox(this.b);
		this.a = new ct4();
		this.a.IsPrivateComponent = true;
		this.a.Location = this.b.Location;
		this.a.Size = this.b.Size;
		this.aox(this.a);
		this.e = new dak();
		if (wj.c())
		{
			this.e.Size = new esj(120, 25);
			this.e.Location = new Point(this.b.Location.X + (this.b.Size.c - this.e.Size.c * 2 + 10) / 2, this.b.Location.Y + this.b.Size.d + 10);
			if (egg.v)
			{
				this.e.Font = egg.a;
				this.e.TextLabelOffset = new Point(0, 6);
			}
			else
			{
				this.e.Font = egg.aq;
				this.e.TextLabelOffset = new Point(0, egg.b(this.e.Font));
			}
			this.e.d = bo1.z;
		}
		else
		{
			this.e.Size = wj.dl;
			this.e.Location = new Point(this.b.Location.X + (this.b.Size.c - (int)((float)this.e.Size.c * 2.25f)) / 2, this.b.Location.Y + this.b.Size.d + wj.d3);
			this.e.Font = wj.c5;
			this.e.TextLabelOffset = new Point(0, egg.b(this.e.Font));
			this.e.d = wj.f;
			this.e.f = wj.e7;
			this.e.e = new esj?(wj.e8);
		}
		this.e.g = adi.a;
		this.e.j = adi.b;
		this.e.Text = "Создать";
		this.e.c(new EventHandler<b25>(this.b));
		e4z.j(this.e);
		this.aox(this.e);
		this.f = new dak();
		if (wj.c())
		{
			this.f.Size = new esj(120, 25);
			this.f.Location = new Point(this.e.Location.X + this.e.Size.c + 10, this.e.Location.Y);
			if (egg.v)
			{
				this.f.Font = egg.a;
				this.f.TextLabelOffset = new Point(0, 6);
			}
			else
			{
				this.f.Font = egg.aq;
				this.f.TextLabelOffset = new Point(0, egg.b(this.f.Font));
			}
			this.f.d = bo1.z;
		}
		else
		{
			this.f.Size = wj.dl;
			this.f.Location = new Point(this.e.Location.X + (int)((float)this.e.Size.c * 1.25f), this.e.Location.Y);
			this.f.Font = wj.c5;
			this.f.TextLabelOffset = new Point(0, egg.b(this.e.Font));
			this.f.d = wj.f;
			this.f.f = wj.e7;
			this.f.e = new esj?(wj.e8);
		}
		this.f.g = adi.a;
		this.f.j = adi.b;
		this.f.Text = "Создать всё";
		this.f.c(new EventHandler<b25>(this.a));
		e4z.j(this.f);
		this.aox(this.f);
		int num2 = this.f.Location.X + this.f.Size.c + 10 - base.Size.c;
		if (num2 > 0)
		{
			this.e.Location = new Point(this.e.Location.X - num2, this.e.Location.Y);
			this.f.Location = new Point(this.f.Location.X - num2, this.f.Location.Y);
		}
		this.d = new ahu((serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null);
		this.d.IsPrivateComponent = true;
		if (wj.c())
		{
			this.d.Location = new Point(15, this.c.Location.Y + this.c.Size.d + 15);
			this.d.Size = new esj(200, 244);
		}
		else
		{
			this.d.Location = new Point(wj.d3, this.c.Location.Y + this.c.Size.d + wj.d3);
			this.d.Size = new esj(this.c.Size.c, this.b.Location.Y + this.b.Size.d - this.d.Location.Y);
			int num3 = wj.g - this.d.Size.d % wj.g;
			this.d.Location = new Point(this.d.Location.X, this.d.Location.Y - num3);
			this.d.Size = new esj(this.d.Size.c, this.d.Size.d + num3);
		}
		this.d.a(new EventHandler(this.c));
		this.aox(this.d);
		this.g = new avo();
		this.g.Text = "Вы не можете создавать предметы в пошаговом режиме.";
		this.g.a(true);
		if (wj.c())
		{
			if (egg.v)
			{
				this.g.a(egg.n);
			}
			else
			{
				this.g.a(egg.ad);
			}
			this.g.Location = new Point(15, this.e.Location.Y + 3 + egg.b(this.g.g()));
		}
		else
		{
			this.g.a(wj.ee);
			this.g.Location = new Point(10, base.Size.d - wj.d3 - this.g.Size.d + egg.b(this.g.g()));
		}
		this.g.Color = Color.Red;
		this.aox(this.g);
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			eed.b b = new eed.b();
			b.a = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("SelectedBlueprint");
			int? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("BlueprintListScrollPos", null);
			if (primitivePropertyValue != null)
			{
				this.c.d(primitivePropertyValue.Value);
			}
			if (!string.IsNullOrEmpty(b.a))
			{
				zt value = Enumerable.FirstOrDefault<KeyValuePair<cwp, zt>>(Enumerable.Where<KeyValuePair<cwp, zt>>(this.k, new Func<KeyValuePair<cwp, zt>, bool>(b.a))).Value;
				if (value != null)
				{
					this.b(value);
				}
				return;
			}
		}
		this.a();
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x000DC96C File Offset: 0x000DAB6C
	private new void d()
	{
		this.j.Clear();
		foreach (cwp cwp in this.i)
		{
			if (this.a(cwp))
			{
				this.j.Add(cwp);
			}
		}
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x000DC9E4 File Offset: 0x000DABE4
	private new void e(object A_0, b25 A_1)
	{
		aqw aqw = A_0 as aqw;
		if (aqw != null)
		{
			foreach (euz euz in base.Controls)
			{
				aqw aqw2 = euz as aqw;
				if (aqw2 != null)
				{
					aqw2.Checked = (aqw2 == aqw);
				}
			}
			BlueprintCategory blueprintCategory = (BlueprintCategory)aqw.Tag;
			if (this.m != blueprintCategory)
			{
				this.m = blueprintCategory;
				this.d();
				this.c.g();
			}
		}
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x000DCA88 File Offset: 0x000DAC88
	private void a(wj A_0, bool A_1)
	{
		this.b.Location = new Point(this.c.Location.X + this.c.Size.c + A_0.d3, A_0.ci.d + A_0.d3);
		if (A_1)
		{
			this.b.Location = new Point(this.b.Location.X, this.b.Location.Y + A_0.d8.d - A_0.d9);
		}
		int a_ = base.Size.d - this.b.Location.Y - A_0.dl.d - (int)(2.5 * (double)A_0.d3);
		A_0.a(ref a_);
		this.b.Size = new esj(base.Size.c - this.b.Location.X - 15, a_);
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x000DCB9C File Offset: 0x000DAD9C
	private void c()
	{
		this.i = new List<cwp>();
		this.j = new List<cwp>();
		this.k = new Dictionary<cwp, zt>();
		foreach (bdc a_ in Enumerable.OrderBy<bdc, string>(bpo.GetServiceOrThrow<cnk>().aqu().v().d(), new Func<bdc, string>(eed.a.a.a)))
		{
			this.a(a_, false);
		}
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x000DCC4C File Offset: 0x000DAE4C
	private void a(bdc A_0, bool A_1 = false)
	{
		if (A_0 != null && A_0.ao() != null)
		{
			if (A_1)
			{
				this.i.Insert(0, A_0.ao());
				if (this.a(A_0.ao()))
				{
					this.j.Insert(0, A_0.ao());
				}
			}
			else
			{
				this.i.Add(A_0.ao());
				if (this.a(A_0.ao()))
				{
					this.j.Add(A_0.ao());
				}
			}
			this.k[A_0.ao()] = this.c(A_0.ao());
		}
	}

	// Token: 0x0600269D RID: 9885 RVA: 0x000DCCFC File Offset: 0x000DAEFC
	private void a(bdc A_0)
	{
		if (A_0 != null && A_0.ao() != null && this.i.Remove(A_0.ao()))
		{
			this.k.Remove(A_0.ao());
			this.j.Remove(A_0.ao());
		}
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x000DCD54 File Offset: 0x000DAF54
	private zt c(cwp A_0)
	{
		wj wj = wj.a();
		zt zt = new zt();
		if (wj.c())
		{
			zt.Font = egg.al;
			zt.TextLabelOffset = new Point(5, egg.b(zt.Font));
		}
		else
		{
			zt.Font = wj.d4;
			zt.TextLabelOffset = new Point(5, egg.b(zt.Font));
			zt.d = wj.f;
			zt.e = wj.fg;
			zt.f = new esj?(wj.fh);
		}
		zt.a = adi.a;
		zt.b = Color.Black;
		zt.HorizontalAlignment = cab.a;
		zt.Text = A_0.LocalizedName;
		zt.Tag = A_0;
		zt.c(new EventHandler<b25>(this.c));
		e4z.f(zt);
		return zt;
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x000DCE34 File Offset: 0x000DB034
	private void b(zt A_0)
	{
		if (A_0 == null)
		{
			this.b(null);
		}
		foreach (KeyValuePair<cwp, zt> keyValuePair in this.k)
		{
			keyValuePair.Value.Checked = (keyValuePair.Value == A_0);
			if (keyValuePair.Value.Checked)
			{
				this.b(keyValuePair.Key);
				this.d.a(keyValuePair.Key);
			}
		}
		this.b();
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x000DCEE0 File Offset: 0x000DB0E0
	private void b()
	{
		wj wj = wj.a();
		this.l = new bool?(dz6.e());
		this.d.h();
		this.e.Enabled = false;
		this.f.Enabled = false;
		this.b.b(false);
		if (this.d.j() != null && this.d.g() != null)
		{
			int num = 0;
			for (int i = 0; i < this.h.Count; i++)
			{
				if (this.h[i].Checked)
				{
					num = i;
				}
				this.g(this.h[i]);
			}
			if (wj.c())
			{
				this.b.Location = new Point(this.b.Location.X, 40);
				this.b.Size = new esj(base.Size.c - this.b.Location.X - 15, base.Size.d - 40 - 50);
			}
			else
			{
				this.a(wj, false);
			}
			int count = this.d.g().a.Count;
			if (count > 0)
			{
				if (count == 1)
				{
					this.b.a(this.d.g().a());
					this.b.a(true);
				}
				else
				{
					if (num > count - 1)
					{
						num = 0;
					}
					this.b.a(this.d.g().a[num]);
					for (int j = 0; j < count; j++)
					{
						dtd dtd = new dtd();
						if (wj.c())
						{
							dtd.Location = new Point(this.b.Location.X + 5 + j * 41, 40);
						}
						else
						{
							dtd.Location = new Point(this.b.Location.X + wj.d3 + j * (wj.d8.c + 2), wj.ci.d + wj.d3);
						}
						dtd.a = this.d.g().a[j];
						dtd.Checked = (num == j);
						dtd.Tag = this.d.g().a[j];
						dtd.c(new EventHandler<b25>(this.d));
						this.h.Add(dtd);
						this.aox(dtd);
					}
					if (wj.c())
					{
						this.b.Location = new Point(this.b.Location.X, 81);
						this.b.Size = new esj(this.b.Size.c, this.b.Size.d - 42);
					}
					else
					{
						this.a(wj, count > 1);
					}
					this.b.a(false);
				}
				this.a.Visible = false;
				this.b.Visible = true;
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (this.d.g().d && this.d.g().a(serviceOrThrow.aqu().v()) && !dz6.e())
				{
					this.e.Enabled = true;
					this.f.Enabled = true;
				}
				this.b.b(this.d.g().d);
				return;
			}
		}
		this.b.a(null);
		this.a.Visible = true;
		this.b.Visible = false;
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x000DD2CC File Offset: 0x000DB4CC
	private void b(cwp A_0)
	{
		this.a.a(A_0);
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x000DD2DC File Offset: 0x000DB4DC
	private void a()
	{
		this.b(Enumerable.FirstOrDefault<zt>(this.k.Values));
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x000DD2F8 File Offset: 0x000DB4F8
	private new void d(object A_0, b25 A_1)
	{
		dtd dtd = A_0 as dtd;
		if (dtd != null)
		{
			foreach (dtd dtd2 in this.h)
			{
				dtd2.Checked = (dtd2 == dtd);
			}
			this.b.a(dtd.Tag as coh);
		}
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x000DD378 File Offset: 0x000DB578
	private void c(object A_0, b25 A_1)
	{
		zt a_ = A_0 as zt;
		this.b(a_);
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x000DD394 File Offset: 0x000DB594
	private new void e(object A_0, EventArgs A_1)
	{
		bdc a_ = A_0 as bdc;
		this.a(a_, true);
		this.c.g();
		if (!Enumerable.Any<zt>(this.k.Values, new Func<zt, bool>(this.a)))
		{
			this.a();
		}
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x000DD3E4 File Offset: 0x000DB5E4
	private bool a(cwp A_0)
	{
		return A_0 != null && (this.m == BlueprintCategory.All || A_0.Category == this.m);
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x000DD40C File Offset: 0x000DB60C
	private new void d(object A_0, EventArgs A_1)
	{
		bdc a_ = A_0 as bdc;
		this.a(a_);
		this.c.g();
		if (!Enumerable.Any<zt>(this.k.Values, new Func<zt, bool>(eed.a.a.a)))
		{
			this.a();
		}
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x000DD470 File Offset: 0x000DB670
	private void c(object A_0, EventArgs A_1)
	{
		this.b();
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x000DD478 File Offset: 0x000DB678
	private void b(object A_0, EventArgs A_1)
	{
		this.b();
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x000DD484 File Offset: 0x000DB684
	private void b(object A_0, b25 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		cfe cfe = this.d.i();
		if (cfe != null && cfe.d && cfe.a() != null)
		{
			foreach (coh coh in cfe.a)
			{
				serviceOrThrow.aqu().v().Bag.z3(coh, true);
				a7v.a(new erv(new ap9(serviceOrThrow.aqu().v()), coh));
			}
		}
		this.b();
	}

	// Token: 0x060026AB RID: 9899 RVA: 0x000DD53C File Offset: 0x000DB73C
	private void a(object A_0, b25 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		while (this.e.Enabled)
		{
			cfe cfe = this.d.i();
			if (cfe != null && cfe.d && cfe.a() != null)
			{
				foreach (coh coh in cfe.a)
				{
					serviceOrThrow.aqu().v().Bag.z3(coh, true);
					a7v.a(new erv(new ap9(serviceOrThrow.aqu().v()), coh));
				}
			}
			this.b();
		}
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x000DD60C File Offset: 0x000DB80C
	private void a(object A_0, EventArgs A_1)
	{
		this.b();
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x000DD614 File Offset: 0x000DB814
	[CompilerGenerated]
	private bool a(zt A_0)
	{
		return A_0.Checked && this.a(A_0.Tag as cwp);
	}

	// Token: 0x040015E2 RID: 5602
	private new ct4 a;

	// Token: 0x040015E3 RID: 5603
	private new i5 b;

	// Token: 0x040015E4 RID: 5604
	private new cj5 c;

	// Token: 0x040015E5 RID: 5605
	private new ahu d;

	// Token: 0x040015E6 RID: 5606
	private new dak e;

	// Token: 0x040015E7 RID: 5607
	private new dak f;

	// Token: 0x040015E8 RID: 5608
	private new avo g;

	// Token: 0x040015E9 RID: 5609
	private new List<dtd> h = new List<dtd>();

	// Token: 0x040015EA RID: 5610
	private new List<cwp> i;

	// Token: 0x040015EB RID: 5611
	private new List<cwp> j;

	// Token: 0x040015EC RID: 5612
	private new Dictionary<cwp, zt> k;

	// Token: 0x040015ED RID: 5613
	private new bool? l;

	// Token: 0x040015EE RID: 5614
	private new BlueprintCategory m;

	// Token: 0x040015EF RID: 5615
	private Dictionary<dsy, BlueprintCategory> n;

	// Token: 0x040015F0 RID: 5616
	private static Dictionary<BlueprintCategory, string> o = new Dictionary<BlueprintCategory, string>();

	// Token: 0x0200202F RID: 8239
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C302 RID: 49922 RVA: 0x00437C80 File Offset: 0x00435E80
		internal bool a(KeyValuePair<cwp, zt> A_0)
		{
			return A_0.Value.Checked;
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x00437C90 File Offset: 0x00435E90
		internal string a(bdc A_0)
		{
			if (A_0.ao() == null)
			{
				return null;
			}
			return A_0.ao().Name;
		}

		// Token: 0x0600C304 RID: 49924 RVA: 0x00437CAC File Offset: 0x00435EAC
		internal bool a(zt A_0)
		{
			return A_0.Checked;
		}

		// Token: 0x040046BE RID: 18110
		public static readonly eed.a a = new eed.a();

		// Token: 0x040046BF RID: 18111
		public static Func<KeyValuePair<cwp, zt>, bool> b;

		// Token: 0x040046C0 RID: 18112
		public static Func<bdc, string> c;

		// Token: 0x040046C1 RID: 18113
		public static Func<zt, bool> d;
	}

	// Token: 0x02002030 RID: 8240
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600C306 RID: 49926 RVA: 0x00437CBC File Offset: 0x00435EBC
		internal bool a(KeyValuePair<cwp, zt> A_0)
		{
			return A_0.Key.TechnicalName == this.a;
		}

		// Token: 0x040046C2 RID: 18114
		public string a;
	}
}
