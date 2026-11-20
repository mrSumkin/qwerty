using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02002071 RID: 8305
public sealed class bda : ec9
{
	// Token: 0x0600C633 RID: 50739 RVA: 0x00455914 File Offset: 0x00453B14
	[CompilerGenerated]
	public new void d(EventHandler A_0)
	{
		EventHandler eventHandler = this.h;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C634 RID: 50740 RVA: 0x0045594C File Offset: 0x00453B4C
	[CompilerGenerated]
	public new void c(EventHandler A_0)
	{
		EventHandler eventHandler = this.h;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C635 RID: 50741 RVA: 0x00455984 File Offset: 0x00453B84
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.i;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C636 RID: 50742 RVA: 0x004559BC File Offset: 0x00453BBC
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.i;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.i, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C637 RID: 50743 RVA: 0x004559F4 File Offset: 0x00453BF4
	public override bool et()
	{
		if (!base.IsMousedOver)
		{
			return Enumerable.Any<euz>(base.Controls, new Func<euz, bool>(bda.a.a.a));
		}
		return true;
	}

	// Token: 0x0600C638 RID: 50744 RVA: 0x00455A30 File Offset: 0x00453C30
	public bda(ech A_0, bool A_1)
	{
		this.e = A_0;
		this.g = A_1;
		this.c();
	}

	// Token: 0x0600C639 RID: 50745 RVA: 0x00455A70 File Offset: 0x00453C70
	private new void c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.c = bo1.r;
			this.f = new bdl();
		}
		else
		{
			this.c = wj.f;
			this.e = wj.b8;
			this.d = new esj?(wj.b9);
			this.f = new dg8();
			this.a = wj.gk;
			this.b = wj.gl;
			this.c = wj.bm.c;
		}
		this.f.Gravity = axy.c;
		this.f.IsPrivateComponent = true;
		this.f.c(1);
		this.f.d(5);
		this.f.e(0);
		this.f.f(new EventHandler<c1>(this.b));
		e4z.c(this.f.d());
		e4z.c(this.f.e());
		e4z.d(this.f.h());
		this.aox(this.f);
		this.b();
		this.a();
	}

