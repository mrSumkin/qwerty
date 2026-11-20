using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000E1C RID: 3612
[e79("tch_rahmLeaves")]
public sealed class s4 : dgy
{
	// Token: 0x06004C7D RID: 19581 RVA: 0x00216ABC File Offset: 0x00214CBC
	public s4()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			s4.a a = new s4.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null && a.a.i.b != null)
			{
				a.a.i.b.a(true, false);
				a.b = (new ar7(new Guid("b2b1039f-a68e-4bc3-9d02-ada1698fa0d9"), a.a.Area).ao() as c5x);
				if (a.b != null && a.b.h.b != null && a.b.i.b != null)
				{
					new e80(false).ym(null, null, null);
					a.b.i.b.a(true, false);
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array = new btm[1];
					int num = 0;
					c6w c6w = new c6w();
					c6w.a(new ar7(a.b));
					c6w.a = new Func<auv>(a.a);
					array[num] = c6w;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E1D RID: 3613
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C7F RID: 19583 RVA: 0x00216C90 File Offset: 0x00214E90
		internal auv a()
		{
			ak1 ak = this.a.Area.b(24, 20);
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportEnter"), null, null, null);
			a4s.b(new ar7(this.b));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.b, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			if (this.b.h.b.aa().Offense.au() == WeaponKey.Secondary)
			{
				awx.ad().Add(new e4t(this.b.h.b, CharacterState.Custom4, cux.j, 0, null, 1));
			}
			else
			{
				awx.ad().Add(new e4t(this.b.h.b, CharacterState.Custom3, cux.j, 0, null, 1));
			}
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.b);
			ad.b(1.0);
			ad.c(0.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(250));
			awx.ad().Add(new a8v(this.b, ak.Location.a()));
			awx.ad().Add(new a7j(this.b, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new bm3(150));
			List<auv> list3 = awx.ad();
			ad6 ad2 = new ad6(this.b);
			ad2.b(0.0);
			ad2.c(1.0);
			ad2.a(0.005);
			list3.Add(ad2);
			awx.ad().Add(new bm3(100));
			awx.ad().Add(new ays(this.b, false, false, true));
			return awx;
		}

		// Token: 0x04001EF9 RID: 7929
		public c5x a;

		// Token: 0x04001EFA RID: 7930
		public c5x b;
	}
}
