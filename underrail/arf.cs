using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D9A RID: 3482
[e79("RiftExit")]
public sealed class arf : dgy
{
	// Token: 0x06004B67 RID: 19303 RVA: 0x0020993C File Offset: 0x00207B3C
	public arf()
	{
		arf.b b = new arf.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			arf.a a = new arf.a();
			base.a(new btm[]
			{
				new dva(new Func<e6d, bool>(b.a), null, null, null, null)
			});
			a.a = (b.a.aqu().v().b() as c5x);
			if (a.a != null && a.a.Zone != null && a.a.Area != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
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
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D9B RID: 3483
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B69 RID: 19305 RVA: 0x00209A6C File Offset: 0x00207C6C
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["hidePlayer"] = false;
			return true;
		}

		// Token: 0x04001E4A RID: 7754
		public cnk a;
	}

	// Token: 0x02000D9C RID: 3484
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B6B RID: 19307 RVA: 0x00209A9C File Offset: 0x00207C9C
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportExit"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.a, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new a4s(new akw(), new ar7(this.a), new ar7(this.a), null));
			awx.ad().Add(new bm3(150));
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.a);
			ad.b(0.0);
			ad.c(1.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(100));
			return awx;
		}

		// Token: 0x04001E4B RID: 7755
		public c5x a;
	}
}
