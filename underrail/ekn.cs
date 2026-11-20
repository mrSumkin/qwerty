using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020007C3 RID: 1987
[eiz("XPBLTPSAJ")]
[Serializable]
public sealed class ekn : cze
{
	// Token: 0x060031C5 RID: 12741 RVA: 0x00130C24 File Offset: 0x0012EE24
	private ekn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060031C6 RID: 12742 RVA: 0x00130C30 File Offset: 0x0012EE30
	public ekn()
	{
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x00130C3C File Offset: 0x0012EE3C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			int a_ = 0;
			object obj;
			if (A_2 != null && A_2.TryGetValue("stats", out obj))
			{
				cru cru = obj as cru;
				if (cru != null && cru.a != null)
				{
					a_ = Enumerable.Sum<csk>(cru.a, new Func<csk, int>(ekn.a.a.a));
				}
			}
			dg2 aspect = A_1.GetAspect<dg2>();
			if (aspect != null)
			{
				aspect.b(a_);
			}
		}
	}

	// Token: 0x020007C4 RID: 1988
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060031CA RID: 12746 RVA: 0x00130CD8 File Offset: 0x0012EED8
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04001AC0 RID: 6848
		public static readonly ekn.a a = new ekn.a();

		// Token: 0x04001AC1 RID: 6849
		public static Func<csk, int> b;
	}
}
