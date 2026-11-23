using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000EF5 RID: 3829
[e79("Xphw_TripToNorthUnderrail2")]
public sealed class a3v : dgy
{
	// Token: 0x06004E60 RID: 20064 RVA: 0x0022DC04 File Offset: 0x0022BE04
	public a3v()
	{
		a3v.a a = new a3v.a();
		base..ctor();
		a.a = this;
		a.b = bpo.GetServiceOrThrow<cnk>();
		if (a.b != null && a.b.aqu() != null)
		{
			a.c = a.b.aqw().GetAddon<d60>();
			a.d = (a.b.aqu().v().b() as c5x);
			if (a.d != null && a.c != null)
			{
				a3v.b b = new a3v.b();
				b.g = a;
				b.g.d.i.b.a(true, false);
				b.c = (new ar7(new Guid("8120ceb3-c07c-4992-aaaf-d2ded349c170"), b.g.d.Area).ao() as c5x);
				b.f = (new ar7(new Guid("c31eeaf5-65f9-4863-9dc2-8e35578ff9db"), b.g.d.Area).ao() as c5x);
				b.d = (new ar7(new Guid("859f2bdc-6252-4749-8e22-b66136d94fc1"), b.g.d.Area).ao() as c5x);
				b.b = (new ar7(new Guid("1cb39d22-9ae4-4c34-a52b-579155b4756b"), b.g.d.Area).ao() as c5x);
				b.e = (new ar7(new Guid("3cc21abd-8fb0-426e-8fbc-a32d36bbd5e8"), b.g.d.Area).ao() as c5x);
				c5x c5x = new ar7(new Guid("6d9f5c63-6049-4caf-90da-b2fc6051e0ce"), b.g.d.Area).ao() as c5x;
				b.a = (new ar7(new Guid("14ba038d-20f9-4ae9-b420-170391b23aa0"), b.g.d.Area).ao() as c5x);
				float num = 0.1f;
				float num2 = 0.07f;
				float a_ = 0.85f;
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num3 = 0;
				kw kw = new kw();
				kw.a(new bt4("xphw_exobase_tun_railcar", new Vector3(2f, 7f, 0f)));
				kw.IsAsync = true;
				kw.a(false);
				kw.a(new float?((float)1));
				array[num3] = kw;
				base.a(array);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.i), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array2 = new btm[1];
				int num4 = 0;
				egx egx = new egx();
				egx.a("Хр-р-р...");
				array2[num4] = new ace(egx)
				{
					TargetRef = new ar7(b.e)
				};
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array3 = new btm[1];
				int num5 = 0;
				egx egx2 = new egx();
				egx2.a("Сколько ещё осталось до Второй трансрегионализации?");
				array3[num5] = new ace(egx2)
				{
					TargetRef = new ar7(b.c)
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(6.0))
				});
				btm[] array4 = new btm[1];
				int num6 = 0;
				egx egx3 = new egx();
				egx3.a("::Он качает головой.:: Уф... Это не показывает сенсор.");
				array4[num6] = new ace(egx3)
				{
					TargetRef = new ar7(b.d)
				};
				base.a(array4);
				btm[] array5 = new btm[1];
				int num7 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Operating);
				bb.a(atp.a);
				bb.IsAsync = true;
				bb.a(new ar7(b.d));
				bb.b(4);
				array5[num7] = bb;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.5))
				});
				btm[] array6 = new btm[1];
				int num8 = 0;
				egx egx4 = new egx();
				egx4.a("Отлично. Теперь мы заблудились.");
				array6[num8] = new ace(egx4)
				{
					TargetRef = new ar7(b.f)
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array7 = new btm[1];
				int num9 = 0;
				egx egx5 = new egx();
				egx5.a("Эй, заткнись! Я пытаюсь сосредоточиться.");
				array7[num9] = new ace(egx5)
				{
					TargetRef = new ar7(b.d)
				};
				base.a(array7);
				btm[] array8 = new btm[1];
				int num10 = 0;
				bb8 bb2 = new bb8();
				bb2.a(CharacterState.Operating);
				bb2.a(atp.a);
				bb2.IsAsync = true;
				bb2.a(new ar7(b.d));
				bb2.b(3);
				array8[num10] = bb2;
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.h), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array9 = new btm[1];
				int num11 = 0;
				egx egx6 = new egx();
				egx6.a("Будете ли вы уже спать?");
				array9[num11] = new ace(egx6)
				{
					TargetRef = new ar7(b.e)
				};
				base.a(array9);
				btm[] array10 = new btm[1];
				int num12 = 0;
				s5 s = new s5();
				s.a(new ar7(b.e));
				s.a(new bt4("spanner_move"));
				s.IsAsync = true;
				s.a(true);
				array10[num12] = s;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array11 = new btm[1];
				int num13 = 0;
				egx egx7 = new egx();
				egx7.a("Блин. Мы можем развернуться или что?");
				array11[num13] = new ace(egx7)
				{
					TargetRef = new ar7(b.f)
				};
				base.a(array11);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				btm[] array12 = new btm[1];
				int num14 = 0;
				egx egx8 = new egx();
				egx8.a("Развернуться?..");
				array12[num14] = new ace(egx8)
				{
					TargetRef = new ar7(b.d)
				};
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array13 = new btm[1];
				int num15 = 0;
				egx egx9 = new egx();
				egx9.a("Вилкос! Свет! Там, в конце туннеля.");
				array13[num15] = new ace(egx9)
				{
					TargetRef = new ar7(b.c)
				};
				base.a(array13);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(7.0))
				});
				btm[] array14 = new btm[1];
				int num16 = 0;
				egx egx10 = new egx();
				egx10.a("Что за...");
				array14[num16] = new ace(egx10)
				{
					TargetRef = new ar7(b.c)
				};
				base.a(array14);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array15 = new btm[1];
				int num17 = 0;
				bfq bfq = new bfq();
				bfq.c("TntExplode");
				bfq.a(1f);
				array15[num17] = new ace(bfq)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array15);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.g), null, null, null)
				});
				btm[] array16 = new btm[1];
				int num18 = 0;
				s5 s2 = new s5();
				s2.a(new ar7(b.b));
				s2.a(new bt4("gunslinger_move"));
				s2.IsAsync = true;
				s2.a(true);
				array16[num18] = s2;
				base.a(array16);
				btm[] array17 = new btm[1];
				int num19 = 0;
				eb7 eb = new eb7();
				eb.a(new Guid?(c5x.qe()));
				eb.a(false);
				array17[num19] = new ace(eb)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array17);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.2))
				});
				btm[] array18 = new btm[1];
				int num20 = 0;
				bfq bfq2 = new bfq();
				bfq2.c("TrainBreak");
				bfq2.a(1f);
				array18[num20] = new ace(bfq2)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array18);
				btm[] array19 = new btm[1];
				int num21 = 0;
				eb7 eb2 = new eb7();
				eb2.a(new Guid?(c5x.qe()));
				eb2.a(true);
				array19[num21] = new ace(eb2)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array19);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array20 = new btm[1];
				int num22 = 0;
				eb7 eb3 = new eb7();
				eb3.a(new Guid?(c5x.qe()));
				eb3.a(false);
				array20[num22] = new ace(eb3)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array20);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.2))
				});
				btm[] array21 = new btm[1];
				int num23 = 0;
				eb7 eb4 = new eb7();
				eb4.a(new Guid?(c5x.qe()));
				eb4.a(true);
				array21[num23] = new ace(eb4)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array21);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array22 = new btm[1];
				int num24 = 0;
				eb7 eb5 = new eb7();
				eb5.a(new Guid?(c5x.qe()));
				eb5.a(false);
				array22[num24] = new ace(eb5)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array22);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.f), null, null, null)
				});
				btm[] array23 = new btm[1];
				int num25 = 0;
				bb8 bb3 = new bb8();
				bb3.a(CharacterState.Stunned);
				bb3.a(atp.a);
				bb3.IsAsync = true;
				bb3.a(new ar7(b.b));
				bb3.b(99);
				array23[num25] = bb3;
				base.a(array23);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array24 = new btm[1];
				int num26 = 0;
				egx egx11 = new egx();
				egx11.a("Бак!");
				array24[num26] = new ace(egx11)
				{
					TargetRef = new ar7(b.d)
				};
				base.a(array24);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.k), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.g.e), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array25 = new btm[1];
				int num27 = 0;
				bfq bfq3 = new bfq();
				bfq3.c("pistolShot");
				bfq3.a(a_);
				array25[num27] = new ace(bfq3)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array25);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array26 = new btm[1];
				int num28 = 0;
				bfq bfq4 = new bfq();
				bfq4.c("BulletHitMetal");
				array26[num28] = new ace(bfq4)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array26);
				btm[] array27 = new btm[1];
				int num29 = 0;
				bfq bfq5 = new bfq();
				bfq5.c("pistolShot");
				bfq5.a(a_);
				array27[num29] = new ace(bfq5)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array27);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array28 = new btm[1];
				int num30 = 0;
				s5 s3 = new s5();
				s3.a(new ar7(b.f));
				s3.a(new bt4("torrence_move"));
				s3.IsAsync = true;
				s3.a(true);
				array28[num30] = s3;
				base.a(array28);
				btm[] array29 = new btm[1];
				int num31 = 0;
				bfq bfq6 = new bfq();
				bfq6.c("pistolShot");
				bfq6.a(a_);
				array29[num31] = new ace(bfq6)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array29);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.j), null, null, null)
				});
				btm[] array30 = new btm[1];
				int num32 = 0;
				bfq bfq7 = new bfq();
				bfq7.c("CrowbarHitMetal");
				array30[num32] = new ace(bfq7)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array30);
				btm[] array31 = new btm[1];
				int num33 = 0;
				bfq bfq8 = new bfq();
				bfq8.c("pistolShot");
				bfq8.a(a_);
				array31[num33] = new ace(bfq8)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array31);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array32 = new btm[1];
				int num34 = 0;
				bb8 bb4 = new bb8();
				bb4.a(CharacterState.ChannelPsi);
				bb4.a(atp.a);
				bb4.IsAsync = true;
				bb4.a(new ar7(b.e));
				bb4.b(4);
				array32[num34] = bb4;
				base.a(array32);
				btm[] array33 = new btm[1];
				int num35 = 0;
				bfq bfq9 = new bfq();
				bfq9.c("pistolShot");
				bfq9.a(a_);
				array33[num35] = new ace(bfq9)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array33);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.g.d), null, null, null)
				});
				btm[] array34 = new btm[1];
				int num36 = 0;
				bfq bfq10 = new bfq();
				bfq10.c("pistolShot");
				bfq10.a(a_);
				array34[num36] = new ace(bfq10)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array34);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array35 = new btm[1];
				int num37 = 0;
				bfq bfq11 = new bfq();
				bfq11.c("BulletHitMetal");
				array35[num37] = new ace(bfq11)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array35);
				btm[] array36 = new btm[1];
				int num38 = 0;
				bfq bfq12 = new bfq();
				bfq12.c("pistolShot");
				bfq12.a(a_);
				array36[num38] = new ace(bfq12)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array36);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array37 = new btm[1];
				int num39 = 0;
				bfq bfq13 = new bfq();
				bfq13.c("pistolShot");
				bfq13.a(a_);
				array37[num39] = new ace(bfq13)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array37);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array38 = new btm[1];
				int num40 = 0;
				bfq bfq14 = new bfq();
				bfq14.c("pistolShot");
				bfq14.a(a_);
				array38[num40] = new ace(bfq14)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array38);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.c), null, null, null)
				});
				btm[] array39 = new btm[1];
				int num41 = 0;
				bfq bfq15 = new bfq();
				bfq15.c("pistolShot");
				bfq15.a(a_);
				array39[num41] = new ace(bfq15)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array39);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array40 = new btm[1];
				int num42 = 0;
				bfq bfq16 = new bfq();
				bfq16.c("pistolShot");
				bfq16.a(a_);
				array40[num42] = new ace(bfq16)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array40);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num))
				});
				btm[] array41 = new btm[1];
				int num43 = 0;
				bfq bfq17 = new bfq();
				bfq17.c("pistolShot");
				bfq17.a(a_);
				array41[num43] = new ace(bfq17)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array41);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array42 = new btm[1];
				int num44 = 0;
				egx egx12 = new egx();
				egx12.a("Жрите свинец!");
				array42[num44] = new ace(egx12)
				{
					TargetRef = new ar7(b.f)
				};
				base.a(array42);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array43 = new btm[1];
				int num45 = 0;
				bb8 bb5 = new bb8();
				bb5.a(CharacterState.RaiseWeapon);
				bb5.a(cux.k);
				bb5.a(atp.a);
				bb5.IsAsync = false;
				bb5.a(new ar7(b.f));
				bb5.b(1);
				array43[num45] = bb5;
				base.a(array43);
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Attack1)))
					{
						TargetRef = new ar7(b.f)
					}
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(0)))
					{
						TargetRef = new ar7(b.f)
					}
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array44 = new btm[1];
				int num46 = 0;
				bfq bfq18 = new bfq();
				bfq18.c("Minigun_motor");
				array44[num46] = new ace(bfq18)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array44);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.01))
				});
				btm[] array45 = new btm[1];
				int num47 = 0;
				bfq bfq19 = new bfq();
				bfq19.c("MachineGun_first");
				bfq19.a(a_);
				array45[num47] = new ace(bfq19)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array45);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array46 = new btm[1];
				int num48 = 0;
				bfq bfq20 = new bfq();
				bfq20.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq20.a(a_);
				array46[num48] = new ace(bfq20)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array46);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array47 = new btm[1];
				int num49 = 0;
				bfq bfq21 = new bfq();
				bfq21.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq21.a(a_);
				array47[num49] = new ace(bfq21)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array47);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array48 = new btm[1];
				int num50 = 0;
				bfq bfq22 = new bfq();
				bfq22.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq22.a(a_);
				array48[num50] = new ace(bfq22)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array48);
				btm[] array49 = new btm[1];
				int num51 = 0;
				bfq bfq23 = new bfq();
				bfq23.c("CrowbarHitMetal");
				array49[num51] = new ace(bfq23)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array49);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.g.f), null, null, null)
				});
				btm[] array50 = new btm[1];
				int num52 = 0;
				bfq bfq24 = new bfq();
				bfq24.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq24.a(a_);
				array50[num52] = new ace(bfq24)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array50);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array51 = new btm[1];
				int num53 = 0;
				bfq bfq25 = new bfq();
				bfq25.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq25.a(a_);
				array51[num53] = new ace(bfq25)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array51);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array52 = new btm[1];
				int num54 = 0;
				bfq bfq26 = new bfq();
				bfq26.c("BulletHitMetal");
				array52[num54] = new ace(bfq26)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array52);
				btm[] array53 = new btm[1];
				int num55 = 0;
				bfq bfq27 = new bfq();
				bfq27.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq27.a(a_);
				array53[num55] = new ace(bfq27)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array53);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array54 = new btm[1];
				int num56 = 0;
				bfq bfq28 = new bfq();
				bfq28.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq28.a(a_);
				array54[num56] = new ace(bfq28)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array54);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array55 = new btm[1];
				int num57 = 0;
				bfq bfq29 = new bfq();
				bfq29.c("CrowbarHitMetal");
				array55[num57] = new ace(bfq29)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array55);
				btm[] array56 = new btm[1];
				int num58 = 0;
				bfq bfq30 = new bfq();
				bfq30.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq30.a(a_);
				array56[num58] = new ace(bfq30)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array56);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array57 = new btm[1];
				int num59 = 0;
				bfq bfq31 = new bfq();
				bfq31.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq31.a(a_);
				array57[num59] = new ace(bfq31)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array57);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.d), null, null, null)
				});
				btm[] array58 = new btm[1];
				int num60 = 0;
				bfq bfq32 = new bfq();
				bfq32.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq32.a(a_);
				array58[num60] = new ace(bfq32)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array58);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array59 = new btm[1];
				int num61 = 0;
				bfq bfq33 = new bfq();
				bfq33.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq33.a(a_);
				array59[num61] = new ace(bfq33)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array59);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array60 = new btm[1];
				int num62 = 0;
				bfq bfq34 = new bfq();
				bfq34.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq34.a(a_);
				array60[num62] = new ace(bfq34)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array60);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array61 = new btm[1];
				int num63 = 0;
				bfq bfq35 = new bfq();
				bfq35.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq35.a(a_);
				array61[num63] = new ace(bfq35)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array61);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array62 = new btm[1];
				int num64 = 0;
				bfq bfq36 = new bfq();
				bfq36.c("CrowbarHitMetal");
				array62[num64] = new ace(bfq36)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array62);
				btm[] array63 = new btm[1];
				int num65 = 0;
				bfq bfq37 = new bfq();
				bfq37.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq37.a(a_);
				array63[num65] = new ace(bfq37)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array63);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.g.b), null, null, null)
				});
				btm[] array64 = new btm[1];
				int num66 = 0;
				bfq bfq38 = new bfq();
				bfq38.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq38.a(a_);
				array64[num66] = new ace(bfq38)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array64);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array65 = new btm[1];
				int num67 = 0;
				bfq bfq39 = new bfq();
				bfq39.c("BulletHitMetal");
				array65[num67] = new ace(bfq39)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array65);
				btm[] array66 = new btm[1];
				int num68 = 0;
				bfq bfq40 = new bfq();
				bfq40.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq40.a(a_);
				array66[num68] = new ace(bfq40)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array66);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array67 = new btm[1];
				int num69 = 0;
				bfq bfq41 = new bfq();
				bfq41.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq41.a(a_);
				array67[num69] = new ace(bfq41)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array67);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.g.a), null, null, null)
				});
				btm[] array68 = new btm[1];
				int num70 = 0;
				bfq bfq42 = new bfq();
				bfq42.c("PlasticBoxOpen");
				array68[num70] = new ace(bfq42)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array68);
				btm[] array69 = new btm[1];
				int num71 = 0;
				bfq bfq43 = new bfq();
				bfq43.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq43.a(a_);
				array69[num71] = new ace(bfq43)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array69);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array70 = new btm[1];
				int num72 = 0;
				bfq bfq44 = new bfq();
				bfq44.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq44.a(a_);
				array70[num72] = new ace(bfq44)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array70);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array71 = new btm[1];
				int num73 = 0;
				bfq bfq45 = new bfq();
				bfq45.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq45.a(a_);
				array71[num73] = new ace(bfq45)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array71);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.g.c), null, null, null)
				});
				btm[] array72 = new btm[1];
				int num74 = 0;
				bfq bfq46 = new bfq();
				bfq46.c("MachineGun_" + cuo.a.Next(1, 9).ToString());
				bfq46.a(a_);
				array72[num74] = new ace(bfq46)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array72);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds((double)num2))
				});
				btm[] array73 = new btm[1];
				int num75 = 0;
				bfq bfq47 = new bfq();
				bfq47.c("MachineGun_tail");
				bfq47.a(a_);
				array73[num75] = new ace(bfq47)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array73);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array74 = new btm[1];
				int num76 = 0;
				s5 s4 = new s5();
				s4.a(new ar7(b.g.d));
				s4.a(new bt4("railcar_exit"));
				s4.IsAsync = true;
				s4.a(true);
				array74[num76] = s4;
				base.a(array74);
				btm[] array75 = new btm[1];
				int num77 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array75[num77] = dky;
				base.a(array75);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array76 = new btm[1];
				int num78 = 0;
				bfq bfq48 = new bfq();
				bfq48.c("LowerMetalShipRamp");
				array76[num78] = new ace(bfq48)
				{
					TargetRef = new ar7(b.g.d)
				};
				base.a(array76);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.e), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array77 = new btm[1];
				int num79 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array77[num79] = c8s;
				base.a(array77);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
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

	// Token: 0x06004E61 RID: 20065 RVA: 0x0022FD94 File Offset: 0x0022DF94
	private void a(ak1 A_0)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Zone.n("xphw_exobase_tun");
			if (aud != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (!string.IsNullOrEmpty(c5x.y8()) && c5x.y8().Contains("- тело"))
					{
						a0l.a(c5x, aud, new Vector3(c5x.Location.X + 16f, c5x.Location.Y + 17f, c5x.Location.Z), null, true);
					}
					else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
					{
						c5x.o.b.f = 0.7f;
						c5x.o.b.d = new float?(0.6f);
						a0l.a(c5x, aud, new Vector3(c5x.Location.X + 16f, c5x.Location.Y + 17f, c5x.Location.Z), null, true);
					}
				}
			}
		}
	}

	// Token: 0x02000EF6 RID: 3830
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E63 RID: 20067 RVA: 0x0022FF34 File Offset: 0x0022E134
		internal bool e(e6d A_0)
		{
			foreach (e36 e in Enumerable.ToList<e36>(this.d.Zone.ActionManager.g8()))
			{
				if (e.a is dtb && e.a.Name == "tracks")
				{
					(e.a as dtb).j();
				}
			}
			return true;
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x0022FFD8 File Offset: 0x0022E1D8
		internal bool d(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"window4"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.X = 2;
			}
			return true;
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x00230038 File Offset: 0x0022E238
		internal bool f(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"railcarWall1"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.Y = 2;
			}
			return true;
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x00230098 File Offset: 0x0022E298
		internal bool b(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"railcarWall3"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.Y = 3;
			}
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"window6"
			})) as c5x;
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.b.X = 2;
			}
			c5x c5x3 = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"pot"
			})) as c5x;
			if (c5x3 != null)
			{
				c5x3.an();
			}
			return true;
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x00230178 File Offset: 0x0022E378
		internal bool a(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"boxes"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.X = 6;
			}
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"papers"
			})) as c5x;
			if (c5x2 != null)
			{
				c5x2.ae = null;
			}
			return true;
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x0023020C File Offset: 0x0022E40C
		internal bool c(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"railcarWall4"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.Y = 2;
			}
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
			{
				"window8"
			})) as c5x;
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.b.X = 2;
			}
			return true;
		}

		// Token: 0x04001FFA RID: 8186
		public a3v a;

		// Token: 0x04001FFB RID: 8187
		public cnk b;

		// Token: 0x04001FFC RID: 8188
		public d60 c;

		// Token: 0x04001FFD RID: 8189
		public c5x d;
	}

	// Token: 0x02000EF7 RID: 3831
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004E6A RID: 20074 RVA: 0x002302C8 File Offset: 0x0022E4C8
		internal bool i(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "xphw_exobase_tun_l" + 2.ToString()) + ".uzl");
			this.g.b.aqw().a(a_, 1, null);
			ld.a(this.g.b.aqw(), "railcar_itemTransfer", false);
			foreach (b0b b0b in this.g.c.ab4(new string[]
			{
				"tracks"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Area.y8().Equals("xphw_exobase_tun_railcar"))
				{
					bpu bpu = new bpu(c5x);
					bpu.a(1f);
					bpu.b(1f);
					c5x.SetAspect<bpu>(bpu);
					mj mj = new mj(c5x, bpu);
					c5x.SetAspect<mj>(mj);
					dtb dtb = new dtb("tracks");
					dtb.ad().Add(new bpr(mj, new Vector3(c5x.Location.X, c5x.Location.Y + 1f, c5x.Location.Z)));
					dtb.ad().Add(new a8v(c5x, new Vector3(c5x.Location.X, c5x.Location.Y, c5x.Location.Z)));
					this.g.b.aqw().ActionManager.g9(dtb, atp.b);
				}
			}
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			if (this.a != null)
			{
				this.a.v.b.a("railcar", "TrainInteriorLoop", 0.9f, c9z.b, true, false);
			}
			dvn dvn = new dvn(this.g.b.aqw().y8(), "xphw_DarkTerritory");
			dvn.a(new float?(0f));
			dvn.ym(null, null, null);
			return true;
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x0023051C File Offset: 0x0022E71C
		internal bool h(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x0023052C File Offset: 0x0022E72C
		internal bool g(e6d A_0)
		{
			dm5 dm = new dm5();
			dm.a(null);
			dm.d("EMP");
			dm.a(0.0);
			dm.a(new List<a1q>());
			dm.b(100);
			dm.c("EmpBlast");
			dm.b("EmpBlast");
			dm.a(5);
			dm.ym(null, this.c, null);
			bpo.GetService<ps>().ane(500, null, null, null, null, null);
			boj.a(this.c, "Electricity", 100, 300.0, true, true, null, null, null, null, false);
			this.c.c().a(Guid.NewGuid().ToString(), "Electroshock", 0.5f, c9z.a, false, false);
			a3f a3f = this.c.GetAspect<a3f>();
			if (a3f == null)
			{
				a3f = new a3f(this.c);
				this.c.SetAspect<a3f>(a3f);
			}
			a3f.a()["BloodlessDeath"] = true;
			this.c.h.b.a(null, false);
			return true;
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x002306AC File Offset: 0x0022E8AC
		internal bool f(e6d A_0)
		{
			if (this.g.c != null)
			{
				foreach (b0b b0b in this.g.c.ab4(new string[]
				{
					"wheels"
				}))
				{
					c5x c5x = (c5x)b0b;
					etz etz = c5x.GetAspect<cd0>() as etz;
					if (etz != null)
					{
						cd0 cd = new cd0(c5x);
						cd.b = etz.a(true, null);
						cd.a = etz.a;
						c5x.RemoveAspect<etz>();
						c5x.SetAspect<cd0>(cd);
					}
				}
			}
			if (this.a != null)
			{
				this.a.v.b.a("railcar", true);
			}
			boj.a(this.b, "Electricity", 100, 300.0, true, true, null, null, null, null, false);
			this.b.c().a(Guid.NewGuid().ToString(), "Electroshock", 0.5f, c9z.a, false, false);
			List<coh> list = new List<coh>();
			list.AddRange(this.b.h.b.aa().Gear.i());
			list.AddRange(this.b.h.b.aa().Bag.z2());
			foreach (coh coh in list)
			{
				coh.Battery = 0.0;
			}
			return true;
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x002308B0 File Offset: 0x0022EAB0
		internal bool k(e6d A_0)
		{
			this.d.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x002308C0 File Offset: 0x0022EAC0
		internal bool j(e6d A_0)
		{
			this.g.d.VisualDirection = HorizontalDirection.Northwest;
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
			{
				"window1"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.X = 1;
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
				{
					"glass1"
				})) as c5x;
				if (c5x2 != null)
				{
					c5x2.ae = null;
				}
			}
			c5x c5x3 = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
			{
				"window2"
			})) as c5x;
			if (c5x3 != null && c5x3.o.b != null)
			{
				c5x3.o.b.b.X = 2;
			}
			this.g.d.c().a("VialBreak");
			boj.a(this.d, "BloodImpact", 1, double.MaxValue, true, true, null, null, null, null, false);
			this.d.h.b.a(null, false);
			c5x c5x4 = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
			{
				"blood"
			})) as c5x;
			if (c5x4 != null)
			{
				c5x4.ae = new float?(0.5f);
			}
			return true;
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00230A80 File Offset: 0x0022EC80
		internal bool c(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
			{
				"window5"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.X = 4;
			}
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
			{
				"window7"
			})) as c5x;
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.b.X = 2;
			}
			this.g.d.VisualDirection = HorizontalDirection.West;
			this.g.d.c().a("VialBreak");
			boj.a(this.e, "BloodImpact", 1, double.MaxValue, true, true, null, null, null, null, false);
			this.e.h.b.a(null, false);
			return true;
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00230BC0 File Offset: 0x0022EDC0
		internal bool b(e6d A_0)
		{
			apk apk = new apk(new ar7(this.f));
			if (apk != null)
			{
				this.f.h.b.aa().StatusEffects.a(apk, false, false, false);
			}
			return true;
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00230C0C File Offset: 0x0022EE0C
		internal bool d(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
			{
				"railcarWall2"
			})) as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b.Y = 4;
			}
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
			{
				"window3"
			})) as c5x;
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.b.X = 1;
				c5x c5x3 = Enumerable.FirstOrDefault<b0b>(this.g.c.ab4(new string[]
				{
					"glass2"
				})) as c5x;
				if (c5x3 != null)
				{
					c5x3.ae = null;
				}
			}
			boj.a(this.f, "BloodImpact", 1, double.MaxValue, true, true, null, null, null, null, false);
			this.f.h.b.a(null, false);
			return true;
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00230D5C File Offset: 0x0022EF5C
		internal bool e(e6d A_0)
		{
			a0l.a(this.g.d, "player_ramp", true);
			a0l.a(this.b, "gunslinger_exit", true);
			edk edk = new edk();
			edk.b().Add("RailcarDivination");
			edk.ym(this.g.d, this.g.d, null);
			this.g.a.a(this.g.b.aqw().n("xphw_exobase_tun_railcar").a(new Point(2, 4)));
			this.g.a.a(this.g.b.aqw().n("xphw_exobase_tun_railcar").a(new Point(1, 4)));
			this.g.a.a(this.g.b.aqw().n("xphw_exobase_tun_railcar").a(new Point(2, 7)));
			this.g.a.a(this.g.b.aqw().n("xphw_exobase_tun_railcar").a(new Point(1, 11)));
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			dvn dvn = new dvn(this.g.b.aqw().y8(), "xphw_DarkTerritory");
			dvn.a(null);
			dvn.ym(null, null, null);
			this.g.b.aqz().atc("xphw_tripNorth", true);
			this.g.b.aqz().atb("xphw_findWayBack", true);
			this.g.b.aqz().atb("xphw_investigateExobase", true);
			this.g.b.aqu().r()["quest_xphw_tripToNorthUnderrail_completed"] = true;
			this.g.b.aqu().r()["quest_xphw_tripToNorthUnderrail_ambushed"] = true;
			this.g.b.aqu().r()["faction_xphw_exoBase_know"] = true;
			this.g.b.aqu().r()["interface_xphw_railcar_hasPower"] = false;
			return true;
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x00230FCC File Offset: 0x0022F1CC
		internal bool a(e6d A_0)
		{
			this.g.d.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001FFE RID: 8190
		public c5x a;

		// Token: 0x04001FFF RID: 8191
		public c5x b;

		// Token: 0x04002000 RID: 8192
		public c5x c;

		// Token: 0x04002001 RID: 8193
		public c5x d;

		// Token: 0x04002002 RID: 8194
		public c5x e;

		// Token: 0x04002003 RID: 8195
		public c5x f;

		// Token: 0x04002004 RID: 8196
		public a3v.a g;
	}
}
