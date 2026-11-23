using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;

// Token: 0x02000EEB RID: 3819
[e79("Xphw_ExoBase_CommanderGoesCryo")]
public sealed class e6c : dgy
{
	// Token: 0x06004E49 RID: 20041 RVA: 0x0022BDEC File Offset: 0x00229FEC
	public e6c()
	{
		e6c.a a = new e6c.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.b.i.b.a(true, false);
				base.a(new btm[]
				{
					new ace(new e80(false))
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
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array2[num2] = c8s;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				eln eln = new eln();
				eln.a(Xphw_GunslingerCommentCodeEnum.Event_CommanderSleeps);
				array3[num3] = new ace(eln);
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000EEC RID: 3820
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E4B RID: 20043 RVA: 0x0022BFB0 File Offset: 0x0022A1B0
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("04415430-2dc3-4f19-9325-5a7facb1eeed"), this.b.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("da48b0cb-39ac-4e30-8134-8eabe744ddfc"), this.b.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("4f92e2b9-640d-4888-84a2-276762e267bb"), this.b.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
			if (c5x3 != null)
			{
				c5x3.ae = null;
				if (c5x3.s.b != null)
				{
					c5x3.s.b.g(true);
				}
			}
			if (c5x2 != null)
			{
				cd0 aspect = c5x2.GetAspect<cd0>();
				if (aspect != null)
				{
					aspect.b.X = 0;
				}
				c5x2.RemoveAspect<bim>();
			}
			this.a.aqu().a(new bw0("xphw_exobase_med1", new cf6(), 1));
			this.a.aqu().a(new bw0("xphw_exobase_med2", new cf6(), 1));
			this.a.aqu().r()["faction_xphw_exoBase_returnedToCryo"] = true;
			this.a.aqu().r()["faction_xphw_exoBase_exosoldiers_stopDeployment"] = true;
			this.a.aqu().r()["faction_xphw_exoBase_superSoldiers_stopDeployment"] = true;
			eaq eaq = new eaq();
			eaq.b(asp.gx);
			eaq.a(asp.a);
			eaq.a(h.c);
			eaq.a(true);
			eaq.ym(null, null, null);
			return true;
		}

		// Token: 0x04001FEB RID: 8171
		public cnk a;

		// Token: 0x04001FEC RID: 8172
		public c5x b;
	}
}
