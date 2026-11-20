using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000CC8 RID: 3272
[e79("Xpbl_ojyc1_CraneClearBlockade")]
public sealed class dwy : dgy
{
	// Token: 0x06004991 RID: 18833 RVA: 0x001EAA6C File Offset: 0x001E8C6C
	public dwy()
	{
		dwy.a a = new dwy.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			c5x c5x = a.a.aqu().v().b() as c5x;
			if (c5x != null)
			{
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
				btm[] array2 = new btm[1];
				int num2 = 0;
				bfq bfq = new bfq();
				bfq.c("InstituteElevatorLoop");
				array2[num2] = new ace(bfq)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				bfq bfq2 = new bfq();
				bfq2.c("xpbl_SubmarineGroan3");
				array3[num3] = new ace(bfq2)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.35))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				bfq bfq3 = new bfq();
				bfq3.c("xpbl_SubmarineGroan1");
				array4[num4] = new ace(bfq3)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				bfq bfq4 = new bfq();
				bfq4.c("xpbl_SubmarineGroan5");
				array5[num5] = new ace(bfq4)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.5))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array6[num6] = c8s;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000CC9 RID: 3273
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004993 RID: 18835 RVA: 0x001EAD10 File Offset: 0x001E8F10
		internal bool a(e6d A_0)
		{
			d60 d = this.a.aqw().a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"xpbl_ojyc1_waterBlock"
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						b0b.w();
						b0b.an();
					}
				}
				List<b0b> list2 = d.ab4(new string[]
				{
					"xpbl_ojyc1_waterBlockNew"
				});
				if (list2 != null)
				{
					foreach (b0b b0b2 in list2)
					{
						c5x c5x = (c5x)b0b2;
						if (c5x.o.b != null)
						{
							c5x.o.b.d = new float?((float)1);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x04001D23 RID: 7459
		public cnk a;
	}
}
