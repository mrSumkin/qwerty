using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CFE RID: 3326
[e79("Cc_DropCageNearTheTunneler")]
public sealed class dti : dgy
{
	// Token: 0x060049FC RID: 18940 RVA: 0x001F0B40 File Offset: 0x001EED40
	public dti()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dti.a a = new dti.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("d327121f-270b-4108-bfed-44e0ac12decc"), a.a.Area).ao() as c5x);
				c5x c5x = new ar7(new Guid("f03ac24d-d458-424b-bffd-65ec9368bd04"), a.a.Area).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("f1227d9b-2241-4e1c-9f18-2d8a2d618401"), a.a.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("671c388b-c10c-4e7e-9d8c-390e48045fd1"), a.a.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("f68dc707-3d3f-4c67-8a0a-44e8d0defa35"), a.a.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("5a06df1b-bf27-45a2-9852-100e5b27cd1f"), a.a.Area).ao() as c5x;
				c5x c5x6 = new ar7(new Guid("8ebe7278-6129-4851-b71e-88b2a036c424"), a.a.Area).ao() as c5x;
				base.a(new btm[]
				{
					new ace(new e80(false))
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
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (c5x != null)
				{
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x));
					a2.c(false);
					array2[num2] = a2;
					base.a(array2);
				}
				if (c5x2 != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a3 = new a5();
					a3.a(new ar7(c5x2));
					a3.c(false);
					array3[num3] = a3;
					base.a(array3);
				}
				if (c5x3 != null)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a4 = new a5();
					a4.a(new ar7(c5x3));
					a4.c(false);
					array4[num4] = a4;
					base.a(array4);
				}
				if (c5x4 != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					a5 a5 = new a5();
					a5.a(new ar7(c5x4));
					a5.c(false);
					array5[num5] = a5;
					base.a(array5);
				}
				if (c5x5 != null)
				{
					btm[] array6 = new btm[1];
					int num6 = 0;
					a5 a6 = new a5();
					a6.a(new ar7(c5x5));
					a6.c(false);
					array6[num6] = a6;
					base.a(array6);
				}
				if (c5x6 != null)
				{
					btm[] array7 = new btm[1];
					int num7 = 0;
					a5 a7 = new a5();
					a7.a(new ar7(c5x6));
					a7.c(false);
					array7[num7] = a7;
					base.a(array7);
				}
				if (a.b != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc16_faceless_released", new bool?(false)).Value)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
				}
				if (a.b != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc16_faceless_killed", new bool?(false)).Value)
				{
					btm[] array8 = new btm[1];
					int num8 = 0;
					a5 a8 = new a5();
					a8.a(new ar7(a.b));
					a8.c(false);
					array8[num8] = a8;
					base.a(array8);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array9[num9] = c8s;
				base.a(array9);
				if (a.b != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc16_faceless_released", new bool?(false)).Value)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc16_faceless_killed", new bool?(false)).Value)
				{
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx = new egx();
					egx.a("Вот это грохот!");
					array10[num10] = new ace(egx)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array10);
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000CFF RID: 3327
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049FE RID: 18942 RVA: 0x001F0FEC File Offset: 0x001EF1EC
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_releaseFaceless", true);
			a0l.a(this.b, "faceless_released", true);
			return true;
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x001F1014 File Offset: 0x001EF214
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D6B RID: 7531
		public c5x a;

		// Token: 0x04001D6C RID: 7532
		public c5x b;
	}
}
