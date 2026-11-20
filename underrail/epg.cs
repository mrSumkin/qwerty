using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020014EA RID: 5354
[eiz("TCAVA")]
[Serializable]
public sealed class epg : mo, ISerializable
{
	// Token: 0x0600782D RID: 30765 RVA: 0x00325D7C File Offset: 0x00323F7C
	private epg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600782E RID: 30766 RVA: 0x00325D88 File Offset: 0x00323F88
	public epg()
	{
	}

	// Token: 0x0600782F RID: 30767 RVA: 0x00325D90 File Offset: 0x00323F90
	protected override string ao8()
	{
		return "corrosiveAcidSplash";
	}

	// Token: 0x06007830 RID: 30768 RVA: 0x00325D98 File Offset: 0x00323F98
	protected override string ao9()
	{
		return "CorrosiveAcidVial";
	}

	// Token: 0x06007831 RID: 30769 RVA: 0x00325DA0 File Offset: 0x00323FA0
	protected override a1q apa()
	{
		return dry.a(base.vg().e());
	}

	// Token: 0x06007832 RID: 30770 RVA: 0x00325DB4 File Offset: 0x00323FB4
	protected override AmmoType apb()
	{
		return AmmoType.Vial_Acid_Corrosive;
	}

	// Token: 0x06007833 RID: 30771 RVA: 0x00325DBC File Offset: 0x00323FBC
	protected override cze apc(edx A_0, EntityAspectReference<amc, amc> A_1)
	{
		return new b69(A_0, A_1);
	}

	// Token: 0x06007834 RID: 30772 RVA: 0x00325DC8 File Offset: 0x00323FC8
	public override void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3 != null && A_3.a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(epg.a.a.b)), new Func<csk, int>(epg.a.a.a)) > 0)
			{
				A_1.aa().StatusEffects.a(new deu(deu.c * d0u.b)
				{
					Stacks = dry.c
				}, false, false, false);
			}
		}
	}

	// Token: 0x020014EB RID: 5355
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007837 RID: 30775 RVA: 0x00325EA8 File Offset: 0x003240A8
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Acid;
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00325EB4 File Offset: 0x003240B4
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0400304A RID: 12362
		public static readonly epg.a a = new epg.a();

		// Token: 0x0400304B RID: 12363
		public static Func<csk, bool> b;

		// Token: 0x0400304C RID: 12364
		public static Func<csk, int> c;
	}
}
