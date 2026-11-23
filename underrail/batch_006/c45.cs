using System;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D4C RID: 3404
[e79("Gc_DoctorZilchGivePoison")]
public sealed class c45 : dgy
{
	// Token: 0x06004AA7 RID: 19111 RVA: 0x001FE630 File Offset: 0x001FC830
	public c45()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				aud aud = c5x.Area;
				if (aud != null)
				{
					c5x.i.b.a(true, false);
					c5x a_ = new ar7(new Guid("21dbaf0f-32bf-4300-bb03-661dd963d71e"), c5x.Area).ao() as c5x;
					bool flag = false;
					foreach (csd csd in Enumerable.ToList<csd>(c5x.Zone.Waypoints))
					{
						if (csd.Name == "LeaveMap" && csd.Area == aud)
						{
							flag = true;
							break;
						}
					}
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
					egx.a("::Вы затыкаете нос и пробуете жидкость.::");
					array[num] = new ace(egx)
					{
						TargetRef = new ar7(c5x)
					};
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					egx egx2 = new egx();
					egx2.a("На вкус она немного даже... ничего. Неплохо.");
					array2[num2] = new ace(egx2)
					{
						TargetRef = new ar7(c5x)
					};
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx3 = new egx();
					egx3.a("Совсем неплохо.");
					array3[num3] = new ace(egx3)
					{
						TargetRef = new ar7(c5x)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx4 = new egx();
					egx4.a("Подумать только, а я уж было...");
					array4[num4] = new ace(egx4)
					{
						TargetRef = new ar7(c5x)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Stunned);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(c5x));
					bb.b(4);
					array5[num5] = bb;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx5 = new egx();
					egx5.a("Мой желудок, он горит!");
					array6[num6] = new ace(egx5)
					{
						TargetRef = new ar7(c5x)
					};
					base.a(array6);
					btm[] array7 = new btm[1];
					int num7 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.Die);
					bb2.a(atp.a);
					bb2.IsAsync = false;
					bb2.a(new ar7(c5x));
					bb2.a(cux.h);
					array7[num7] = bb2;
					base.a(array7);
					base.a(new btm[]
					{
						new ace(new epw(new CharacterState?(CharacterState.Die)))
						{
							TargetRef = new ar7(c5x)
						}
					});
					base.a(new btm[]
					{
						new ace(new b16(new int?(7)))
						{
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
						}
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.1))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx6 = new egx();
					egx6.a("А-а-а-а!");
					array8[num8] = new ace(egx6)
					{
						TargetRef = new ar7(c5x)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new ace(new b16(new int?(6)))
						{
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
						}
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new ace(new b16(new int?(6)))
						{
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
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
							TargetRef = new ar7(c5x)
						}
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx7 = new egx();
					egx7.a("Значит, употребление внутрь, *всё-таки*, смертельно. Кто бы мог подумать!");
					array9[num9] = new ace(egx7)
					{
						TargetRef = new ar7(a_)
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx8 = new egx();
					egx8.a("Мда, стоит постирать одежду.");
					array10[num10] = new ace(egx8)
					{
						TargetRef = new ar7(a_)
					};
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					if (flag)
					{
						btm[] array11 = new btm[1];
						int num11 = 0;
						s5 s = new s5();
						s.a(new ar7(a_));
						s.a(new bt4("LeaveMap"));
						s.IsAsync = true;
						s.a(true);
						array11[num11] = s;
						base.a(array11);
						btm[] array12 = new btm[1];
						int num12 = 0;
						az4 az = new az4();
						az.a(new bt4("LeaveMap"));
						array12[num12] = new ace(az)
						{
							TargetRef = new ar7(a_)
						};
						base.a(array12);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
					}
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					nb nb = new nb();
					nb.a(bvl.d);
					nb.a(true);
					array13[num13] = new ace(nb);
					base.a(array13);
				}
			}
		}
	}
}
