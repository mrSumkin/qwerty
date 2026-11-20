using System;
using System.Runtime.Serialization;

// Token: 0x02002085 RID: 8325
[eiz("VING")]
[Serializable]
public sealed class b90 : ISerializable
{
	// Token: 0x0600C6F2 RID: 50930 RVA: 0x0045D7D0 File Offset: 0x0045B9D0
	private b90(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600C6F3 RID: 50931 RVA: 0x0045D7D8 File Offset: 0x0045B9D8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600C6F4 RID: 50932 RVA: 0x0045D7DC File Offset: 0x0045B9DC
	public b90()
	{
	}

	// Token: 0x0600C6F5 RID: 50933 RVA: 0x0045D7E4 File Offset: 0x0045B9E4
	[dcc("VING:mOIC")]
	public void a(object A_0, EventArgs A_1)
	{
		a7v.a(new t9((A_0 as bx5).a(), null));
	}
}