	// Token: 0x0600C63A RID: 50746 RVA: 0x00455BA4 File Offset: 0x00453DA4
	private void b()
	{
		if (this.e != null)
		{
			foreach (object obj in Enum.GetValues(typeof(SkillCategory)))
			{
				SkillCategory a_ = (SkillCategory)obj;
				List<csn> list = this.e.a(a_);
				if (list.Count > 0)
				{
					this.d.Add(this.a(a_));
					foreach (csn csn in list)
					{
						if (csn.DLC == null || dk2.b(csn.DLC))
						{
							this.d.Add(this.a(csn));
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C63B RID: 50747 RVA: 0x00455CB4 File Offset: 0x00453EB4
	private euz a(csn A_0)
	{
		wj wj = wj.a();
		string text = dh9.a("SkillEnum." + A_0.Name);
		if (string.IsNullOrEmpty(text))
		{
			text = A_0.Name;
		}
		if (wj.d < UiSize.Large && A_0.Name.Length > 16)
		{
			text = text.Substring(0, 16) + ".";
		}
		b0a b0a = new b0a();
		b0a.Text = text;
		b0a.e(A_0.f());
		if (wj.c())
		{
			b0a.Font = egg.b;
			b0a.d = bo1.b;
		}
		else
		{
			b0a.Font = wj.gm;
			b0a.d = wj.f;
			b0a.e = wj.fg;
			b0a.f = new esj?(wj.fh);
		}
		b0a.a(A_0);
		b0a.d(true);
		b0a.a(true);
		b0a.b(new Color(255, 255, 255, 255));
		b0a.a(new Color(0, 0, 0, 255));
		b0a.a = adi.a;
		b0a.c = adi.b;
		b0a.HorizontalAlignment = cab.a;
		b0a.VerticalAlignment = ad4.b;
		b0a.h = new Color(255, 255, 255, 255);
		b0a.e(this.g);
		b0a.a(new EventHandler<c1>(this.a));
		b0a.j(new EventHandler<b25>(this.a));
		return b0a;
	}

	// Token: 0x0600C63C RID: 50748 RVA: 0x00455E50 File Offset: 0x00454050
	private euz a(SkillCategory A_0)
	{
		wj wj = wj.a();
		avo avo = new avo();
		avo.Text = dh9.a(A_0);
		if (wj.c())
		{
			avo.a(egg.b);
			avo.Size = new esj(10, this.a);
			avo.a(ad4.a);
		}
		else
		{
			avo.a(wj.gj);
			avo.a(ad4.a);
		}
		avo.a(cab.a);
		return avo;
	}

	// Token: 0x0600C63D RID: 50749 RVA: 0x00455ECC File Offset: 0x004540CC
	private void a()
	{
		wj wj = wj.a();
		int num = (base.Size.d - 2 * this.b) / this.a;
		if (this.d.Count > num)
		{
			this.f.Visible = true;
			this.f.a(this.d.Count - num);
			this.f.Location = new Point(base.Size.c - this.c, 0);
			if (wj.c())
			{
				this.f.Size = new esj(this.c, base.Size.d - 1);
			}
			else
			{
				this.f.Size = new esj(this.c, base.Size.d);
			}
			this.f.b(0);
			if (this.f.l() > this.f.k())
			{
				this.f.e(this.f.k());
			}
		}
		else
		{
			this.f.e(0);
			this.f.Visible = false;
		}
		foreach (euz a_ in this.d)
		{
			this.g(a_);
		}
		int num2 = 0;
		while (num2 < num && num2 + this.f.l() < this.d.Count)
		{
			euz euz = this.d[num2 + this.f.l()];
			if (euz is d7w)
			{
				euz.Location = new Point(this.b + 60, this.b + num2 * this.a + 8);
			}
			else
			{
				euz.Location = new Point(this.b, this.b + num2 * this.a);
			}
			euz.Size = new esj(base.Size.c - 2 * this.b, this.a);
			b0a b0a = euz as b0a;
			if (b0a != null)
			{
				if (wj.c())
				{
					b0a.TextLabelOffset = new Point(10, 7);
					b0a.c(new Point(240, 7));
					b0a.b(50);
					b0a.a(new Point(295, 7));
					b0a.a(70);
					b0a.c(375);
					b0a.f(5);
				}
				else
				{
					b0a.TextLabelOffset = new Point(10, wj.gn);
					b0a.c(new Point((int)((float)base.Size.c * 0.475f), wj.gn));
					b0a.b((int)((float)base.Size.c * 0.125f));
					b0a.a(new Point((int)((float)base.Size.c * 0.625f), wj.gn));
					b0a.a((int)((float)base.Size.c * 0.15f));
					b0a.c((int)((float)base.Size.c * 0.81f));
					b0a.f((int)((float)wj.gz.c * 0.33f));
				}
			}
			if (!wj.c())
			{
				avo avo = euz as avo;
				if (avo != null)
				{
					avo.Size = new esj(base.Size.c - 2 * this.b, (int)((float)this.a * 1.5f));
				}
			}
			this.aox(euz);
			num2++;
		}
	}

	// Token: 0x0600C63E RID: 50750 RVA: 0x004562B0 File Offset: 0x004544B0
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C63F RID: 50751 RVA: 0x004562C0 File Offset: 0x004544C0
	private void b(object A_0, c1 A_1)
	{
		this.a();
	}

	// Token: 0x0600C640 RID: 50752 RVA: 0x004562C8 File Offset: 0x004544C8
	private void a(object A_0, c1 A_1)
	{
		if (this.h != null)
		{
			this.h(this, new EventArgs());
		}
	}

	// Token: 0x0600C641 RID: 50753 RVA: 0x004562E8 File Offset: 0x004544E8
	private void a(object A_0, b25 A_1)
	{
		if (this.i != null)
		{
			this.i(A_0, new EventArgs());
		}
	}

	// Token: 0x0600C642 RID: 50754 RVA: 0x00456308 File Offset: 0x00454508
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		bdl bdl = this.f;
		bdl.e(bdl.l() - this.f.m() * Math.Sign(A_1.c()));
		this.a();
	}

	// Token: 0x040048D3 RID: 18643
	private new int a = 30;

	// Token: 0x040048D4 RID: 18644
	private new int b = 10;

	// Token: 0x040048D5 RID: 18645
	private new int c = 26;

	// Token: 0x040048D6 RID: 18646
	private new List<euz> d = new List<euz>();

	// Token: 0x040048D7 RID: 18647
	private new ech e;

	// Token: 0x040048D8 RID: 18648
	private new bdl f;

	// Token: 0x040048D9 RID: 18649
	private new bool g;

	// Token: 0x040048DA RID: 18650
	[CompilerGenerated]
	private EventHandler h;

	// Token: 0x040048DB RID: 18651
	[CompilerGenerated]
	private EventHandler i;

	// Token: 0x02002072 RID: 8306
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C645 RID: 50757 RVA: 0x00456360 File Offset: 0x00454560
		internal bool a(euz A_0)
		{
			return A_0.IsMousedOver;
		}

		// Token: 0x040048DC RID: 18652
		public static readonly bda.a a = new bda.a();

		// Token: 0x040048DD RID: 18653
		public static Func<euz, bool> b;
	}
}
