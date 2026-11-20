using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D40 RID: 3392
[e79("Xpbl_Dude_FirstRiftTravel")]
public sealed class ec0 : dgy
{
	// Token: 0x06004A93 RID: 19091 RVA: 0x001FB858 File Offset: 0x001F9A58
	public ec0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ec0.a a = new ec0.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Zone != null && a.a.Area != null)
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
				c6w c6w = new c6w();
				c6w.a(new ar7(a.a));
				c6w.IsAsync = false;
				c6w.a = new Func<auv>(a.a);
				array[num] = c6w;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_wumb2", "player_start"), true, new bool?(false), 0, null, true, false, false)
				});
			}
		}
	}

	// Token: 0x02000D41 RID: 3393
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A95 RID: 19093 RVA: 0x001FB9C8 File Offset: 0x001F9BC8
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportEnter"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.a, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new e4t(this.a.h.b, CharacterState.OperateShort, 100, 0, null, 1));
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.a);
			ad.b(1.0);
			ad.c(0.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(250));
			return awx;
		}

		// Token: 0x04001DD1 RID: 7633
		public c5x a;
	}
}
