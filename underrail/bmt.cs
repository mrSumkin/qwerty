using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000D2B RID: 3371
[e79("Cc_TrippyDrugs4")]
public sealed class bmt : dgy
{
	// Token: 0x06004A62 RID: 19042 RVA: 0x001F7B04 File Offset: 0x001F5D04
	public bmt()
	{
		bmt.b b = new bmt.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			b.b = (b.a.aqu().v().b() as c5x);
			b.c = new ar7(b.b);
			b.d = new ar7();
			b.e = new ar7();
			b.f = new ar7();
			if (b.b != null)
			{
				bmt.a a = new bmt.a();
				a.b = b;
				a.a = new List<Point>();
				a.a.Add(new Point(7, 7));
				a.a.Add(new Point(8, 4));
				a.a.Add(new Point(8, 7));
				a.a.Add(new Point(9, 4));
				a.a.Add(new Point(10, 4));
				a.a.Add(new Point(11, 4));
				a.a.Add(new Point(12, 4));
				a.a.Add(new Point(13, 7));
				a.a.Add(new Point(14, 7));
				a.a.Add(new Point(8, 11));
				a.a.Add(new Point(9, 11));
				a.a.Add(new Point(10, 11));
				a.a.Add(new Point(11, 11));
				a.a.Add(new Point(7, 13));
				a.a.Add(new Point(8, 13));
				a.a.Add(new Point(9, 13));
				a.a.Add(new Point(12, 13));
				a.a.Add(new Point(13, 13));
				a.a.Add(new Point(14, 13));
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Stunned)))
					{
						TargetRef = new ar7(a.b.b)
					}
				});
				base.a(new btm[]
				{
					new am8()
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
					new cmc(null)
				});
				base.a(new btm[]
				{
					new ace(new epw(null))
					{
						TargetRef = new ar7(a.b.b)
					}
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("lu-c5", "dodge1"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("dodge4"));
				kw.a(false);
				kw.IsAsync = true;
				array2[num2] = kw;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array3[num3] = dva;
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				s5 s = new s5();
				s.a(a.b.c);
				s.a(new bt4("dodge2"));
				s.IsAsync = true;
				s.a(false);
				array4[num4] = s;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				egx egx = new egx();
				egx.a("Меня...");
				array5[num5] = new ace(egx)
				{
					TargetRef = a.b.c
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx2 = new egx();
					egx2.a("Какого хрена она делает?");
					array6[num6] = new ace(egx2)
					{
						TargetRef = a.b.d
					};
					base.a(array6);
				}
				else
				{
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx3 = new egx();
					egx3.a("Какого хрена он делает?");
					array7[num7] = new ace(egx3)
					{
						TargetRef = a.b.d
					};
					base.a(array7);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				s5 s2 = new s5();
				s2.a(a.b.c);
				s2.a(new bt4("dodge3"));
				s2.IsAsync = true;
				s2.a(false);
				array8[num8] = s2;
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				egx egx4 = new egx();
				egx4.a("...не...");
				array9[num9] = new ace(egx4)
				{
					TargetRef = a.b.c
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				if (a.b.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx5 = new egx();
					egx5.a("Она или под веществами или рехнулась.");
					array10[num10] = new ace(egx5)
					{
						TargetRef = a.b.e
					};
					base.a(array10);
				}
				else
				{
					btm[] array11 = new btm[1];
					int num11 = 0;
					egx egx6 = new egx();
					egx6.a("Он или под веществами или рехнулся.");
					array11[num11] = new ace(egx6)
					{
						TargetRef = a.b.e
					};
					base.a(array11);
				}
				btm[] array12 = new btm[1];
				int num12 = 0;
				s5 s3 = new s5();
				s3.a(a.b.c);
				s3.a(new bt4("dodge4"));
				s3.IsAsync = true;
				s3.a(false);
				array12[num12] = s3;
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				egx egx7 = new egx();
				egx7.a("...сразить!");
				array13[num13] = new ace(egx7)
				{
					TargetRef = a.b.c
				};
				base.a(array13);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array14 = new btm[1];
				int num14 = 0;
				s5 s4 = new s5();
				s4.a(a.b.c);
				s4.a(new bt4("dodge5"));
				s4.IsAsync = true;
				s4.a(false);
				array14[num14] = s4;
				base.a(array14);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array15 = new btm[1];
					int num15 = 0;
					egx egx8 = new egx();
					egx8.a("Поспорим, как скоро её задоминируют?");
					array15[num15] = new ace(egx8)
					{
						TargetRef = a.b.e
					};
					base.a(array15);
				}
				else
				{
					btm[] array16 = new btm[1];
					int num16 = 0;
					egx egx9 = new egx();
					egx9.a("Поспорим, как скоро его задоминируют?");
					array16[num16] = new ace(egx9)
					{
						TargetRef = a.b.e
					};
					base.a(array16);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array17 = new btm[1];
				int num17 = 0;
				s5 s5 = new s5();
				s5.a(a.b.c);
				s5.a(new bt4("dodge6"));
				s5.IsAsync = true;
				s5.a(false);
				array17[num17] = s5;
				base.a(array17);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array18 = new btm[1];
				int num18 = 0;
				egx egx10 = new egx();
				egx10.a("Пиу-пиу!");
				array18[num18] = new ace(egx10)
				{
					TargetRef = a.b.c
				};
				base.a(array18);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array19 = new btm[1];
				int num19 = 0;
				egx egx11 = new egx();
				egx11.a("Ещё секунд десять \u0097 максимум.");
				array19[num19] = new ace(egx11)
				{
					TargetRef = a.b.f
				};
				base.a(array19);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array20 = new btm[1];
				int num20 = 0;
				s5 s6 = new s5();
				s6.a(a.b.c);
				s6.a(new bt4("dodge2"));
				s6.IsAsync = true;
				s6.a(false);
				array20[num20] = s6;
				base.a(array20);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array21 = new btm[1];
				int num21 = 0;
				s5 s7 = new s5();
				s7.a(a.b.c);
				s7.a(new bt4("dodge3"));
				s7.IsAsync = true;
				s7.a(false);
				array21[num21] = s7;
				base.a(array21);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array22 = new btm[1];
				int num22 = 0;
				egx egx12 = new egx();
				egx12.a("Не попадёшь...");
				array22[num22] = new ace(egx12)
				{
					TargetRef = a.b.c
				};
				base.a(array22);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array23 = new btm[1];
					int num23 = 0;
					egx egx13 = new egx();
					egx13.a("Ну ни хрена себе, как ей везёт!");
					array23[num23] = new ace(egx13)
					{
						TargetRef = a.b.d
					};
					base.a(array23);
				}
				else
				{
					btm[] array24 = new btm[1];
					int num24 = 0;
					egx egx14 = new egx();
					egx14.a("Ну ни хрена себе, как ему везёт!");
					array24[num24] = new ace(egx14)
					{
						TargetRef = a.b.d
					};
					base.a(array24);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array25 = new btm[1];
				int num25 = 0;
				s5 s8 = new s5();
				s8.a(a.b.c);
				s8.a(new bt4("dodge4"));
				s8.IsAsync = true;
				s8.a(false);
				array25[num25] = s8;
				base.a(array25);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array26 = new btm[1];
				int num26 = 0;
				s5 s9 = new s5();
				s9.a(a.b.c);
				s9.a(new bt4("dodge5"));
				s9.IsAsync = true;
				s9.a(false);
				array26[num26] = s9;
				base.a(array26);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array27 = new btm[1];
				int num27 = 0;
				egx egx15 = new egx();
				egx15.a("У меня сюжетная броня...");
				array27[num27] = new ace(egx15)
				{
					TargetRef = a.b.c
				};
				base.a(array27);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array28 = new btm[1];
					int num28 = 0;
					egx egx16 = new egx();
					egx16.a("Смотри как носится!");
					array28[num28] = new ace(egx16)
					{
						TargetRef = a.b.e
					};
					base.a(array28);
				}
				else
				{
					btm[] array29 = new btm[1];
					int num29 = 0;
					egx egx17 = new egx();
					egx17.a("Смотри как носится!");
					array29[num29] = new ace(egx17)
					{
						TargetRef = a.b.e
					};
					base.a(array29);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array30 = new btm[1];
				int num30 = 0;
				s5 s10 = new s5();
				s10.a(a.b.c);
				s10.a(new bt4("dodge6"));
				s10.IsAsync = true;
				s10.a(false);
				array30[num30] = s10;
				base.a(array30);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array31 = new btm[1];
				int num31 = 0;
				egx egx18 = new egx();
				egx18.a("Я избранный!");
				array31[num31] = new ace(egx18)
				{
					TargetRef = a.b.c
				};
				base.a(array31);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array32 = new btm[1];
				int num32 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array32[num32] = dky2;
				base.a(array32);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("cc_s1", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array33 = new btm[1];
				int num33 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.b.a));
				array33[num33] = dva2;
				base.a(array33);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array34 = new btm[1];
				int num34 = 0;
				egx egx19 = new egx();
				egx19.a("Ой! Кажется, ухо обожгло.");
				array34[num34] = new ace(egx19)
				{
					TargetRef = a.b.c
				};
				base.a(array34);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D2C RID: 3372
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A64 RID: 19044 RVA: 0x001F8A70 File Offset: 0x001F6C70
		internal bool a(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			return true;
		}

		// Token: 0x04001DB0 RID: 7600
		public cnk a;

		// Token: 0x04001DB1 RID: 7601
		public c5x b;

		// Token: 0x04001DB2 RID: 7602
		public ar7 c;

		// Token: 0x04001DB3 RID: 7603
		public ar7 d;

		// Token: 0x04001DB4 RID: 7604
		public ar7 e;

		// Token: 0x04001DB5 RID: 7605
		public ar7 f;
	}

	// Token: 0x02000D2D RID: 3373
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A66 RID: 19046 RVA: 0x001F8ABC File Offset: 0x001F6CBC
		internal bool a(e6d A_0)
		{
			this.b.b = (this.b.a.aqu().v().b() as c5x);
			this.b.c.a(this.b.b);
			this.b.d.a(new ar7(new Guid("2cdad8ad-434f-41ae-9d33-ab892cf25a72"), this.b.b.Area).ao());
			this.b.e.a(new ar7(new Guid("d89ad461-9fe4-4c4b-95e8-f0aac43a54cd"), this.b.b.Area).ao());
			this.b.f.a(new ar7(new Guid("cdb44d0b-1fff-4d39-9aab-9aea624892bf"), this.b.b.Area).ao());
			dtb dtb = new dtb();
			for (int i = 0; i < 70; i++)
			{
				Point point = this.a[cuo.a.Next(this.a.Count)];
				string a_;
				string a_2;
				if (cuo.a.NextDouble() < 0.3)
				{
					a_ = "PlasmaShoot";
					a_2 = "Plasma";
				}
				else
				{
					a_ = "LaserShoot";
					a_2 = "RedLaser";
				}
				List<auv> list = dtb.ad();
				bfq bfq = new bfq(a_);
				bfq.a(0.6f);
				a4s a4s = new a4s(bfq, null, null, null);
				a4s.b(this.b.c);
				list.Add(a4s);
				dtb.ad().Add(new a6c(new Vector3((float)point.X, 0f, 0.5f), new Vector3((float)point.X, (float)point.Y, 0.5f), this.b.b.Area, a_2, null));
				dtb.ad().Add(new bm3(300 + cuo.a.Next(200)));
			}
			this.b.b.i.b.b(dtb, atp.a);
			return true;
		}

		// Token: 0x04001DB6 RID: 7606
		public List<Point> a;

		// Token: 0x04001DB7 RID: 7607
		public bmt.b b;
	}
}
