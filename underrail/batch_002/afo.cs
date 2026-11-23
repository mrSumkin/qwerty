using System;
using System.Collections.Generic;

// Token: 0x02000266 RID: 614
public sealed class afo
{
	// Token: 0x06001228 RID: 4648 RVA: 0x0004AF3C File Offset: 0x0004913C
	public static afo a(b0b A_0)
	{
		afo afo = new afo();
		afo.a = A_0;
		afo.b = A_0.m;
		afo.c = A_0.l;
		A_0.m = null;
		A_0.l = null;
		return afo;
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x0004AF70 File Offset: 0x00049170
	public void a()
	{
		this.a.m = this.b;
		this.a.l = this.c;
	}

	// Token: 0x04000A14 RID: 2580
	public b0b a;

	// Token: 0x04000A15 RID: 2581
	public aud b;

	// Token: 0x04000A16 RID: 2582
	public List<ak1> c;
}
