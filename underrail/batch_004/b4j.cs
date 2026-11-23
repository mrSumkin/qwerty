using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D32 RID: 3378
[e79("Cc_PlayerTalksToVivianAfterQuest")]
public sealed class b4j : dgy
{
	// Token: 0x06004A6F RID: 19055 RVA: 0x001F9794 File Offset: 0x001F7994
	public b4j()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b4j.a a = new b4j.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				b4j.b b = new b4j.b();
				b.b = a;
				b.a = (new ar7(new Guid("ae9a9089-e9d6-4416-9b34-6ca5851683e3"), b.b.a.Zone.n("cc_bcf0")).ao() as c5x);
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
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				c8s.a(false);
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				s5 s = new s5();
				s.a(new ar7(b.a));
				s.a(new bt4("vivian_talkToPlayerLastTime"));
				s.IsAsync = false;
				s.a(true);
				array3[num3] = s;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D33 RID: 3379
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A71 RID: 19057 RVA: 0x001F99E0 File Offset: 0x001F7BE0
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "FromElevator2", true);
			return true;
		}

		// Token: 0x04001DBD RID: 7613
		public c5x a;
	}

	// Token: 0x02000D34 RID: 3380
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A73 RID: 19059 RVA: 0x001F9A00 File Offset: 0x001F7C00
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.a.GetAspect<j7>(), true, null, false);
			return true;
		}

		// Token: 0x04001DBE RID: 7614
		public c5x a;

		// Token: 0x04001DBF RID: 7615
		public b4j.a b;
	}
}
