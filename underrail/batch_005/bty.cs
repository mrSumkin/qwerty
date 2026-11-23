using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000D60 RID: 3424
[e79("Xpbl_Mc_DeathmanLeaves")]
public sealed class bty : dgy
{
	// Token: 0x06004AD8 RID: 19160 RVA: 0x00201C58 File Offset: 0x001FFE58
	public bty()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bty.a a = new bty.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			c5x c5x = new ar7(new Guid("a0d8e852-cf11-45bf-949f-8c5273c703c6"), a.a.Area).ao() as c5x;
			new ar7(new Guid("41ececc1-962e-4d5d-a41d-94dea94f911d"), a.a.Area).ao();
			c5x c5x2 = new ar7(new Guid("4557507b-5d75-46dc-b57a-6c2e6ec1fe4a"), a.a.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("33d28cfa-c0cc-4131-86cc-9da15ae24824"), a.a.Area).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("fa59afd9-a7ec-4ca9-9bf8-d222cf8c8190"), a.a.Area).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("89321fc1-855b-45c9-83e9-39f1ecb692c4"), a.a.Area).ao() as c5x;
			c5x c5x6 = new ar7(new Guid("bddc29b8-9511-4ded-9582-c73e23bff2d2"), a.a.Area).ao() as c5x;
			c5x c5x7 = new ar7(new Guid("5f3d8ff7-10be-4e1c-bc35-be9dd788a52b"), a.a.Area).ao() as c5x;
			c5x c5x8 = new ar7(new Guid("8f33e528-4ce6-4113-8e87-15f3afbc35ea"), a.a.Area).ao() as c5x;
			c5x c5x9 = new ar7(new Guid("97da34b3-f2dc-495f-938b-303ea8938fa2"), a.a.Area).ao() as c5x;
			c5x c5x10 = new ar7(new Guid("5e87e1ae-43ea-4a09-99f3-3daf71f4ad40"), a.a.Area).ao() as c5x;
			serviceOrThrow.aqu().r()["loc_xpbl_mc_deathMan_done"] = true;
			foreach (b0b b0b in Enumerable.ToList<b0b>(a.a.Area.Entities))
			{
				c5x c5x11 = (c5x)b0b;
				if (c5x11 != null)
				{
					if (c5x11.y8() == "Door" && c5x11.s.b != null)
					{
						d2b aspect = c5x11.GetAspect<d2b>();
						if (aspect != null && !aspect.e())
						{
							aspect.e(false);
						}
					}
					else if (c5x11.h.b != null && c5x11.h.b.aa().FactionId == asp.f9)
					{
						c5x11.b("dsp_xpbl_mc1_servants");
					}
				}
			}
			if (c5x10 != null && c5x10.h.b != null)
			{
				c5x10.h.b.aa().FactionId = asp.ga;
			}
			if (a.a != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				if (c5x2 != null)
				{
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(c5x2));
					s.a(new bt4("servant1"));
					s.IsAsync = true;
					s.a(true);
					array[num] = s;
					base.a(array);
				}
				if (c5x3 != null)
				{
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(c5x3));
					s2.a(new bt4("servant2"));
					s2.IsAsync = true;
					s2.a(true);
					array2[num2] = s2;
					base.a(array2);
				}
				if (c5x4 != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(c5x4));
					s3.a(new bt4("servant3"));
					s3.IsAsync = true;
					s3.a(true);
					array3[num3] = s3;
					base.a(array3);
				}
				if (c5x5 != null)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					s5 s4 = new s5();
					s4.a(new ar7(c5x5));
					s4.a(new bt4("servant5"));
					s4.IsAsync = true;
					s4.a(true);
					array4[num4] = s4;
					base.a(array4);
				}
				if (c5x6 != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s5 = new s5();
					s5.a(new ar7(c5x6));
					s5.a(new bt4("servant6"));
					s5.IsAsync = true;
					s5.a(true);
					array5[num5] = s5;
					base.a(array5);
				}
				if (c5x7 != null)
				{
					btm[] array6 = new btm[1];
					int num6 = 0;
					s5 s6 = new s5();
					s6.a(new ar7(c5x7));
					s6.a(new bt4("servant8"));
					s6.IsAsync = true;
					s6.a(true);
					array6[num6] = s6;
					base.a(array6);
				}
				if (c5x8 != null)
				{
					btm[] array7 = new btm[1];
					int num7 = 0;
					s5 s7 = new s5();
					s7.a(new ar7(c5x8));
					s7.a(new bt4("servant9"));
					s7.IsAsync = true;
					s7.a(true);
					array7[num7] = s7;
					base.a(array7);
				}
				if (c5x9 != null)
				{
					btm[] array8 = new btm[1];
					int num8 = 0;
					s5 s8 = new s5();
					s8.a(new ar7(c5x9));
					s8.a(new bt4("servant10"));
					s8.IsAsync = true;
					s8.a(true);
					array8[num8] = s8;
					base.a(array8);
				}
				if (c5x != null)
				{
					btm[] array9 = new btm[1];
					int num9 = 0;
					s5 s9 = new s5();
					s9.a(new ar7(a.a));
					s9.a(new bt4("playerWait"));
					s9.IsAsync = true;
					s9.a(true);
					array9[num9] = s9;
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					s5 s10 = new s5();
					s10.a(new ar7(c5x));
					s10.a(new bt4("deathman_leaves"));
					s10.IsAsync = true;
					s10.a(true);
					array10[num10] = s10;
					base.a(array10);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				if (c5x != null)
				{
					btm[] array11 = new btm[1];
					int num11 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x));
					a2.c(false);
					array11[num11] = a2;
					base.a(array11);
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x06004AD9 RID: 19161 RVA: 0x0020230C File Offset: 0x0020050C
	protected override List<btm> ti(Exception A_0, btm A_1)
	{
		return new List<btm>
		{
			new ace(new e80(true))
		};
	}

	// Token: 0x02000D61 RID: 3425
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004ADB RID: 19163 RVA: 0x0020232C File Offset: 0x0020052C
		internal bool a(e6d A_0)
		{
			awh awh = new awh();
			awh.b("xpbl_mc1");
			awh.b(new Guid("397c5e97-2fd9-4cb7-a25b-e1a5a6cecbc0"));
			awh.a(new Guid("d97c112f-ac46-4a5f-95ea-498114b69d62"));
			awh.a(bbo.b);
			awh.a(false);
			awh.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001E00 RID: 7680
		public c5x a;
	}
}
