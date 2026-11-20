using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000659 RID: 1625
[eiz("LINF")]
[Serializable]
public sealed class alg : ISerializable
{
	// Token: 0x0600293F RID: 10559 RVA: 0x000EB330 File Offset: 0x000E9530
	private alg(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetBoolean("LINF:E");
		if (ell.a() >= 428)
		{
			this.b = A_0.GetBoolean("LINF:S");
			di7.ReadList<string>("LINF:D", ref this.c, A_0);
			if (ell.a() >= 546)
			{
				this.d = (A_0.GetValue("LINF:C", typeof(TimeSpan?)) as TimeSpan?);
				return;
			}
		}
		else
		{
			this.c = new List<string>();
		}
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x000EB3D0 File Offset: 0x000E95D0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LINF:E", this.a);
		info.AddValue("LINF:S", this.b);
		di7.WriteList<string>("LINF:D", this.c, info);
		info.AddValue("LINF:C", this.d);
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x000EB428 File Offset: 0x000E9628
	public alg()
	{
	}

	// Token: 0x0400168A RID: 5770
	public bool a;

	// Token: 0x0400168B RID: 5771
	public bool b;

	// Token: 0x0400168C RID: 5772
	public List<string> c = new List<string>();

	// Token: 0x0400168D RID: 5773
	public TimeSpan? d;
}
