using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E34 RID: 7732
[a1("Evasion")]
[eiz("ES1")]
[Serializable]
public sealed class erc : exc, ISerializable
{
	// Token: 0x0600AB63 RID: 43875 RVA: 0x003F6878 File Offset: 0x003F4A78
	private erc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(erc);
		}
	}

	// Token: 0x0600AB64 RID: 43876 RVA: 0x003F68A4 File Offset: 0x003F4AA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AB65 RID: 43877 RVA: 0x003F68B0 File Offset: 0x003F4AB0
	public override string fh()
	{
		return "Evasion";
	}

	// Token: 0x0600AB66 RID: 43878 RVA: 0x003F68B8 File Offset: 0x003F4AB8
	public erc(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB67 RID: 43879 RVA: 0x003F68C4 File Offset: 0x003F4AC4
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

	// Token: 0x0600AB68 RID: 43880 RVA: 0x003F68E0 File Offset: 0x003F4AE0
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(e74),
				0.1f
			}
		};
	}
}
