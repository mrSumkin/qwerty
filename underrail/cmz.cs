using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F4B RID: 3915
[e79("Xpbl_I5_EnterPipe")]
public sealed class cmz : dgy
{
	// Token: 0x06004F37 RID: 20279 RVA: 0x0023BFDC File Offset: 0x0023A1DC
	public cmz()
	{
		cmz.a a = new cmz.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				ar7 a_ = new ar7(a.b);
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
				btm[] array2 = new btm[1];
				int num2 = 0;
				bfq bfq = new bfq();
				bfq.c("VentilationShaftEnterExit");
				array2[num2] = new ace(bfq)
				{
					TargetRef = a_
				};
				base.a(array2);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				bfq bfq2 = new bfq();
				bfq2.c("VentilationShaftEnterExit");
				array3[num3] = new ace(bfq2)
				{
					TargetRef = a_
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array4[num4] = c8s;
				base.a(array4);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F4C RID: 3916
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F39 RID: 20281 RVA: 0x0023C1C0 File Offset: 0x0023A3C0
		internal bool a(e6d A_0)
		{
			if (this.a.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_i5_enteredLowerPipe", new bool?(false)).Value)
			{
				a0l.a(this.b, "FromPipeBar", true);
			}
			else
			{
				a0l.a(this.b, "FromPipeWh", true);
			}
			return true;
		}

		// Token: 0x0400207F RID: 8319
		public cnk a;

		// Token: 0x04002080 RID: 8320
		public c5x b;
	}
}
