using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012CE RID: 4814
[eiz("XCG")]
[Serializable]
public sealed class d0t : cry, ISerializable, chb, c98
{
	// Token: 0x06006A59 RID: 27225 RVA: 0x002CCEAC File Offset: 0x002CB0AC
	private d0t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006A5A RID: 27226 RVA: 0x002CCEB8 File Offset: 0x002CB0B8
	public override string gv()
	{
		return "cryogas";
	}

	// Token: 0x06006A5B RID: 27227 RVA: 0x002CCEC0 File Offset: 0x002CB0C0
	public override bool gw()
	{
		return false;
	}

	// Token: 0x06006A5C RID: 27228 RVA: 0x002CCEC4 File Offset: 0x002CB0C4
	public d0t(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06006A5D RID: 27229 RVA: 0x002CCED0 File Offset: 0x002CB0D0
	public override void gx(c5x A_0)
	{
	}

	// Token: 0x06006A5E RID: 27230 RVA: 0x002CCED8 File Offset: 0x002CB0D8
	protected override void gy(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive)
		{
			a2 a = Enumerable.FirstOrDefault<a2>(A_0.h.b.aa().StatusEffects.Get<a2>());
			if (a != null && a.Duration == 0)
			{
				return;
			}
			ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
			int a_ = base.f();
			cwt cwt = new cwt();
			cwt.i = new ap9("Cryogas", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
			cwt.f.Add(euf.a(c18.b(a_), 1.0));
			cwt.l = true;
			cwt.v = "криогаз";
			cwt.b = true;
			cwt.w = true;
			cru cru = A_0.h.b.aa().Defense.a(cwt);
			if (cru.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.a, new Func<csk, bool>(d0t.a.a.a)), new Func<csk, int>(d0t.a.a.b)) > 0 && !A_0.h.b.aa().d(CharacterImmunities.Chill))
				{
					b34 b = Enumerable.FirstOrDefault<b34>(A_0.h.b.aa().StatusEffects.Get<b34>());
					e6y e6y = Enumerable.FirstOrDefault<e6y>(A_0.h.b.aa().StatusEffects.Get<e6y>());
					if (!A_0.h.b.aa().SpecialStates.h && !A_0.h.b.aa().d(CharacterImmunities.Freeze) && e6y != null && e6y.Stacks == qz.b && cuo.a.NextDouble() < 0.25)
					{
						A_0.h.b.u();
						A_0.h.b.aa().StatusEffects.a(new a2(d0u.b * 2, null), false, false, false);
						awq.b(A_0.h.b);
					}
					if (b != null && b.Stacks == h7.i)
					{
						A_0.h.b.aa().StatusEffects.a(new e6y(qz.c, qz.b), false, false, false);
					}
					A_0.h.b.aa().StatusEffects.a(new b34(d0u.b * 4, h7.i), false, false, false);
					awq.c(A_0.h.b);
				}
			}
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && base.d() == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
			awq.e(A_0.h.b);
		}
	}

	// Token: 0x020012CF RID: 4815
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006A61 RID: 27233 RVA: 0x002CD28C File Offset: 0x002CB48C
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Cold;
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x002CD298 File Offset: 0x002CB498
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002BB1 RID: 11185
		public static readonly d0t.a a = new d0t.a();

		// Token: 0x04002BB2 RID: 11186
		public static Func<csk, bool> b;

		// Token: 0x04002BB3 RID: 11187
		public static Func<csk, int> c;
	}
}
