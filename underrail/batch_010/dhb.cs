using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EED RID: 3821
[e79("Xphw_ExoBase_GunslingersFateAfterAmbush")]
public sealed class dhb : dgy
{
	// Token: 0x06004E4C RID: 20044 RVA: 0x0022C16C File Offset: 0x0022A36C
	public dhb()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dhb.a a = new dhb.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				dhb.b b = new dhb.b();
				b.b = a;
				b.b.a.i.b.a(true, false);
				b.a = (new ar7(c29.a, b.b.a.Area).ao() as c5x);
				if (b.a != null)
				{
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_helpLeaveRailcar", new bool?(false)).Value;
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
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
					});
					if (value)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.c), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
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
							new dva(null, new Func<e6d, bool>(b.b), null, null, null)
						});
					}
					else
					{
						btm[] array3 = new btm[1];
						int num3 = 0;
						bfq bfq = new bfq();
						bfq.c("pistolShot");
						bfq.a(0.6f);
						array3[num3] = new ace(bfq)
						{
							TargetRef = new ar7(b.b.a)
						};
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.10000000149011612))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						bfq bfq2 = new bfq();
						bfq2.c("BulletHitMetal");
						array4[num4] = new ace(bfq2)
						{
							TargetRef = new ar7(b.b.a)
						};
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						bfq bfq3 = new bfq();
						bfq3.c("pistolShot");
						bfq3.a(0.6f);
						array5[num5] = new ace(bfq3)
						{
							TargetRef = new ar7(b.b.a)
						};
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.10000000149011612))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						bfq bfq4 = new bfq();
						bfq4.c("pistolShot");
						bfq4.a(0.6f);
						array6[num6] = new ace(bfq4)
						{
							TargetRef = new ar7(b.b.a)
						};
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.10000000149011612))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						bfq bfq5 = new bfq();
						bfq5.c("pistolShot");
						bfq5.a(0.6f);
						array7[num7] = new ace(bfq5)
						{
							TargetRef = new ar7(b.b.a)
						};
						base.a(array7);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.10000000149011612))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						c8s c8s2 = new c8s();
						c8s2.a(0.2f);
						c8s2.IsAsync = false;
						array8[num8] = c8s2;
						base.a(array8);
					}
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000EEE RID: 3822
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E4E RID: 20046 RVA: 0x0022C5D8 File Offset: 0x0022A7D8
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "player_fromRailcar", true);
			return true;
		}

		// Token: 0x04001FED RID: 8173
		public c5x a;
	}

	// Token: 0x02000EEF RID: 3823
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004E50 RID: 20048 RVA: 0x0022C5F4 File Offset: 0x0022A7F4
		internal bool c(e6d A_0)
		{
			a0l.a(this.a, "global:xphw_gunslinger:fromRailcar", true);
			return true;
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x0022C60C File Offset: 0x0022A80C
		internal bool b(e6d A_0)
		{
			this.b.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x0022C640 File Offset: 0x0022A840
		internal bool a(e6d A_0)
		{
			this.a.h.b.a(null, false);
			return true;
		}

		// Token: 0x04001FEE RID: 8174
		public c5x a;

		// Token: 0x04001FEF RID: 8175
		public dhb.a b;
	}
}
