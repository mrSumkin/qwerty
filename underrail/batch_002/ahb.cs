using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F31 RID: 3889
[e79("Xpbl_Hc_PushAwayRocksOutside")]
public sealed class ahb : dgy
{
	// Token: 0x06004EFA RID: 20218 RVA: 0x00238840 File Offset: 0x00236A40
	public ahb()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ahb.a a = new ahb.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				ar7 a_ = new ar7(a.a);
				a.a.i.b.a(true, false);
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
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				bfq bfq = new bfq();
				bfq.c("EarthquakeShort");
				array2[num2] = new ace(bfq)
				{
					TargetRef = a_
				};
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				bfq bfq2 = new bfq();
				bfq2.c("WaterSplashGiant");
				array3[num3] = new ace(bfq2)
				{
					TargetRef = a_
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				bfq bfq3 = new bfq();
				bfq3.c("EarthquakeShort");
				array4[num4] = new ace(bfq3)
				{
					TargetRef = a_
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				bfq bfq4 = new bfq();
				bfq4.c("WaterSplashGiant");
				array5[num5] = new ace(bfq4)
				{
					TargetRef = a_
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				bfq bfq5 = new bfq();
				bfq5.c("EarthquakeShort");
				array6[num6] = new ace(bfq5)
				{
					TargetRef = a_
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				bfq bfq6 = new bfq();
				bfq6.c("EarthquakeShort");
				array7[num7] = new ace(bfq6)
				{
					TargetRef = a_
				};
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				bfq bfq7 = new bfq();
				bfq7.c("WaterSplashGiant");
				array8[num8] = new ace(bfq7)
				{
					TargetRef = a_
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				bfq bfq8 = new bfq();
				bfq8.c("EarthquakeShort");
				array9[num9] = new ace(bfq8)
				{
					TargetRef = a_
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				bfq bfq9 = new bfq();
				bfq9.c("WaterSplashGiant");
				array10[num10] = new ace(bfq9)
				{
					TargetRef = a_
				};
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array11[num11] = dva;
				base.a(array11);
				btm[] array12 = new btm[1];
				int num12 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array12[num12] = c8s;
				base.a(array12);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F32 RID: 3890
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EFC RID: 20220 RVA: 0x00238C48 File Offset: 0x00236E48
		internal bool a(e6d A_0)
		{
			d60 d = this.a.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"xpbl_h7_strengthCheckRemove"
				}))
				{
					if (b0b != null)
					{
						b0b.w();
						b0b.an();
					}
				}
			}
			return true;
		}

		// Token: 0x0400205E RID: 8286
		public c5x a;
	}
}
