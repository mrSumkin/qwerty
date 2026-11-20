using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Events;

// Token: 0x020005A8 RID: 1448
public sealed class dhn : a9t
{
	// Token: 0x0600267D RID: 9853 RVA: 0x000DAADC File Offset: 0x000D8CDC
	public dhn()
	{
		this.c = bpo.GetServiceOrThrow<cnk>();
		this.e();
		this.e = new dhn.a(this);
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x000DAB10 File Offset: 0x000D8D10
	private new void e()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.d = bo1.r;
		}
		else
		{
			this.d = wj.f;
			this.e = wj.b8;
			this.f = wj.b9;
		}
		base.Text = "Заметки";
		esj esj = a2x.a();
		esj esj2;
		if (wj.c())
		{
			esj2 = new esj((int)Math.Min(700.0, (double)esj.c * 0.5), (int)Math.Max(490.0, (double)esj.d * 0.6));
			if (esj2.d % 2 != 0)
			{
				esj2.d++;
			}
		}
		else
		{
			esj2 = new esj((int)Math.Min((double)wj.d1, (double)esj.c * 0.4), (int)Math.Max((double)wj.d2, (double)esj.d * 0.6));
			wj.a(ref esj2.d);
		}
		base.Size = esj2;
		this.d = new be8(this.d(), base.Size.c - 6, 33, (base.Size.d - base.Location.Y) / 36, 3, 0);
		this.d.b(true);
		if (wj.c())
		{
			this.d.Location = new Point(0, 27);
			this.d.Size = new esj(base.Size.c, base.Size.d - 30);
		}
		else
		{
			this.d.Location = new Point(0, wj.ci.d + 1);
			this.d.Size = new esj(base.Size.c, base.Size.d - this.d.Location.Y - 2);
		}
		this.d.a(true);
		this.d.l().e((this.d.l() != null && this.d.l().Visible) ? dhn.a : 0);
		this.aox(this.d);
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x000DAD80 File Offset: 0x000D8F80
	private void a(eei A_0)
	{
		dhn.b b = new dhn.b();
		b.a = A_0;
		this.c();
		euz euz = Enumerable.FirstOrDefault<euz>(Enumerable.Where<euz>(Enumerable.OfType<euz>(this.d.d()), new Func<euz, bool>(b.b)));
		euz euz2 = Enumerable.FirstOrDefault<euz>(Enumerable.Where<euz>(this.d(), new Func<euz, bool>(b.a)));
		if (euz2 != null)
		{
			if (euz != null)
			{
				this.d.a(euz, euz2);
			}
			else
			{
				this.d.xj(euz2);
			}
		}
		this.b();
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x000DAE14 File Offset: 0x000D9014
	private new List<euz> d()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		List<euz> list = new List<euz>();
		List<List<eza>> list2 = new List<List<eza>>();
		Dictionary<string, List<eza>> dictionary = new Dictionary<string, List<eza>>();
		foreach (eza eza in Enumerable.Union<eza>(Enumerable.Union<eza>(this.c.aqu().t().c(), this.c.aqu().t().a()), this.c.aqu().t().b()))
		{
			if (eza != null && eza.Value != null && eza.Value.Group != null)
			{
				List<eza> list3;
				dictionary.TryGetValue(eza.Value.Group, out list3);
				if (list3 == null)
				{
					list3 = new List<eza>();
					dictionary[eza.Value.Group] = list3;
					list2.Add(list3);
				}
				list3.Add(eza);
			}
		}
		try
		{
			if (list2.Count == 1 && (dhn.b == null || dhn.b.Count == 0) && list2[0].Count > 0)
			{
				dhn.b = new List<string>();
				dhn.b.Add(list2[0][0].Value.Group);
			}
		}
		catch
		{
		}
		for (int i = 0; i < list2.Count; i++)
		{
			List<eza> list4 = list2[i];
			bool flag = dhn.b == null || !dhn.b.Contains(list4[0].Value.Group);
			if (!flag)
			{
				this.f.Add(list4[0].Value.Group);
			}
			euz item = this.a(list4[0].Value.Group, list4, flag);
			list.Add(item);
		}
		stopwatch.Stop();
		return list;
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x000DB054 File Offset: 0x000D9254
	private euz a(string A_0, List<eza> A_1, bool A_2)
	{
		wj wj = wj.a();
		erf erf;
		if (wj.c())
		{
			erf = new erf(A_1, 2, new esj(10, 5), 477, 33, A_2);
			erf.Location = new Point(20, 20);
		}
		else
		{
			erf = new erf(A_1, 2, new esj(10, 5), 477, wj.er.d, A_2);
			erf.Location = new Point(20, 20);
		}
		erf.aul(new EventHandler<EventArgs>(this.a));
		erf.b(A_0);
		erf.Text = A_0;
		return erf;
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x000DB0F0 File Offset: 0x000D92F0
	private void a(object A_0, EventArgs A_1)
	{
		erf erf = A_0 as erf;
		if (erf != null && !erf.auj() && !string.IsNullOrEmpty(erf.i()))
		{
			this.f.Add(erf.i());
		}
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x000DB138 File Offset: 0x000D9338
	private void c()
	{
		dhn.b = new List<string>();
		foreach (int num in this.d.e())
		{
			if (this.d.d() != null && this.d.d().Count > num)
			{
				euz euz = this.d.d()[num] as euz;
				if (euz != null)
				{
					dhn.b.Add(euz.Text);
				}
			}
		}
		dhn.a = ((this.d.l() != null && this.d.l().Visible) ? this.d.l().l() : 0);
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x000DB22C File Offset: 0x000D942C
	private void b()
	{
		this.d.l().e((this.d.l() != null && this.d.l().Visible) ? dhn.a : 0);
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x000DB27C File Offset: 0x000D947C
	protected override void i0()
	{
		base.i0();
		bpo.GetServiceOrThrow<eta>().RegisterHandler<dul>(this.e);
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x000DB294 File Offset: 0x000D9494
	protected override void i1()
	{
		base.i1();
		this.c();
		bpo.GetServiceOrThrow<eta>().UnregisterHandler<dul>(this.e);
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x000DB2B4 File Offset: 0x000D94B4
	protected override void r4(object A_0, el5 A_1)
	{
		base.r4(A_0, A_1);
		if (this.f.Count > 0 && this.c.aqu() != null)
		{
			foreach (eza eza in Enumerable.Union<eza>(Enumerable.Union<eza>(this.c.aqu().t().c(), this.c.aqu().t().a()), this.c.aqu().t().b()))
			{
				if (eza.Value != null && this.f.Contains(eza.Value.Group))
				{
					eza.Read = true;
				}
			}
		}
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x000DB39C File Offset: 0x000D959C
	public new static void a()
	{
		if (dhn.b != null)
		{
			dhn.b.Clear();
		}
		dhn.a = 0;
	}

	// Token: 0x040015DC RID: 5596
	private new static int a;

	// Token: 0x040015DD RID: 5597
	private new static List<string> b;

	// Token: 0x040015DE RID: 5598
	private new cnk c;

	// Token: 0x040015DF RID: 5599
	private new be8 d;

	// Token: 0x040015E0 RID: 5600
	private new dhn.a e;

	// Token: 0x040015E1 RID: 5601
	private new HashSet<string> f = new HashSet<string>();

	// Token: 0x0200202D RID: 8237
	private new sealed class a : GlobalEventHandler<dul>
	{
		// Token: 0x0600C2FB RID: 49915 RVA: 0x00437C10 File Offset: 0x00435E10
		public a(dhn A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C2FC RID: 49916 RVA: 0x00437C20 File Offset: 0x00435E20
		public override void cr(dul A_0)
		{
			this.a.a(A_0.e());
		}

		// Token: 0x040046BC RID: 18108
		private dhn a;
	}

	// Token: 0x0200202E RID: 8238
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600C2FE RID: 49918 RVA: 0x00437C3C File Offset: 0x00435E3C
		internal bool b(euz A_0)
		{
			return A_0.Text == this.a.Group;
		}

		// Token: 0x0600C2FF RID: 49919 RVA: 0x00437C54 File Offset: 0x00435E54
		internal bool a(euz A_0)
		{
			return A_0.Text == this.a.Group;
		}

		// Token: 0x040046BD RID: 18109
		public eei a;
	}
}
