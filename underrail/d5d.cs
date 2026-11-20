using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E57 RID: 3671
[e79("Lu_BanditsThrowYouAndHugoOut")]
public sealed class d5d : dgy
{
	// Token: 0x06004CF4 RID: 19700 RVA: 0x0021D584 File Offset: 0x0021B784
	public d5d()
	{
		d5d.b b = new d5d.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			b.b = (b.a.aqu().v().b() as c5x);
			b.c = (b.a.aqu().ac() as bv9);
			if (b.b != null)
			{
				b.d = (new ar7(new Guid("3c741a36-914b-45de-80f0-2a80ea14ec7d"), b.b.Area).ao() as c5x);
				if (b.d != null)
				{
					d5d.a a = new d5d.a();
					a.b = b;
					a.a = a.b.d.GetAspect<bm6>();
					if (a.a != null)
					{
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
						dky dky = new dky();
						dky.a(0.2f);
						dky.a(false);
						array[num] = dky;
						base.a(array);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						c8s.IsAsync = false;
						array2[num2] = c8s;
						base.a(array2);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b.a), null, null, null)
						});
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000E58 RID: 3672
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004CF6 RID: 19702 RVA: 0x0021D78C File Offset: 0x0021B98C
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["npc_lu26x_letPass"] = false;
			this.b.GetAspect<j7>().a(this.d.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F50 RID: 8016
		public cnk a;

		// Token: 0x04001F51 RID: 8017
		public c5x b;

		// Token: 0x04001F52 RID: 8018
		public bv9 c;

		// Token: 0x04001F53 RID: 8019
		public c5x d;
	}

	// Token: 0x02000E59 RID: 3673
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CF8 RID: 19704 RVA: 0x0021D7E8 File Offset: 0x0021B9E8
		internal bool a(e6d A_0)
		{
			a0l.a(this.b.b, "player_outsideCamp", true);
			a0l.a(this.b.d, "hugo_outsideCamp", true);
			this.a.y6()[ddq.ay] = new bt4("hugo_outsideCamp");
			this.b.c.a(asp.c8, asp.da, h.c, null, false, false, false);
			return true;
		}

		// Token: 0x04001F54 RID: 8020
		public bm6 a;

		// Token: 0x04001F55 RID: 8021
		public d5d.b b;
	}
}
