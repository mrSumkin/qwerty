using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D9D RID: 3485
[e79("RiftTravel")]
public sealed class a4g : dgy
{
	// Token: 0x06004B6C RID: 19308 RVA: 0x00209BD8 File Offset: 0x00207DD8
	public a4g()
	{
		a4g.a a = new a4g.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a4g.b b = new a4g.b();
			b.a = (a.a.aqu().v().b() as c5x);
			if (b.a != null && b.a.Zone != null)
			{
				string classPropertyValue = a.a.aqu().r().GetClassPropertyValue<string>("Rift_TargetLocaleId");
				string classPropertyValue2 = a.a.aqu().r().GetClassPropertyValue<string>("Rift_TargetRiftId");
				if (!string.IsNullOrEmpty(classPropertyValue) && !string.IsNullOrEmpty(classPropertyValue2) && b.a.Area != null)
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
					c6w.a(new ar7(b.a));
					c6w.IsAsync = false;
					c6w.a = new Func<auv>(b.a);
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
						new dva(new Func<e6d, bool>(a.a), null, null, null, null)
					});
					base.a(new btm[]
					{
						new di4(new c2w(classPropertyValue, "Rift_" + classPropertyValue2), true, new bool?(false), 0, null, true, false, false)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					dgq dgq = new dgq();
					dgq.a("RiftExit");
					array2[num2] = new ace(dgq);
					base.a(array2);
				}
			}
		}
	}

	// Token: 0x02000D9E RID: 3486
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B6E RID: 19310 RVA: 0x00209DF4 File Offset: 0x00207FF4
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["hidePlayer"] = true;
			return true;
		}

		// Token: 0x04001E4C RID: 7756
		public cnk a;
	}

	// Token: 0x02000D9F RID: 3487
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B70 RID: 19312 RVA: 0x00209E24 File Offset: 0x00208024
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

		// Token: 0x04001E4D RID: 7757
		public c5x a;
	}
}
