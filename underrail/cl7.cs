using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Input;

// Token: 0x02000672 RID: 1650
[eiz("ABB")]
[Serializable]
public sealed class cl7 : ISerializable
{
	// Token: 0x060029E7 RID: 10727 RVA: 0x000ED940 File Offset: 0x000EBB40
	private cl7(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadDictionary<Keys, List<av>>("ABB:AB", ref this.a, A_0);
		this.b = A_0.GetBoolean("ABB:ABL");
		if (ell.a() >= 621)
		{
			this.c = A_0.GetBoolean("ABB:PL");
		}
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x000ED998 File Offset: 0x000EBB98
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteDictionary<Keys, List<av>>("ABB:AB", this.a, info);
		info.AddValue("ABB:ABL", this.b);
		info.AddValue("ABB:PL", this.c);
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x000ED9D0 File Offset: 0x000EBBD0
	public cl7()
	{
	}

	// Token: 0x040016D4 RID: 5844
	public Dictionary<Keys, List<av>> a;

	// Token: 0x040016D5 RID: 5845
	public bool b;

	// Token: 0x040016D6 RID: 5846
	public bool c;
}
