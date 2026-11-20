using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001024 RID: 4132
[eiz("FFDJ")]
[Serializable]
public sealed class ci0 : cze
{
	// Token: 0x06005543 RID: 21827 RVA: 0x0025AEE8 File Offset: 0x002590E8
	private ci0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005544 RID: 21828 RVA: 0x0025AEF4 File Offset: 0x002590F4
	public ci0()
	{
	}

	// Token: 0x06005545 RID: 21829 RVA: 0x0025AF00 File Offset: 0x00259100
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null)
		{
			dv1.a(new List<string>
			{
				"Projectiles\\PsiFlake"
			}, c5x.Area, c5x.aj(), 0.2f, 20, 100, 2f, 12f, true, true, false, null, false);
		}
	}
}
