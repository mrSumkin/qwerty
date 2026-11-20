using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B57 RID: 2903
[eiz("JYSBFUSJ")]
[Serializable]
public sealed class eu9 : cze, ISerializable
{
	// Token: 0x0600428E RID: 17038 RVA: 0x0019CF30 File Offset: 0x0019B130
	private eu9(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600428F RID: 17039 RVA: 0x0019CF38 File Offset: 0x0019B138
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004290 RID: 17040 RVA: 0x0019CF3C File Offset: 0x0019B13C
	public eu9()
	{
	}

	// Token: 0x06004291 RID: 17041 RVA: 0x0019CF48 File Offset: 0x0019B148
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		d60 d = null;
		if (A_0 != null)
		{
			d = A_0.a();
		}
		else if (A_1 != null)
		{
			d = A_1.a();
		}
		if (d != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
			{
				"console"
			})) as c5x;
			if (c5x != null && c5x.Zone.y8() == "si1" && c5x.s.b != null)
			{
				c5x.s.b.g(true);
			}
		}
	}
}
