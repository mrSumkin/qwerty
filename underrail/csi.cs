using System;
using System.Collections.Generic;

// Token: 0x02002093 RID: 8339
public static class csi
{
	// Token: 0x0600C79E RID: 51102 RVA: 0x00465474 File Offset: 0x00463674
	public static bool a(c5x A_0)
	{
		if (A_0 != null)
		{
			using (List<ak1>.Enumerator enumerator = A_0.l.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.a((long)((ulong)dm9.a)))
					{
						A_0.a(dm9.a);
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}
}
