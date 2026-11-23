using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001BFA RID: 7162
public sealed class cn5
{
	// Token: 0x06009BEC RID: 39916 RVA: 0x003D2778 File Offset: 0x003D0978
	public cn5()
	{
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType key = (DamageType)obj;
			this.c[key] = 1.0;
			this.d[key] = 1.0;
			this.f[key] = false;
		}
	}

	// Token: 0x04003BEB RID: 15339
	public Action<efk, cwt, List<csk>> a;

	// Token: 0x04003BEC RID: 15340
	public Action<efk, List<csk>> b;

	// Token: 0x04003BED RID: 15341
	public Dictionary<DamageType, double> c = new Dictionary<DamageType, double>();

	// Token: 0x04003BEE RID: 15342
	public Dictionary<DamageType, double> d = new Dictionary<DamageType, double>();

	// Token: 0x04003BEF RID: 15343
	public Action<efk, Dictionary<DamageType, du2>> e;

	// Token: 0x04003BF0 RID: 15344
	public Dictionary<DamageType, bool> f = new Dictionary<DamageType, bool>();
}
