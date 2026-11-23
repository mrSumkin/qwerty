using System;
using System.Runtime.Serialization;

// Token: 0x020000C3 RID: 195
[eiz("RC1")]
[Serializable]
public class ut : ISerializable
{
	// Token: 0x06000461 RID: 1121 RVA: 0x00014190 File Offset: 0x00012390
	protected ut(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetValue("RC1:T", typeof(object));
			return;
		}
		if (base.GetType() == typeof(ut))
		{
			this.a = A_0.GetValue("_Tag", typeof(object));
			return;
		}
		this.a = A_0.GetValue("RayContext+_Tag", typeof(object));
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x0001421C File Offset: 0x0001241C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RC1:T", this.a);
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00014230 File Offset: 0x00012430
	public object a()
	{
		return this.a;
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00014238 File Offset: 0x00012438
	public void a(object A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00014244 File Offset: 0x00012444
	public ut()
	{
	}

	// Token: 0x04000446 RID: 1094
	private object a;
}
