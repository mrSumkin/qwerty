using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CAE RID: 3246
[e79("Lux_Ms_MidsummerianHealing")]
public sealed class ejz : dgy
{
	// Token: 0x06004940 RID: 18752 RVA: 0x001E297C File Offset: 0x001E0B7C
	public ejz()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ejz.a a = new ejz.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					a.c = (Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						"randomEvent_lux-ms_midsummerian1"
					})) as c5x);
					a.d = (Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						"randomEvent_lux-ms_midsummerian2"
					})) as c5x);
					a.b = (Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						"randomEvent_lux-ms_midsummerian3"
					})) as c5x);
					if (a.c != null && a.d != null && a.b != null)
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
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.Operating);
						bb.a(atp.a);
						bb.IsAsync = true;
						bb.a(new ar7(a.c));
						bb.b(4);
						array2[num2] = bb;
						base.a(array2);
						btm[] array3 = new btm[1];
						int num3 = 0;
						bb8 bb2 = new bb8();
						bb2.a(CharacterState.Operating);
						bb2.a(atp.a);
						bb2.IsAsync = true;
						bb2.a(new ar7(a.d));
						bb2.b(4);
						array3[num3] = bb2;
						base.a(array3);
						btm[] array4 = new btm[1];
						int num4 = 0;
						bb8 bb3 = new bb8();
						bb3.a(CharacterState.Operating);
						bb3.a(atp.a);
						bb3.IsAsync = true;
						bb3.a(new ar7(a.b));
						bb3.b(4);
						array4[num4] = bb3;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						c8s.IsAsync = false;
						array5[num5] = c8s;
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						egx egx = new egx();
						egx.a("М-м-м...");
						array6[num6] = new ace(egx)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array6);
						btm[] array7 = new btm[1];
						int num7 = 0;
						bb8 bb4 = new bb8();
						bb4.a(CharacterState.Operating);
						bb4.a(atp.a);
						bb4.IsAsync = true;
						bb4.a(new ar7(a.c));
						bb4.b(6);
						array7[num7] = bb4;
						base.a(array7);
						btm[] array8 = new btm[1];
						int num8 = 0;
						bb8 bb5 = new bb8();
						bb5.a(CharacterState.Operating);
						bb5.a(atp.a);
						bb5.IsAsync = true;
						bb5.a(new ar7(a.d));
						bb5.b(6);
						array8[num8] = bb5;
						base.a(array8);
						btm[] array9 = new btm[1];
						int num9 = 0;
						bb8 bb6 = new bb8();
						bb6.a(CharacterState.Operating);
						bb6.a(atp.a);
						bb6.IsAsync = true;
						bb6.a(new ar7(a.b));
						bb6.b(6);
						array9[num9] = bb6;
						base.a(array9);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array10 = new btm[1];
						int num10 = 0;
						dky dky2 = new dky();
						dky2.a(0.2f);
						dky2.a(false);
						array10[num10] = dky2;
						base.a(array10);
						base.a(new btm[]
						{
							new ace(new eop())
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array11 = new btm[1];
						int num11 = 0;
						c8s c8s2 = new c8s();
						c8s2.a(0.2f);
						c8s2.IsAsync = false;
						array11[num11] = c8s2;
						base.a(array11);
						btm[] array12 = new btm[1];
						int num12 = 0;
						egx egx2 = new egx();
						egx2.a("Я могу использовать это.");
						array12[num12] = new ace(egx2)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array12);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000CAF RID: 3247
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004942 RID: 18754 RVA: 0x001E2E24 File Offset: 0x001E1024
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "randomEvent_lux-ms_playerHeal", true);
			a0l.a(this.b, "randomEvent_lux-ms_midsummerianHeal", true);
			this.a.VisualDirection = HorizontalDirection.East;
			this.c.VisualDirection = HorizontalDirection.North;
			this.d.VisualDirection = HorizontalDirection.South;
			this.b.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x001E2E84 File Offset: 0x001E1084
		internal bool a(e6d A_0)
		{
			awz a_ = new awz(2400000, 0.05);
			this.a.h.b.aa().StatusEffects.a(a_, false, false, false);
			a0l.a(this.a, "randomEvent_lux-ms_guard4", true);
			a0l.a(this.b, "randomEvent_lux-ms_guard3", true);
			this.a.VisualDirection = HorizontalDirection.Northwest;
			this.c.VisualDirection = HorizontalDirection.Northeast;
			this.d.VisualDirection = HorizontalDirection.Southeast;
			this.b.VisualDirection = HorizontalDirection.Southwest;
			return true;
		}

		// Token: 0x04001CF8 RID: 7416
		public c5x a;

		// Token: 0x04001CF9 RID: 7417
		public c5x b;

		// Token: 0x04001CFA RID: 7418
		public c5x c;

		// Token: 0x04001CFB RID: 7419
		public c5x d;
	}
}
