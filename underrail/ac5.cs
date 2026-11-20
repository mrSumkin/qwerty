using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200205B RID: 8283
public sealed class ac5 : euz
{
	// Token: 0x0600C4C5 RID: 50373 RVA: 0x00446BB0 File Offset: 0x00444DB0
	public Dictionary<string, ScrollingCombatTextOptions> c()
	{
		return this.j;
	}

	// Token: 0x0600C4C6 RID: 50374 RVA: 0x00446BBC File Offset: 0x00444DBC
	public ac5(Dictionary<string, ScrollingCombatTextOptions> A_0)
	{
		this.j = new Dictionary<string, ScrollingCombatTextOptions>(A_0);
		this.b();
	}

	// Token: 0x0600C4C7 RID: 50375 RVA: 0x00446C38 File Offset: 0x00444E38
	private void b()
	{
		wj wj = wj.a();
		if (!wj.c())
		{
			this.c = (int)((float)wj.hn * 0.225f);
			this.d = (int)((float)this.c * 0.75f);
			this.e = (int)((float)this.d * 1.6f);
			this.g = wj.hh;
			this.f = wj.hr;
			this.h = egg.b(this.g);
			this.i = wj.g3.c;
		}
		int num = this.e;
		foreach (string str in this.j.Keys)
		{
			avo avo = this.a();
			avo.Text = dh9.c("Options_SCT_" + str);
			avo.Location = new Point(num, this.h);
			this.aox(avo);
			num += this.c;
		}
		int num2 = this.f + this.b;
		int num3 = 0;
		foreach (object obj in Enum.GetValues(typeof(ScrollingCombatTextOptions)))
		{
			ScrollingCombatTextOptions scrollingCombatTextOptions = (ScrollingCombatTextOptions)obj;
			if (scrollingCombatTextOptions != ScrollingCombatTextOptions.Mandatory && scrollingCombatTextOptions != ScrollingCombatTextOptions.All)
			{
				avo avo2 = this.a();
				avo2.Text = dh9.a(scrollingCombatTextOptions).Replace(" S ", "/");
				avo2.Location = new Point(0, num2 + this.h);
				avo2.Size = new esj(this.e, avo2.Size.d);
				this.aox(avo2);
				num3 = this.e + this.c / 2 - this.i;
				foreach (string key in this.j.Keys)
				{
					ac5.a a = new ac5.a();
					a.d = this;
					a.c = scrollingCombatTextOptions;
					a.b = key;
					if (wj.c())
					{
						eki eki = new eki();
						eki.a(true);
						eki.b(this.g);
						a.a = eki;
					}
					else
					{
						aad aad = new aad();
						aad.a(true);
						aad.a(this.g);
						a.a = aad;
					}
					a.a.Checked = ((this.j[key] & scrollingCombatTextOptions) > ScrollingCombatTextOptions.Mandatory);
					a.a.Location = new Point(num3, num2);
					e4z.g(a.a);
					a.a.c(new EventHandler<c1>(a.a));
					this.aox(a.a);
					num3 += this.c;
				}
				num2 += this.f + this.a;
			}
		}
		if (wj.c())
		{
			base.Size = new esj(600, num2 - this.a);
			return;
		}
		base.Size = new esj(num3 + this.c / 2, num2 - this.a);
	}

	// Token: 0x0600C4C8 RID: 50376 RVA: 0x00447014 File Offset: 0x00445214
	private avo a()
	{
		avo avo = new avo();
		avo.a(this.g);
		avo.Color = adi.a;
		avo.Size = new esj(this.d, this.f);
		avo.a(cab.b);
		return avo;
	}

	// Token: 0x040047C2 RID: 18370
	private new int a = 5;

	// Token: 0x040047C3 RID: 18371
	private new int b = 15;

	// Token: 0x040047C4 RID: 18372
	private new int c = 120;

	// Token: 0x040047C5 RID: 18373
	private new int d = 90;

	// Token: 0x040047C6 RID: 18374
	private new int e = 170;

	// Token: 0x040047C7 RID: 18375
	private new int f = 22;

	// Token: 0x040047C8 RID: 18376
	private new string g = egg.aq;

	// Token: 0x040047C9 RID: 18377
	private int h = egg.b(egg.aq);

	// Token: 0x040047CA RID: 18378
	private int i = 20;

	// Token: 0x040047CB RID: 18379
	private new Dictionary<string, ScrollingCombatTextOptions> j;

	// Token: 0x0200205C RID: 8284
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600C4CA RID: 50378 RVA: 0x00447068 File Offset: 0x00445268
		internal void a(object A_0, c1 A_1)
		{
			if (this.a.Checked)
			{
				this.d.j[this.b] = (this.d.j[this.b] | this.c);
				return;
			}
			this.d.j[this.b] = (this.d.j[this.b] & ~this.c);
		}

		// Token: 0x040047CC RID: 18380
		public cao a;

		// Token: 0x040047CD RID: 18381
		public string b;

		// Token: 0x040047CE RID: 18382
		public ScrollingCombatTextOptions c;

		// Token: 0x040047CF RID: 18383
		public ac5 d;
	}
}
