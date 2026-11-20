using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D4B RID: 3403
[e79("Gc_ForcePoison")]
public sealed class dvb : dgy
{
	// Token: 0x06004AA6 RID: 19110 RVA: 0x001FD910 File Offset: 0x001FBB10
	public dvb()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				c5x.i.b.a(true, false);
				ar7 ar = new ar7(new Guid("21dbaf0f-32bf-4300-bb03-661dd963d71e"), c5x.Area);
				c5x a_ = ar.ao() as c5x;
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				egx egx = new egx();
				egx.a("::Кашляет.::");
				array[num] = new ace(egx)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				egx egx2 = new egx();
				egx2.a("Я чуть не задохнулся, балда ты!");
				array2[num2] = new ace(egx2)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				egx egx3 = new egx();
				egx3.a("Я...");
				array3[num3] = new ace(egx3)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx4 = new egx();
				egx4.a("::Он вытирает рот и молча смотрит на вас.::");
				array4[num4] = new ace(egx4)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				egx egx5 = new egx();
				egx5.a("Ну?");
				array5[num5] = new ace(egx5)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx6 = new egx();
				egx6.a("Ничего...");
				array6[num6] = new ace(egx6)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				egx egx7 = new egx();
				egx7.a("Я чувствую... нет абсолютно ничего.");
				array7[num7] = new ace(egx7)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				egx egx8 = new egx();
				egx8.a("А *ты* дум...");
				array8[num8] = new ace(egx8)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Stunned);
				bb.a(atp.a);
				bb.IsAsync = false;
				bb.a(new ar7(a_));
				bb.b(2);
				array9[num9] = bb;
				base.a(array9);
				btm[] array10 = new btm[1];
				int num10 = 0;
				egx egx9 = new egx();
				egx9.a("Так-то лучше.");
				array10[num10] = new ace(egx9)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array10);
				btm[] array11 = new btm[1];
				int num11 = 0;
				bb8 bb2 = new bb8();
				bb2.a(CharacterState.Stunned);
				bb2.a(atp.a);
				bb2.IsAsync = false;
				bb2.a(new ar7(a_));
				bb2.b(2);
				array11[num11] = bb2;
				base.a(array11);
				btm[] array12 = new btm[1];
				int num12 = 0;
				egx egx10 = new egx();
				egx10.a("Уф... ::Хватается за живот.::");
				array12[num12] = new ace(egx10)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				bb8 bb3 = new bb8();
				bb3.a(CharacterState.Die);
				bb3.a(atp.a);
				bb3.IsAsync = false;
				bb3.a(new ar7(a_));
				bb3.a(cux.h);
				array13[num13] = bb3;
				base.a(array13);
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Die)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(5)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array14 = new btm[1];
				int num14 = 0;
				egx egx11 = new egx();
				egx11.a("Н-ннннн!");
				array14[num14] = new ace(egx11)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array14);
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(5)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(5)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(5)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(a_)
					}
				});
				btm[] array15 = new btm[1];
				int num15 = 0;
				egx egx12 = new egx();
				egx12.a("Кххннагх!");
				array15[num15] = new ace(egx12)
				{
					TargetRef = new ar7(a_)
				};
				base.a(array15);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(5)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.2))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(5)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(6)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(7)))
					{
						TargetRef = new ar7(a_)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array16 = new btm[1];
				int num16 = 0;
				egx egx13 = new egx();
				egx13.a("Что ж, лучше ты, чем я.");
				array16[num16] = new ace(egx13)
				{
					TargetRef = new ar7(c5x)
				};
				base.a(array16);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array17 = new btm[1];
				int num17 = 0;
				nb nb = new nb();
				nb.a(bvl.c);
				nb.a(true);
				array17[num17] = new ace(nb)
				{
					TargetRef = ar
				};
				base.a(array17);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
