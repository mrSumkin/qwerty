using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B2B RID: 2859
[eiz("GSME")]
[Serializable]
public sealed class a5y : cze, ISerializable
{
	// Token: 0x060041F4 RID: 16884 RVA: 0x00198CEC File Offset: 0x00196EEC
	private a5y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x00198CF8 File Offset: 0x00196EF8
	public a5y()
	{
	}

	// Token: 0x060041F6 RID: 16886 RVA: 0x00198D04 File Offset: 0x00196F04
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.s.b != null)
		{
			a72 a = Enumerable.FirstOrDefault<cze>(c5x.s.b.s()) as a72;
			if (a != null)
			{
				a.b("Interfacing\\GmsElevator");
				a.b(false);
			}
		}
	}
}
