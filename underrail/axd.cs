using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;

// Token: 0x02001FF2 RID: 8178
public sealed class axd : au6
{
	// Token: 0x0600C076 RID: 49270 RVA: 0x0042AE30 File Offset: 0x00429030
	public override bool hh()
	{
		return true;
	}

	// Token: 0x0600C077 RID: 49271 RVA: 0x0042AE34 File Offset: 0x00429034
	public axd(esj A_0) : base(null, null, axd.a())
	{
		this.a(A_0);
	}

	// Token: 0x0600C078 RID: 49272 RVA: 0x0042AE4C File Offset: 0x0042904C
	private new static cs9 a()
	{
		if (wj.a().c())
		{
			return new se
			{
				PropagateMouseScrollEvent = true
			};
		}
		return new c1y
		{
			PropagateMouseScrollEvent = true
		};
	}

	// Token: 0x0600C079 RID: 49273 RVA: 0x0042AE78 File Offset: 0x00429078
	private void a(esj A_0)
	{
		wj wj = wj.a();
		base.Size = A_0;
		this.Focusable = false;
		this.g = 26;
		this.i = 0;
		this.h = 0;
		base.d(true);
		if (!wj.c())
		{
			this.g = wj.bo.c;
			base.b(null);
		}
		this.b = new avo();
		this.b.Color = adi.a;
		if (wj.c())
		{
			this.b.a(egg.ai);
		}
		else
		{
			this.b.a(wj.dn);
		}
		this.b.Text = "Никаких диковинок пока не найдено.";
		this.b.a(cab.b);
		this.b.a(ad4.b);
		this.b.Location = new Point(0, 0);
		this.b.Size = base.Size;
		this.b.Visible = false;
		this.aox(this.b);
		this.a = new SortedList<string, cie>();
		string text = Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), Path.Combine(d5x.ai, "Oddities"));
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "*.*", 1);
			for (int i = 0; i < files.Length; i++)
			{
				cie cie = new cie(files[i].Substring(text.Length + 1).Split(new string[]
				{
					"."
				}, StringSplitOptions.RemoveEmptyEntries)[0]);
				cie.PropagateMouseScrollEvent = true;
				if (cie.d() != null && cie.d().fu() != null && !string.IsNullOrEmpty(cie.d().fu().az()) && !this.a.ContainsKey(cie.d().fu().az()))
				{
					this.a.Add(cie.d().fu().az(), cie);
				}
			}
			this.a(false);
		}
	}

	// Token: 0x0600C07A RID: 49274 RVA: 0x0042B09C File Offset: 0x0042929C
	public void b()
	{
		int num = (base.Size.c - 20) / this.a.Values[0].Size.c;
		int num2 = (base.Size.d - 20 + 10) / (this.a.Values[0].Size.d + 10);
		esj a_ = new esj(20 + num * this.a.Values[0].Size.c, 10 + num2 * (this.a.Values[0].Size.d + 10));
		this.b.Size = a_;
		base.Size = a_;
		this.a(true);
		this.p();
		base.j();
	}

	// Token: 0x0600C07B RID: 49275 RVA: 0x0042B178 File Offset: 0x00429378
	private void a(bool A_0)
	{
		bool a_ = true;
		int num = 0;
		int num2 = 0;
		int num3 = (base.Size.c - 20) / this.a.Values[0].Size.c;
		if (A_0)
		{
			foreach (cie a_2 in this.a.Values)
			{
				this.g(a_2);
			}
		}
		foreach (cie cie in this.a.Values)
		{
			if (cie.e() > 0)
			{
				a_ = false;
				cie.Location = new Point(num * cie.Size.c, 10 + num2 * (cie.Size.d + 10));
				this.aox(cie);
				if (++num == num3)
				{
					num = 0;
					num2++;
				}
			}
		}
		this.b.Visible = a_;
	}

	// Token: 0x0600C07C RID: 49276 RVA: 0x0042B2C0 File Offset: 0x004294C0
	private void a(object A_0, by0 A_1)
	{
		if (A_1.a() != null)
		{
			x2 x = A_1.a().Definition as x2;
			if (x != null)
			{
				foreach (cie cie in this.a.Values)
				{
					if (cie.d() != null && cie.d().fu() != null && cie.d().fu().a5() == x.a5())
					{
						bool flag = cie.e() != 0;
						cie.c();
						if (!flag)
						{
							this.a(true);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C07D RID: 49277 RVA: 0x0042B390 File Offset: 0x00429590
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		cs9 cs = base.h();
		cs.e(cs.l() - base.h().m() * Math.Sign(A_1.c()));
	}

	// Token: 0x0600C07E RID: 49278 RVA: 0x0042B3D0 File Offset: 0x004295D0
	protected override void i0()
	{
		base.i0();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			serviceOrThrow.aqu().v().Bag.zw(new EventHandler<by0>(this.a));
		}
	}

	// Token: 0x0600C07F RID: 49279 RVA: 0x0042B428 File Offset: 0x00429628
	protected override void i1()
	{
		base.i1();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			serviceOrThrow.aqu().v().Bag.zx(new EventHandler<by0>(this.a));
		}
	}

	// Token: 0x0400458A RID: 17802
	private new SortedList<string, cie> a;

	// Token: 0x0400458B RID: 17803
	private new avo b;
}
