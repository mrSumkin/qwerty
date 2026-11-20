using System;
using System.Runtime.Serialization;

// Token: 0x02000226 RID: 550
[eiz("CS1")]
[Serializable]
public sealed class cat : ISerializable
{
	// Token: 0x06000F49 RID: 3913 RVA: 0x000400A8 File Offset: 0x0003E2A8
	private cat(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.c = A_0.GetSingle("CS1:P");
			this.d = (c3)A_0.GetValue("CS1:MCM", typeof(c3));
			return;
		}
		if (base.GetType() == typeof(cat))
		{
			this.c = A_0.GetSingle("_Padding");
			this.d = (c3)A_0.GetValue("_MovementCollisionMode", typeof(c3));
			return;
		}
		this.c = A_0.GetSingle("CollisionSettings+_Padding");
		this.d = (c3)A_0.GetValue("CollisionSettings+_MovementCollisionMode", typeof(c3));
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00040188 File Offset: 0x0003E388
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CS1:P", this.c);
		info.AddValue("CS1:MCM", this.d);
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x000401B4 File Offset: 0x0003E3B4
	public cat()
	{
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x000401D0 File Offset: 0x0003E3D0
	public float b()
	{
		return this.c;
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x000401D8 File Offset: 0x0003E3D8
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x000401E4 File Offset: 0x0003E3E4
	public c3 a()
	{
		return this.d;
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x000401EC File Offset: 0x0003E3EC
	public void a(c3 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x04000920 RID: 2336
	public const float a = 0.05f;

	// Token: 0x04000921 RID: 2337
	public const c3 b = c3.b;

	// Token: 0x04000922 RID: 2338
	private float c = 0.05f;

	// Token: 0x04000923 RID: 2339
	private c3 d = c3.b;
}
