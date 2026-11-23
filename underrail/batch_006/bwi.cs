using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001444 RID: 5188
[eiz("BLARCB")]
[Serializable]
public sealed class bwi : bvd, ISerializable
{
	// Token: 0x060074A7 RID: 29863 RVA: 0x00317868 File Offset: 0x00315A68
	private bwi(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("BLARCB:D");
	}

	// Token: 0x060074A8 RID: 29864 RVA: 0x00317884 File Offset: 0x00315A84
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("BLARCB:D", this.a);
	}

	// Token: 0x060074A9 RID: 29865 RVA: 0x00317898 File Offset: 0x00315A98
	public bwi(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060074AA RID: 29866 RVA: 0x003178A8 File Offset: 0x00315AA8
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		this.mm(A_0, A_1, A_2, A_3, new bps());
	}

	// Token: 0x060074AB RID: 29867 RVA: 0x003178BC File Offset: 0x00315ABC
	public void mm(amc A_0, amc A_1, cwt A_2, cru A_3, bps A_4)
	{
		if (A_4.b("blasted_armor"))
		{
			return;
		}
		A_4.a("blasted_armor");
		if (A_1 != null && A_3 != null && !A_3.c && A_3.a != null)
		{
			if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(bwi.a.a.a)) > 0)
			{
				if (A_1.aa().Passive || A_1.aa().d(CharacterImmunities.Dismantle))
				{
					etm a_ = new etm(new ap9(A_1.aa()), "эффекту разборки");
					bey.a(a_, (A_0 != null) ? A_0.aa() : null, A_1.aa(), A_1);
					a7v.a(a_);
					bmj.a(A_1.a8(), new ba0());
					return;
				}
				bca a_2 = new bca(this.a * d0u.b);
				A_1.aa().StatusEffects.a(a_2, false, false, false);
			}
		}
	}

	// Token: 0x04002FA9 RID: 12201
	public int a;

	// Token: 0x02001445 RID: 5189
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060074AE RID: 29870 RVA: 0x003179EC File Offset: 0x00315BEC
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002FAA RID: 12202
		public static readonly bwi.a a = new bwi.a();

		// Token: 0x04002FAB RID: 12203
		public static Func<csk, int> b;
	}
}
