using System;
using System.Runtime.Serialization;

// Token: 0x02000158 RID: 344
[eiz("J")]
[Serializable]
public class a31 : d55, ISerializable
{
	// Token: 0x06000899 RID: 2201 RVA: 0x000242A4 File Offset: 0x000224A4
	protected a31(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() == 0)
		{
			base.GetType() == typeof(a31);
		}
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x000242D0 File Offset: 0x000224D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x000242DC File Offset: 0x000224DC
	public a31(string A_0) : base(A_0)
	{
	}
}
