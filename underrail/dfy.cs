using System;
using System.Runtime.Serialization;

// Token: 0x02001A4C RID: 6732
[eiz("SMSME")]
[Serializable]
public sealed class dfy : d3e, ISerializable
{
	// Token: 0x06009214 RID: 37396 RVA: 0x0039E7D8 File Offset: 0x0039C9D8
	private dfy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009215 RID: 37397 RVA: 0x0039E7E4 File Offset: 0x0039C9E4
	public dfy()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x06009216 RID: 37398 RVA: 0x0039E7F8 File Offset: 0x0039C9F8
	public override d3e b3()
	{
		dfy dfy = new dfy();
		this.xx(dfy);
		return dfy;
	}

	// Token: 0x06009217 RID: 37399 RVA: 0x0039E814 File Offset: 0x0039CA14
	protected override void @in(ll A_0)
	{
		double num = e5b.b((A_0 != null) ? A_0.a() : null);
		if ((A_0.a().MovementSpeed *= (float)(1.0 - num)) < aiy.e)
		{
			A_0.a().MovementSpeed = aiy.e;
		}
	}
}
