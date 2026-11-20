using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000DE8 RID: 3560
[e79("Dc_RepairGateMechanism")]
public sealed class crs : dgy
{
	// Token: 0x06004C05 RID: 19461 RVA: 0x0021164C File Offset: 0x0020F84C
	public crs()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			crs.b b = new crs.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				crs.a a = new crs.a();
				a.b = b;
				a.a = (new ar7(new Guid("44518e0a-2110-45c3-9520-a926e2e69246"), a.b.a.Area).ao() as c5x);
				new ar7(new Guid("5da66943-14ac-44fa-8fe0-ddcf9cad0f5b"), a.b.a.Area).ao();
				if (a.a != null)
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
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_dc_repairGate_repairWithBot", new bool?(false)).Value)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
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
						btm[] array3 = new btm[1];
						int num3 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.Operating);
						bb.a(atp.a);
						bb.IsAsync = true;
						bb.a(new ar7(a.a));
						bb.b(3);
						array3[num3] = bb;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						dky dky2 = new dky();
						dky2.a(0.2f);
						dky2.a(false);
						array4[num4] = dky2;
						base.a(array4);
					}
					else
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						c8s c8s2 = new c8s();
						c8s2.a(0.2f);
						c8s2.IsAsync = false;
						array5[num5] = c8s2;
						base.a(array5);
						btm[] array6 = new btm[1];
						int num6 = 0;
						bb8 bb2 = new bb8();
						bb2.a(CharacterState.Operating);
						bb2.a(atp.a);
						bb2.IsAsync = true;
						bb2.a(new ar7(a.b.a));
						bb2.b(3);
						array6[num6] = bb2;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						dky dky3 = new dky();
						dky3.a(0.2f);
						dky3.a(false);
						array7[num7] = dky3;
						base.a(array7);
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					c8s c8s3 = new c8s();
					c8s3.a(0.2f);
					c8s3.IsAsync = false;
					array8[num8] = c8s3;
					base.a(array8);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000DE9 RID: 3561
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C07 RID: 19463 RVA: 0x00211A00 File Offset: 0x0020FC00
		internal bool a(e6d A_0)
		{
			a72 a = new a72();
			a.b("interfacing\\dc_repairGate");
			a.d("interface");
			a.c("Механизм ворот");
			a.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001EB1 RID: 7857
		public c5x a;
	}

	// Token: 0x02000DEA RID: 3562
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C09 RID: 19465 RVA: 0x00211A4C File Offset: 0x0020FC4C
		internal bool a(e6d A_0)
		{
			a0l.a(this.b.a, "player_wait", true);
			a0l.a(this.a, "repairs", true);
			return true;
		}

		// Token: 0x04001EB2 RID: 7858
		public c5x a;

		// Token: 0x04001EB3 RID: 7859
		public crs.b b;
	}
}
