using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001186 RID: 4486
public static class a37
{
	// Token: 0x06005FCD RID: 24525 RVA: 0x0029BDEC File Offset: 0x00299FEC
	public static List<ble> a(aud A_0)
	{
		List<ble> list = new List<ble>();
		if (A_0 != null && A_0.Entities != null)
		{
			foreach (c5x c5x in Enumerable.OfType<c5x>(A_0.Entities))
			{
				j7 aspect = c5x.GetAspect<j7>();
				if (aspect != null)
				{
					list.Add(aspect);
				}
			}
		}
		return list;
	}
}
