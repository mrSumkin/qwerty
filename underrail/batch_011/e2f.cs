using System;
using System.Collections.Generic;

// Token: 0x02000FE5 RID: 4069
public sealed class e2f
{
	// Token: 0x060053C1 RID: 21441 RVA: 0x00251728 File Offset: 0x0024F928
	public e2f()
	{
	}

	// Token: 0x060053C2 RID: 21442 RVA: 0x00251730 File Offset: 0x0024F930
	public e2f(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		this.a = A_0;
		this.b = A_1;
		if (A_2 != null)
		{
			this.c = new Dictionary<string, object>(A_2);
		}
	}

	// Token: 0x04002228 RID: 8744
	public b0b a;

	// Token: 0x04002229 RID: 8745
	public b0b b;

	// Token: 0x0400222A RID: 8746
	public Dictionary<string, object> c;
}
