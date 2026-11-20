using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D81 RID: 3457
[e79("Xpbl_DudeShowsUpperUnderrailHome")]
public sealed class cww : dgy
{
	// Token: 0x06004B30 RID: 19248 RVA: 0x002064D0 File Offset: 0x002046D0
	public cww()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			cww.a a = new cww.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("b45fb78a-ab31-4364-abd2-fce8442dcc9c"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(a.b));
					s.a(new bt4("dude_openDoor"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.2))
					});
					if (a.c != null)
					{
						cww.b b = new cww.b();
						b.a = (a.c.GetAspect<bim>() as cnb);
						if (b.a != null)
						{
							btm[] array2 = new btm[1];
							int num2 = 0;
							bb8 bb = new bb8();
							bb.a(CharacterState.OperateShort);
							bb.a(atp.a);
							bb.IsAsync = false;
							bb.a(new ar7(a.b));
							bb.b(1);
							array2[num2] = bb;
							base.a(array2);
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
					btm[] array3 = new btm[1];
					int num3 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.b));
					s2.a(new bt4("dude_inside"));
					s2.IsAsync = true;
					s2.a(true);
					array3[num3] = s2;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					kw kw = new kw();
					kw.a(new bt4("xpbl_cc_dh", new Vector3(10f, 5f, 0f)));
					kw.IsAsync = true;
					array4[num4] = kw;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(a.a));
					s3.a(new bt4("player_inside"));
					s3.IsAsync = true;
					s3.a(true);
					array5[num5] = s3;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx = new egx();
					egx.a("Блин, я всё вспонил: раньше здесь было так уютно.");
					array6[num6] = new ace(egx)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(6.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx2 = new egx();
					egx2.a("У меня было место, чтобы расслабиться, поработать, поспать в тишине и спокойствии...");
					array7[num7] = new ace(egx2)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx3 = new egx();
					egx3.a("Ну, пока не наползали обсидиановые муравьи.");
					array8[num8] = new ace(egx3)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx4 = new egx();
					egx4.a("Вот мой стол. Там моя мастерская и спальня.");
					array9[num9] = new ace(egx4)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(6.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx5 = new egx();
					egx5.a("Вот мой старый диванчик. Мой холодильник!");
					array10[num10] = new ace(egx5)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array11 = new btm[1];
					int num11 = 0;
					egx egx6 = new egx();
					egx6.a("А вот и мой ко... Разве у меня здесь не было ковра?");
					array11[num11] = new ace(egx6)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array11);
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
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					egx egx7 = new egx();
					egx7.a("Ах, а вот и моя лаборатория! Моя лаборатория!");
					array12[num12] = new ace(egx7)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					egx egx8 = new egx();
					egx8.a("То, что мы ищем, должно быть там!");
					array13[num13] = new ace(egx8)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array13);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array14 = new btm[1];
					int num14 = 0;
					s5 s4 = new s5();
					s4.a(new ar7(a.b));
					s4.a(new bt4("dude_door"));
					s4.IsAsync = true;
					s4.a(true);
					array14[num14] = s4;
					base.a(array14);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array15 = new btm[1];
					int num15 = 0;
					s5 s5 = new s5();
					s5.a(new ar7(a.a));
					s5.a(new bt4("player_labDoorFar"));
					s5.IsAsync = true;
					s5.a(true);
					array15[num15] = s5;
					base.a(array15);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array16 = new btm[1];
					int num16 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.OperateShort);
					bb2.a(atp.a);
					bb2.IsAsync = false;
					bb2.a(new ar7(a.b));
					bb2.b(1);
					array16[num16] = bb2;
					base.a(array16);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.h), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array17 = new btm[1];
					int num17 = 0;
					bb8 bb3 = new bb8();
					bb3.a(CharacterState.OperateShort);
					bb3.a(atp.a);
					bb3.IsAsync = false;
					bb3.a(new ar7(a.b));
					bb3.b(1);
					array17[num17] = bb3;
					base.a(array17);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.g), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array18 = new btm[1];
					int num18 = 0;
					egx egx9 = new egx();
					egx9.a("О, да.");
					array18[num18] = new ace(egx9)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array18);
					btm[] array19 = new btm[1];
					int num19 = 0;
					s5 s6 = new s5();
					s6.a(new ar7(a.b));
					s6.a(new bt4("dude_lockFacingAt"));
					s6.IsAsync = true;
					s6.a(true);
					array19[num19] = s6;
					base.a(array19);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array20 = new btm[1];
					int num20 = 0;
					bb8 bb4 = new bb8();
					bb4.a(CharacterState.OperateShort);
					bb4.a(atp.a);
					bb4.IsAsync = false;
					bb4.a(new ar7(a.b));
					bb4.b(1);
					array20[num20] = bb4;
					base.a(array20);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.f), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.e), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D82 RID: 3458
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B32 RID: 19250 RVA: 0x00206F30 File Offset: 0x00205130
		internal bool d(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00206F40 File Offset: 0x00205140
		internal bool c(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x00206F50 File Offset: 0x00205150
		internal bool b(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00206F60 File Offset: 0x00205160
		internal bool a(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.Northeast;
			return true;
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00206F74 File Offset: 0x00205174
		internal bool h(e6d A_0)
		{
			this.c.c().a(Guid.NewGuid().ToString(), "LockedMech", 1f, c9z.a, false, false);
			return true;
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00206FB4 File Offset: 0x002051B4
		internal bool g(e6d A_0)
		{
			this.c.c().a(Guid.NewGuid().ToString(), "LockedMech", 1f, c9z.a, false, false);
			return true;
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00206FF4 File Offset: 0x002051F4
		internal bool f(e6d A_0)
		{
			this.b.c().a(Guid.NewGuid().ToString(), "HackingFailure", 1f, c9z.a, false, false);
			return true;
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x00207034 File Offset: 0x00205234
		internal bool e(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E27 RID: 7719
		public c5x a;

		// Token: 0x04001E28 RID: 7720
		public c5x b;

		// Token: 0x04001E29 RID: 7721
		public c5x c;
	}

	// Token: 0x02000D83 RID: 3459
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B3B RID: 19259 RVA: 0x0020706C File Offset: 0x0020526C
		internal bool a(e6d A_0)
		{
			this.a.d(true);
			return true;
		}

		// Token: 0x04001E2A RID: 7722
		public cnb a;
	}
}
