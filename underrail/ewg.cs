using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012D0 RID: 4816
[eiz("PGSE")]
[Serializable]
public sealed class ewg : cry, ISerializable, chb, c98
{
	// Token: 0x06006A63 RID: 27235 RVA: 0x002CD2A4 File Offset: 0x002CB4A4
	private ewg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006A64 RID: 27236 RVA: 0x002CD2B0 File Offset: 0x002CB4B0
	public override string gv()
	{
		return "poisonedGas";
	}

	// Token: 0x06006A65 RID: 27237 RVA: 0x002CD2B8 File Offset: 0x002CB4B8
	public override bool gw()
	{
		return true;
	}

	// Token: 0x06006A66 RID: 27238 RVA: 0x002CD2BC File Offset: 0x002CB4BC
	public ewg(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06006A67 RID: 27239 RVA: 0x002CD2C8 File Offset: 0x002CB4C8
	public override void gx(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0)
		{
			ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
			int a_ = base.f();
			cwt cwt = new cwt();
			cwt.i = new ap9("Toxic gas", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
			cwt.f.Add(euf.a(c18.d(a_), 0.33));
			cwt.l = true;
			cwt.v = "токсичный газ";
			cwt.b = true;
			cwt.w = true;
			cwt.ad["IsToxicGas"] = true;
			cru a_2 = A_0.h.b.aa().Defense.a(cwt);
			this.a(A_0.h.b, a_2);
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && base.d() == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
		}
	}

	// Token: 0x06006A68 RID: 27240 RVA: 0x002CD494 File Offset: 0x002CB694
	protected override void gy(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && (A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0 || A_0.IsPlayer))
		{
			ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
			int a_ = base.f();
			cwt cwt = new cwt();
			cwt.i = new ap9("Toxic gas", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
			cwt.f.Add(euf.a(c18.d(a_), 1.0));
			cwt.l = true;
			cwt.v = "токсичный газ";
			cwt.b = true;
			cwt.w = true;
			cwt.ad["IsToxicGas"] = true;
			cru a_2 = A_0.h.b.aa().Defense.a(cwt);
			this.a(A_0.h.b, a_2);
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && base.d() == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
		}
		efk efk = A_0.h.b.aa();
		etc microfeat = efk.GetMicrofeat<etc>();
		if (microfeat != null)
		{
			microfeat.a(efk, base.f());
		}
	}

	// Token: 0x06006A69 RID: 27241 RVA: 0x002CD69C File Offset: 0x002CB89C
	private void a(amc A_0, cru A_1)
	{
		if (!A_0.aa().Dead && !A_1.c && A_1.a != null && !A_0.aa().d(CharacterImmunities.Biohazard))
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a, new Func<csk, bool>(ewg.a.a.b)), new Func<csk, int>(ewg.a.a.a));
			if (num > 0)
			{
				a8l a_ = new a8l(1 + num / 10);
				A_0.aa().StatusEffects.a(a_, false, false, false);
			}
		}
	}

	// Token: 0x020012D1 RID: 4817
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006A6C RID: 27244 RVA: 0x002CD778 File Offset: 0x002CB978
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Bio;
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x002CD784 File Offset: 0x002CB984
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002BB4 RID: 11188
		public static readonly ewg.a a = new ewg.a();

		// Token: 0x04002BB5 RID: 11189
		public static Func<csk, bool> b;

		// Token: 0x04002BB6 RID: 11190
		public static Func<csk, int> c;
	}
}
