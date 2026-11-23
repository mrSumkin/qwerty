using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000D77 RID: 3447
[e79("Xpbl_Lux_OutsideDudesCave")]
public sealed class ecq : dgy
{
	// Token: 0x06004B10 RID: 19216 RVA: 0x00204E5C File Offset: 0x0020305C
	public ecq()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ecq.a a = new ecq.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				ecq.b b = new ecq.b();
				b.b = a;
				b.a = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), b.b.a.Area).ao() as c5x);
				eyj a_ = Enumerable.FirstOrDefault<eyj>(b.b.a.h.b.aa().StatusEffects.Get<eyj>());
				b.b.a.h.b.aa().StatusEffects.d(a_);
				if (b.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.e), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array = new btm[1];
					int num = 0;
					egx egx = new egx();
					egx.a("Блин, извини, что я опять уронил тебя. Но мы наконец на месте.");
					array[num] = new ace(egx)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(6.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					egx egx2 = new egx();
					egx2.a("Прямо головой же.");
					array2[num2] = new ace(egx2)
					{
						TargetRef = new ar7(b.b.a)
					};
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx3 = new egx();
					egx3.a("Но мы наконец на месте!");
					array3[num3] = new ace(egx3)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx4 = new egx();
					egx4.a("Странно, как от старых воспоминаний становится... так хорошо.");
					array4[num4] = new ace(egx4)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(8.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx5 = new egx();
					egx5.a("Помню, как блевал вот здесь, когда меня покусал здоровый краулер. А-ах...");
					array5[num5] = new ace(egx5)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(6.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx6 = new egx();
					egx6.a("А потом я...");
					array6[num6] = new ace(egx6)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.g), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.f), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx7 = new egx();
					egx7.a("Нет, не здесь! Вон там.");
					array7[num7] = new ace(egx7)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx8 = new egx();
					egx8.a("Да, блин, извини. Иди за мной.");
					array8[num8] = new ace(egx8)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.7))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					s5 s = new s5();
					s.a(new ar7(b.a));
					s.a(new bt4("global:rc_dude:entrance"));
					s.IsAsync = true;
					s.a(true);
					array9[num9] = s;
					base.a(array9);
					btm[] array10 = new btm[1];
					int num10 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(b.b.a));
					s2.a(new bt4("player_entrance"));
					s2.IsAsync = true;
					s2.a(true);
					array10[num10] = s2;
					base.a(array10);
					btm[] array11 = new btm[1];
					int num11 = 0;
					kw kw = new kw();
					kw.a(new bt4("lux-c5", new Vector3(22f, 11f, 0f)));
					kw.IsAsync = true;
					array11[num11] = kw;
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					egx egx9 = new egx();
					egx9.a("Здесь.");
					array12[num12] = new ace(egx9)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					egx egx10 = new egx();
					egx10.a("Что здесь?");
					array13[num13] = new ace(egx10)
					{
						TargetRef = new ar7(b.b.a)
					};
					base.a(array13);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array14 = new btm[1];
					int num14 = 0;
					egx egx11 = new egx();
					egx11.a("Вход. Ты разве не видишь?");
					array14[num14] = new ace(egx11)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array14);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.e), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array15 = new btm[1];
					int num15 = 0;
					egx egx12 = new egx();
					egx12.a("Нет.");
					array15[num15] = new ace(egx12)
					{
						TargetRef = new ar7(b.b.a)
					};
					base.a(array15);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array16 = new btm[1];
					int num16 = 0;
					egx egx13 = new egx();
					egx13.a("Позволь самогону внутри тебя помочь: взгляни на ту стену с вершины своего сознания!");
					array16[num16] = new ace(egx13)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array16);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(8.0))
					});
					btm[] array17 = new btm[1];
					int num17 = 0;
					egx egx14 = new egx();
					egx14.a("Может быть, мне надо ещё выпить...");
					array17[num17] = new ace(egx14)
					{
						TargetRef = new ar7(b.b.a)
					};
					base.a(array17);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array18 = new btm[1];
					int num18 = 0;
					egx egx15 = new egx();
					egx15.a("Да чтоб тебя, блин, посмотри-ка ещё раз и получше.");
					array18[num18] = new ace(egx15)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array18);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D78 RID: 3448
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B12 RID: 19218 RVA: 0x002058EC File Offset: 0x00203AEC
		internal bool e(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x002058FC File Offset: 0x00203AFC
		internal bool d(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x0020590C File Offset: 0x00203B0C
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x0020591C File Offset: 0x00203B1C
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x0020592C File Offset: 0x00203B2C
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("52d06390-bc20-4923-8ed7-ec71354c8639"), this.a.Area).ao() as c5x;
			if (c5x != null && c5x.r.b != null)
			{
				c5x.r.b.a(this.a, false, false);
			}
			return true;
		}

		// Token: 0x04001E1A RID: 7706
		public c5x a;
	}

	// Token: 0x02000D79 RID: 3449
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B18 RID: 19224 RVA: 0x00205998 File Offset: 0x00203B98
		internal bool e(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x002059A8 File Offset: 0x00203BA8
		internal bool d(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Southwest;
			return true;
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x002059B8 File Offset: 0x00203BB8
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x002059C8 File Offset: 0x00203BC8
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x002059D8 File Offset: 0x00203BD8
		internal bool g(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x002059E8 File Offset: 0x00203BE8
		internal bool f(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x002059F8 File Offset: 0x00203BF8
		internal bool a(e6d A_0)
		{
			this.b.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E1B RID: 7707
		public c5x a;

		// Token: 0x04001E1C RID: 7708
		public ecq.a b;
	}
}
