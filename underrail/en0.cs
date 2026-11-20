using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000F25 RID: 3877
[e79("Xpbl_Pir_KatyaArrivesToCave")]
public sealed class en0 : dgy
{
	// Token: 0x06004EE7 RID: 20199 RVA: 0x00237974 File Offset: 0x00235B74
	public en0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			en0.a a = new en0.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("5c4e9e80-fa71-4977-82bc-93ca150844ee"), a.a.Zone.n("xpbl_f1")).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(a.a));
					s.a(new bt4("player_caughtByKatya"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000F26 RID: 3878
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EE9 RID: 20201 RVA: 0x00237B14 File Offset: 0x00235D14
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_caughtByKatya", true);
			a0l.a(this.b, "FromWaterfall", true);
			if (this.b.t.b != null)
			{
				List<string> classPropertyValue = this.b.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
				if (classPropertyValue != null && Enumerable.Any<string>(classPropertyValue))
				{
					this.b.t.b.y6()["UnusedPatrolRoute"] = classPropertyValue;
					this.b.t.b.y6().RemoveProperty(ddq.k);
				}
				this.b.t.b.y6()[ddq.ay] = new bt4("FromWaterfall");
			}
			if (this.b.h.b != null)
			{
				this.b.h.b.aa().HostilityBroadcastMode = c2n.b;
			}
			return true;
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00237C24 File Offset: 0x00235E24
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04002054 RID: 8276
		public c5x a;

		// Token: 0x04002055 RID: 8277
		public c5x b;
	}
}
