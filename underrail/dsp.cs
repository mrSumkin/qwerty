using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000CCB RID: 3275
[e79("Cc_TransportThingsFromSgsToWardellMansion")]
public sealed class dsp : dgy
{
	// Token: 0x06004995 RID: 18837 RVA: 0x001EB088 File Offset: 0x001E9288
	public dsp()
	{
		dsp.a a = new dsp.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.c = (a.a.aqu().v().b() as c5x);
			a.b = new dcw();
			if (a.c != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new di4(new c2w("StationAlpha-Level5", "start"), false, new bool?(false), 0, null, false, false, false)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c6w c6w = new c6w(new Func<auv>(a.b));
				c6w.a(new ar7(aju.a, new Guid("392e485f-080c-4233-a776-2322a43b1d53"), new Guid("7fd08eea-0db1-4661-81c7-c58a26dd93eb"), bl1.a));
				array2[num2] = c6w;
				base.a(array2);
				base.a(new btm[]
				{
					new di4(new c2w("cc_ph", "FromOutside"), false, new bool?(false), 0, null, false, false, false)
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c6w c6w2 = new c6w(new Func<auv>(a.a));
				c6w2.a(new ar7(aju.a, new Guid("349cec48-4d4f-46b5-afcd-b3b38d2a4a8d"), new Guid("8fed3617-b38c-4a5c-b015-c71df6f69305"), bl1.a));
				array3[num3] = c6w2;
				base.a(array3);
				base.a(new btm[]
				{
					new di4(new c2w("cc-res", "player_coreCityHousing"), false, new bool?(false), 0, null, false, false, false)
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx = new egx();
				egx.a("Вот и всё. Вы можете ожидать, ваша доставка прибудет в ближайшее время.");
				array4[num4] = new ace(egx)
				{
					TargetRef = new ar7(new Guid("b22ff63d-833a-4a2e-b5a9-66f231147e8a"), a.a.aqw().n("cc-res"))
				};
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.a(false);
				array5[num5] = c8s;
				base.a(array5);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000CCC RID: 3276
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004997 RID: 18839 RVA: 0x001EB354 File Offset: 0x001E9554
		internal auv b()
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.a.aqw().n("StationAlpha-Level5").Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Location.X >= 28f && c5x.Location.X <= 34f && c5x.Location.Y >= 18f && c5x.Location.Y <= 24f)
				{
					c7j c7j = c5x.GetAspect<bim>() as c7j;
					if (c7j != null)
					{
						this.b.z2().AddRange(c7j.ItemContainer.z2());
						c7j.ItemContainer.z2().Clear();
					}
				}
			}
			return null;
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x001EB45C File Offset: 0x001E965C
		internal auv a()
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_ph_l5") + ".uzl");
			this.a.aqw().a(a_, aju.x, null);
			c5x c5x = new ar7(new Guid("c41b86b8-d4c7-4920-90dd-b55cad9c6f4a"), this.a.aqw().n("cc_ph1")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.ItemContainer.z2().AddRange(this.b.z2());
				}
				c5x.q("'" + this.c.y8() + ", станция Саут-Гейт'");
			}
			return null;
		}

		// Token: 0x04001D24 RID: 7460
		public cnk a;

		// Token: 0x04001D25 RID: 7461
		public dcw b;

		// Token: 0x04001D26 RID: 7462
		public c5x c;
	}
}
