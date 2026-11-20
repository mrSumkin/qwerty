using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020001CD RID: 461
[eiz("MU")]
[Serializable]
public sealed class eva : ISerializable
{
	// Token: 0x06000DC1 RID: 3521 RVA: 0x00039968 File Offset: 0x00037B68
	private eva(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("MU:N");
		this.b = A_0.GetString("MU:T");
		this.c = (Point)A_0.GetValue("MU:S", typeof(Point));
		this.d = A_0.GetBoolean("MU:P");
		this.e = (Point)A_0.GetValue("MU:UO", typeof(Point));
		this.f = (Vector2)A_0.GetValue("MU:TO", typeof(Vector2));
		this.g = (Point)A_0.GetValue("MU:MS", typeof(Point));
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00039A30 File Offset: 0x00037C30
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("MU:N", this.a);
		info.AddValue("MU:T", this.b);
		info.AddValue("MU:S", this.c);
		info.AddValue("MU:P", this.d);
		info.AddValue("MU:UO", this.e);
		info.AddValue("MU:TO", this.f);
		info.AddValue("MU:MS", this.g);
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00039AC8 File Offset: 0x00037CC8
	public eva()
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00039AD0 File Offset: 0x00037CD0
	public eva(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040007F6 RID: 2038
	public string a;

	// Token: 0x040007F7 RID: 2039
	public string b;

	// Token: 0x040007F8 RID: 2040
	public Point c;

	// Token: 0x040007F9 RID: 2041
	public bool d;

	// Token: 0x040007FA RID: 2042
	public Point e;

	// Token: 0x040007FB RID: 2043
	public Vector2 f;

	// Token: 0x040007FC RID: 2044
	public Point g;
}
