using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E4B RID: 7755
[a1("Lockpicking")]
[eiz("LS1")]
[Serializable]
public sealed class dca : r5, ISerializable
{
	// Token: 0x0600ABE4 RID: 44004 RVA: 0x003F7C2C File Offset: 0x003F5E2C
	private dca(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dca);
		}
	}

	// Token: 0x0600ABE5 RID: 44005 RVA: 0x003F7C58 File Offset: 0x003F5E58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABE6 RID: 44006 RVA: 0x003F7C64 File Offset: 0x003F5E64
	public override string fh()
	{
		return "Lockpicking";
	}

	// Token: 0x0600ABE7 RID: 44007 RVA: 0x003F7C6C File Offset: 0x003F5E6C
	public dca(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABE8 RID: 44008 RVA: 0x003F7C78 File Offset: 0x003F5E78
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(cwu),
				1f
			}
		};
	}

	// Token: 0x0600ABE9 RID: 44009 RVA: 0x003F7C94 File Offset: 0x003F5E94
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(eq1),
				0.1f
			},
			{
				typeof(c0b),
				0.1f
			}
		};
	}
}
