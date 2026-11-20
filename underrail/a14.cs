using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020008E8 RID: 2280
[eiz("CCURPSG")]
[Serializable]
public sealed class a14 : bdw, ISerializable
{
	// Token: 0x0600388C RID: 14476 RVA: 0x0014F0CC File Offset: 0x0014D2CC
	private a14(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600388D RID: 14477 RVA: 0x0014F0D4 File Offset: 0x0014D2D4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600388E RID: 14478 RVA: 0x0014F0D8 File Offset: 0x0014D2D8
	public a14()
	{
	}

	// Token: 0x0600388F RID: 14479 RVA: 0x0014F0E0 File Offset: 0x0014D2E0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_utility");
			if (aud != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["ignoreConditions"] = true;
				e5u e5u = new e5u();
				e5u.a(aud.y8());
				e5u.a(true);
				e5u.a(new Guid?(new Guid("5a6be181-2635-4257-868b-84fce7eecd22")));
				e5u.ym(null, null, dictionary);
			}
		}
	}
}
