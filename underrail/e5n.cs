using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E35 RID: 7733
[a1("Crossbows")]
[eiz("CS6")]
[Serializable]
public sealed class e5n : cxd, ISerializable
{
	// Token: 0x0600AB69 RID: 43881 RVA: 0x003F68FC File Offset: 0x003F4AFC
	private e5n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(e5n);
		}
	}

	// Token: 0x0600AB6A RID: 43882 RVA: 0x003F6928 File Offset: 0x003F4B28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AB6B RID: 43883 RVA: 0x003F6934 File Offset: 0x003F4B34
	public override string fh()
	{
		return "Crossbows";
	}

	// Token: 0x0600AB6C RID: 43884 RVA: 0x003F693C File Offset: 0x003F4B3C
	public e5n(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB6D RID: 43885 RVA: 0x003F6948 File Offset: 0x003F4B48
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(eav),
				1f
			}
		};
	}
}
