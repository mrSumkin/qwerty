using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001080 RID: 4224
[eiz("SPIXPJ")]
[Serializable]
public sealed class c83 : cze, ISerializable
{
	// Token: 0x06005808 RID: 22536 RVA: 0x002640B4 File Offset: 0x002622B4
	private c83(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005809 RID: 22537 RVA: 0x002640C0 File Offset: 0x002622C0
	public c83()
	{
	}

	// Token: 0x0600580A RID: 22538 RVA: 0x002640C8 File Offset: 0x002622C8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.c().a("Xpbl_StriderInfestationExpires");
			boj.a(c5x, "Xpbl_StriderInfestationBurst", 1, double.MaxValue, true, true, null, null, null, null, false);
			int num = 1;
			object obj;
			if (A_2 != null && A_2.TryGetValue("StatusEffect", out obj))
			{
				zh zh = obj as zh;
				if (zh != null)
				{
					num = zh.a();
				}
			}
			cwt cwt = new cwt();
			cwt.i = new ap9("Parasitic Infestation", null);
			cwt.f.Add(euf.a(a1q.a(zh.e, (double)num), 1.0));
			cwt.l = true;
			cwt.p = true;
			cwt.r = false;
			cwt.b = true;
			cwt.w = true;
			c5x.h.b.aa().Defense.a(cwt);
		}
	}
}
