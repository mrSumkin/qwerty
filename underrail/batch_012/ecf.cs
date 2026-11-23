using System;
using Ouroboros.Common.Data;

// Token: 0x02000694 RID: 1684
public static class ecf
{
	// Token: 0x06002BCF RID: 11215 RVA: 0x000FCDC8 File Offset: 0x000FAFC8
	public static av a(c3n A_0, TypedObjectReference<efk> A_1, object A_2)
	{
		czh.a(A_1, "invoker");
		if (A_0 == null)
		{
			return null;
		}
		ce5 ce = A_0 as ce5;
		if (ce != null)
		{
			return new bd0(A_1, ce, A_2);
		}
		ehl ehl = A_0 as ehl;
		if (ehl != null)
		{
			return new eu7(A_1, ehl, A_2);
		}
		a8s a8s = A_0 as a8s;
		if (a8s != null)
		{
			return new bl6(A_1, a8s, A_2);
		}
		return new av(A_1, A_0, A_2);
	}
}
