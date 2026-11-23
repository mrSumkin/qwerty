using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020016D8 RID: 5848
[eiz("SIAX")]
[Serializable]
public sealed class dih : cvd
{
	// Token: 0x06007F42 RID: 32578 RVA: 0x0035E108 File Offset: 0x0035C308
	private dih(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SIAX:E");
	}

	// Token: 0x06007F43 RID: 32579 RVA: 0x0035E124 File Offset: 0x0035C324
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIAX:E", this.a);
	}

	// Token: 0x06007F44 RID: 32580 RVA: 0x0035E140 File Offset: 0x0035C340
	public dih(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06007F45 RID: 32581 RVA: 0x0035E150 File Offset: 0x0035C350
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().e() != null && base.aig().e().b8() != null)
		{
			foreach (KeyValuePair<aia, dph> keyValuePair in Enumerable.ToList<KeyValuePair<aia, dph>>(base.aig().e().b8().Auras.c()))
			{
				if (keyValuePair.Key.Value != null && keyValuePair.Key.Value is a8s && keyValuePair.Key.Value.TechnicalName != null && keyValuePair.Key.Value.TechnicalName.StartsWith("infusion", StringComparison.OrdinalIgnoreCase) && keyValuePair.Key.Value.TechnicalName != this.a)
				{
					base.aig().e().b8().Auras.b(keyValuePair.Key.Value as a8s);
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04003231 RID: 12849
	private new string a;
}
