using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EB9 RID: 3769
[e79("GoInvestigateCoveCorpseWithMordre")]
public sealed class aov : dgy
{
	// Token: 0x06004DAF RID: 19887 RVA: 0x00228674 File Offset: 0x00226874
	public aov()
	{
		aov.a a = new aov.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a.aqw() != null && a.a.aqu() != null)
		{
			dmv dmv = new dmv();
			a.b = null;
			a.c = null;
			if (a.a.aqu().v() != null && a.a.aqu().v().b() != null)
			{
				a.b = new s5();
				a.b.a(new bt4("cutsceneExitPlayer"));
				a.b.a(new ar7(a.a.aqu().v().b()));
				dmv.a(new btm[]
				{
					a.b
				});
			}
			a.d = null;
			foreach (aud aud in a.a.aqw().Areas)
			{
				a.d = aud.a(new Guid("bad8f763-91ac-4ae0-9c9b-bfc937c5dff1"));
				if (a.d != null)
				{
					break;
				}
			}
			if (a.d != null)
			{
				a.c = new s5();
				a.c.a(new bt4("cutsceneExitMordre"));
				a.c.a(new ar7(a.d));
				dmv.a(new btm[]
				{
					a.c
				});
			}
			b8q b8q = new b8q();
			b8q.a(new btm[]
			{
				new os(TimeSpan.FromSeconds(1.0))
			});
			di6 di = b8q;
			btm[] array = new btm[1];
			int num = 0;
			dky dky = new dky();
			dky.a(0.2f);
			array[num] = dky;
			di.a(array);
			b8q.a(new btm[]
			{
				new dva(null, new Func<e6d, bool>(a.a), null, null, null)
			});
			b8q.a(new btm[]
			{
				new di4(new c2w("MushroomCoveNW", "cutsceneEntrancePlayer"), false, null, 0, null, true, false, false)
			});
			dmv.a(new btm[]
			{
				b8q
			});
			base.a(new btm[]
			{
				dmv
			});
		}
	}

	// Token: 0x02000EBA RID: 3770
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DB1 RID: 19889 RVA: 0x002288FC File Offset: 0x00226AFC
		internal bool a(e6d A_0)
		{
			if (this.b != null)
			{
				this.b.n();
			}
			if (this.c != null)
			{
				this.c.n();
			}
			crm.a(this.d, "mordre");
			cyt cyt = this.a.aqu();
			string a_ = "MushroomCoveNW";
			uq uq = new uq();
			uq.a("mordre");
			uq.a(new bt4("cutsceneEntranceOther"));
			cyt.a(new bw0(a_, uq, 1));
			cyt cyt2 = this.a.aqu();
			string a_2 = "MushroomCoveNW";
			bf3 bf = new bf3();
			cu4 cu = new cu4();
			cu.a(new Guid?(this.d.qe()));
			cu.a("characters\\mordreCoveCorpse");
			bf.a(cu);
			cyt2.a(new bw0(a_2, bf, 1));
			return true;
		}

		// Token: 0x04001FC3 RID: 8131
		public cnk a;

		// Token: 0x04001FC4 RID: 8132
		public s5 b;

		// Token: 0x04001FC5 RID: 8133
		public s5 c;

		// Token: 0x04001FC6 RID: 8134
		public b0b d;
	}
}
