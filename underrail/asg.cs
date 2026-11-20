using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200150A RID: 5386
[eiz("TK01")]
[Serializable]
public sealed class asg : bp7, ISerializable
{
	// Token: 0x060078AB RID: 30891 RVA: 0x003288EC File Offset: 0x00326AEC
	private asg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060078AC RID: 30892 RVA: 0x003288F8 File Offset: 0x00326AF8
	public asg()
	{
	}

	// Token: 0x060078AD RID: 30893 RVA: 0x00328900 File Offset: 0x00326B00
	protected override enp r6()
	{
		return new asg.a();
	}

	// Token: 0x0200150B RID: 5387
	[eiz("TK01a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060078AE RID: 30894 RVA: 0x00328908 File Offset: 0x00326B08
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00328910 File Offset: 0x00326B10
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00328914 File Offset: 0x00326B14
		public a()
		{
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x00328920 File Offset: 0x00326B20
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null)
			{
				if (A_3.c)
				{
					awq.a(A_0, A_1);
				}
				if (!A_1.aa().Dead && A_2.b && A_3.a != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(asg.a.a.a.b)), new Func<csk, int>(asg.a.a.a.a)) > 0)
					{
						awq.b(A_0, A_1);
					}
				}
			}
		}

		// Token: 0x0200150C RID: 5388
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060078B4 RID: 30900 RVA: 0x003289E4 File Offset: 0x00326BE4
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x060078B5 RID: 30901 RVA: 0x003289F0 File Offset: 0x00326BF0
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400306A RID: 12394
			public static readonly asg.a.a a = new asg.a.a();

			// Token: 0x0400306B RID: 12395
			public static Func<csk, bool> b;

			// Token: 0x0400306C RID: 12396
			public static Func<csk, int> c;
		}
	}
}
