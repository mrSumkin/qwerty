using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000D02 RID: 3330
[e79("Cc_JookhelaTrapsYou")]
public sealed class dqf : dgy
{
	// Token: 0x06004A02 RID: 18946 RVA: 0x001F1424 File Offset: 0x001EF624
	public dqf()
	{
		dqf.b b = new dqf.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			b.c = (b.a.aqu().v().b() as c5x);
			b.b = new ar7();
			if (b.c != null)
			{
				dqf.c c = new dqf.c();
				c.b = b;
				c.b.c.i.b.a(true, false);
				c.a = c.b.c.Area;
				if (c.a != null)
				{
					dqf.a a = new dqf.a();
					a.b = c;
					a.a = new EntityAspectReference<bim, bim>(a.b.a, new Guid("f38d8316-65eb-42a2-bb12-3cb6ce0eb306")).ao();
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					kw kw = new kw();
					kw.a(new bt4("jookhelaFace"));
					kw.a(false);
					kw.IsAsync = false;
					array[num] = kw;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.b.a));
					array2[num2] = dva;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(a.b.b.a));
					array3[num3] = dva2;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					s5 s = new s5();
					s.a(a.b.b.b);
					s.a(new bt4("jookhelaFace"));
					s.IsAsync = false;
					s.a(true);
					array4[num4] = s;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s2 = new s5();
					s2.a(a.b.b.b);
					s2.a(new bt4("jookhelaLever"));
					s2.IsAsync = false;
					s2.a(true);
					array5[num5] = s2;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(a.a));
					array6[num6] = dva3;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					s5 s3 = new s5();
					s3.a(a.b.b.b);
					s3.a(new bt4("jookhelaSpawn1"));
					s3.IsAsync = false;
					s3.a(false);
					array7[num7] = s3;
					base.a(array7);
					btm[] array8 = new btm[1];
					int num8 = 0;
					kw kw2 = new kw();
					kw2.a(new bt4(a.b.b.c.Area.y8(), a.b.b.c.Location));
					kw2.a(false);
					kw2.IsAsync = false;
					array8[num8] = kw2;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(a.b.b.b));
					array9[num9] = dva4;
					base.a(array9);
					btm[] array10 = new btm[1];
					int num10 = 0;
					a5 a2 = new a5();
					a2.a(a.b.b.b);
					array10[num10] = a2;
					base.a(array10);
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
	}

	// Token: 0x02000D03 RID: 3331
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A04 RID: 18948 RVA: 0x001F1894 File Offset: 0x001EFA94
		internal bool a(e6d A_0)
		{
			aw1.b(this.c, this.b.ao(), false);
			return true;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x001F18B0 File Offset: 0x001EFAB0
		internal bool b(e6d A_0)
		{
			c5x c5x = this.b.ao() as c5x;
			if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead)
			{
				int num;
				if (this.a.aqu().ae() >= GameDifficulty.Hard)
				{
					num = 3;
				}
				else if (this.a.aqu().ae() >= GameDifficulty.Normal)
				{
					num = 2;
				}
				else
				{
					num = 1;
				}
				this.c.c().a("DarkSecretReveal");
				for (int i = 1; i <= num; i++)
				{
					new d8g(c5x, c5x, new bt4("dop" + i.ToString()), new a1q?(new a1q(DamageType.Electricity, 15, 30)), false, new Guid?(this.c.qe()), "Тень Жукелы", null, null).ym(c5x, null, null);
				}
			}
			return true;
		}

		// Token: 0x04001D6D RID: 7533
		public cnk a;

		// Token: 0x04001D6E RID: 7534
		public ar7 b;

		// Token: 0x04001D6F RID: 7535
		public c5x c;
	}

	// Token: 0x02000D04 RID: 3332
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004A07 RID: 18951 RVA: 0x001F19BC File Offset: 0x001EFBBC
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.Zone.g("jookhelaSpawn1");
			c5x a_2 = vq.a("creature\\critters\\jookhela", a_, true);
			this.b.b.a(a_2);
			return true;
		}

		// Token: 0x04001D70 RID: 7536
		public aud a;

		// Token: 0x04001D71 RID: 7537
		public dqf.b b;
	}

	// Token: 0x02000D05 RID: 3333
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A09 RID: 18953 RVA: 0x001F1A0C File Offset: 0x001EFC0C
		internal bool a(e6d A_0)
		{
			c5x c5x = this.b.b.b.ao() as c5x;
			if (c5x != null && c5x.k.b != null && this.a != null)
			{
				c5x.k.b.b(this.a.a8(), this.a.t(), 1, false, null);
			}
			return true;
		}

		// Token: 0x04001D72 RID: 7538
		public bim a;

		// Token: 0x04001D73 RID: 7539
		public dqf.c b;
	}
}
