using System;
using System.Runtime.Serialization;

// Token: 0x02001E43 RID: 7747
[a1("Electronics")]
[eiz("ES2")]
[Serializable]
public sealed class ij : b3m, ISerializable
{
	// Token: 0x0600ABC3 RID: 43971 RVA: 0x003F7994 File Offset: 0x003F5B94
	private ij(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(ij);
		}
	}

	// Token: 0x0600ABC4 RID: 43972 RVA: 0x003F79C0 File Offset: 0x003F5BC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABC5 RID: 43973 RVA: 0x003F79CC File Offset: 0x003F5BCC
	public override string fh()
	{
		return "Electronics";
	}

	// Token: 0x0600ABC6 RID: 43974 RVA: 0x003F79D4 File Offset: 0x003F5BD4
	public ij(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}
}
