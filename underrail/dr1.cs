using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020014E7 RID: 5351
[eiz("TRSAVA")]
[Serializable]
public sealed class dr1 : mo, ISerializable
{
	// Token: 0x06007818 RID: 30744 RVA: 0x003256E4 File Offset: 0x003238E4
	private dr1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007819 RID: 30745 RVA: 0x003256F0 File Offset: 0x003238F0
	public dr1()
	{
	}

	// Token: 0x0600781A RID: 30746 RVA: 0x003256F8 File Offset: 0x003238F8
	protected override string ao8()
	{
		return "rustingAcidSplash";
	}

	// Token: 0x0600781B RID: 30747 RVA: 0x00325700 File Offset: 0x00323900
	protected override string ao9()
	{
		return "RustingAcidVial";
	}

	// Token: 0x0600781C RID: 30748 RVA: 0x00325708 File Offset: 0x00323908
	protected override a1q apa()
	{
		return es1.a(base.vg().e());
	}

	// Token: 0x0600781D RID: 30749 RVA: 0x0032571C File Offset: 0x0032391C
	protected override AmmoType apb()
	{
		return AmmoType.Vial_Acid_Rusting;
	}

	// Token: 0x0600781E RID: 30750 RVA: 0x00325724 File Offset: 0x00323924
	protected override cze apc(edx A_0, EntityAspectReference<amc, amc> A_1)
	{
		return new amg(A_0, A_1);
	}

	// Token: 0x0600781F RID: 30751 RVA: 0x00325730 File Offset: 0x00323930
	public override void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && !A_1.aa().Dead && A_2.b)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(dr1.a.a.b)), new Func<csk, int>(dr1.a.a.a)) > 0)
			{
				A_1.aa().StatusEffects.a(new ce(ce.b * d0u.b)
				{
					Stacks = es1.c
				}, false, false, false);
			}
		}
	}

	// Token: 0x020014E9 RID: 5353
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600782B RID: 30763 RVA: 0x00325D64 File Offset: 0x00323F64
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Acid;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00325D70 File Offset: 0x00323F70
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003047 RID: 12359
		public static readonly dr1.a a = new dr1.a();

		// Token: 0x04003048 RID: 12360
		public static Func<csk, bool> b;

		// Token: 0x04003049 RID: 12361
		public static Func<csk, int> c;
	}
}
