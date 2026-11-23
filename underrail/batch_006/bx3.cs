using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules;

// Token: 0x02000D06 RID: 3334
[e79("Cc_JookhelaConfrontsYou")]
public sealed class bx3 : dgy
{
	// Token: 0x06004A0A RID: 18954 RVA: 0x001F1A80 File Offset: 0x001EFC80
	public bx3()
	{
		bx3.b b = new bx3.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			b.c = (b.a.aqu().v().b() as c5x);
			b.b = new ar7();
			if (b.c != null)
			{
				bx3.a a = new bx3.a();
				a.b = b;
				a.b.c.i.b.a(true, false);
				a.a = a.b.c.Area;
				if (a.a != null)
				{
					new EntityAspectReference<bim, bim>(a.a, new Guid("f38d8316-65eb-42a2-bb12-3cb6ce0eb306")).ao();
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					kw kw = new kw();
					kw.a(new bt4("jookhelaConfront"));
					kw.a(false);
					kw.IsAsync = false;
					array[num] = kw;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.a));
					array2[num2] = dva;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					s5 s = new s5();
					s.a(a.b.b);
					s.a(new bt4("jookhelaConfront"));
					s.IsAsync = false;
					s.a(true);
					array3[num3] = s;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D07 RID: 3335
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A0C RID: 18956 RVA: 0x001F1C88 File Offset: 0x001EFE88
		internal bool a(e6d A_0)
		{
			c5x c5x = this.b.ao() as c5x;
			if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead)
			{
				this.c.GetAspect<j7>().a(c5x.GetAspect<j7>(), false, null, false);
			}
			return true;
		}

		// Token: 0x04001D74 RID: 7540
		public cnk a;

		// Token: 0x04001D75 RID: 7541
		public ar7 b;

		// Token: 0x04001D76 RID: 7542
		public c5x c;
	}

	// Token: 0x02000D08 RID: 3336
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A0E RID: 18958 RVA: 0x001F1D00 File Offset: 0x001EFF00
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.Zone.g("jookhelaSpawn2");
			c5x c5x = vq.a("creature\\critters\\jookhela", a_, true);
			if (c5x != null && c5x.h.b != null)
			{
				if (this.b.a.aqu() != null)
				{
					if (this.b.a.aqu().ae() >= GameDifficulty.Hard)
					{
						c5x.h.b.aa().PsiAbilities.b(dgk.Get<d97>());
						c5x.h.b.aa().bl();
					}
					if (this.b.a.aqu().ae() == GameDifficulty.Dominating)
					{
						c5x.h.b.aa().Feats.d(typeof(ch));
						c5x.h.b.aa().SpecialAbilities.b(dgk.Get<hy>());
						axa axa = c5x.h.b.aa().BaseAbilities.Get<axa>();
						axa.a(axa.f() + 5);
						c5x.h.b.aa().StatusEffects.a(new uj(0f, 0f, 1f, 0, 0, 20, 4), false, false, false);
						c5x.h.b.aa().bl();
					}
					if (this.b.a.aqu().ae() == GameDifficulty.Easy)
					{
						c5x.h.b.aa().PsiAbilities.a(dgk.Get<dxh>());
						axa axa2 = c5x.h.b.aa().BaseAbilities.Get<axa>();
						axa2.a(axa2.f() - 4);
						c5x.h.b.aa().bl();
					}
				}
				this.b.b.a(c5x);
			}
			return true;
		}

		// Token: 0x04001D77 RID: 7543
		public aud a;

		// Token: 0x04001D78 RID: 7544
		public bx3.b b;
	}
}
