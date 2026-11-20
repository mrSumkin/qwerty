using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000DBE RID: 3518
[e79("Dc_RahmUmbraEnterElevator")]
public sealed class ey5 : dgy
{
	// Token: 0x06004BAB RID: 19371 RVA: 0x0020D3B0 File Offset: 0x0020B5B0
	public ey5()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ey5.a a = new ey5.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				aud aud = a.a.Area;
				if (aud != null)
				{
					csd a_ = aud.Zone.g("rahmUmbra");
					bv9 bv = serviceOrThrow.aqu().ac() as bv9;
					if (bv != null)
					{
						bv.a(asp.a, asp.er, h.c, null, true, false, false);
					}
					a.b = vq.a("creature\\characters\\RahmUmbra", a_, true);
					a.b.ae = new float?(0f);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					if (a.b != null)
					{
						a.b.h.b.aa().FactionId = asp.er;
						a.b.h.b.aa().Offense.a(WeaponKey.Primary);
						btm[] array = new btm[1];
						int num = 0;
						c6w c6w = new c6w();
						c6w.a(new ar7(a.b));
						c6w.IsAsync = false;
						c6w.a = new Func<auv>(a.a);
						array[num] = c6w;
						base.a(array);
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					d92 d = new d92();
					d.a("events\\dc_RahmUmbraEpilogue");
					d.b(new ar7(a.b));
					d.a(new ar7(a.a));
					array2[num2] = d;
					base.a(array2);
				}
			}
		}
	}

	// Token: 0x02000DBF RID: 3519
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BAD RID: 19373 RVA: 0x0020D5A4 File Offset: 0x0020B7A4
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportExit"), null, null, null);
			a4s.b(new ar7(this.b));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.b, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new a4s(new akw(), new ar7(this.a), new ar7(this.b), null));
			awx.ad().Add(new bm3(150));
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.b);
			ad.b(0.0);
			ad.c(1.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(100));
			return awx;
		}

		// Token: 0x04001E73 RID: 7795
		public c5x a;

		// Token: 0x04001E74 RID: 7796
		public c5x b;
	}
}
