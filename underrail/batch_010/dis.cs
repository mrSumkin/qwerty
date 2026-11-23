using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000C91 RID: 3217
[e79("Cc_HoboChase")]
public sealed class dis : dgy
{
	// Token: 0x060048EC RID: 18668 RVA: 0x001DBB80 File Offset: 0x001D9D80
	public dis()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dis.a a = new dis.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			a.b = (new ar7(new Guid("eb464304-0ca7-4fd6-810e-a718fae366ce"), a.a.Area).ao() as c5x);
			bool flag = a.a.h.b.aa().BaseAbilities.a("Agility").g() >= 7;
			if (a.a != null && a.b != null)
			{
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
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				if (flag)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Die);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(a.b));
					bb.a(cux.h);
					array2[num2] = bb;
					base.a(array2);
					base.a(new btm[]
					{
						new ace(new epw(new CharacterState?(CharacterState.Die)))
						{
							TargetRef = new ar7(a.b)
						}
					});
					base.a(new btm[]
					{
						new ace(new b16(new int?(7)))
						{
							TargetRef = new ar7(a.b)
						}
					});
				}
				else
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(a.b));
					a2.c(true);
					array3[num3] = a2;
					base.a(array3);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array4[num4] = c8s;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				if (flag)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx = new egx();
					egx.a("Попался!");
					array5[num5] = new ace(egx)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx2 = new egx();
					egx2.a("Моя спина! Ты трубо...");
					array6[num6] = new ace(egx2)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.5))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx3 = new egx();
					egx3.a("Вставай! Ты отправляешься в тюрьму.");
					array7[num7] = new ace(egx3)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					dky dky2 = new dky();
					dky2.a(0.2f);
					dky2.a(false);
					array8[num8] = dky2;
					base.a(array8);
					btm[] array9 = new btm[1];
					int num9 = 0;
					a5 a3 = new a5();
					a3.a(new ar7(a.b));
					a3.c(true);
					array9[num9] = a3;
					base.a(array9);
					base.a(new btm[]
					{
						new di4(new c2w("cc22", "outsidePraetorian"), false, new bool?(true), 0, null, true, false, false)
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx4 = new egx();
					egx4.a("Очередь хода зависит от подвижности.");
					array10[num10] = new ace(egx4)
					{
						TargetRef = new ar7(aju.a, new Guid("480b0f4f-eb96-439e-95e2-85b237a4852c"), new Guid("6288a198-4d25-4f23-8c9a-d5c65afdbc6a"), bl1.a)
					};
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
				}
				else
				{
					btm[] array11 = new btm[1];
					int num11 = 0;
					egx egx5 = new egx();
					egx5.a("Чёрт... Он быстрее, чем кажется.");
					array11[num11] = new ace(egx5)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000C92 RID: 3218
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060048EE RID: 18670 RVA: 0x001DC0A8 File Offset: 0x001DA2A8
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_chaseHobo", true);
			return true;
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x001DC0BC File Offset: 0x001DA2BC
		internal bool a(e6d A_0)
		{
			a0l.a(this.b, "hobo_dropped", true);
			return true;
		}

		// Token: 0x04001CCA RID: 7370
		public c5x a;

		// Token: 0x04001CCB RID: 7371
		public c5x b;
	}
}
