using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E33 RID: 7731
[eiz("DS1")]
[a1("Dodge")]
[Serializable]
public sealed class e74 : exc, ISerializable
{
	// Token: 0x0600AB5D RID: 43869 RVA: 0x003F67F4 File Offset: 0x003F49F4
	private e74(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(e74);
		}
	}

	// Token: 0x0600AB5E RID: 43870 RVA: 0x003F6820 File Offset: 0x003F4A20
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AB5F RID: 43871 RVA: 0x003F682C File Offset: 0x003F4A2C
	public override string fh()
	{
		return "Dodge";
	}

	// Token: 0x0600AB60 RID: 43872 RVA: 0x003F6834 File Offset: 0x003F4A34
	public e74(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB61 RID: 43873 RVA: 0x003F6840 File Offset: 0x003F4A40
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(dqg),
				1f
			}
		};
	}

	// Token: 0x0600AB62 RID: 43874 RVA: 0x003F685C File Offset: 0x003F4A5C
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(erc),
				0.1f
			}
		};
	}
}
