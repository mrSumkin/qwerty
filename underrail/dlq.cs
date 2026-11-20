using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001410 RID: 5136
[eiz("ESHASC")]
[Serializable]
public sealed class dlq : enp, ISerializable
{
	// Token: 0x06007351 RID: 29521 RVA: 0x00309D5C File Offset: 0x00307F5C
	private dlq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06007352 RID: 29522 RVA: 0x00309D64 File Offset: 0x00307F64
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x00309D68 File Offset: 0x00307F68
	public dlq()
	{
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x00309D74 File Offset: 0x00307F74
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (cuo.a.NextDouble() < cs4.i && A_1 != null && A_2 != null && A_2.b && A_3 != null && A_3.a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(dlq.a.a.b)), new Func<csk, int>(dlq.a.a.a)) > 0)
			{
				awq.a(A_0, A_1, cs4.j * d0u.b, false);
			}
		}
	}

	// Token: 0x02001411 RID: 5137
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06007357 RID: 29527 RVA: 0x00309E44 File Offset: 0x00308044
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x00309E50 File Offset: 0x00308050
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002F23 RID: 12067
		public static readonly dlq.a a = new dlq.a();

		// Token: 0x04002F24 RID: 12068
		public static Func<csk, bool> b;

		// Token: 0x04002F25 RID: 12069
		public static Func<csk, int> c;
	}
}
