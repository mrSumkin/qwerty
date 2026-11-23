using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F27 RID: 3879
[e79("Xpbl_Pir_AegisAttackWhileInCaptainsOffice")]
public sealed class xy : dgy
{
	// Token: 0x06004EEB RID: 20203 RVA: 0x00237C54 File Offset: 0x00235E54
	public xy()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			xy.a a = new xy.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			ar7 a_ = new ar7(a.a);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("eeeb3815-98da-4fc1-8d8c-29204bc22801"), a.a.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array = new btm[1];
				int num = 0;
				bfq bfq = new bfq();
				bfq.c("TntExplode");
				array[num] = new ace(bfq)
				{
					TargetRef = a_
				};
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				bfq bfq2 = new bfq();
				bfq2.c("pistolShot");
				array2[num2] = new ace(bfq2)
				{
					TargetRef = a_
				};
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				bfq bfq3 = new bfq();
				bfq3.c("TntExplode");
				array3[num3] = new ace(bfq3)
				{
					TargetRef = a_
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				bfq bfq4 = new bfq();
				bfq4.c("pistolShot");
				array4[num4] = new ace(bfq4)
				{
					TargetRef = a_
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				bfq bfq5 = new bfq();
				bfq5.c("pistolShot");
				array5[num5] = new ace(bfq5)
				{
					TargetRef = a_
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				bfq bfq6 = new bfq();
				bfq6.c("pistolShot");
				array6[num6] = new ace(bfq6)
				{
					TargetRef = a_
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				bfq bfq7 = new bfq();
				bfq7.c("pistolShot");
				array7[num7] = new ace(bfq7)
				{
					TargetRef = a_
				};
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.4))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				bfq bfq8 = new bfq();
				bfq8.c("FlashbangExplode");
				array8[num8] = new ace(bfq8)
				{
					TargetRef = a_
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.6))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				bfq bfq9 = new bfq();
				bfq9.c("TntExplode");
				array9[num9] = new ace(bfq9)
				{
					TargetRef = a_
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
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

	// Token: 0x02000F28 RID: 3880
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EED RID: 20205 RVA: 0x0023802C File Offset: 0x0023622C
		internal bool a(e6d A_0)
		{
			new c8z("spawnstay").ym(this.a, null, null);
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04002056 RID: 8278
		public c5x a;

		// Token: 0x04002057 RID: 8279
		public c5x b;
	}
}
