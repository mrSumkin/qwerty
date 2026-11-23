using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D71 RID: 3441
[e79("Xpbl_DudeMakesTheJuice")]
public sealed class act : dgy
{
	// Token: 0x06004AF7 RID: 19191 RVA: 0x0020369C File Offset: 0x0020189C
	public act()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			act.b b = new act.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null && b.a.Area != null)
			{
				act.a a = new act.a();
				a.c = b;
				a.a = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), a.c.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("826f77b5-80f0-4986-bdd7-ce08967ed7d8"), a.c.a.Area).ao() as c5x);
				if (a.a != null)
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
						new dva(null, new Func<e6d, bool>(a.c), null, null, null)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("xpbl_lux_dh", new Vector3(3f, 2f, 0f)));
					kw.IsAsync = false;
					kw.a(true);
					array2[num2] = kw;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array3[num3] = c8s;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.a));
					bb.b(2);
					array4[num4] = bb;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx = new egx();
					egx.a("Итак, оборудование готово.");
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
					egx2.a("Ладно, блин. Заливай самогон.");
					array6[num6] = new ace(egx2)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.OperateShort);
					bb2.a(atp.a);
					bb2.IsAsync = false;
					bb2.a(new ar7(a.c.a));
					bb2.b(1);
					array7[num7] = bb2;
					base.a(array7);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					bb8 bb3 = new bb8();
					bb3.a(CharacterState.Operating);
					bb3.a(atp.a);
					bb3.IsAsync = false;
					bb3.a(new ar7(a.a));
					bb3.b(4);
					array8[num8] = bb3;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx3 = new egx();
					egx3.a("Теперь передай катализатор.");
					array9[num9] = new ace(egx3)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					bb8 bb4 = new bb8();
					bb4.a(CharacterState.OperateShort);
					bb4.a(atp.a);
					bb4.IsAsync = false;
					bb4.a(new ar7(a.c.a));
					bb4.b(1);
					array10[num10] = bb4;
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array11 = new btm[1];
					int num11 = 0;
					bb8 bb5 = new bb8();
					bb5.a(CharacterState.Operating);
					bb5.a(atp.a);
					bb5.IsAsync = false;
					bb5.a(new ar7(a.a));
					bb5.b(6);
					array11[num11] = bb5;
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					egx egx4 = new egx();
					egx4.a("Теперь морфин.");
					array12[num12] = new ace(egx4)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					bb8 bb6 = new bb8();
					bb6.a(CharacterState.OperateShort);
					bb6.a(atp.a);
					bb6.IsAsync = false;
					bb6.a(new ar7(a.c.a));
					bb6.b(1);
					array13[num13] = bb6;
					base.a(array13);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array14 = new btm[1];
					int num14 = 0;
					bb8 bb7 = new bb8();
					bb7.a(CharacterState.Operating);
					bb7.a(atp.a);
					bb7.IsAsync = false;
					bb7.a(new ar7(a.a));
					bb7.b(6);
					array14[num14] = bb7;
					base.a(array14);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array15 = new btm[1];
					int num15 = 0;
					egx egx5 = new egx();
					egx5.a("Протри мне лоб.");
					array15[num15] = new ace(egx5)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array15);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array16 = new btm[1];
					int num16 = 0;
					egx egx6 = new egx();
					egx6.a("Так, так. Давай гиромитрин.");
					array16[num16] = new ace(egx6)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array16);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c.a), null, null, null)
					});
					btm[] array17 = new btm[1];
					int num17 = 0;
					bb8 bb8 = new bb8();
					bb8.a(CharacterState.OperateShort);
					bb8.a(atp.a);
					bb8.IsAsync = false;
					bb8.a(new ar7(a.c.a));
					bb8.b(1);
					array17[num17] = bb8;
					base.a(array17);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array18 = new btm[1];
					int num18 = 0;
					bb8 bb9 = new bb8();
					bb9.a(CharacterState.Operating);
					bb9.a(atp.a);
					bb9.IsAsync = false;
					bb9.a(new ar7(a.a));
					bb9.b(6);
					array18[num18] = bb9;
					base.a(array18);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array19 = new btm[1];
					int num19 = 0;
					egx egx7 = new egx();
					egx7.a("Сок! Да! Я, типа, сделал его! *Мы* его сделали!");
					array19[num19] = new ace(egx7)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array19);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(6.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.d), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D72 RID: 3442
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AF9 RID: 19193 RVA: 0x00203F5C File Offset: 0x0020215C
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x00203F6C File Offset: 0x0020216C
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x04001E10 RID: 7696
		public c5x a;
	}

	// Token: 0x02000D73 RID: 3443
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AFC RID: 19196 RVA: 0x00203F84 File Offset: 0x00202184
		internal bool c(e6d A_0)
		{
			a0l.a(this.a, "global:rc_dude:lab", true);
			a0l.a(this.c.a, "player_help", true);
			return true;
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00203FB0 File Offset: 0x002021B0
		internal bool b(e6d A_0)
		{
			if (this.b != null)
			{
				this.b.ae = new float?((float)1);
			}
			return true;
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00203FD0 File Offset: 0x002021D0
		internal bool a(e6d A_0)
		{
			if (this.b != null)
			{
				this.b.ae = new float?(0f);
			}
			return true;
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x00203FF4 File Offset: 0x002021F4
		internal bool d(e6d A_0)
		{
			this.c.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E11 RID: 7697
		public c5x a;

		// Token: 0x04001E12 RID: 7698
		public c5x b;

		// Token: 0x04001E13 RID: 7699
		public act.b c;
	}
}
