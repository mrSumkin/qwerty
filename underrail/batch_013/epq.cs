using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000D8D RID: 3469
[e79("Xpbl_StartDrinkingWithDude")]
public sealed class epq : dgy
{
	// Token: 0x06004B50 RID: 19280 RVA: 0x0020832C File Offset: 0x0020652C
	public epq()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			epq.a a = new epq.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				a.b = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), a.a.Area).ao() as c5x);
				if (a.b != null)
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
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
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

	// Token: 0x02000D8E RID: 3470
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B52 RID: 19282 RVA: 0x002084E8 File Offset: 0x002066E8
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_drink", true);
			a0l.a(this.b, "44ed2389-eb6f-416d-a11e-efbb98548ab4", true);
			doq a_ = doq.a(Path.Combine(d5x.q(), "rc1_l" + 3.ToString()) + ".uzl");
			this.a.Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x00208558 File Offset: 0x00206758
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E3B RID: 7739
		public c5x a;

		// Token: 0x04001E3C RID: 7740
		public c5x b;
	}
}
