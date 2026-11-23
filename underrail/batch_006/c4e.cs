using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D89 RID: 3465
[e79("Xpbl_DudeAndZonerMa")]
public sealed class c4e : dgy
{
	// Token: 0x06004B47 RID: 19271 RVA: 0x00207B84 File Offset: 0x00205D84
	public c4e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c4e.c c = new c4e.c();
			c.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (c.a != null && c.a.Area != null)
			{
				c4e.a a = new c4e.a();
				a.c = c;
				a.a = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), a.c.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("c90e5cb1-8a3b-4b8d-8694-87cc32ce58f2"), a.c.a.Area).ao() as c5x);
				c5x c5x = new ar7(new Guid("1971c323-c40c-4c39-b926-330abce1436b"), a.c.a.Area).ao() as c5x;
				a.c.a.h.b.aa().StatusEffects.a(new eyj(0, -4), false, false, false);
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
					egx egx = new egx();
					egx.a("Это то самое место.");
					array[num] = new ace(egx)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s = new s5();
					s.a(new ar7(a.a));
					s.a(new bt4("dude_openDoor"));
					s.IsAsync = false;
					s.a(true);
					array2[num2] = s;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx2 = new egx();
					egx2.a("Ну пошли...");
					array3[num3] = new ace(egx2)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.5))
					});
					if (c5x != null)
					{
						c4e.b b = new c4e.b();
						b.a = (c5x.GetAspect<bim>() as cnb);
						if (b.a != null)
						{
							btm[] array4 = new btm[1];
							int num4 = 0;
							bb8 bb = new bb8();
							bb.a(CharacterState.OperateShort);
							bb.a(atp.a);
							bb.IsAsync = false;
							bb.a(new ar7(a.a));
							bb.b(1);
							array4[num4] = bb;
							base.a(array4);
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(b.a), null, null, null)
							});
						}
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.a));
					s2.a(new bt4("global:rc_dude:enter"));
					s2.IsAsync = true;
					s2.a(true);
					array5[num5] = s2;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					kw kw = new kw();
					kw.a(new bt4("xpbl_cc_dh", new Vector3(10f, 5f, 0f)));
					kw.IsAsync = true;
					array6[num6] = kw;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(a.c.a));
					s3.a(new bt4("player_enter"));
					s3.IsAsync = true;
					s3.a(true);
					array7[num7] = s3;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx3 = new egx();
					egx3.a("Что, во имя грязных бочек...?");
					array8[num8] = new ace(egx3)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx4 = new egx();
					egx4.a("П-привет, матушка Чувака! М-м-м-м, ч-чем это так вкусно пахнет?");
					array9[num9] = new ace(egx4)
					{
						TargetRef = new ar7(a.c.a)
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx5 = new egx();
					egx5.a("Что? Блин, она не моя мать!");
					array10[num10] = new ace(egx5)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array11 = new btm[1];
					int num11 = 0;
					egx egx6 = new egx();
					egx6.a("ЭЙ!");
					array11[num11] = new ace(egx6)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D8A RID: 3466
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004B49 RID: 19273 RVA: 0x0020826C File Offset: 0x0020646C
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x04001E36 RID: 7734
		public c5x a;
	}

	// Token: 0x02000D8B RID: 3467
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B4B RID: 19275 RVA: 0x00208284 File Offset: 0x00206484
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x00208294 File Offset: 0x00206494
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.East;
			this.c.a.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x002082B8 File Offset: 0x002064B8
		internal bool a(e6d A_0)
		{
			this.a.t.b.y6()[ddq.bc] = "quest_DudesOtherQuest_cc_startSearching";
			this.c.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E37 RID: 7735
		public c5x a;

		// Token: 0x04001E38 RID: 7736
		public c5x b;

		// Token: 0x04001E39 RID: 7737
		public c4e.c c;
	}

	// Token: 0x02000D8C RID: 3468
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B4F RID: 19279 RVA: 0x00208318 File Offset: 0x00206518
		internal bool a(e6d A_0)
		{
			this.a.d(true);
			return true;
		}

		// Token: 0x04001E3A RID: 7738
		public cnb a;
	}
}
