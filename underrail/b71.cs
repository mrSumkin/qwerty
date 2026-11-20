using System;
using System.Runtime.Serialization;

// Token: 0x02001A2D RID: 6701
[dn2("ForceEmission")]
[eiz("F23")]
[Serializable]
public sealed class b71 : buu, ISerializable
{
	// Token: 0x06009123 RID: 37155 RVA: 0x0039C408 File Offset: 0x0039A608
	private b71(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009124 RID: 37156 RVA: 0x0039C414 File Offset: 0x0039A614
	public b71()
	{
	}

	// Token: 0x06009125 RID: 37157 RVA: 0x0039C420 File Offset: 0x0039A620
	public override string e1(edm A_0)
	{
		a1q a1q = e5o.a(A_0.Power, 1.0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% нанести дополнительно {1} урона.", (int)(A_0.Chance * 100.0), a1q.a(true));
		}
		return string.Format("Наносит дополнительно {0} урона.", a1q.a(true));
	}
}
