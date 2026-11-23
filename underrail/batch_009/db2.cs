using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000E73 RID: 3699
[e79("Sgs_GorskyPunchesYouAgain")]
public sealed class db2 : dgy
{
	// Token: 0x06004D27 RID: 19751 RVA: 0x0021F878 File Offset: 0x0021DA78
	public db2()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			db2.a a = new db2.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.h.b != null)
			{
				a.b = (new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), a.a.Area).ao() as c5x);
				if (a.b != null && a.b.h.b != null)
				{
					if (a.a.h.b.aa().Defense.q().zo() >= 2f)
					{
						a.a.h.b.aa().Defense.a(new cwt
						{
							b = true,
							p = true,
							l = true,
							f = new List<csk>
							{
								new csk(DamageType.Mechanical, Math.Min(35, (int)(a.a.h.b.aa().Defense.q().zo() - 1f)))
							},
							i = new ap9(a.b.h.b.aa())
						});
					}
					if (!euf.o(a.b.h.b.aa().Offense.u()))
					{
						a.b.h.b.aa().Offense.k();
					}
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					c6w c6w = new c6w();
					c6w.a = new Func<auv>(a.a);
					c6w.a(new ar7(a.b));
					array[num] = c6w;
					base.a(array);
					base.a(new btm[]
					{
						new ace(new bfq(Guid.NewGuid().ToString(), "UnarmedWoosh"))
						{
							TargetRef = new ar7(a.a)
						}
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Attack1);
					bb.a(cux.m);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.b));
					bb.b(1);
					array2[num2] = bb;
					base.a(array2);
					base.a(new btm[]
					{
						new ace(new bfq(Guid.NewGuid().ToString(), "UnarmedHitBody"))
						{
							TargetRef = new ar7(a.a)
						}
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.Die);
					bb2.a(atp.a);
					bb2.IsAsync = true;
					bb2.a(new ar7(a.a));
					bb2.a(cux.h);
					array3[num3] = bb2;
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new epw(new CharacterState?(CharacterState.Die)))
						{
							TargetRef = new ar7(a.a)
						}
					});
					base.a(new btm[]
					{
						new ace(new b16(new int?(7)))
						{
							TargetRef = new ar7(a.a)
						}
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					dky.IsAsync = false;
					array4[num4] = dky;
					base.a(array4);
					base.a(new btm[]
					{
						new ace(new epw(null))
						{
							TargetRef = new ar7(a.a)
						}
					});
					base.a(new btm[]
					{
						new ace(new b16(null))
						{
							TargetRef = new ar7(a.a)
						}
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array5[num5] = c8s;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx = new egx();
					egx.a("Не нравятся мне твои глупые шутки. В следующий раз отправлю тебя в лазарет, так что смотри!");
					array6[num6] = new ace(egx)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array6);
				}
			}
		}
	}

	// Token: 0x02000E74 RID: 3700
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D29 RID: 19753 RVA: 0x0021FD44 File Offset: 0x0021DF44
		internal auv a()
		{
			return new fk(this.b.k.b, this.a, new List<HorizontalDirection>
			{
				this.a.VisualDirection
			}, true, 0);
		}

		// Token: 0x04001F78 RID: 8056
		public c5x a;

		// Token: 0x04001F79 RID: 8057
		public c5x b;
	}
}
