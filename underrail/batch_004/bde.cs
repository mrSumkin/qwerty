using System;
using System.Runtime.Serialization;

// Token: 0x020000C4 RID: 196
[eiz("FC")]
[Serializable]
public class bde : ISerializable
{
	// Token: 0x06000466 RID: 1126 RVA: 0x00014250 File Offset: 0x00012450
	protected bde(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetValue("FC:T", typeof(object));
			return;
		}
		if (base.GetType() == typeof(bde))
		{
			this.a = A_0.GetValue("_Tag", typeof(object));
			return;
		}
		this.a = A_0.GetValue("FieldContext+_Tag", typeof(object));
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x000142DC File Offset: 0x000124DC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("FC:T", this.a);
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x000142F0 File Offset: 0x000124F0
	public object a()
	{
		return this.a;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x000142F8 File Offset: 0x000124F8
	public void a(object A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00014304 File Offset: 0x00012504
	public bde()
	{
	}

	// Token: 0x04000447 RID: 1095
	private object a;
}
