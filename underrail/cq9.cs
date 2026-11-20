using System;
using System.Collections.Generic;

// Token: 0x02001B65 RID: 7013
public sealed class cq9 : cb6
{
	// Token: 0x060097EB RID: 38891 RVA: 0x003B2D90 File Offset: 0x003B0F90
	public cq9(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060097EC RID: 38892 RVA: 0x003B2DA0 File Offset: 0x003B0FA0
	public int aha()
	{
		return this.a;
	}

	// Token: 0x060097ED RID: 38893 RVA: 0x003B2DAC File Offset: 0x003B0FAC
	public bool ahb(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			List<coh> classPropertyValue = A_0.Definition.a7().GetClassPropertyValue<List<coh>>("Components");
			return classPropertyValue != null && classPropertyValue.Count > 0;
		}
		return false;
	}

	// Token: 0x04003A50 RID: 14928
	private int a;
}
